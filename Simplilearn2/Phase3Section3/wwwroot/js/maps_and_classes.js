var map1 = new Map();
map1.set("first name", "Robb")
    .set("last name", "Stark")
    .set("friend 1", "Bran")
    .set("friend 2", "Arya");

console.log(map1);
console.log("map1 has friend 2 ? " + map1.has("friend 2"));
console.log("map1 has friend 3 ? " + map1.has("friend 3"));
console.log("value for Key= friend 2 - " + map1.get("friend 2"));
console.log("value for Key= friend 3 - " + map1.get("friend 3"));
console.log("delete for Key= friend 2 - " + map1.delete("friend 2"));
console.log("delete for Key= friend 3 - " + map1.delete("friend 3"));
console.log("map1 has friend 2 ? " + map1.has("friend 2"));
map1.clear();
console.log(map1);

class Employee {
    constructor(id, name) {
        this.id = id;
        this.name = name;
    }

    detail() {
        document.writeln(this.id + "-" + this.name + "<br/>");
    }
}
var e1 = new Employee(101, "Mike");
var e2 = new Employee(102, "Bob");
e1.detail();
e2.detail();