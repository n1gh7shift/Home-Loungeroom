<script lang="ts">
    import { useDigital, type DigitalSignal } from "ch5-svelte";

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

    function handleButtonPulse(button: DigitalSignal){
        button.pulse();
    }
</script>

<div class="title">Playstation</div>
<div class="container">
    <ArrowSet
        up={() => handleButtonPulse(arrowUp)}
        down={() => handleButtonPulse(arrowDown)}
        left={() => handleButtonPulse(arrowLeft)}
        right={() => handleButtonPulse(arrowRight)}
        center_down={() => handleButtonPulse(select)}
        center_up={() => null}
    />
    <NumpadSet
        zero={() => handleButtonPulse(button0)}
        one={() => handleButtonPulse(button1)}
        two={() => handleButtonPulse(button2)}
        three={() => handleButtonPulse(button3)}
        four={() => handleButtonPulse(button4)}
        five={() => handleButtonPulse(button5)}
        six={() => handleButtonPulse(button6)}
        seven={() => handleButtonPulse(button7)}
        eight={() => handleButtonPulse(button8)}
        nine={() => handleButtonPulse(button9)}
    />
    <TransportsSet
        rev={() => handleButtonPulse(reverseScan)}
        play={() => handleButtonPulse(play)}
        pause={() => handleButtonPulse(pause)}
        stop={() => handleButtonPulse(stop)}
        ff={() => handleButtonPulse(forwardScan)}
    />

    <ControlsSet
        exit={() => handleButtonPulse(exit)}
        menu={() => handleButtonPulse(menu)}
        back={() => handleButtonPulse(back)}
        home={() => handleButtonPulse(home)}
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
