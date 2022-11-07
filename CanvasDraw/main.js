window.onload = (e) =>
{
    let canvas = document.getElementById('canvas')

    window.onresize = (eResize) =>
    {
        canvas.width = window.innerWidth
        canvas.height = window.innerHeight
    }

    window.onresize()

    let ctx = canvas.getContext('2d')
    let isClicking = false

    let draw = (e) =>
    {
        ctx.lineTo(e.clientX, e.clientY)
        ctx.stroke()
    }

    canvas.addEventListener('mousedown', (eMousedown) =>
    {
        isClicking = true
        ctx.lineWidth = 2
        ctx.lineStyle = 'black'
        ctx.lineCap = 'round'
        ctx.beginPath()
        ctx.moveTo(eMousedown.clientX, eMousedown.clientY)
        draw(eMousedown)
    })

    canvas.addEventListener('mousemove', (eMousemove) =>
    {
        if(isClicking)
        {
            draw(eMousemove)
        }
    })

    canvas.addEventListener('mouseup', (eMouseup) =>
    {
        isClicking = false
        ctx.closePath()
    })

    canvas.addEventListener('contextmenu', (eKeydown) =>
    {
        ctx.clearRect(0,0,canvas.width,canvas.height)
    })

    // ctx.lineWidth = 2
    // ctx.strokeStyle = 'red'
    // ctx.strokeRect(10, 10, 40, 40)

    // ctx.fillStyle = 'pink'
    // ctx.fillRect(10, 10, 40, 40)

    // ctx.beginPath()
    // ctx.moveTo(50, 50)
    // ctx.lineTo(70, 60)
    // ctx.lineTo(90, 40)
    // ctx.closePath()
    // ctx.stroke()
}