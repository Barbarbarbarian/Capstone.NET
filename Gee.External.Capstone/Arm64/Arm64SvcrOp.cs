using System.Diagnostics.CodeAnalysis;

namespace Gee.External.Capstone.Arm64;

/// <summary>
///     ARM64 SVCR Operation.
/// </summary>
[SuppressMessage("ReSharper", "IdentifierTypo")]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum Arm64SvcrOp {
    Invalid = 0,
    ARM64_SVCR_SVCRSM = 0x1,
    ARM64_SVCR_SVCRSMZA = 0x3,
    ARM64_SVCR_SVCRZA = 0x2
}
