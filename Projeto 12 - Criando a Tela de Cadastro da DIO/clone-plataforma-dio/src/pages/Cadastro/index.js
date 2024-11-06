import { useNavigate } from "react-router-dom";

import { Header } from "../../components/Header";

const Cadastro = () => {
    const navigate = useNavigate();

    const handleClickHome = () => {
        navigate("/");
    };

    const handleClickSignIn = () => {
        navigate("/login");
    };

    return (
        <div>
            <Header showCadastrar={false} onClickHome={handleClickHome} onClickEntrar={handleClickSignIn}/>
        </div>
    );
};

export { Cadastro };
