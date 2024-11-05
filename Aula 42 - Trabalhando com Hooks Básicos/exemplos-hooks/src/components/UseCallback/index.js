import React from "react";
import { useState, useCallback } from "react";
import { Button, Container, Row, Text } from "./styles";

const TesteUseCallback = () => {
    const [name, setName] = useState("João");
    const [age, setAge] = useState(20);

    const handleChangeName = useCallback(() => {
        console.log(`Alterou o nome: ${name}`);
        setName((prev) => (prev === "João" ? "Maria" : "João"));
    }, [name]);

    const handleChangeAge = useCallback(() => {
        const calculo = 1000 * age;
        console.log(`Idade: ${age} Cálculo: ${calculo}`);
        setAge((prev) => (prev === 20 ? 30 : 20));
    }, [age]);

    return (
        <Container>
            <Row>
                <Text>Nome: {name}</Text>
                <Button onClick={handleChangeName}>Mudar Nome</Button>
            </Row>
            <Row>
                <Text>Idade: {age}</Text>
                <Button onClick={handleChangeAge}>Mudar Idade</Button>
            </Row>
        </Container>
    );
};

export { TesteUseCallback };
