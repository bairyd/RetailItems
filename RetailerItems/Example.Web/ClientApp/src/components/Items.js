import React from 'react';
import {Table} from "antd";
import 'antd/lib/table/style/css';


export const Items = (props) => {

    const columns = [
        {
            title: 'Name',
            dataIndex: 'name',
            key: 'name',
        },
        {
            title: 'Size',
            dataIndex: 'size',
            key: 'size',
        },
        {
            title: 'Cost',
            dataIndex: 'cost',
            key: 'cost',
        },
    ];
    
    function transformData(items) {
        let tableRecords = [];
        Object.keys(items).forEach(key => {
            let item = items[key];
            let tableRecord = {
                key: item.id,
                name: item.name,
                size: item.size,
                cost: item.cost
            };
            tableRecords.push(tableRecord);
        });
        return tableRecords;
    }

    return (
        <div>
            <Table columns={columns} 
            dataSource={transformData(props.items)}/>
        </div>
    )
};