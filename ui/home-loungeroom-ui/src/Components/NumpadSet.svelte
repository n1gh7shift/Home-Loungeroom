<script lang="ts">
    const { zero, one, two, three, four, five, six, seven, eight, nine } =
        $props();
</script>

<div class="numbers-box">
    <button class="button number button0" onpointerdown={() => zero()}>0</button>
    <button class="button number button1" onpointerdown={() => one()}>1</button>
    <button class="button number button2" onpointerdown={() => two()}>2</button>
    <button class="button number button3" onpointerdown={() => three()}>3</button>
    <button class="button number button4" onpointerdown={() => four()}>4</button>
    <button class="button number button5" onpointerdown={() => five()}>5</button>
    <button class="button number button6" onpointerdown={() => six()}>6</button>
    <button class="button number button7" onpointerdown={() => seven()}>7</button>
    <button class="button number button8" onpointerdown={() => eight()}>8</button>
    <button class="button number button9" onpointerdown={() => nine()}>9</button>
</div>

<style>
    .button {
        font-family: "Material Icons";
        align-items: center;
        background: #f5f5fa;
        border-radius: 8px;
        color: #2a1f62;
        touch-action: manipulation;
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
