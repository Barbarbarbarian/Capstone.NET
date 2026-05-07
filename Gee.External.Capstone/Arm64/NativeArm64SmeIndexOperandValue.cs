using System.Runtime.InteropServices;

namespace Gee.External.Capstone.Arm64;

/// <summary>
///     Native ARM64 SME Index Operand Value.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
internal struct NativeArm64SmeIndexOperandValue {
    /// <summary>
    ///     Register Being Indexed.
    /// </summary>
    public Arm64RegisterId Register;

    /// <summary>
    ///     Base Register.
    /// </summary>
    public Arm64RegisterId Base;

    /// <summary>
    ///     Displacement Value.
    /// </summary>
    public int Displacement;
}
