<script lang="ts">
    import { useDigital } from "ch5-svelte";
    import ArrowSet from "./Components/ArrowSet.svelte";
    import NumpadSet from "./Components/NumpadSet.svelte";
    import ControlsSet from "./Components/ControlsSet.svelte";

    const arrowUp = useDigital("", "50");
    const arrowDown = useDigital("", "51");
    const arrowLeft = useDigital("", "52");
    const arrowRight = useDigital("", "53");
    const select = useDigital("", "54");

    const exit = useDigital("", "55");
    const menu = useDigital("", "57");
    const back = useDigital("", "55");
    const home = useDigital("", "56");
    // const reverseScan = useDigital("", "34");
    // const play = useDigital("", "31");
    // const pause = useDigital("", "32");
    // const stop = useDigital("", "33");
    // const forwardScan = useDigital("", "35");
    const button0 = useDigital("", "58");
    const button1 = useDigital("", "59");
    const button2 = useDigital("", "60");
    const button3 = useDigital("", "61");
    const button4 = useDigital("", "62");
    const button5 = useDigital("", "63");
    const button6 = useDigital("", "64");
    const button7 = useDigital("", "65");
    const button8 = useDigital("", "66");
    const button9 = useDigital("", "67");

    function handleUp() {
        arrowUp.pulse();
    }
    function handleDowm() {
        arrowDown.pulse();
    }
    function handleLeft() {
        arrowLeft.pulse();
    }
    function handleRight() {
        arrowRight.pulse();
    }
    function handleCenter() {
        select.pulse();
    }

    function handleZero() {
        button0.pulse();
    }
    function handleOne() {
        button1.pulse();
    }
    function handleTwo() {
        button2.pulse();
    }
    function handleThree() {
        button3.pulse();
    }
    function handleFour() {
        button4.pulse();
    }
    function handleFive() {
        button5.pulse();
    }
    function handleSix() {
        button6.pulse();
    }
    function handleSeven() {
        button7.pulse();
    }
    function handleEight() {
        button8.pulse();
    }
    function handleNine() {
        button9.pulse();
    }

    // function handleRev() {
    //     reverseScan.pulse();
    // }
    // function handlePlay() {
    //     play.pulse();
    // }
    // function handlePause() {
    //     pause.pulse();
    // }
    // function handleStop() {
    //     stop.pulse();
    // }
    // function handleFf() {
    //     forwardScan.pulse();
    // }

    function handleExit() {
        exit.pulse();
    }
    function handleMenu() {
        menu.pulse();
    }
    function handleBack() {
        back.pulse();
    }
    function handleHome() {
        home.pulse();
    }
</script>

<div class="title">TV Controls</div>
<div class="container">
    <ArrowSet
        up={handleUp}
        down={handleDowm}
        left={handleLeft}
        right={handleRight}
        center={handleCenter}
    />
    <NumpadSet
        zero={handleZero}
        one={handleOne}
        two={handleTwo}
        three={handleThree}
        four={handleFour}
        five={handleFive}
        six={handleSix}
        seven={handleSeven}
        eight={handleEight}
        nine={handleNine}
    />
    <ControlsSet
        exit={handleExit}
        menu={handleMenu}
        back={handleBack}
        home={handleHome}
    />
</div>

<style>
    .container {
        display: flex;
        justify-content: space-evenly;
        align-items: center;
        flex-flow: row wrap;
        gap: 50px;
        max-width: 600px;
    }
    .title {
        min-height: 50px;
        text-align: center;
    }
</style>
