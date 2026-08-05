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
	public class IFPWIWXHRMB : LPQKGKRWOJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly KPPBDAZHTUT KYFQUJELSHV;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x999E160", Offset = "0x999CB60", VA = "0x18999E160")]
		[UnityEngine.Scripting.Preserve]
		public IFPWIWXHRMB([Inject(null)][NotNull] KPPBDAZHTUT provider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3B3ED60", Offset = "0x3B3D760", VA = "0x183B3ED60", Slot = "4")]
		public bool IHZEGEQNIYW<a>([Out] a a) where a : IZMIHLUNFVU, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3B3EC70", Offset = "0x3B3D670", VA = "0x183B3EC70", Slot = "5")]
		public bool IHZEGEQNIYW<b>(string a, [Out] b b) where b : IZMIHLUNFVU, new()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IZMIHLUNFVU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KPPBDAZHTUT
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IHZEGEQNIYW<a>([Out] a a) where a : IZMIHLUNFVU, new();

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IHZEGEQNIYW<b>(string a, [Out] b b) where b : IZMIHLUNFVU, new();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JNGTYRZDOIQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface LPQKGKRWOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IHZEGEQNIYW<a>([Out] a a) where a : IZMIHLUNFVU, new();

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IHZEGEQNIYW<b>(string a, [Out] b b) where b : IZMIHLUNFVU, new();
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
		public Type NPYYRABJPOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x999DF70", Offset = "0x999C970", VA = "0x18999DF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x999E060", Offset = "0x999CA60", VA = "0x18999E060")]
		public FieldOrPropertyInfo(MemberInfo memberInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x999DE30", Offset = "0x999C830", VA = "0x18999DE30")]
		public object KHJQRGNTLDB(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x999DAB0", Offset = "0x999C4B0", VA = "0x18999DAB0")]
		public void DQMVUXBDMYP(object a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x999DC70", Offset = "0x999C670", VA = "0x18999DC70")]
		private static bool JYKRZYRSEPF(Type a, object b, [Out] object c)
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
		[Cpp2IlInjected.Address(RVA = "0x999E1F0", Offset = "0x999CBF0", VA = "0x18999E1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x999E250", Offset = "0x999CC50", VA = "0x18999E250")]
		public StatsigExperimentParameterAttribute(string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Tested]
	public class YIRMPKVAZEX : KPPBDAZHTUT
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LRCDTOFPHMM<a> where a : IZMIHLUNFVU, new()
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public bool LDGIXKDVVAY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public ABMSBGWFNTZ CWAIZTYMHXE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LRCDTOFPHMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x68ECB90", Offset = "0x68EB590", VA = "0x1868ECB90")]
			internal bool RKGKOWXUQCY(string a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly GXIDENQQQUA VCTNXGHSMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<string, IZMIHLUNFVU> LYUOUMUTLZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<Type, StatsigExperimentAttribute> PHTPIXGLJYT;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x999E2E0", Offset = "0x999CCE0", VA = "0x18999E2E0")]
		[UnityEngine.Scripting.Preserve]
		public YIRMPKVAZEX([Inject(null)][NotNull] GXIDENQQQUA statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4133F50", Offset = "0x4132950", VA = "0x184133F50", Slot = "4")]
		public bool IHZEGEQNIYW<a>([Out] a a) where a : IZMIHLUNFVU, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4133AD0", Offset = "0x41324D0", VA = "0x184133AD0", Slot = "5")]
		public bool IHZEGEQNIYW<b>(string a, [Out] b b) where b : IZMIHLUNFVU, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x999E290", Offset = "0x999CC90", VA = "0x18999E290", Slot = "6")]
		public void JNGTYRZDOIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x41332F0", Offset = "0x4131CF0", VA = "0x1841332F0")]
		private bool FCXJMNUBHYG<c>([Out] StatsigExperimentAttribute a) where c : IZMIHLUNFVU
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4134470", Offset = "0x4132E70", VA = "0x184134470")]
		private static void XBPPRQBVIVV<d>(d a, RLZCMGHPLGW b, Predicate<string> c) where d : IZMIHLUNFVU
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
