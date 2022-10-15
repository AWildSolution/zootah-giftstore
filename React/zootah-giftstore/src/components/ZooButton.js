import React from "react"


function ZooButton({onClick, width, text, ...props}) {

    return (
            <button className={`
            w-32
            h-10 
            pr-2
            pl-2
            m-2
            rounded 
            shadow-md
            font-sans
            font-medium
            text-white
            hover:rounded-xl hover:shadow-xl 
            bg-green-500 border 
            border-green-800`}
            onClick={onClick}>{text}</button>
    )
}

export default ZooButton