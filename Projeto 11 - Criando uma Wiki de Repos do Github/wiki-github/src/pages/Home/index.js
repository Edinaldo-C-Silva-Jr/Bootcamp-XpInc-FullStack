import gitLogo from "../../assets/github-logo.png";
import { Container } from "./styles";
import Input from '../../components/Input'
import ItemRepo from "../../components/ItemRepo";

const App = () => {
    return (
        <Container className="App">
            <img src={gitLogo} width={72} height={72} alt="logo"></img>
            <Input />
            <ItemRepo />
        </Container>
    );
};

export default App;
