<script>
    const { up, down, left, right, center } = $props();


    // Paste functions into parent and setup like this
    // In body:
    // <ArrowSet up={handleUp} down={handleDowm} left={handleLeft} right={handleRight} center={handleCenter} />
    //  
    // In script:
    //
    // function handleUp(){
    //     console.log("handleUp Run")
    // }
    // function handleDowm(){
    //     console.log("handleDowm Run")
    // }
    // function handleLeft(){
    //     console.log("handleLeft Run")
    // }
    // function handleRight(){
    //     console.log("handleRight Run")
    // }
    // function handleCenter(){
    //     console.log("handleCenter Run")
    // }

</script>

<div class="arrow-box">
    <button class="button arrow-button arrowUp" onclick={() => up()}
        >arrow_upward</button
    >
    <button class="button arrow-button arrowLeft" onclick={() => down()}
        >arrow_back</button
    >
    <button class="button arrow-button arrowDown" onclick={() => left()}
        >arrow_downward</button
    >
    <button class="button arrow-button arrowRight" onclick={() => right()}
        >arrow_forward</button
    >

    <button class="button arrow-button center" onclick={() => center()}
        >crop_square</button
    >
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
    .arrow-box {
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-template-rows: repeat(3, 1fr);
        grid-column-gap: 10px;
        grid-row-gap: 10px;
        max-width: 216px;
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
