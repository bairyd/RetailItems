import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getLocations } from "../actions/location/GetLocationsAction";
import {Locations} from "./Locations";
import {InitialItems, InitialLocations} from "../Models";
import {getItemsByLocation} from "../actions/item/GetItemsByLocationAction";
import {Items} from "./Items";
import {Button, Input, Modal} from "antd";
import 'antd/lib/button/style/css';
import 'antd/lib/modal/style/css';
import {addItem} from "../actions/item/AddItemAction";

class Home extends Component {
    constructor(props) {
        super(props);
        this.state =
        {
            locations : {
                ...InitialLocations
            },
            items: {
                ...InitialItems
            },
            modalVisible: false
        };
        this.handleOnChange = this.handleOnChange.bind(this);
        this.props.getLocations();
    }

    componentDidMount() {
    }
    
    handleOnChange(key) {
        this.props.getItemsByLocation(key);
    }
    
    doNothingOnChange(key) {
    }

    showModal(isVisible) {
        this.setState({
            modalVisible: isVisible
        })
    }
    
    submitItemDetails() {
        this.showModal(false);
    }

    render() {
        return (
            <div>
                <Locations locations={this.props.locations} handleOnChange={this.handleOnChange}/>
                
                <Items items={this.props.items}/>
                <Button onClick={() => this.showModal(true)}>Add New Item</Button>
                <Modal
                        title="Add Item"
                        visible={this.state.modalVisible}
                        onOk={() => this.submitItemDetails()}
                        onCancel={() => this.showModal(false)}
                    >
                    ID:<Input  />
                    Name: <Input />
                    Size: <Input />
                    Cost: <Input />
                    Availability: <Input />
                    Colour Range: <Input />
                    Region: <Locations locations={this.props.locations} handleOnChange={this.doNothingOnChange}/>
                </Modal>
            </div>
        );
    }
}


const mapDispatchToProps = {
    getLocations,
    getItemsByLocation,
    addItem
};

const mapStateToProps = (state) => ({
    locations: state.locationsState.locations,
    items: state.itemsState.items
});

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(Home);