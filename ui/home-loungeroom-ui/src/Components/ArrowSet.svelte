<script>
    const { up, down, left, right, center_down, center_up } = $props();

</script>

<div class="arrow-box">
    <button class="button arrow-button arrowUp" onpointerdown={() => up()}
        >arrow_upward</button
    >
    <button class="button arrow-button arrowLeft" onpointerdown={() => left()}
        >arrow_back</button
    >
    <button class="button arrow-button arrowDown" onpointerdown={() => down()}
        >arrow_downward</button
    >
    <button class="button arrow-button arrowRight" onpointerdown={() => right()}
        >arrow_forward</button
    >

    <button class="button arrow-button center" onpointerdown={() => center_down()} onpointerup={() => center_up()} onpointerleave={() => center_up()}>crop_square</button
    >
</div>

<style>
    .button {
        font-family: "Material Icons";
        align-items: center;
        background: #f5f5fa;
        border: 0;
        border-radius: 8px;
        touch-action: manipulation;
        color: #2a1f62;
        line-height: 1.5rem;
        text-align: center;
        min-height: 72px;
        min-width: 72px;
    }
    .arrow-box {
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-template-rows: repeat(3, 1fr);
        grid-column-gap: 10px;
        grid-row-gap: 10px;
        max-height: 236px;
    }
    .arrow-button {
        font-size: xx-large;
    }

    .arrowUp {
        grid-area: 1 / 2 / 2 / 3;
    }
    .arrowRight {
        grid-area: 2 / 3 / 3 / 4;
    }
    .arrowDown {
        grid-area: 3 / 2 / 4 / 3;
    }
    .arrowLeft {
        grid-area: 2 / 1 / 3 / 2;
    }
    .center {
        grid-area: 2 / 2 / 3 / 3;
    }
</style>
