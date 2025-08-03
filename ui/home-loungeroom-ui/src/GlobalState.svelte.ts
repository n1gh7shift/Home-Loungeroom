

let powerState = $state(false);

export function getPowerState(){
    return powerState;
}

export function setPowerState(state: boolean){
    powerState = state;
}


let selection = $state(1)

export function getSelection(){
    return selection;
}

export function setSelection(state: number){
    selection = state;
}

let emulating = $state(false)

export function getEmulating(){
    return emulating;
}

export function setEmulating(state: boolean){
    emulating = state;
}

export function isTouchDevice(): boolean{
    return navigator.maxTouchPoints > 0;
}