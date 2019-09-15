import React from 'react';
import { connect } from 'react-redux';
import Table from "antd/lib/table";
import 'antd/lib/table/style/css';

const Home = props => {

    const dataSource = [
        {
            key: '1',
            name: 'T-Shirt',
            colour: 'White'
        },
        {
            key: '2',
            name: 'Pants',
            colour: 'Black'
        },
    ];
    
    const columns = [
        {
            title: "Name",
            key: "name",
            dataIndex: "name",
            width: "50%"
        },
        {
            title: "Colour",
            key: "colour",
            dataIndex: "colour",
            width: "50%"
        }
    ];
    return (
        <Table columns={columns} dataSource={dataSource}/>
    );

};

export default connect()(Home);
