import gitLogo from '../../assets/github-logo.png';
import { Container } from './styles'

const App = () => {
    return <Container className="App">
        <img src={gitLogo} width={72} height={72} alt="logo"></img>
    </Container>;
};

export default App;
