import React, { Component } from 'react';
import logo from './greenfox.png';
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Have a nice day, dude.</h1>
        </header>
        <p className="App-intro">
          This is some start of content.
        </p>
        <p className="App-body">
          Content, yeah!
        </p>
        <p className="App-body">
          asdasdasdasdasdasdasdasdasdasd
        </p>
        <p>
          <img src={logo} />
        </p>
      </div>
    );
  }
}

export default App;
