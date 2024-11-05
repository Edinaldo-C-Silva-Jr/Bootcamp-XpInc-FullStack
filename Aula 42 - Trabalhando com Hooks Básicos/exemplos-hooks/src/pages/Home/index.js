import { TesteUseCallback } from "../../components/UseCallback";
import { TesteUseEffect } from "../../components/UseEffect";
import { TesteUseMemo } from "../../components/UseMemo";
import { TesteUseState } from "../../components/UseState";
import { Container } from "./styles";

function App() {
    return <Container className="App">
        <TesteUseState />
        <TesteUseEffect />
        <TesteUseMemo />
        <TesteUseCallback />
    </Container>;
}

export default App;
