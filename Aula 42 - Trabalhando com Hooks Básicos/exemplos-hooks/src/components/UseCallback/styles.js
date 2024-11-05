import styled from "styled-components";

export const Container = styled.div`
    border: 1px solid;
    width: 80%;
    height: 120px;
    border-radius: 20px;

    display: flex;
    align-items: center;
    justify-content: space-evenly;
    flex-direction: column;

    background-color: #b0a0c0;
`

export const Row = styled.div`
    border: 0;
    width: 100%;
    height: 30%;

    display: flex;
    align-items: center;
    justify-content: space-around;
`

export const Text = styled.p`
    font-size: 18px;
    line-height: 25px;
    font-weight: 700;
`

export const Button = styled.button`
    width: 20%;
    height: 30px;
    margin-left: 20;
    border: 1px solid #406080;
    border-radius: 10px;

    &:hover{
        opacity: 0.8;
    }
`