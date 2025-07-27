<script lang="ts">
    const { zero, one, two, three, four, five, six, seven, eight, nine } =
        $props();

    // Place in script:
    //
    // function handleUp() {
    //     arrowUp.pulse();
    // }
    // function handleDowm() {
    //     arrowDown.pulse();
    // }
    // function handleLeft() {
    //     arrowLeft.pulse();
    // }
    // function handleRight() {
    //     arrowRight.pulse();
    // }
    // function handleCenter() {
    //     select.pulse();
    // }
    // function handleZero() {
    //     button0.pulse();
    // }
    // function handleOne() {
    //     button1.pulse();
    // }
    // function handleTwo() {
    //     button2.pulse();
    // }
    // function handleThree() {
    //     button3.pulse();
    // }
    // function handleFour() {
    //     button4.pulse();
    // }
    // function handleFive() {
    //     button5.pulse();
    // }
    // function handleSix() {
    //     button6.pulse();
    // }
    // function handleSeven() {
    //     button7.pulse();
    // }
    // function handleEight() {
    //     button8.pulse();
    // }
    // function handleNine() {}

    // Place in body
    //
    // <NumpadSet zero={handleZero}
    // one={handleOne}
    // two={handleTwo}
    // three={handleThree}
    // four={handleFour}
    // five={handleFive}
    // six={handleSix}
    // seven={handleSeven}
    // eight={handleEight}
    // nine={handleNine}
    // />
</script>

<div class="numbers-box">
    <button class="button number button0" onclick={() => zero()}>0</button>
    <button class="button number button1" onclick={() => one()}>1</button>
    <button class="button number button2" onclick={() => two()}>2</button>
    <button class="button number button3" onclick={() => three()}>3</button>
    <button class="button number button4" onclick={() => four()}>4</button>
    <button class="button number button5" onclick={() => five()}>5</button>
    <button class="button number button6" onclick={() => six()}>6</button>
    <button class="button number button7" onclick={() => seven()}>7</button>
    <button class="button number button8" onclick={() => eight()}>8</button>
    <button class="button number button9" onclick={() => nine()}>9</button>
</div>

<style>
    .button {
        font-family: "Material Icons";
        align-items: center;
        background: #f5f5fa;
        border: 0;
        border-radius: 8px;
        box-sizing: border-box;
        color: #2a1f62;
        cursor: pointer;
        display: flex;
        justify-content: center;
        line-height: 1.5rem;
        position: relative;
        text-align: left;
        transition: 0.2s;
        user-select: none;
        -webkit-user-select: none;
        touch-action: manipulation;
        white-space: pre;
        width: max-content;
        word-break: normal;
        word-spacing: normal;
        min-height: 72px;
        min-width: 72px;
        font-size: large;
    }

    .numbers-box {
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-template-rows: repeat(4, 1fr);
        grid-column-gap: 10px;
        grid-row-gap: 10px;
        max-width: 216px;
        
    }
    .numbers-box button {
        font-family: "Roboto", sans-serif;
        font-size: xx-large;
    }

    .button0 {
        grid-area: 4 / 2 / 5 / 3;
    }
    .button1 {
        grid-area: 1 / 1 / 2 / 2;
    }
    .button2 {
        grid-area: 1 / 2 / 2 / 3;
    }
    .button3 {
        grid-area: 1 / 3 / 2 / 4;
    }
    .button4 {
        grid-area: 2 / 1 / 3 / 2;
    }
    .button5 {
        grid-area: 2 / 2 / 3 / 3;
    }
    .button6 {
        grid-area: 2 / 3 / 3 / 4;
    }
    .button7 {
        grid-area: 3 / 1 / 4 / 2;
    }
    .button8 {
        grid-area: 3 / 2 / 4 / 3;
    }
    .button9 {
        grid-area: 3 / 3 / 4 / 4;
    }
</style>
