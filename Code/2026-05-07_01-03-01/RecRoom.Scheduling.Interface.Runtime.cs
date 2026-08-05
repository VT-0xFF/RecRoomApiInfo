using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Async;
using RecRoom.Build;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FQFNQAVQHHT
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BQUYOYJDJCS YKRHZNPSQDW
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BQUYOYJDJCS COKXGHVBROO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BQUYOYJDJCS TUBZBHYVBIR
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KNZQBVEQJEQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GWBZBMLVBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface PESYKSMCDNI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ScheduleQueueType TJBXNVCLFRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float CBQUNUSVGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool WIHIGLAENYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZTDKPTFAXWL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PTRCHJDLDBY
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool isActiveAndEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ZWJDJVEAFMW
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IDisposable Update(PTRCHJDLDBY context, Action callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Update(PTRCHJDLDBY context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable FLWFAIQHMVA(float a, Action<float> b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable FLWFAIQHMVA(PTRCHJDLDBY a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IDisposable WNCCDUOHLPG(PTRCHJDLDBY a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface HIVJVEKFYXO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ScheduleQueueType RIEOICZMZLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		BNFWNHVDKGB AAAHQASWKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PESYKSMCDNI XZZUOGGVCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		PESYKSMCDNI GTWZQGFPOHS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PESYKSMCDNI NZCXKRWWNWI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PESYKSMCDNI XOHZUYJOZPY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AMGSXYCAQOJ Run(IEnumerator<PESYKSMCDNI> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		AMGSXYCAQOJ Run(Behaviour context, IEnumerator<PESYKSMCDNI> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AMGSXYCAQOJ FKOBTBQAHWH(FQFNQAVQHHT a, IEnumerator<PESYKSMCDNI> b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ClearExpiredCoroutines();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		PESYKSMCDNI PXPHBUFMTTC(ScheduleQueueType a = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		PESYKSMCDNI QTFWVOPEKIN(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		AMGSXYCAQOJ GGNOVLMAUJS(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "14")]
		PESYKSMCDNI VWQSRLGVHPK(Func<bool> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface AMGSXYCAQOJ : IXMAZJMESBM, NXPIPFBMDQY, IEnumerator, PESYKSMCDNI, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface BNFWNHVDKGB
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float MLEQHIMPQSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		double BXWPAEHGKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IMYKACWPCYZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PXDVPQKQEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Task YDYUDUNHECV;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public PXDVPQKQEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1603990", Offset = "0x1602390", VA = "0x181603990")]
			internal bool MGEWGCUZPUL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class JSKXOTRANKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NXPIPFBMDQY FPEOXNZBWXH;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public JSKXOTRANKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA335FD0", Offset = "0xA3349D0", VA = "0x18A335FD0")]
			internal bool PZSRZZVYTWD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class QBBXCGMBUXT : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Task YDYUDUNHECV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private PXDVPQKQEEK CQZWTYHJHCX;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public QBBXCGMBUXT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA336090", Offset = "0xA334A90", VA = "0x18A336090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA3362C0", Offset = "0xA334CC0", VA = "0x18A3362C0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static PESYKSMCDNI UAMALJOMVJL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static PESYKSMCDNI AXPSGUXGPAD;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static PESYKSMCDNI NJZBOTRZUIJ;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static PESYKSMCDNI VJJBBEBECBP;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static PESYKSMCDNI NWUCPTVKHQB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static PESYKSMCDNI QGPHYSTEZRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA335E30", Offset = "0xA334830", VA = "0x18A335E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static PESYKSMCDNI NSVTEFYHUNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA335960", Offset = "0xA334360", VA = "0x18A335960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static PESYKSMCDNI GTWZQGFPOHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA335920", Offset = "0xA334320", VA = "0x18A335920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static PESYKSMCDNI NZCXKRWWNWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA335E70", Offset = "0xA334870", VA = "0x18A335E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static PESYKSMCDNI XOHZUYJOZPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA3359A0", Offset = "0xA3343A0", VA = "0x18A3359A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA335B00", Offset = "0xA334500", VA = "0x18A335B00")]
		private static void QZXGNGYANIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3359E0", Offset = "0xA3343E0", VA = "0x18A3359E0")]
		public static PESYKSMCDNI QTFWVOPEKIN(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA335D90", Offset = "0xA334790", VA = "0x18A335D90")]
		public static PESYKSMCDNI VWQSRLGVHPK(Func<bool> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA335D20", Offset = "0xA334720", VA = "0x18A335D20")]
		[IteratorStateMachine(typeof(QBBXCGMBUXT))]
		public static IEnumerator<PESYKSMCDNI> VGXIFZNPGCL(Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3357F0", Offset = "0xA3341F0", VA = "0x18A3357F0")]
		public static PESYKSMCDNI BZNYMZRJSSP(NXPIPFBMDQY a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowSerialization]
	public enum ScheduleQueueType
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		PreRender,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		LatePreRender,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		EndOfFrame
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class JGVWUGAHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ScheduleQueueType[] QVCWLBMJHKX;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class JZHXKDCCDOR
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static bool ZTYHHKVUBEN;
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
