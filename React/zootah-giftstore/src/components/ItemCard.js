import React, { useMemo } from "react";
import ZooButton from "./ZooButton";

function ItemCard({imageLocation, product, ...props}) {

    /*
    product = { name, price, sizes[{size: 'XL', quantity: 8}], subText}
    */

    const inStock = useMemo(()=>{
        return product.sizes.some(s => s.quantity > 0)
    }, [product])
    
    return (
        <div className="flex font-sans border border-slate-300 rounded-md shadow-lg m-4">
            <div className="flex-none w-56 relative">
                <img src={imageLocation} alt={product.name} class="absolute inset-0 w-full h-full object-cover rounded-md" loading="lazy" />
            </div>
            <form className="flex-auto p-6">
                <div className="flex flex-wrap">
                <h1 className="flex-auto font-medium text-slate-900">
                    {product.name}
                </h1>
                <div className="w-full flex-none mt-2 order-1 text-3xl font-bold text-slate-900">
                    {'$' + product.price}
                </div>
                <div className="text-sm font-medium text-slate-400">
                    {inStock}
                </div>
                </div>
                <div className="flex items-baseline mt-4 mb-6 pb-6 border-b border-slate-200">
                    <div className="space-x-2 flex text-sm">
                        {product.sizes && product.sizes.map((size, index) => {
                            return (
                                <label key={index}>
                                    <input className="sr-only peer" name="size" type="radio" value={size} disabled={!size.quantity} />
                                    <div className="w-9 h-9 rounded-full flex items-center justify-center text-stone-400 peer-checked:bg-stone-600 peer-checked:text-white hover:bg-stone-200">
                                        <span className={size.quantity > 0 ? "no-underline font-bold" : "line-through font-light"}>
                                            {size.size}
                                        </span>
                                    </div>
                                </label>
                            )
                        })}
                    </div>
                </div>
                <div className="flex space-x-4 mb-5 text-sm font-medium">
                <div className="flex-auto flex space-x-4">
                    <ZooButton onClick={()=> console.log('do something')} text='Add to Cart' />
                </div>
                <button className="flex-none flex items-center justify-center w-9 h-9 rounded-full text-green-500 bg-green-50" type="button" aria-label="Like">
                    <svg width="20" height="20" fill="currentColor" aria-hidden="true">
                    <path fill-rule="evenodd" clip-rule="evenodd" d="M3.172 5.172a4 4 0 015.656 0L10 6.343l1.172-1.171a4 4 0 115.656 5.656L10 17.657l-6.828-6.829a4 4 0 010-5.656z" />
                    </svg>
                </button>
                </div>
                <p className="text-sm text-slate-500">
                {product.subtext}
                </p>
            </form>
        </div>
    )
}

export default ItemCard