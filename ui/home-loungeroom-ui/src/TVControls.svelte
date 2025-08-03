<script lang="ts">
    import { useDigital, type DigitalSignal } from "ch5-svelte";

    import ArrowSet from "./Components/ArrowSet.svelte";
    import NumpadSet from "./Components/NumpadSet.svelte";
    import ControlsSet from "./Components/ControlsSet.svelte";
    import VolumeControls from "./Components/VolumeControls.svelte";

    const arrowUp = useDigital("", "50");
    const arrowDown = useDigital("", "51");
    const arrowLeft = useDigital("", "52");
    const arrowRight = useDigital("", "53");
    const select = useDigital("", "54");

    const exit = useDigital("", "55");
    const menu = useDigital("", "57");
    const back = useDigital("", "55");
    const home = useDigital("", "56");

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
    
    const vol_up = useDigital("", "68");
    const vol_down = useDigital("", "69");

    function handleButtonPulse(button: DigitalSignal){
        button.pulse();
    }

    function handleButtonDown(button: DigitalSignal){
        button.value = true;
    }
    function handleButtonUp(button: DigitalSignal){
        button.value = false;
    }
</script>

<div class="title">TV Controls</div>
<div class="container">
    <ArrowSet
        up={() => handleButtonPulse(arrowUp)}
        down={() => handleButtonPulse(arrowDown)}
        left={() => handleButtonPulse(arrowLeft)}
        right={() => handleButtonPulse(arrowRight)}
        center_down={() => handleButtonDown(select)}
        center_up={() => handleButtonUp(select)}
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
    <ControlsSet
        exit={() => handleButtonPulse(exit)}
        menu={() => handleButtonPulse(menu)}
        back={() => handleButtonPulse(back)}
        home={() => handleButtonPulse(home)}
    />
    <VolumeControls 
        vol_up_start={() => handleButtonDown(vol_up)} 
        vol_up_end={() => handleButtonUp(vol_up)} 
        vol_down_start={() => handleButtonDown(vol_down)}  
        vol_down_end={() => handleButtonUp(vol_down)}
        />
</div>

<style>
    .container {
        display: flex;
        justify-content: space-evenly;
        align-items: center;
        flex-flow: row wrap;
        gap: 50px;
        max-width: 800px;
    }
    .title {
        min-height: 50px;
        text-align: center;
    }
</style>
