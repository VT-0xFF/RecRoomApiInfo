using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Analytics.Statsig;
using RecRoom.NoEngine.Common;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Experiments
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Tested]
	public class NNIHLIRAFLN : FOTBTNHTEDS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly JVJYIJIRXWN JRROJJZNABT;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85062A0", Offset = "0x85050A0", VA = "0x1885062A0")]
		[UnityEngine.Scripting.Preserve]
		public NNIHLIRAFLN([Inject(null)][NotNull] JVJYIJIRXWN provider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x39356D0", Offset = "0x39344D0", VA = "0x1839356D0", Slot = "4")]
		public bool DAGXWJOTYQI<a>([Out] a a) where a : BJAYBDLTTNK, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x39357B0", Offset = "0x39345B0", VA = "0x1839357B0", Slot = "5")]
		public bool DAGXWJOTYQI<b>(string a, [Out] b b) where b : BJAYBDLTTNK, new()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BJAYBDLTTNK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JVJYIJIRXWN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DAGXWJOTYQI<a>([Out] a a) where a : BJAYBDLTTNK, new();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DAGXWJOTYQI<b>(string a, [Out] b b) where b : BJAYBDLTTNK, new();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JZDZNTJKOOO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface FOTBTNHTEDS
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DAGXWJOTYQI<a>([Out] a a) where a : BJAYBDLTTNK, new();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DAGXWJOTYQI<b>(string a, [Out] b b) where b : BJAYBDLTTNK, new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[AttributeUsage(AttributeTargets.Field)]
	public class NotExperimentParameterAttribute : Attribute
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal readonly struct FieldOrPropertyInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly MemberInfo memberInfo;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type MFULOPJXHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8505ED0", Offset = "0x8504CD0", VA = "0x188505ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8506190", Offset = "0x8504F90", VA = "0x188506190")]
		public FieldOrPropertyInfo(MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8505D80", Offset = "0x8504B80", VA = "0x188505D80")]
		public object CHVOCEPXJHL(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8505BC0", Offset = "0x85049C0", VA = "0x188505BC0")]
		public void BWZXNRYLFBT(object a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8505FD0", Offset = "0x8504DD0", VA = "0x188505FD0")]
		private static bool JJRXLIHMXXT(Type a, object b, [Out] object c)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Experiments.Providers
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum StatsigExperimentType
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Experiment,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Layer
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class StatsigExperimentAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly bool UseLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly StatsigExperimentType Type;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8506330", Offset = "0x8505130", VA = "0x188506330")]
		public StatsigExperimentAttribute([Optional] string name, StatsigExperimentType type = StatsigExperimentType.Experiment, bool useLayerDefaults = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class StatsigExperimentParameterAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly string Name;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8506390", Offset = "0x8505190", VA = "0x188506390")]
		public StatsigExperimentParameterAttribute(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Tested]
	public class WDQFIPIHZRX : JVJYIJIRXWN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class XMLYRAPYPHU<a> where a : BJAYBDLTTNK, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public bool JZMQIAZLCNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public YAPUCMXMLXX BFLQZQZZZEM;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public XMLYRAPYPHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3ED30D0", Offset = "0x3ED1ED0", VA = "0x183ED30D0")]
			internal bool CNLWLTHEIRU(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly XCPQFGYWTBQ RIFSMTIEHLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, BJAYBDLTTNK> RMPRETTNSOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<Type, StatsigExperimentAttribute> YJBBOFYHBKZ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8506420", Offset = "0x8505220", VA = "0x188506420")]
		[UnityEngine.Scripting.Preserve]
		public WDQFIPIHZRX([Inject(null)][NotNull] XCPQFGYWTBQ statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C884F0", Offset = "0x3C872F0", VA = "0x183C884F0", Slot = "4")]
		public bool DAGXWJOTYQI<a>([Out] a a) where a : BJAYBDLTTNK, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C88070", Offset = "0x3C86E70", VA = "0x183C88070", Slot = "5")]
		public bool DAGXWJOTYQI<b>(string a, [Out] b b) where b : BJAYBDLTTNK, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85063D0", Offset = "0x85051D0", VA = "0x1885063D0", Slot = "6")]
		public void JZDZNTJKOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C88690", Offset = "0x3C87490", VA = "0x183C88690")]
		private bool NRJFWHGJCEI<c>([Out] StatsigExperimentAttribute a) where c : BJAYBDLTTNK
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C88C20", Offset = "0x3C87A20", VA = "0x183C88C20")]
		private static void WLSXJSETYAR<d>(d a, DYPOERVYSFG b, Predicate<string> c) where d : BJAYBDLTTNK
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
