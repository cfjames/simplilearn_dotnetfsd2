﻿import React, { Component } from 'react';
import PostDetail from './PostDetail';

export class PostsList extends Component {
    constructor() {
        super();

        this.handleFormSubmit = this.handleFormSubmit.bind(this);

        this.state = {
            loadingCategories: true,
            loadingPosts: true,
            post: {
                id: 0,
                title: '',
                body: '',
                author: '',
                category: ''
            },
            postCleared: {
                id: 0,
                title: '',
                body: '',
                author: '',
                category: ''
            },
            //categories: [
            //    { code: 'react', name: 'React' },
            //    { code: 'redux', name: 'Redux' },
            //    { code: 'angular', name: 'Angular' }
            //],
            //posts: [
            //    {
            //        id: 1,
            //        title: 'Introduction to React',
            //        body: 'This post provides an intro to React',
            //        author: 'Hari',
            //        category: 'react'
            //    },
            //    {
            //        id: 2,
            //        title: 'Advanced React',
            //        body: 'This post discusses advanced features of React',
            //        author: 'Ram',
            //        category: 'react'
            //    },
            //    {
            //        id: 3,
            //        title: 'Introduction to Redux',
            //        body: 'This post provides an intro to Redux',
            //        author: 'Shiv',
            //        category: 'redux'
            //    }
            //]
        };
    }

    componentDidMount() {
        this.populateCategoryData();
        this.populatePostData();
    }

    async populateCategoryData() {
        const response = await fetch('categories');
        const data = await response.json();
        this.setState({ categories: data, loadingCategories: false });
    }

    async populatePostData() {
        const response = await fetch('blogposts');
        const data = await response.json();
        this.setState({ posts: data, loadingPosts: false });
    }

    handleEditCallback = (postToEdit) => {
        this.setState({post : postToEdit})
    }

    handleDeleteCallback = (postId) => {
        let postIndex = this.state.posts.findIndex(p => p.id === postId)
        if (postIndex !== -1) {
            fetch('blogposts/' + postId, {
                method: 'DELETE'
            }).then(response => response)
                .then(data => {
                    let postsUpdated = this.state.posts;
                    postsUpdated.splice(postIndex, 1);
                    this.setState({ posts: postsUpdated });
                }).catch((error) => {
                    console.error('Error', error);
                });
        }
    }

    handleFormSubmit(event) {
        event.preventDefault();
        console.log('this:', this);
        console.log('Form submitted:', this.state.post);

        //we are adding a blog post via a POST method
        if (this.state.post.id === 0) {
            fetch('blogposts', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(this.state.post)
            }).then(response => response.json())
                .then(data => {              
                        let postsUpdated = this.state.posts;
                        postsUpdated.push(data);
                        this.setState({ post: this.state.postCleared, posts: postsUpdated })
                }).catch((error) => {
                    console.error('Error', error);
                });
        }
        else {
            fetch('blogposts/' + this.state.post.id, {
                method: 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(this.state.post)
            }).then(response => response)
                .then(data => {
                    if (data.status === 204) {
                        let postIndex = this.state.posts.findIndex(p => p.id === this.state.post.id)
                        let postsUpdated = this.state.posts;
                        postsUpdated[postIndex] = this.state.post;
                        this.setState({ post: this.state.postCleared, posts: postsUpdated })
                    }
                }).catch((error) => {
                    console.error('Error', error);
                });
        }
    }

    handleTitleChange = (e) => {
        console.log('title:', e.target.value);
        // this.state.post.title = e.target.value;
        const post = this.state.post;
        this.setState({ post: { ...post, title: e.target.value } });
    }

    handleBodyChange = (e) => {
        console.log('body:', e.target.value);
        // this.state.post.title = e.target.value;
        const post = this.state.post;
        this.setState({ post: { ...post, body: e.target.value } });
    }

    handleAuthorChange = (e) => {
        console.log('author:', e.target.value);
        // this.state.post.title = e.target.value;
        const post = this.state.post;
        this.setState({ post: { ...post, author: e.target.value } });
    }

    handleCategoryChange = (e) => {
        console.log('category:', e.target.value);
        // this.state.post.title = e.target.value;
        const post = this.state.post;
        this.setState({ post: { ...post, category: e.target.value } });
    }

    renderCategories() {
        return this.state.categories.map((category) => {
            return <option key={category.code} value={category.code}>{category.name}</option>;
        });
    }

    renderForm() {
        if (this.state.loadingCategories)
            return (<p><em>Loading...</em></p>);
        else {
            return (
                <div className="col-sm-4">
                    <h3>Post Form</h3>
                    <div className="card bg-light">
                        <div className="card-body">
                            <form onSubmit={this.handleFormSubmit}>
                                <div className="form-group">
                                    <label htmlFor="title">Title</label>
                                    <input type="text" className="form-control" id="title" name="title"
                                        placeholder="Enter title" value={this.state.post.title}
                                    onChange={this.handleTitleChange}/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="body">Body</label>
                                    <textarea className="form-control" id="body" name="body" placeholder="Enter body"
                                        rows="3" cols="30" value={this.state.post.body}
                                        onChange={this.handleBodyChange}></textarea>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="author">Author</label>
                                    <input type="text" className="form-control" id="author" name="author" placeholder="Enter author" value={this.state.post.author}
                                        onChange={this.handleAuthorChange}/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="category">Category</label>
                                    <select required className="form-control" id="category" name="category" value={this.state.post.category}
                                        onChange={this.handleCategoryChange}>
                                        <option value=""></option>
                                        {this.renderCategories()}
                                    </select>
                                </div>
                                <button type="submit" className="btn btn-primary">Save</button>
                            </form>
                        </div>
                    </div>
                </div>
            );
        }
    }

    renderPosts() {
        if (this.state.loadingPosts)
            return (<p><em>Loading Posts...</em></p>)
        else if (this.state.posts.length == 0)
            return (<div className="col-sm-8"><p><em>No Blog Posts Available...</em></p></div>)
        else {
        return (
            <div className="col-sm-8">
                <h3>Posts</h3>
                {this.state.posts.map((post) => {
                    return <PostDetail key={post.id} post={post}
                        parentEditCallback={this.handleEditCallback}
                        parentDeleteCallback={this.handleDeleteCallback} />
                })}
            </div>
            );
        }
    }

    render() {
        return (
            <div className="row">
                {this.renderForm()}
                {this.renderPosts()}
            </div>
        );
    }
}