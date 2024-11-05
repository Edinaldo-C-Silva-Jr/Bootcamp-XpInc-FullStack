import { TesteUseCallback } from "../../components/UseCallback";
import { TesteUseMemo } from "../../components/UseMemo";
import { TesteUseState } from "../../components/UseState";
import { Container } from "./styles";

function App() {
    return <Container className="App">
        <TesteUseState />
        <TesteUseState />
        <TesteUseMemo />
        <TesteUseCallback />
    </Container>;
}

export default App;
