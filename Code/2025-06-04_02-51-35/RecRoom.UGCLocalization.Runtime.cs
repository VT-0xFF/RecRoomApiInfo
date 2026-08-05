using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_UGCLocalization_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AECA50", Offset = "0x8AEB250", VA = "0x188AECA50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DIADIMJDNBG]
public class EFDKKBLELLN : KLJDHLNOMBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class PDPEBMOFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum AJICOMEOOCG
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Needed = 0,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Requested = 1,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Default = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum OCECEGIIADK
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Modified,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			AddedFirstOrRemovedLast
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HashSet<JMPCLAAGBAN> IJAMKKHKCCE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GOLMNHOAKHA MPLKEONLJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GEFGCOBCBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC190", Offset = "0x8AEA990", VA = "0x188AEC190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FALFADIMAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC140", Offset = "0x8AEA940", VA = "0x188AEC140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AJICOMEOOCG FKHKBMKPOOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
			[CompilerGenerated]
			get
			{
				return default(AJICOMEOOCG);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC1B0", Offset = "0x8AEA9B0", VA = "0x188AEC1B0")]
		public PDPEBMOFJLN(JMPCLAAGBAN BMKNMHKBMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC1C0", Offset = "0x8AEA9C0", VA = "0x188AEC1C0")]
		public PDPEBMOFJLN(GOLMNHOAKHA DEIGOCBAOOG, JMPCLAAGBAN BMKNMHKBMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AEBF70", Offset = "0x8AEA770", VA = "0x188AEBF70")]
		public int CPODCPKEHOH(GOLMNHOAKHA DEIGOCBAOOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AEBFF0", Offset = "0x8AEA7F0", VA = "0x188AEBFF0")]
		public OCECEGIIADK FKNFGBJLAGF(JMPCLAAGBAN BMKNMHKBMNE)
		{
			return default(OCECEGIIADK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC080", Offset = "0x8AEA880", VA = "0x188AEC080")]
		public OCECEGIIADK GAPGBFPBMCK(JMPCLAAGBAN BMKNMHKBMNE)
		{
			return default(OCECEGIIADK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CALAINPEOEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KeyValuePair<string, GOLMNHOAKHA> pair;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CALAINPEOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3320", Offset = "0x8AE1B20", VA = "0x188AE3320")]
		internal object BONNFCMDENB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AIDODKJKJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public string localizationKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PDPEBMOFJLN entry;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AIDODKJKJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2EF0", Offset = "0x8AE16F0", VA = "0x188AE2EF0")]
		internal object IPOGEDLOKBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2EA0", Offset = "0x8AE16A0", VA = "0x188AE2EA0")]
		internal object GDBLKJDIIMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KHJEKKOLCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public long requestorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AIDODKJKJAJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KHJEKKOLCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8AEADC0", Offset = "0x8AE95C0", VA = "0x188AEADC0")]
		internal object DANBNCCJMNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HKNDGAOCLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public string translationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AIDODKJKJAJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public HKNDGAOCLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8AEAA80", Offset = "0x8AE9280", VA = "0x188AEAA80")]
		internal object OIECPLMHJED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IDCHKLHOKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JMPCLAAGBAN requestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string localizationKey;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public IDCHKLHOKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AEAD00", Offset = "0x8AE9500", VA = "0x188AEAD00")]
		internal object JDIBLKEGCBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AEACB0", Offset = "0x8AE94B0", VA = "0x188AEACB0")]
		internal object DMBMGDJPDGP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MDKIKPKEIIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<List<GOLMNHOAKHA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public bool logExceptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private TaskAwaiter<PKGCJLAGKGO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AEB9A0", Offset = "0x8AEA1A0", VA = "0x188AEB9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8AEBDF0", Offset = "0x8AEA5F0", VA = "0x188AEBDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LBLEPANLPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public List<GOLMNHOAKHA> translations;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LBLEPANLPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8AEB910", Offset = "0x8AEA110", VA = "0x188AEB910")]
		internal object MOPFPAMEKCD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EMGJKEAJCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEnumerable<KCDFJLGNJKD> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private LBLEPANLPCC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<List<GOLMNHOAKHA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7260", Offset = "0x8AE5A60", VA = "0x188AE7260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7D00", Offset = "0x8AE6500", VA = "0x188AE7D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BEODGPEHFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BDAEIJHOJDG notification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BEODGPEHFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3270", Offset = "0x8AE1A70", VA = "0x188AE3270")]
		internal object OLIDOECCDBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3200", Offset = "0x8AE1A00", VA = "0x188AE3200")]
		internal object CJBFDJBHINN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3300", Offset = "0x8AE1B00", VA = "0x188AE3300")]
		internal void OLLHFHGMJJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class AJEJEALCKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int updatedStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AJEJEALCKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3150", Offset = "0x8AE1950", VA = "0x188AE3150")]
		internal object NKDDIMBPKAP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GLDCDIIKNLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private AJEJEALCKAN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<List<GOLMNHOAKHA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7E30", Offset = "0x8AE6630", VA = "0x188AE7E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8BE0", Offset = "0x8AE73E0", VA = "0x188AE8BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class AFOHDMJOCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public List<string> existingTranslations;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AFOHDMJOCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2D20", Offset = "0x8AE1520", VA = "0x188AE2D20")]
		internal object DNCEFFNDNHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E20", Offset = "0x8AE1620", VA = "0x188AE2E20")]
		internal object MAGALKFJHLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GOEFJKNDDEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KPMJFDCAFMO serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private AFOHDMJOCKP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Dictionary<string, PDPEBMOFJLN> <neededTranslationLookup>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Guid <nextScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8C40", Offset = "0x8AE7440", VA = "0x188AE8C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8AEAA20", Offset = "0x8AE9220", VA = "0x188AEAA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EHOPPBPBEIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EFDKKBLELLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HDBLPJBDELH deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6890", Offset = "0x8AE5090", VA = "0x188AE6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6D30", Offset = "0x8AE5530", VA = "0x188AE6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BOMOPHAJODK CDLPHPFMIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly AGKENCJENIJ IADJPOODAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CLPMKNHLPCN LNNANJEPCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KIFHCLNMNON FLIPFCGMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FCKOEGGMONG JHNGDGEMICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly string KDAFACNPDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IDisposable HJNLINOFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<string, PDPEBMOFJLN> CIAMNBNOKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, GOLMNHOAKHA> MLMHBLKFKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private int MOBGBNOBAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool KOKNLHLEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private long HCFCMPIBAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private long FBAJKHACGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Guid LJEJLEGJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JPGPFPDJOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly bool MIKGILEBDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HBHGFCGLKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HashSet<HFNBMBHCMDD> NPDOALGHFMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	internal Guid PKKPAGGJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1A57B50", Offset = "0x1A56350", VA = "0x181A57B50")]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AE37E0", Offset = "0x8AE1FE0", VA = "0x188AE37E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4A30", Offset = "0x8AE3230", VA = "0x188AE4A30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string KIJEHIKHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private string ADCCJPMDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4820", Offset = "0x8AE3020", VA = "0x188AE4820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal bool JIHJJADEPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3A20", Offset = "0x8AE2220", VA = "0x188AE3A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool FKJFLLIPDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE48C0", Offset = "0x8AE30C0", VA = "0x188AE48C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal bool DEIJKCDNOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3770", Offset = "0x8AE1F70", VA = "0x188AE3770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CKCDBENMCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE35E0", Offset = "0x8AE1DE0", VA = "0x188AE35E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static LBMIHNICFPI MGBOHCLCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4860", Offset = "0x8AE3060", VA = "0x188AE4860")]
		get
		{
			return default(LBMIHNICFPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int BICOLGJIOND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5C50", Offset = "0x8AE4450", VA = "0x188AE5C50")]
	private static void OKAHNNPFHPN(LCEDLBJLHMD ILBALOOKKCP, LBMIHNICFPI LLHEGEEGDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3680", Offset = "0x8AE1E80", VA = "0x188AE3680")]
	[NOOFMBJKOEL.BCMLOIAHPDE.FPJPEJHIEAN]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6180", Offset = "0x8AE4980", VA = "0x188AE6180")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EFDKKBLELLN([NotNull][FAPODKMFODF(null)] BOMOPHAJODK CDLPHPFMIJP, [NotNull][FAPODKMFODF(null)] AGKENCJENIJ IADJPOODAKJ, [NotNull][FAPODKMFODF(null)] CLPMKNHLPCN LNNANJEPCEJ, [FAPODKMFODF(null)][NotNull] KIFHCLNMNON FLIPFCGMCOP, [FAPODKMFODF(null)][NotNull] FCKOEGGMONG JHNGDGEMICF, [FAPODKMFODF(null)][NotNull] KJKOPAPPDAJ OMNNJBKLOOP, [FAPODKMFODF(null)][NotNull] FNBFDEKMNMG ELFBOFKBFJF, [NotNull][FAPODKMFODF(null)] OPHBELKNMNO NJNLAMHGMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8AE38A0", Offset = "0x8AE20A0", VA = "0x188AE38A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3570", Offset = "0x8AE1D70", VA = "0x188AE3570")]
	private static string BEIJCOCOBLL(Guid EHDFAANBFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3C80", Offset = "0x8AE2480", VA = "0x188AE3C80")]
	private Dictionary<string, GOLMNHOAKHA> FBMCGPFBHII(IEnumerable<GOLMNHOAKHA> IACMJBLEFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5D00", Offset = "0x8AE4500", VA = "0x188AE5D00")]
	private void PAOLFCJCGEK(Dictionary<string, GOLMNHOAKHA> LFAEBHPBODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3A70", Offset = "0x8AE2270", VA = "0x188AE3A70")]
	internal static string EPHBNDGLCBF(string JAPGEBMHOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4760", Offset = "0x8AE2F60", VA = "0x188AE4760", Slot = "4")]
	public bool ICMKIMAHHOB(HFNBMBHCMDD BPBKMAFMEMC, bool EMMOENAPJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3790", Offset = "0x8AE1F90", VA = "0x188AE3790", Slot = "7")]
	public string CDIBEHLEAAL(string KAJENDFCCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8AE53A0", Offset = "0x8AE3BA0", VA = "0x188AE53A0", Slot = "8")]
	public AHMPBCEMCEO LGACKBHHEMA(string JFJOJHDBHHD, string BJNLPCOGDLM, [CanBeNull] JMPCLAAGBAN BMKNMHKBMNE)
	{
		return default(AHMPBCEMCEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE41F0", Offset = "0x8AE29F0", VA = "0x188AE41F0", Slot = "9")]
	public void GMPEPJJNINE(string JFJOJHDBHHD, [NotNull] JMPCLAAGBAN BMKNMHKBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3FA0", Offset = "0x8AE27A0", VA = "0x188AE3FA0", Slot = "10")]
	public BOLHOHLBNAC FJLDFFDNNHN(string JFJOJHDBHHD)
	{
		return default(BOLHOHLBNAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE45A0", Offset = "0x8AE2DA0", VA = "0x188AE45A0")]
	[AsyncStateMachine(typeof(MDKIKPKEIIN))]
	private Task<List<GOLMNHOAKHA>> HMHKPDLJBJN(bool PAJLLOHLCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5FF0", Offset = "0x8AE47F0", VA = "0x188AE5FF0")]
	[AsyncStateMachine(typeof(EMGJKEAJCNL))]
	private Task POKENOMDPAJ(IEnumerable<KCDFJLGNJKD> JBLIANBCKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4B00", Offset = "0x8AE3300", VA = "0x188AE4B00")]
	private void LAACDCJNHMG(BDAEIJHOJDG JGIGPLKCEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8AE52D0", Offset = "0x8AE3AD0", VA = "0x188AE52D0")]
	[AsyncStateMachine(typeof(GLDCDIIKNLC))]
	private Task LDOLJDLIHKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4910", Offset = "0x8AE3110", VA = "0x188AE4910", Slot = "11")]
	[AsyncStateMachine(typeof(GOEFJKNDDEF))]
	public Task KAFGLJCBOOA(KPMJFDCAFMO IENPLAMADNI, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5BC0", Offset = "0x8AE43C0", VA = "0x188AE5BC0", Slot = "5")]
	public void OHOFOOIFBAN(PCENONMPPIA JPCNIAHCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3E00", Offset = "0x8AE2600", VA = "0x188AE3E00")]
	private void FCDIFLOCAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4070", Offset = "0x8AE2870", VA = "0x188AE4070")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EHOPPBPBEIL))]
	private Task GEBDBOEECEN(HDBLPJBDELH ODEKLFJBJKH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5B60", Offset = "0x8AE4360", VA = "0x188AE5B60")]
	[CompilerGenerated]
	private object NIBHHCIICCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8AE46A0", Offset = "0x8AE2EA0", VA = "0x188AE46A0")]
	[CompilerGenerated]
	private string HNKAEHCFGPG(GOLMNHOAKHA DEIGOCBAOOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8AE60F0", Offset = "0x8AE48F0", VA = "0x188AE60F0")]
	[CompilerGenerated]
	private object PPMOLKHDHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4160", Offset = "0x8AE2960", VA = "0x188AE4160")]
	[CompilerGenerated]
	private object GKKOFIGLFBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class NPMHCEFHPEP : JMPCLAAGBAN, IEquatable<JMPCLAAGBAN>
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string EKBDHLKCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8AEBED0", Offset = "0x8AEA6D0", VA = "0x188AEBED0")]
	public NPMHCEFHPEP(long EBHOIBHGECB, string BJNLPCOGDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8AEBE60", Offset = "0x8AEA660", VA = "0x188AEBE60", Slot = "7")]
	public bool Equals(JMPCLAAGBAN LHMEHOJLNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x287F5D0", Offset = "0x287DDD0", VA = "0x18287F5D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class KMBKDLPICEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KLJDHLNOMBG LPBIMLHBFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private JMPCLAAGBAN BMKNMHKBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool DEACHOJCHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string BJNLPCOGDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private string KAJENDFCCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool KIHEDKNBDOO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal long GHNKKMOPFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AEAF70", Offset = "0x8AE9770", VA = "0x188AEAF70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string EKBDHLKCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8AEAE80", Offset = "0x8AE9680", VA = "0x188AEAE80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AEB720", Offset = "0x8AE9F20", VA = "0x188AEB720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB7F0", Offset = "0x8AE9FF0", VA = "0x188AEB7F0")]
	public KMBKDLPICEG([Optional] KLJDHLNOMBG EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB130", Offset = "0x8AE9930", VA = "0x188AEB130")]
	public BOLHOHLBNAC HGGNDPNBBHC(HFNBMBHCMDD GHBGGNJJHCP)
	{
		return default(BOLHOHLBNAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB270", Offset = "0x8AE9A70", VA = "0x188AEB270")]
	internal void JNHFKCNMNLI(HFNBMBHCMDD OIFLFJEDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB7E0", Offset = "0x8AE9FE0", VA = "0x188AEB7E0")]
	public void PBPOAHLKNMA(HFNBMBHCMDD OIFLFJEDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8AEB010", Offset = "0x8AE9810", VA = "0x188AEB010")]
	private void GMPEPJJNINE(HFNBMBHCMDD OIFLFJEDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8AEAFC0", Offset = "0x8AE97C0", VA = "0x188AEAFC0")]
	[CompilerGenerated]
	private object DBLMGBKABME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8AEAED0", Offset = "0x8AE96D0", VA = "0x188AEAED0")]
	[CompilerGenerated]
	private object BLKLDMBFNDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FCCKBNODNHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HFNBMBHCMDD LEEIBEDNLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7DB0", Offset = "0x8AE65B0", VA = "0x188AE7DB0")]
	public FCCKBNODNHB(HFNBMBHCMDD CODEFCLPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7D60", Offset = "0x8AE6560", VA = "0x188AE7D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EMAGMCBCOBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HFNBMBHCMDD MHOOOECIBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KMBKDLPICEG BOHCPNNJLED;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BOLHOHLBNAC NAJJKHAFDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6DD0", Offset = "0x8AE55D0", VA = "0x188AE6DD0")]
		get
		{
			return default(BOLHOHLBNAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IJAFLNBKIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string EKBDHLKCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6F10", Offset = "0x8AE5710", VA = "0x188AE6F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7000", Offset = "0x8AE5800", VA = "0x188AE7000")]
	public EMAGMCBCOBE(HFNBMBHCMDD OIFLFJEDOIB, [Optional] KLJDHLNOMBG EGOJLGMOLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6D90", Offset = "0x8AE5590", VA = "0x188AE6D90")]
	public void ECAEGHAMACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6FE0", Offset = "0x8AE57E0", VA = "0x188AE6FE0")]
	public void PBPOAHLKNMA()
	{
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
