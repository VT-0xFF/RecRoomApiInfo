using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.NoEngine.JetBrains.Annotations
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	public sealed class NotNullAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public NotNullAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x85E9AE0", Offset = "0x85E88E0", VA = "0x1885E9AE0")]
		public UsedImplicitlyAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74A46B0", Offset = "0x74A34B0", VA = "0x1874A46B0")]
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85E9AE0", Offset = "0x85E88E0", VA = "0x1885E9AE0")]
		public MeansImplicitUseAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A46B0", Offset = "0x74A34B0", VA = "0x1874A46B0")]
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Flags]
	public enum ImplicitUseKindFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Default = 7,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Access = 1,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Assign = 2,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		InstantiatedWithFixedConstructorSignature = 4,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		InstantiatedNoFixedConstructorSignature = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum ImplicitUseTargetFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Default = 1,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Itself = 1,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Members = 2,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		WithInheritors = 4,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		WithMembers = 3
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public MustUseReturnValueAttribute()
		{
		}
	}
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
