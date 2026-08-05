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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BXAPWFAQUBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x130F7E0", Offset = "0x130DFE0", VA = "0x18130F7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PHEUSJQEBDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D174C0", Offset = "0x8D15CC0", VA = "0x188D174C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public UKSTOOYZQQW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D17580", Offset = "0x8D15D80", VA = "0x188D17580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D177B0", Offset = "0x8D15FB0", VA = "0x188D177B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D16E60", Offset = "0x8D15660", VA = "0x188D16E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static YTAMKWOJLST QOYZQIMENQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D16E20", Offset = "0x8D15620", VA = "0x188D16E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static YTAMKWOJLST UZPUIHGPOEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8D16EA0", Offset = "0x8D156A0", VA = "0x188D16EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static YTAMKWOJLST BQJFSKWGIUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8D16EE0", Offset = "0x8D156E0", VA = "0x188D16EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static YTAMKWOJLST SGXCASDZXQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D17480", Offset = "0x8D15C80", VA = "0x188D17480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D16F20", Offset = "0x8D15720", VA = "0x188D16F20")]
		private static void QWIFWOCBHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D17360", Offset = "0x8D15B60", VA = "0x188D17360")]
		public static YTAMKWOJLST TYNZDYVVWBA(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D17120", Offset = "0x8D15920", VA = "0x188D17120")]
		public static YTAMKWOJLST QYCCHFSBLDD(Func<bool> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D171C0", Offset = "0x8D159C0", VA = "0x188D171C0")]
		[IteratorStateMachine(typeof(UKSTOOYZQQW))]
		public static IEnumerator<YTAMKWOJLST> RFYMGGJSXLA(Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D17230", Offset = "0x8D15A30", VA = "0x188D17230")]
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
