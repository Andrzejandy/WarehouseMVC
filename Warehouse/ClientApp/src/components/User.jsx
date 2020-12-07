import React, { Component } from 'react';

class User extends Component {
    constructor(props) {
        super(props);
        this.state = {};
    }
    render() {
        return (
            <div>
                <h1 id="tabelLabel" >User</h1>
                <p>This component demonstrates fetching data from the server.</p>
                <p>Users</p>
            </div>
        );
    }
}

export default User;