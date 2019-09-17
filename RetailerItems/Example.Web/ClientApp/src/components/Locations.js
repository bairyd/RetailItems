import React from 'react';
import {Select} from "antd";
import 'antd/lib/select/style/css';


export const Locations = (props) => {
    const { Option } = Select;
    
    return (
        <div>
            <Select style={{ width: 150 }} onChange={(key) => props.handleOnChange(key)}>
                {Object.values(props.locations).map(location => <Option key={location.id} value={location.id}>{location.name}</Option>)}
            </Select>
        </div>
    )
};