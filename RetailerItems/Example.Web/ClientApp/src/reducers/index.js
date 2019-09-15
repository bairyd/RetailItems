import { combineReducers } from 'redux';
import itemReducer from './ItemReducer';
import itemsReducer from './ItemsReducer';
import locationReducer from './LocationReducer';
import locationsReducer from './LocationsReducer';
import retailerReducer from './RetailerReducer';
import retailersReducer from './RetailersReducer';

const rootReducer = combineReducers({
    itemState: itemReducer,
    itemsState: itemsReducer,
    locationState: locationReducer,
    locationsState: locationsReducer,
    retailerState: retailerReducer,
    retailersState: retailersReducer,
});

export default rootReducer;