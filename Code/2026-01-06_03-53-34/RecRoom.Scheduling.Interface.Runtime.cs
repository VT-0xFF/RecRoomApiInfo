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
public interface FRNFKJLNSJK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MWKYWAOJZRV PWFGHYHXZGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MWKYWAOJZRV PULLZVKMGWX
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MWKYWAOJZRV MOTTRBCKUQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool YNYVGUCJUYH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LHYUNIINVRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface YTAMKWOJLST
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ScheduleQueueType XOQALWFTSJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float BNVHBILCHCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool HXQEXYTOCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool STGMJELSBKS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface POKLIYYXBNR
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
	public interface EMRIVLJUJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IDisposable Update(POKLIYYXBNR context, Action callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Update(POKLIYYXBNR context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable OWEJDKYXKRT(float a, Action<float> b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable OWEJDKYXKRT(POKLIYYXBNR a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IDisposable WBQAIMOAAVP(POKLIYYXBNR a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface SEPEWOFBWYL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ScheduleQueueType XYVOJVUJEVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		MUGMONEUUMI OUYSUPPXFVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		YTAMKWOJLST SURLRAXDWXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		YTAMKWOJLST UZPUIHGPOEX
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		YTAMKWOJLST BQJFSKWGIUD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		YTAMKWOJLST SGXCASDZXQT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XEXLSJPFYXK Run(IEnumerator<YTAMKWOJLST> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XEXLSJPFYXK Run(Behaviour context, IEnumerator<YTAMKWOJLST> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XEXLSJPFYXK IEPBFOFACHA(FRNFKJLNSJK a, IEnumerator<YTAMKWOJLST> b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ClearExpiredCoroutines();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		YTAMKWOJLST COZSVWMOSHZ(ScheduleQueueType a = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		YTAMKWOJLST TYNZDYVVWBA(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		XEXLSJPFYXK DFSMWGCJRER(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "14")]
		YTAMKWOJLST QYCCHFSBLDD(Func<bool> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface XEXLSJPFYXK : IHSGGRZWIQF, DNXWICJZUNF, IEnumerator, YTAMKWOJLST, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface MUGMONEUUMI
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float IHVIPGGUYKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float BZRWBGEFTHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		double QRAIJYHXFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class JRMLAYRJBWC
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BXAPWFAQUBV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Task XBJDPZXBWSO;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public BXAPWFAQUBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1326FC0", Offset = "0x13259C0", VA = "0x181326FC0")]
			internal bool BWGSGABXWNI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PHEUSJQEBDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public DNXWICJZUNF UAIIZOLEBCY;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public PHEUSJQEBDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8E19AD0", Offset = "0x8E184D0", VA = "0x188E19AD0")]
			internal bool WSRMFBTIRBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class UKSTOOYZQQW : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Task XBJDPZXBWSO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private BXAPWFAQUBV KUKOITOJGQQ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public UKSTOOYZQQW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8E19B90", Offset = "0x8E18590", VA = "0x188E19B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8E19DC0", Offset = "0x8E187C0", VA = "0x188E19DC0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static YTAMKWOJLST JWQSZYHNDCG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static YTAMKWOJLST UWTLFXYIJWA;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static YTAMKWOJLST QOZHFFFVPFS;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static YTAMKWOJLST XUFEZQXCOUI;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static YTAMKWOJLST QMEWIUFTEAK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static YTAMKWOJLST ZFIFZWWBCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8E19470", Offset = "0x8E17E70", VA = "0x188E19470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static YTAMKWOJLST QOYZQIMENQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8E19430", Offset = "0x8E17E30", VA = "0x188E19430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static YTAMKWOJLST UZPUIHGPOEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8E194B0", Offset = "0x8E17EB0", VA = "0x188E194B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static YTAMKWOJLST BQJFSKWGIUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8E194F0", Offset = "0x8E17EF0", VA = "0x188E194F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static YTAMKWOJLST SGXCASDZXQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8E19A90", Offset = "0x8E18490", VA = "0x188E19A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E19530", Offset = "0x8E17F30", VA = "0x188E19530")]
		private static void QWIFWOCBHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E19970", Offset = "0x8E18370", VA = "0x188E19970")]
		public static YTAMKWOJLST TYNZDYVVWBA(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E19730", Offset = "0x8E18130", VA = "0x188E19730")]
		public static YTAMKWOJLST QYCCHFSBLDD(Func<bool> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E197D0", Offset = "0x8E181D0", VA = "0x188E197D0")]
		[IteratorStateMachine(typeof(UKSTOOYZQQW))]
		public static IEnumerator<YTAMKWOJLST> RFYMGGJSXLA(Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E19840", Offset = "0x8E18240", VA = "0x188E19840")]
		public static YTAMKWOJLST TKEGPBUWNOU(DNXWICJZUNF a)
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
	public static class BESDBKGUIDU
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ScheduleQueueType[] ZFKELIQIJWG;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class KGJJTWZGACS
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static bool YDHYKWADWXI;
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
