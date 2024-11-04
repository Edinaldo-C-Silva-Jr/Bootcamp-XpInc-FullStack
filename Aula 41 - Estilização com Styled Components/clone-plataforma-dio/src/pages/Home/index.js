import React from "react";
import { Button } from "../../components/Button";
import { Header } from "../../components/Header";

const Home = () => {
    return (
        <div>
            <Header />
            <Button title="Teste 1" />
            <Button variant="secondary" title="Teste 2" />
        </div>
    );
}

export { Home }
