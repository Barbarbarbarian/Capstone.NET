namespace Gee.External.Capstone;

/// <summary>
///     Native Query Option.
/// </summary>
internal enum NativeQueryOption {
    /// <summary>
    ///     Query ARM Architecture.
    /// </summary>
    QueryArmArchitecture = DisassembleArchitecture.Arm,

    /// <summary>
    ///     Query ARM64 Architecture.
    /// </summary>
    QueryArm64Architecture = DisassembleArchitecture.Arm64,

    /// <summary>
    ///    Query MIPS Architecture.
    /// </summary>
    QueryMipsArchitecture = DisassembleArchitecture.Mips,

    /// <summary>
    ///     Query X86 Architecture.
    /// </summary>
    QueryX86Architecture = DisassembleArchitecture.X86,

    /// <summary>
    ///     Query PowerPC Architecture.
    /// </summary>
    QueryPowerPcArchitecture = DisassembleArchitecture.PowerPc,

    /// <summary>
    ///     Query Sparc Architecture.
    /// </summary>
    QuerySparcArchitecture = DisassembleArchitecture.Sparc,

    /// <summary>
    ///     Query SystemZ Architecture.
    /// </summary>
    QuerySystemZArchitecture = DisassembleArchitecture.SystemZ,

    /// <summary>
    ///     Query XCore Architecture.
    /// </summary>
    QueryXCoreArchitecture = DisassembleArchitecture.XCore,

    /// <summary>
    ///     Query 68K Architecture.
    /// </summary>
    QueryM68KArchitecture = DisassembleArchitecture.M68K,

    /// <summary>
    ///     Query TMS320C64x Architecture.
    /// </summary>
    QueryTms320C64XArchitecture = DisassembleArchitecture.Tms320C64X,

    /// <summary>
    ///     Query 680X Architecture.
    /// </summary>
    QueryM680XArchitecture = DisassembleArchitecture.M680X,

    /// <summary>
    ///     Query Ethereum EVM Architecture.
    /// </summary>
    QueryEvmArchitecture = DisassembleArchitecture.Evm,

    /// <summary>
    ///     Query MOS65XX Architecture.
    /// </summary>
    QueryMos65XXArchitecture = DisassembleArchitecture.Mos65XX,

    /// <summary>
    ///     Query WebAssembly Architecture.
    /// </summary>
    QueryWasmArchitecture = DisassembleArchitecture.Wasm,

    /// <summary>
    ///     Query Berkeley Packet Filter Architecture.
    /// </summary>
    QueryBpfArchitecture = DisassembleArchitecture.Bpf,

    /// <summary>
    ///     Query RISC-V Architecture.
    /// </summary>
    QueryRiscvArchitecture = DisassembleArchitecture.Riscv,

    /// <summary>
    ///     Query SuperH Architecture.
    /// </summary>
    QueryShArchitecture = DisassembleArchitecture.Sh,

    /// <summary>
    ///     Query TriCore Architecture.
    /// </summary>
    QueryTriCoreArchitecture = DisassembleArchitecture.TriCore,

    /// <summary>
    ///     Query All Architectures.
    /// </summary>
    QueryAllArchitectures = 0xFFFF,

    /// <summary>
    ///     Query Diet Mode.
    /// </summary>
    QueryDietMode = NativeQueryOption.QueryAllArchitectures + 1,

    /// <summary>
    ///     Query X86 Reduce Mode.
    /// </summary>
    QueryX86ReduceMode = NativeQueryOption.QueryAllArchitectures + 2
}