using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Build
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Flags]
	public enum BuildFlavor
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Release = 1,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Debug = 2,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Promo = 4,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		All = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Flags]
	public enum PrebuildCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default = 2,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		ArtAssets = 4,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Scenes = 8,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Prefabs = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Localization = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		RRUI = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Circuits = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		CodeOnly = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Addressables = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Settings = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		ScriptableObjects = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AllObjects = 0x818,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		All = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	public class DisallowSerializationAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly Type UseInstead;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0020", Offset = "0x7EAF020", VA = "0x187EB0020")]
		public DisallowSerializationAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public DisallowSerializationAttribute(Type useInstead)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Field)]
	public class AllowSerializationOverrideAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public AllowSerializationOverrideAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[MeansImplicitUse]
	public class PreBuildValidationStepAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string BuildStepName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly BuildFlavor RunForBuildFlavors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly PrebuildCategory Category;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83621F0", Offset = "0x83611F0", VA = "0x1883621F0")]
		public PreBuildValidationStepAttribute(string buildStepName, BuildFlavor runForBuildFlavors = BuildFlavor.All, PrebuildCategory runForCategory = PrebuildCategory.Default)
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
