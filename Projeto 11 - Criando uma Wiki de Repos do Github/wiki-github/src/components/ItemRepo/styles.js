import styled from "styled-components";

export const ItemContainer = styled.div`
    width: 80%;

    h3 {
        font-size: 32px;
        color: #fafafa;
    }

    p {
        font-size: 16px;
        color: #fafafa60;
        margin-bottom: 10px;
    }

    .links {
        display: flex;
        justify-content: space-between;
    }

    a {
        color: #40d0f0;
    }

    a: hover {
        color: #20a0d0;
    }

    a.remover {
        color: #ff9090;
    }

    a.remover: hover {
        color: #c06060;
    }

    hr {
        margin: 20px 0;
    }
`;
