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
	public class VLFSRLSSHEI : MBKYNWBPZXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly SQIBJTCPXZW UWJFIMBGZZY;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x847D810", Offset = "0x847C810", VA = "0x18847D810")]
		[UnityEngine.Scripting.Preserve]
		public VLFSRLSSHEI([Inject(null)][NotNull] SQIBJTCPXZW provider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3C50D20", Offset = "0x3C4FD20", VA = "0x183C50D20", Slot = "4")]
		public bool UMHXKLSYTYD<a>([Out] a a) where a : SRSVZATPOUV, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3C50C40", Offset = "0x3C4FC40", VA = "0x183C50C40", Slot = "5")]
		public bool UMHXKLSYTYD<b>(string a, [Out] b b) where b : SRSVZATPOUV, new()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface SRSVZATPOUV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface SQIBJTCPXZW
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UMHXKLSYTYD<a>([Out] a a) where a : SRSVZATPOUV, new();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UMHXKLSYTYD<b>(string a, [Out] b b) where b : SRSVZATPOUV, new();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JNQHWPNFOBZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface MBKYNWBPZXP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UMHXKLSYTYD<a>([Out] a a) where a : SRSVZATPOUV, new();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UMHXKLSYTYD<b>(string a, [Out] b b) where b : SRSVZATPOUV, new();
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
		public Type QBDRWFVBZUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x847D0D0", Offset = "0x847C0D0", VA = "0x18847D0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x847D4E0", Offset = "0x847C4E0", VA = "0x18847D4E0")]
		public FieldOrPropertyInfo(MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x847D1D0", Offset = "0x847C1D0", VA = "0x18847D1D0")]
		public object NBDYMUKDUFE(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x847CF10", Offset = "0x847BF10", VA = "0x18847CF10")]
		public void CTSKFDYACCW(object a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x847D320", Offset = "0x847C320", VA = "0x18847D320")]
		private static bool OSLUXQCWLFA(Type a, object b, [Out] object c)
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
		[Cpp2IlInjected.Address(RVA = "0x847D5F0", Offset = "0x847C5F0", VA = "0x18847D5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x847D650", Offset = "0x847C650", VA = "0x18847D650")]
		public StatsigExperimentParameterAttribute(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Tested]
	public class VIJINCITSTW : SQIBJTCPXZW
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MYTWAQUYXSB<a> where a : SRSVZATPOUV, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public bool BBBJTOBYKIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FWGOIZPVNFU FXFPFYQKIBD;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MYTWAQUYXSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5A9AC50", Offset = "0x5A99C50", VA = "0x185A9AC50")]
			internal bool ZXXIIXRXPUN(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly FPWTBIMQZQR OHDLQBRGXKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, SRSVZATPOUV> VGXWOVPMDOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<Type, StatsigExperimentAttribute> RDAABFYOMGC;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x847D6E0", Offset = "0x847C6E0", VA = "0x18847D6E0")]
		[UnityEngine.Scripting.Preserve]
		public VIJINCITSTW([Inject(null)][NotNull] FPWTBIMQZQR statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EEF0", Offset = "0x3C4DEF0", VA = "0x183C4EEF0", Slot = "4")]
		public bool UMHXKLSYTYD<a>([Out] a a) where a : SRSVZATPOUV, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EA80", Offset = "0x3C4DA80", VA = "0x183C4EA80", Slot = "5")]
		public bool UMHXKLSYTYD<b>(string a, [Out] b b) where b : SRSVZATPOUV, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x847D690", Offset = "0x847C690", VA = "0x18847D690", Slot = "6")]
		public void JNQHWPNFOBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E2B0", Offset = "0x3C4D2B0", VA = "0x183C4E2B0")]
		private bool KHRPPKMBQQN<c>([Out] StatsigExperimentAttribute a) where c : SRSVZATPOUV
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3C4DF10", Offset = "0x3C4CF10", VA = "0x183C4DF10")]
		private static void GDLQOLLDHXS<d>(d a, UVMJZCXMZWH b, Predicate<string> c) where d : SRSVZATPOUV
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
