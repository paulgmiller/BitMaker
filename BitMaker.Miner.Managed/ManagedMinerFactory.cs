﻿using BitMaker.Miner.Cpu;

namespace BitMaker.Miner.Managed
{

    /// <summary>
    /// Factory for <see cref="T:ManagedMiner"/>.
    /// </summary>
    [MinerFactory]
    public class ManagedMinerFactory : CpuMinerFactory
    {

        /// <summary>
        /// Starts a new instance of the miner.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public override IMiner StartMiner(IMinerContext context, CpuResource resource)
        {
            var miner = new ManagedMiner(context, (CpuResource)resource);
            miner.Start();

            return miner;
        }

    }

}
