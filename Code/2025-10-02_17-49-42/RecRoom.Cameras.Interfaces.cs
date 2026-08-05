using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83B2AA0", Offset = "0x83B14A0", VA = "0x1883B2AA0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Cameras.Effects
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CameraFadeOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float FadeToBlackDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float FadeToCameraDuration;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83B29E0", Offset = "0x83B13E0", VA = "0x1883B29E0")]
		public CameraFadeOptions()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DGAGDIFOCGB
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const float EFGPFKBDCML = 0f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly float? LCLKCODKDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float? OBIODAIEBLL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly DGAGDIFOCGB JIECLIBKJDH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3101A80", Offset = "0x3100480", VA = "0x183101A80")]
	public DGAGDIFOCGB([Optional] float? DICDANJACBN, [Optional] float? EGAHLKCMDML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JHNBKOHMNNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool COAJFLNLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MPPEOPFFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KFAAPDGLIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AGENNLIPKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ILCEBJOBLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBFOPPEEJNA OFAOKJEFJCB(OMCJCLBFMAA MFKHKDDANII, [Optional] DGAGDIFOCGB? JHKBJHDECNB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task AJMMDPJMFGH([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyCollection<OMCJCLBFMAA> HHPAGHKOPGE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IBFOPPEEJNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HPHKLCPMHCL([Optional] CancellationToken AHOMALKMHKK);
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
