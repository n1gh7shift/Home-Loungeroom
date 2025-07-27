<script lang="ts">
    import { useDigital } from "ch5-svelte";
    import ArrowSet from "./Components/ArrowSet.svelte";
    import NumpadSet from "./Components/NumpadSet.svelte";
    import TransportsSet from "./Components/TransportsSet.svelte";
    import ControlsSet from "./Components/ControlsSet.svelte";

    const arrowUp = useDigital("", "21");
    const arrowDown = useDigital("", "22");
    const arrowLeft = useDigital("", "23");
    const arrowRight = useDigital("", "24");
    const select = useDigital("", "25");
    const exit = useDigital("", "27");
    const menu = useDigital("", "28");
    const back = useDigital("", "30");
    const home = useDigital("", "36");
    const reverseScan = useDigital("", "34");
    const play = useDigital("", "31");
    const pause = useDigital("", "32");
    const stop = useDigital("", "33");
    const forwardScan = useDigital("", "35");
    const button0 = useDigital("", "37");
    const button1 = useDigital("", "38");
    const button2 = useDigital("", "39");
    const button3 = useDigital("", "40");
    const button4 = useDigital("", "41");
    const button5 = useDigital("", "42");
    const button6 = useDigital("", "43");
    const button7 = useDigital("", "44");
    const button8 = useDigital("", "45");
    const button9 = useDigital("", "46");

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

    function handleRev() {
        reverseScan.pulse();
    }
    function handlePlay() {
        play.pulse();
    }
    function handlePause() {
        pause.pulse();
    }
    function handleStop() {
        stop.pulse();
    }
    function handleFf() {
        forwardScan.pulse();
    }

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

<div class="title">Playstation</div>
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
    <TransportsSet
        rev={handleRev}
        play={handlePlay}
        pause={handlePause}
        stop={handleStop}
        ff={handleFf}
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
