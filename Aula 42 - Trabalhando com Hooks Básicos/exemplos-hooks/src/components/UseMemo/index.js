import React from "react";
import { useState, useMemo } from "react";
import { Button, Container, Row, Text } from "./styles";

const TesteUseMemo = () => {
    const [age, setAge] = useState(20);
    const [counter, setCounter] = useState(0);

    const handleChangeAge = () => {
        console.log("Renderizou pela idade.");
        setAge((prev) => (prev === 20 ? 30 : 20));
    };

    const handleIncrementCounter = () => {
        console.log("Renderizou pelo contador.");
        setCounter((counter) => counter + 1);
    };

    // Utiliza o useMemo para só refazer o cálculo quando a idade mudar.
    const calculo = useMemo(() => {
        console.log("Realizou o cálculo.");
        return 1000 * age;
    }, [age]);

    return (
        <Container>
            <Row>
                <Text>Idade: {age}</Text>
                <Text>Calculo: {calculo}</Text>
                <Button onClick={handleChangeAge}>Mudar Idade</Button>
            </Row>
            <Row>
                <Text>Contador: {counter}</Text>
                <Button onClick={handleIncrementCounter}>Incrementar</Button>
            </Row>
        </Container>
    );
};

export { TesteUseMemo };
