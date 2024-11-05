import { TesteUseMemo } from "../../components/UseMemo";
import { TesteUseState } from "../../components/UseState";
import { Container } from "./styles";

function App() {
    return <Container className="App">
        <TesteUseState />
        <TesteUseState />
        <TesteUseMemo />
        <TesteUseState />
    </Container>;
}

export default App;
