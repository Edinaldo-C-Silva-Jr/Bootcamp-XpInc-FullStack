import React from "react";
import { useState, useEffect } from "react";
import { Button, Container, Text } from "./styles";

const TesteUseEffect = () => {
    const [counter, setCounter] = useState(0);

    const handleIncrementCounter = () => {
        setCounter((prev) => prev + 1);
    };

    useEffect(() => {
        console.log("renderizou");
    }, [counter]);

    return (
        <Container>
            <Text>Contador: {counter}</Text>
            <Button onClick={handleIncrementCounter}>Incrementar</Button>
        </Container>
    );
};

export { TesteUseEffect };
