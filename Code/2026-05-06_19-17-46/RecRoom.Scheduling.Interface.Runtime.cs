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
public interface OHMKRHMOYNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PZVGSBFXRHS OTGNTRCPKRE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PZVGSBFXRHS RHNCBWPRCQU
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PZVGSBFXRHS PUQDSKDNUPR
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BQPURYLUXMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ZSDNRDOGIKR
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KHZACSYKHRO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ScheduleQueueType MBWBJANWPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float MUNGGMVKPEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool DRIJNNUMHJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PEALETUSPAJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PBUFILHXHAU
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
	public interface ZWVBXOSJYAY
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IDisposable Update(PBUFILHXHAU context, Action callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Update(PBUFILHXHAU context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable LRJOZNUOPKI(float a, Action<float> b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable LRJOZNUOPKI(PBUFILHXHAU a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IDisposable BFGDWKHYXAS(PBUFILHXHAU a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface GUZFZPTTQMS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ScheduleQueueType RRRTFOVZFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IZYCAHMLASH UPSDDETCOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KHZACSYKHRO NOLGDETKLJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KHZACSYKHRO YVXEJPNBWLY
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KHZACSYKHRO NJLBXFBPNSK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		KHZACSYKHRO JXJUBNQSQTG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NDLSPIRTFEP Run(IEnumerator<KHZACSYKHRO> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NDLSPIRTFEP Run(Behaviour context, IEnumerator<KHZACSYKHRO> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NDLSPIRTFEP UTLRZAYTYLX(OHMKRHMOYNJ a, IEnumerator<KHZACSYKHRO> b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ClearExpiredCoroutines();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		KHZACSYKHRO NHCJGRFQOJU(ScheduleQueueType a = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		KHZACSYKHRO PWVSNGIGLZV(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NDLSPIRTFEP IEKZMCZJUKK(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "14")]
		KHZACSYKHRO NPNULMOTCCS(Func<bool> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NDLSPIRTFEP : LEVOMZEPWVK, NKOSDRYVRPY, IEnumerator, KHZACSYKHRO, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IZYCAHMLASH
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float BNOWTLGKQXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		double YLNYDJYGFSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class MHMYYCKMDNF
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class XPLPZREOGEU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Task QQBVMIREKKP;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XPLPZREOGEU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1613E80", Offset = "0x1612880", VA = "0x181613E80")]
			internal bool BNQVRMVGLUZ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class SXDNZLOKQLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NKOSDRYVRPY KRDTMVFEGYP;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public SXDNZLOKQLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA35D490", Offset = "0xA35BE90", VA = "0x18A35D490")]
			internal bool YIELIGBFKVL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FTADQARCIZV : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Task QQBVMIREKKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private XPLPZREOGEU XFHCWOACVQZ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public FTADQARCIZV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA35CA40", Offset = "0xA35B440", VA = "0x18A35CA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA35CC70", Offset = "0xA35B670", VA = "0x18A35CC70", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static KHZACSYKHRO WVSFGUIWNUH;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static KHZACSYKHRO KQVINLKHVOV;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static KHZACSYKHRO IQFAPWCRTQD;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static KHZACSYKHRO MXXSZXOHBMP;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static KHZACSYKHRO VSJZWDJISPB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static KHZACSYKHRO PRHKHJTKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA35D060", Offset = "0xA35BA60", VA = "0x18A35D060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static KHZACSYKHRO CVCTQDQWXJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA35CD30", Offset = "0xA35B730", VA = "0x18A35CD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static KHZACSYKHRO YVXEJPNBWLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA35CCF0", Offset = "0xA35B6F0", VA = "0x18A35CCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static KHZACSYKHRO NJLBXFBPNSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA35D0A0", Offset = "0xA35BAA0", VA = "0x18A35D0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static KHZACSYKHRO JXJUBNQSQTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA35CCB0", Offset = "0xA35B6B0", VA = "0x18A35CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA35D0E0", Offset = "0xA35BAE0", VA = "0x18A35D0E0")]
		private static void WHKUTFJGBMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA35CF40", Offset = "0xA35B940", VA = "0x18A35CF40")]
		public static KHZACSYKHRO PWVSNGIGLZV(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA35CEA0", Offset = "0xA35B8A0", VA = "0x18A35CEA0")]
		public static KHZACSYKHRO NPNULMOTCCS(Func<bool> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA35D300", Offset = "0xA35BD00", VA = "0x18A35D300")]
		[IteratorStateMachine(typeof(FTADQARCIZV))]
		public static IEnumerator<KHZACSYKHRO> WKCBUMDZTJH(Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA35CD70", Offset = "0xA35B770", VA = "0x18A35CD70")]
		public static KHZACSYKHRO LQTNXPHSFNP(NKOSDRYVRPY a)
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
	public static class QXAKRQOMRAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ScheduleQueueType[] NOTEBQJYEPP;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class XBGFKYLWUPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static bool WBJZQRECISP;
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
