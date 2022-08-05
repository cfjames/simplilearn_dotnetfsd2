import React, { Component } from 'react';
import Header from './Header';
import { PostsList } from './PostsList';

export class Blog extends Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="container">
                <Header headerName="Blogging App" />
                <PostsList/>
            </div>
            );
    }
}