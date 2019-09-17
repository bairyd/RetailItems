import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getLocations } from "../actions/location/GetLocationsAction";
import {Locations} from "./Locations";
import {InitialItems, InitialLocations} from "../Models";
import {getItemsByLocation} from "../actions/item/GetItemsByLocationAction";
import {Items} from "./Items";

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
            }
        };
        this.handleOnChange = this.handleOnChange.bind(this);
        this.props.getLocations();
    }

    componentDidMount() {
    }
    
    handleOnChange(key) {
        this.props.getItemsByLocation(key);
    }

    render() {
        return (
            <div>
                <Locations locations={this.props.locations} handleOnChange={this.handleOnChange}/>
                
                <Items items={this.props.items}/>
            </div>
        );
    }
}


const mapDispatchToProps = {
    getLocations,
    getItemsByLocation
};

const mapStateToProps = (state) => ({
    locations: state.locationsState.locations,
    items: state.itemsState.items
});

export default connect(
    mapStateToProps,
    mapDispatchToProps
)(Home);