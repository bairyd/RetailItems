import { applyMiddleware, compose, createStore } from 'redux';
import thunkMiddleware from 'redux-thunk';
import apiMiddleware from './../middleware/api'
import { routerMiddleware } from 'react-router-redux';
import rootReducer from "../reducers";

export default function configureStore(history, initialState) {

  const middleware = [
    thunkMiddleware,
    routerMiddleware(history),
    apiMiddleware
  ];

  // In development, use the browser's Redux dev tools extension if installed
  const enhancers = [];
  const isDevelopment = process.env.NODE_ENV === 'development';
  if (isDevelopment && typeof window !== 'undefined' && window.__REDUX_DEVTOOLS_EXTENSION__) {
    enhancers.push(window.__REDUX_DEVTOOLS_EXTENSION__());
  }

  return createStore(
      rootReducer,
      initialState,
      compose(applyMiddleware(...middleware), ...enhancers)
  );
}
