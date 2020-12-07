import React, { Component } from 'react';

class Item extends Component {
    constructor(props) {
        super(props);
        this.state = {};
    }
    render() {
        return (
            <div>
                <h1 id="tabelLabel" >Items</h1>
                <p>This component demonstrates fetching data from the server.</p>
                <p>item1</p>
                <p>item2</p>
                <p>item3</p>
            </div>
        );
    }
}

export default Item;