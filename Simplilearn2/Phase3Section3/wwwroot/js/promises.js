function flippingACoin() {
    return new Promise((resolve, reject) => {
        const val = Math.round(Math.random() * 1); //0 or 1 randomly

        val ? resolve('Heads!!') : reject('Tails!!');
    });
}

async function result(iter) {
    try {
        const result = await flippingACoin();
        console.log(result);
    } catch (err) {
        console.log(err);
    }
}

result(1);
result(2);
result(3);
result(4);
result(5);