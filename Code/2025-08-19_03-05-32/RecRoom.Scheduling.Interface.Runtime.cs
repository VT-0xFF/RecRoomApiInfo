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
public interface SAMRDZOWKNO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DQHMEXLDKHB KYMYXOJVAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DQHMEXLDKHB TYXEVPGDWWT
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DQHMEXLDKHB PYVBTDEQLOS
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool WSVZFPUSALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AURCHPLFRYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IMKAVQMVTAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ScheduleQueueType IHLVWRQKHAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		float UNZCYFGBDEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool JGEYXGXUITT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OVVYNSQUSPY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YFIQJDPXTBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool BXTPTFRWDXR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool ZLBFHSBLVHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface CICYNVXEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IDisposable Update(YFIQJDPXTBF context, Action callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Update(YFIQJDPXTBF context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable FRWGVXLREYR(float a, Action<float> b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable FRWGVXLREYR(YFIQJDPXTBF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IDisposable EHDNKOPFZAB(YFIQJDPXTBF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface TQPUKRRDZNZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ScheduleQueueType JUEBRAMHDZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		BHTOMZEUOYU AHFNHSREMJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IMKAVQMVTAL ZWKMYPUCKMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IMKAVQMVTAL TGSLFQTRGYD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		IMKAVQMVTAL EZJLGFDQYYH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		IMKAVQMVTAL FUBVLMBNZPR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DLHIAPQRHVO Run(IEnumerator<IMKAVQMVTAL> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DLHIAPQRHVO Run(Behaviour context, IEnumerator<IMKAVQMVTAL> coroutineToRun);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DLHIAPQRHVO GPGIKFCIMMK(SAMRDZOWKNO a, IEnumerator<IMKAVQMVTAL> b);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ClearExpiredCoroutines();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IMKAVQMVTAL GJCPHUXKTFV(ScheduleQueueType a = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		IMKAVQMVTAL PYORZQZYTLU(float a, ScheduleQueueType b = ScheduleQueueType.Update);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		IMKAVQMVTAL PHRAEDCHEUR(Func<bool> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DLHIAPQRHVO : SGMUANPBQKN, WGVXBSAEBCD, IEnumerator, IMKAVQMVTAL, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface BHTOMZEUOYU
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float DIHMSZUWUBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float GLTPWQWSTBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		double DFBNQKMZLER
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class KAXRSDRPNPU
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class WRYZWRRZYVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Task UDEVSVRDCHY;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRYZWRRZYVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15BE870", Offset = "0x15BD670", VA = "0x1815BE870")]
			internal bool VDBWLTQGVJQ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class VCNKWXLRMEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public WGVXBSAEBCD VVXTPEZYXEA;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VCNKWXLRMEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x906B3D0", Offset = "0x906A1D0", VA = "0x18906B3D0")]
			internal bool ILTIBHDCUEQ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class QDERFOIVXBE : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Task UDEVSVRDCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private WRYZWRRZYVR IBGUFKSPOHO;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public QDERFOIVXBE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x906B080", Offset = "0x9069E80", VA = "0x18906B080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x906B040", Offset = "0x9069E40", VA = "0x18906B040", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static IMKAVQMVTAL KZGGDFHBOAK;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static IMKAVQMVTAL FEJYHHGVWHW;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static IMKAVQMVTAL TDEOHLTLBSM;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static IMKAVQMVTAL EOFNMEAENYQ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static IMKAVQMVTAL NFDQTHEXDRA;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static IMKAVQMVTAL HSUAYYXETUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x906B000", Offset = "0x9069E00", VA = "0x18906B000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static IMKAVQMVTAL IVYESDEJSLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x906A9E0", Offset = "0x90697E0", VA = "0x18906A9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static IMKAVQMVTAL TGSLFQTRGYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x906A9A0", Offset = "0x90697A0", VA = "0x18906A9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static IMKAVQMVTAL EZJLGFDQYYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x906AA20", Offset = "0x9069820", VA = "0x18906AA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static IMKAVQMVTAL FUBVLMBNZPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x906AFC0", Offset = "0x9069DC0", VA = "0x18906AFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x906ADC0", Offset = "0x9069BC0", VA = "0x18906ADC0")]
		private static void UKPOPAEUXLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x906ACA0", Offset = "0x9069AA0", VA = "0x18906ACA0")]
		public static IMKAVQMVTAL PYORZQZYTLU(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x906AC00", Offset = "0x9069A00", VA = "0x18906AC00")]
		public static IMKAVQMVTAL PHRAEDCHEUR(Func<bool> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x906AA60", Offset = "0x9069860", VA = "0x18906AA60")]
		[IteratorStateMachine(typeof(QDERFOIVXBE))]
		public static IEnumerator<IMKAVQMVTAL> HVSTNZLINHE(Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x906AAD0", Offset = "0x90698D0", VA = "0x18906AAD0")]
		public static IMKAVQMVTAL OXLOSQUHLUM(WGVXBSAEBCD a)
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
	public static class VBJGIHGNRJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly ScheduleQueueType[] ILJXTXXVZIG;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MYKNZLYXLZE
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static bool OPEOZDYVAFA;
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
