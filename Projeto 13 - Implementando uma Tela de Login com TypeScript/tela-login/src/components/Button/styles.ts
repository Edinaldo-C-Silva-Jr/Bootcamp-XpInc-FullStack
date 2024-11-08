import styled from "styled-components";

export const ButtonContainer = styled.button`
    width: 100%;
    height: 40px;
    background-color: #81259d;
    color: #ffffff;

    border: 1px solid #a532b8;
    border-radius: 20px;

    &:hover {
        &:enabled {
            opacity: 0.6;
        }
        cursor: pointer;
    }

    &:disabled {
        background-color: #505050;
        opacity: 0.5;
    }
`;
