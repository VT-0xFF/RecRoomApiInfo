using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65B0A60", Offset = "0x65AF860", VA = "0x1865B0A60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : KBDNGCLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x65AF7B0", Offset = "0x65AE5B0", VA = "0x1865AF7B0", Slot = "4")]
		public override void NLHDMBJLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FLHKNEIMLOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65A2310", Offset = "0x65A1110", VA = "0x1865A2310")]
	public FLHKNEIMLOD(string EMKENBOOEOH, Exception ICGGIEKNGIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class DKFGALAPDGC : HFKHLCALHNB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LNNMECECKNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MFFPGPFJMLA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<DFEAEPDPJNH<MFFPGPFJMLA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65AEAA0", Offset = "0x65AD8A0", VA = "0x1865AEAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65AECE0", Offset = "0x65ADAE0", VA = "0x1865AECE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KLICFNGEGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<LPEHNEOEOJD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<LPEHNEOEOJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65AD1A0", Offset = "0x65ABFA0", VA = "0x1865AD1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65AD3B0", Offset = "0x65AC1B0", VA = "0x1865AD3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[UnityEngine.Scripting.Preserve]
	public DKFGALAPDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x659DF20", Offset = "0x659CD20", VA = "0x18659DF20", Slot = "4")]
	[AsyncStateMachine(typeof(LNNMECECKNC))]
	public Task<IReadOnlyList<MFFPGPFJMLA>> DMGGJECHGHA(long CGIDLDOBHII, long FDDHOJFABCM, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x659DE10", Offset = "0x659CC10", VA = "0x18659DE10", Slot = "5")]
	[AsyncStateMachine(typeof(KLICFNGEGFF))]
	public Task<IReadOnlyList<LPEHNEOEOJD>> ANPKGMKKFPG(IReadOnlyList<int> NCLBFPLNLGE, [Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NAIFMEFLDFG : IEquatable<NAIFMEFLDFG>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HENOCOKOCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	LPEHNEOEOJD MIGCKFKNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime CDPIIJOONPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	POJENFLKNLE? NBMKBCFDDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KJJJOOFMJJH? NMOGDIMIPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	MMAHGKHJKNA KENNHGHBADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OMGIPDGCLFM> OPLDFGIOGGK();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum MMAHGKHJKNA
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HFKHLCALHNB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<MFFPGPFJMLA>> DMGGJECHGHA(long CGIDLDOBHII, long FDDHOJFABCM, [Optional] CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<LPEHNEOEOJD>> ANPKGMKKFPG(IReadOnlyList<int> NCLBFPLNLGE, [Optional] CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JPKGAHAOOGJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HJINCODJODI : NAIFMEFLDFG, IEquatable<NAIFMEFLDFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct MOGAJOIJOEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public HJINCODJODI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private APNCHKBJLFJ <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<KEHHDGIBOGN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OMGIPDGCLFM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x65B0140", Offset = "0x65AEF40", VA = "0x1865B0140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65B05E0", Offset = "0x65AF3E0", VA = "0x1865B05E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MFFPGPFJMLA CNGLIMGDDGD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int HENOCOKOCPM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LPEHNEOEOJD MIGCKFKNLJK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JKFNLCNFFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x52C3060", Offset = "0x52C1E60", VA = "0x1852C3060", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public POJENFLKNLE? NBMKBCFDDAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x19166A0", Offset = "0x19154A0", VA = "0x1819166A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KJJJOOFMJJH? NMOGDIMIPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x52C3140", Offset = "0x52C1F40", VA = "0x1852C3140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MMAHGKHJKNA KENNHGHBADJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "10")]
			get
			{
				return default(MMAHGKHJKNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x65A4F20", Offset = "0x65A3D20", VA = "0x1865A4F20", Slot = "9")]
		[AsyncStateMachine(typeof(MOGAJOIJOEF))]
		public Task<OMGIPDGCLFM> OPLDFGIOGGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65A5060", Offset = "0x65A3E60", VA = "0x1865A5060")]
		public HJINCODJODI(int LGAELMBLEGN, LPEHNEOEOJD IIANHNLKLPL, MFFPGPFJMLA CNGLIMGDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x65A4E10", Offset = "0x65A3C10", VA = "0x1865A4E10", Slot = "11")]
		public bool Equals(NAIFMEFLDFG FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x65A4D70", Offset = "0x65A3B70", VA = "0x1865A4D70", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x65A5020", Offset = "0x65A3E20", VA = "0x1865A5020")]
		private bool PCBKMNDNFAA(HJINCODJODI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x65A4EA0", Offset = "0x65A3CA0", VA = "0x1865A4EA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class EGIDCAEHDJB : NAIFMEFLDFG, IEquatable<NAIFMEFLDFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct MFKFICJFCFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public EGIDCAEHDJB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<OMGIPDGCLFM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x65AFD40", Offset = "0x65AEB40", VA = "0x1865AFD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x65AFF70", Offset = "0x65AED70", VA = "0x1865AFF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly EMHEAHMEPJK BBNFNONAEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly POJENFLKNLE HCBGDPNDJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly KJJJOOFMJJH LGIOBKAOBKB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HENOCOKOCPM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x659EEF0", Offset = "0x659DCF0", VA = "0x18659EEF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LPEHNEOEOJD MIGCKFKNLJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x659ED90", Offset = "0x659DB90", VA = "0x18659ED90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JKFNLCNFFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x659EEA0", Offset = "0x659DCA0", VA = "0x18659EEA0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public POJENFLKNLE? NBMKBCFDDAA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x659EF80", Offset = "0x659DD80", VA = "0x18659EF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public KJJJOOFMJJH? NMOGDIMIPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x659EF30", Offset = "0x659DD30", VA = "0x18659EF30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MMAHGKHJKNA KENNHGHBADJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x898740", Offset = "0x897540", VA = "0x180898740", Slot = "10")]
			get
			{
				return default(MMAHGKHJKNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD7CBD0", Offset = "0xD7B9D0", VA = "0x180D7CBD0")]
		public EGIDCAEHDJB(EMHEAHMEPJK ABCDHNPFOAB, POJENFLKNLE JEJNBMFNGIE, KJJJOOFMJJH LDPDGGAOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x659EFD0", Offset = "0x659DDD0", VA = "0x18659EFD0", Slot = "9")]
		[AsyncStateMachine(typeof(MFKFICJFCFN))]
		public Task<OMGIPDGCLFM> OPLDFGIOGGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x659ECF0", Offset = "0x659DAF0", VA = "0x18659ECF0", Slot = "11")]
		public bool Equals(NAIFMEFLDFG FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x659EC40", Offset = "0x659DA40", VA = "0x18659EC40", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x659F0C0", Offset = "0x659DEC0", VA = "0x18659F0C0")]
		private bool PCBKMNDNFAA(EGIDCAEHDJB FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x659EE20", Offset = "0x659DC20", VA = "0x18659EE20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LLEGCOODCDI : NAIFMEFLDFG, IEquatable<NAIFMEFLDFG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct PCKHMNPADKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<OMGIPDGCLFM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x65B1050", Offset = "0x65AFE50", VA = "0x1865B1050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x65B1290", Offset = "0x65B0090", VA = "0x1865B1290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LPEHNEOEOJD IIGOLFBJGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly POJENFLKNLE HCBGDPNDJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KJJJOOFMJJH LGIOBKAOBKB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int HENOCOKOCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x65AE6C0", Offset = "0x65AD4C0", VA = "0x1865AE6C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public LPEHNEOEOJD MIGCKFKNLJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JKFNLCNFFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public POJENFLKNLE? NBMKBCFDDAA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x65AE730", Offset = "0x65AD530", VA = "0x1865AE730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KJJJOOFMJJH? NMOGDIMIPOM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65AE6E0", Offset = "0x65AD4E0", VA = "0x1865AE6E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MMAHGKHJKNA KENNHGHBADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "10")]
			get
			{
				return default(MMAHGKHJKNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD7CBD0", Offset = "0xD7B9D0", VA = "0x180D7CBD0")]
		public LLEGCOODCDI(LPEHNEOEOJD IIANHNLKLPL, POJENFLKNLE JEJNBMFNGIE, KJJJOOFMJJH LDPDGGAOFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x65AE780", Offset = "0x65AD580", VA = "0x1865AE780", Slot = "9")]
		[AsyncStateMachine(typeof(PCKHMNPADKC))]
		public Task<OMGIPDGCLFM> OPLDFGIOGGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65AE520", Offset = "0x65AD320", VA = "0x1865AE520", Slot = "11")]
		public bool Equals(NAIFMEFLDFG FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65AE400", Offset = "0x65AD200", VA = "0x1865AE400", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65AE630", Offset = "0x65AD430", VA = "0x1865AE630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65AE850", Offset = "0x65AD650", VA = "0x1865AE850")]
		private bool PCBKMNDNFAA(LLEGCOODCDI FPEEGIOMOFF)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct GAACAFIHGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<NAIFMEFLDFG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JPKGAHAOOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<MFFPGPFJMLA> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<MFFPGPFJMLA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, LPEHNEOEOJD account, MFFPGPFJMLA roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x65A2380", Offset = "0x65A1180", VA = "0x1865A2380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65A3160", Offset = "0x65A1F60", VA = "0x1865A3160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LNOEMNKIOAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, LPEHNEOEOJD account, MFFPGPFJMLA roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<MFFPGPFJMLA> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public JPKGAHAOOGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<LPEHNEOEOJD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x65AED50", Offset = "0x65ADB50", VA = "0x1865AED50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x65AF740", Offset = "0x65AE540", VA = "0x1865AF740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KMHDGJLNJCM EBFCHOONAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HFKHLCALHNB OLMLKGDNBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BICCKJNHNDG FMHPEIJNKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HJNBIJIMEDB<(long, long), IReadOnlyList<MFFPGPFJMLA>> MGMCAHIMCHD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE10", Offset = "0x65ABC10", VA = "0x1865ACE10")]
	[UnityEngine.Scripting.Preserve]
	public JPKGAHAOOGJ([LICAMFFCLCL(null)] HFKHLCALHNB ACAGBKLPDOG, [LICAMFFCLCL(null)] BICCKJNHNDG MLHMIFDLKIP, [LICAMFFCLCL(null)] KMHDGJLNJCM NLAMJBCHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65ACA10", Offset = "0x65AB810", VA = "0x1865ACA10")]
	[AsyncStateMachine(typeof(GAACAFIHGNB))]
	public Task<IList<NAIFMEFLDFG>> AIBCNIDDCDH(long CGIDLDOBHII, long NECGEBINIAB, bool DIKGGOGHNJD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x65ACC70", Offset = "0x65ABA70", VA = "0x1865ACC70")]
	private bool DOCMNOPAOCH(DateTime? GADFGDOGPKL, long CGIDLDOBHII, long NECGEBINIAB, [Out] EMHEAHMEPJK BFMMNLLBIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65ACB60", Offset = "0x65AB960", VA = "0x1865ACB60")]
	[AsyncStateMachine(typeof(LNOEMNKIOAK))]
	private Task<IReadOnlyList<(int, LPEHNEOEOJD, MFFPGPFJMLA)>> BENEKEDDJLF(IReadOnlyList<MFFPGPFJMLA> OJJDEPBDGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BICCKJNHNDG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EMHEAHMEPJK> EGBPKPLDDEB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACKGHOOKJKP(long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL, CJNNGPMEKJP KGAGAFGNMKC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INNMMGGMAOG(long CGIDLDOBHII, long NECGEBINIAB, [Out] EMHEAHMEPJK BFMMNLLBIHP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGDCNKCFGNO(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, [Out] EMHEAHMEPJK BFMMNLLBIHP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HABFECHEHNP(long CGIDLDOBHII, long NECGEBINIAB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface AHIGBCFDHEO : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KGDICINMOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MADAHHEIAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBHGPNCLJAF(Task IMKKNGNMOEA, string MGKAHINPLEP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface CCFMIKOOHDH : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OMGIPDGCLFM> ICIFKGPEMCM(EMHEAHMEPJK BFMMNLLBIHP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GJGBDJEDCEN(CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OHLHKODEAHG : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	EIABKDOGICB AKHOCIBMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGMDIIOKCBK();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBLFOEBCGKH();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface MAMNOPKFBDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface LFBGPCMLEHM
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan BLPPGKEILDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan GEMEPGMJLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan DKPDLMEMEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan GBONGKFGKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CLBJGKFGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GDPPPDCIKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NHAAFHEGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int HCIOPOOANNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NIFDMLBPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool OELGINOEDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JBODGJAOCIG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HGDMGBMIKKL
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PLLNCCBDCKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long PGPIHDGPHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long FDDHOJFABCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly JBODGJAOCIG HFFNCGFKMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception OPFLEOOOOEL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x65B22B0", Offset = "0x65B10B0", VA = "0x1865B22B0")]
	public PLLNCCBDCKN(long PGPIHDGPHMP, long FDDHOJFABCM, JBODGJAOCIG HFFNCGFKMBJ, [CanBeNull] Exception OPFLEOOOOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x65B2260", Offset = "0x65B1060", VA = "0x1865B2260")]
	public static PLLNCCBDCKN OJBFBHLICAF(EJEIFLCIKHD PDEOOPLKLKJ, JBODGJAOCIG HFFNCGFKMBJ, [Optional] Exception OPFLEOOOOEL)
	{
		return default(PLLNCCBDCKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public delegate void MHHBJIMCKOP(PLLNCCBDCKN CAKCKKEGKCL);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface ABNDDCPEALM : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MLOMAAFBDAN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MHHBJIMCKOP IADKMHCOOMM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MHHBJIMCKOP DJOLNBENJKA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event MHHBJIMCKOP DOPJIEMBIJB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<HGDMGBMIKKL, bool> ECNHHMDEJOC;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CMHLHDAMDCG();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PFMBGCPOHDD(PLLNCCBDCKN CAKCKKEGKCL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PHLALOAEJJL(PLLNCCBDCKN CAKCKKEGKCL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BGNPHFPLJGN(PLLNCCBDCKN CAKCKKEGKCL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KNJNGNOMDIB(HGDMGBMIKKL CPIHABMOFML, bool BECNKAICFJI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface BPFLABMKPNN : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MHLNDDKLKOL();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBJHKOKLNIG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface NFICGBDNKPA : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	TaskStatus NPFELIOIGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MEIFLICLJFD(EJEIFLCIKHD MPMDCLFHGCI, MAIOAFBCNPD FLKBBGDFLEE, CancellationToken JPLHPFGGALJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class MONOMBLAOBA
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65B0650", Offset = "0x65AF450", VA = "0x1865B0650")]
	public static bool JOIPFOCOCKD(this NFICGBDNKPA JHHCPAFMNAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate Task KPMLADPGEIC(LMCJHJIAIGC JJGMEBEMOEB, CancellationToken NBGOKNOECBH);
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface HBFKIPEDJON : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNFFNMIBMMI(KPMLADPGEIC LMIAMJGGAME);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface IHLIMGHFCMP : APNCHKBJLFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CancellationToken KNPFKAIMKEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	IBPIJCMLLGH FKABBJPEBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	IPFJJJBMNCG DPMMPPKNAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	DKHMEJAEAHB GPFBIBMDAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AJHHBOLKMEO OLLNEGCHHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	HAJEBJAEDHD DLMAKAPIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	LFGLPHMHHAH LLFKOOJPAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PKMALFKDGHB IFFGACBAHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	AHIGBCFDHEO BOPMLBIDLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CCFMIKOOHDH NADDFMNFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	ABNDDCPEALM JIJKIKPCPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BPFLABMKPNN LJIHNJMBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NFICGBDNKPA DIJFKJDNNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	HBFKIPEDJON PIPPHJONFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HNKMDNGIGFD MCMEBMHNMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FDLEHNCOFFB MAMNEDLKEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NABHGMPMEON FOMLLPDFADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	LDNBHONPDJP FEEJGLKHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OKIDLBPFEKG HFEBDKGFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	FMOKIODDCMD FAEIEAGJFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JLHBLMECKDP BAGKGCDOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BBEJGMIDLCA IHJMJMCHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	IANHOELLMDM JGJHKKIOMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NAFJINMIHEI CLJHDODKLGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	OHLHKODEAHG CGCJCLDEIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	LFBGPCMLEHM MAHMFFPLIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HDMDMODGHLD FKAOOJLEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BICCKJNHNDG IHCHJNACLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	PGDMLCJHKPC FEPNNCACCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JIFOLPFHJJB EOEOOMOJHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void JKLKGPMNALI(MAIOAFBCNPD LLIGIJMDLPD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface HNKMDNGIGFD : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBLDDFIGNLA ANMBPKAMKOK(Guid MBCGHBNLJEN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JJGPDDBMEBN(Guid MBCGHBNLJEN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHMBHJJPAEC(Guid MBCGHBNLJEN, Task LEACLIFJLOA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAIMEDADOCA(Guid MBCGHBNLJEN, OMGIPDGCLFM NDKNGALAAJL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(OMGIPDGCLFM, Task)> NMMNLJGJDEJ(Guid MBCGHBNLJEN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface AMOIJJBNBDJ : MAMNOPKFBDA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface FDLEHNCOFFB : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGLIFPKGIID(GPALKAPGCML EMKENBOOEOH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFHOGOIEFAM(GPALKAPGCML EMKENBOOEOH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LFKCPECOHNF> KINHOABJEKL(CancellationToken JKAGPAFMMKM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NABHGMPMEON : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBLDDFIGNLA OBKPACDJJEI(GPALKAPGCML GGNHLGBJFIL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMBBOCLHDOA(Guid MBCGHBNLJEN, Task LEACLIFJLOA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface LDNBHONPDJP : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OMGIPDGCLFM> FEEJGLKHHKD(GPALKAPGCML MHOEGLJDFCB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface OKIDLBPFEKG : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MIGCEKPLBCD> AGMPEHGMODG(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, EJEIFLCIKHD MPMDCLFHGCI, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface JLHBLMECKDP : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGIPDGCLFM GPMNPLOMCNH(MNFCKJNKANA EDANDKPIAHA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LCILIPDBLBH(string CIPMAAMIEBA);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface FMOKIODDCMD : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GPALKAPGCML> PMDCMNCAGAE(GPALKAPGCML MIMLCIHLPAB, GEKJJJHLPNL GAOONIBKNFH, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<GPALKAPGCML> BCJMOGFAAIO(CancellationToken HHBHDBLGMFA, GEKJJJHLPNL GAOONIBKNFH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KLBPLCPJKOF LGCLLDLOMHE(IFEGHCNBDPC HHLFOBCDJNP, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KLBPLCPJKOF OOHEEJOEEGM(IFEGHCNBDPC HHLFOBCDJNP, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface BBEJGMIDLCA : MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGIPDGCLFM LGAJPBLMDLB(MNFCKJNKANA EDANDKPIAHA, LFKCPECOHNF IFKFMEODFKA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMGIPDGCLFM IJDOIHKIMOM(MNFCKJNKANA MCHEPFGOPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IANHOELLMDM
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHDELKNJNPA(MNBCHGOIPKA HDPNMMKNHII);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HACCEMONNBB(MNBCHGOIPKA HDPNMMKNHII);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMOFBGFIPPF(MNBCHGOIPKA HDPNMMKNHII);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDGLMLFCEKE(MNBCHGOIPKA HDPNMMKNHII);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class MNBCHGOIPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EJEIFLCIKHD DJFFFKKHEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> DNJGEJODLHM;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public GAKKIOAFLLE<string> NKFJBNFGCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public MNBCHGOIPKA(EJEIFLCIKHD BKHNKMBACHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x65AFFE0", Offset = "0x65AEDE0", VA = "0x1865AFFE0")]
	public MNBCHGOIPKA GFCJFAPLPAG(string JCMGBFKGKLO, string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x65B00B0", Offset = "0x65AEEB0", VA = "0x1865B00B0")]
	public bool KKCEOBPICOB([Out] IEnumerable<KeyValuePair<string, string>> EHGCFNGELKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5949700", Offset = "0x5948500", VA = "0x185949700")]
	public MNBCHGOIPKA IIFDNOPBPPD(GAKKIOAFLLE<string> JNIKEBIHBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HDMDMODGHLD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BIGKHFBLHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string BDJBKAACICP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DIFIMPNPBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCOGGOJCAMA();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GFBFKPIFILG NGMHOEOKJNC(long HDGHLCECFGL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPLBMCFEOGE<GLFMJDNKFLA, PGADOMLEMBK> EILENFEADPN(long HDGHLCECFGL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JPLBMCFEOGE<GLFMJDNKFLA, LBFMLKMCDDP> CMFEFOHOGGP(long HDGHLCECFGL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JPLBMCFEOGE<long, OLOGHCFCDMC> NAPMJCGHHGE();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PIIPOKEILJF(long HDGHLCECFGL, [Out] bool NABMHIPEBMN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<bool> PCHJJHCADNP(byte[] KOLMPBPLBDO, byte[] PFPFOEJKIFC, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface APNCHKBJLFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool JOIPFOCOCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool KLHEEGOILEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	MAIOAFBCNPD FPMFKJENHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MLOMAAFBDAN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event MHHBJIMCKOP IADKMHCOOMM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event MHHBJIMCKOP DJOLNBENJKA;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MHHBJIMCKOP DOPJIEMBIJB;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HGDMGBMIKKL, bool> ECNHHMDEJOC;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HBJHKOKLNIG();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FJGLMBPEPDP MJJKFPMNFGG();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PIOMBPDNICP DAHGPHGEJPC();

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OMGIPDGCLFM> ICIFKGPEMCM(EMHEAHMEPJK ABCDHNPFOAB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task GJGBDJEDCEN(CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AJHHBOLKMEO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool CGJCFEMLBPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	string GDGNIAIEOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOAMOMBIDPK(Scene IBBMEJJFKCD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HMMLEDKMHDN(JCBPMOHPGAJ HCNBDLGDCKI, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task INLKDENJGIM();
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FPLJMDLJDMH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool IFFJCOMFAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool EEJOGGJCAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool GKGBHBFLPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MOICKNJCMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool AIDMAOKFLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OEOLCHDPAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool NCICOJGGFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float BJEKKAAEKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> GEOIKDMNIKD;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IBPIJCMLLGH HGCLHNHLMED(IBPIJCMLLGH AAMJLCHCCEI);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBJBFKHJNPL(IBPIJCMLLGH PPDHICBEIFC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAGGLOGMBCE();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task MHNEKHAIKDE(GAKKIOAFLLE<string>.AGJOEKMHOHC MOFOMAIEHJK, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FODBBBJHLBH(float OPMMDEBAKIH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDCLNJGHHNO(string IDNKFILIEMP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<NLMPFCMDIAG> MANPHLLJMCB();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable LEABHPMIHIF(object HOLFPPNPJAH, NLMPFCMDIAG MBIEFODNHHN);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PGADOMLEMBK GIJDOKILCBF(IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DJPLLDGMLIH(int IAOHADBACOG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task DONNHBJCLEB();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MBPAIGGMGCH();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool KJPAOOBAIAI();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task MPNJAEDEACB(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task AJFMPAAOGKB(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<MEKFINGEDEJ> NHIGDBGICPA(DateTime JHOHAHHLECE, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<bool> DPOPONGPEGF(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PAGFDFOKEPH(string CELMPFBPLGH = "", float JABPPPAGBNP = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MNNMMOFPILD IKPPEEIEODH(FFPAFJNHHFB KCFOCIPAKBM, FCLFNEOHAGE GHPEJLLJDJL, LBFMLKMCDDP DDONBMNOMIG, IEnumerable<PersistenceView> KIOEBKJIKLA, CHFBMNGAMPB ABLFODBKLDD);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJJCHCDMNID(LBFMLKMCDDP DDONBMNOMIG);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LLCNBDEGHKJ(OBGGKDBBBAO BKFACKEMDIF, [In] MNNMMOFPILD MGGKKMBDFDL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task LIGEIPFFHEE(LBFMLKMCDDP OOCAEIBFMFH, bool HCGHNOKHDBG, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task ICAAPAKPDEB(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NDFPCHOHGOL(long CGIDLDOBHII, long FDDHOJFABCM, KEHHDGIBOGN PLCFMAFMELF, MFFPGPFJMLA NPAJOACGIGD, KCEBKGLNFIO OJIODHBMPBL, FBONFFODNOH? LEICDGOKMKC, JNINHFANBCC? KFLMOAHLHGB);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OGFFFEGJKLJ(long CGIDLDOBHII, long FDDHOJFABCM, JNINHFANBCC? KFLMOAHLHGB);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CDOBHPJGPCH(PersistenceView HHAFIDHGPLP);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool GPBKFBBHGEJ(PersistenceView JNGHLJPLHEB);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool HPLFFCIEHEP(OBGGKDBBBAO BKFACKEMDIF, CHJKKBHBLDL ADMLGLPHLFJ, [Out] MKHPKNOMIPE FECEHHPEMHK);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task KIACGJDJAOH(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void MNCLNLMDMNN();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IDisposable JGIHEPIKPME();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void IJFNJBJAIIK(LBFMLKMCDDP OOCAEIBFMFH, CHJKKBHBLDL ADMLGLPHLFJ);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<bool> GHJCNDMPOFO(IPFJJJBMNCG KMLMAPIMMEL, CancellationToken HHBHDBLGMFA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KKFJOADPJDF(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<JOHBNOCABDJ> GDEGHINABDM(PMJFDEIPILD MIMLCIHLPAB);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<KEHHDGIBOGN> HJBANHMJHLH(long CGIDLDOBHII, bool PDCPPKCOLNN, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<MFFPGPFJMLA> DLGJIPPLNGE(long CGIDLDOBHII, long FDDHOJFABCM, long FFOOPFLIOJA, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<NMJKHCKLOOK> LBNNBJGFBNK(string OFEONHHMBHP, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<NMJKHCKLOOK> DDAEJAEMCEL(string OFEONHHMBHP, long CGIDLDOBHII, long FDDHOJFABCM, string DJCBKALPECG, DLJOHAEOFOF.FNFILMIPHID JJGMEBEMOEB, DLJOHAEOFOF.FNFILMIPHID PFPFOEJKIFC, int LOPPOEBHBNL);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool HAAEKBEJMID();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool NHHMFFDNKOM();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool EONIMJAPJDL(IEnumerable<MKHPKNOMIPE> LIPNAFGJEOE);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void ENAJNLGOJDH(List<GameObject> GPOPHGNKOJO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float GDMOPHMFAEI();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "50")]
	Task<Scene> EKBCGGOBJLE(string AOIKHKIKFNC, LoadSceneMode GDKHBJEMFPM, bool BGIBKNJLMHA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void IJKDHDKKLKC();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void POIGBAPIGKJ(bool IFBLBHFFNFB);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void ILMCMDGDFKE(EJEIFLCIKHD MOGGLGBCOPI);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task KHNLBNDLMDA(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task CBIMAFILHIP(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "61")]
	Task ACDODCKPOKC(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "62")]
	IDisposable BBJKNEGKFHA();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "63")]
	IOBNCJEDIHK LLEALLBLCLC();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "64")]
	Task JIJEIBMIFHP(CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IOBNCJEDIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PLEHEDBHBBH(CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KEMICLPNLAI(CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MNNMMOFPILD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> FGLBICJBNIG;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum MEKFINGEDEJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FFPAFJNHHFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string EFOMOIAHCGK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface HJMCDAJJEDH
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	EJEIFLCIKHD MENKDJNCBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	KEHHDGIBOGN EBILINJDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	ALMLFHPANKN IILOGPOIMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool HGEJAKPMIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool GDGBIKKKILA
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	int FFLBEIJODAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KJBHCLOCPOM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> COGOABGGAAO;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OAIGGAPNBMB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.NPAEOOOBGEM> HGEEKHEHELB(long HDGHLCECFGL, [Optional] CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<HNAIHGNMDMN> IPEJIDDDPLP();

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task HGHOIGKFHKD();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(EJEIFLCIKHD, MAIOAFBCNPD) LOAPEEAEBIK();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IAMLLOCNKFO BLAHLJMHLJO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMONFBEMPJB(long HDGHLCECFGL);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NAFJINMIHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOOCAINOIKH([Out] IEnumerable<int> DDFFOHFANCL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPHBLDPGOFI(EOHKIDCJHLO NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBMIIPEPCGC(EOHKIDCJHLO NBGOKNOECBH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JFCNOMEPMIK
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KOOMGOOMJMO(OMGIPDGCLFM DCGGFGCLELD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CFHPNKIOFMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAKAHEHCMCF(DEHIKNPPJDO.BHHBDNAABIG DJMPHGMBNLF);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKGHEHNALIP(DEHIKNPPJDO.BHHBDNAABIG DJMPHGMBNLF);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface HAJEBJAEDHD : CFHPNKIOFMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGIPDGCLFM HDDFOJGKPGO(MNFCKJNKANA MCHEPFGOPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LFGLPHMHHAH : CFHPNKIOFMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGIPDGCLFM GPMNPLOMCNH(MNFCKJNKANA NGFKMPBFIHD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GFBFKPIFILG
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBEPHKHKLJE<JCBPMOHPGAJ, KOAMPGHKKDA>> MEIFKLBPODO(string DJCBKALPECG, long HDGHLCECFGL, LECDIHBIMKG.GOEEDBCANPN FMHMDPBHEPJ, CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface JPLBMCFEOGE<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FBEPHKHKLJE<byte[], KOAMPGHKKDA>> IAFJDIBFCEK(TGetDataArg MLBFGGJBJJC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBEPHKHKLJE<NOMKHBFBACK<TData>, KOAMPGHKKDA> KIJBDDHLNFB(byte[] OMHIFBJFAGA);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class FDFCKBAKDOA : IHLIMGHFCMP, APNCHKBJLFJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HNCKGMGLGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FDFCKBAKDOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public EMHEAHMEPJK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x65A5160", Offset = "0x65A3F60", VA = "0x1865A5160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x65A53E0", Offset = "0x65A41E0", VA = "0x1865A53E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DOJLKFCJMAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public FDFCKBAKDOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x659E040", Offset = "0x659CE40", VA = "0x18659E040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x659E270", Offset = "0x659D070", VA = "0x18659E270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CPLIBDBIBMP : IEnumerable<MAMNOPKFBDA>, IEnumerable, IEnumerator<MAMNOPKFBDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private MAMNOPKFBDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public FDFCKBAKDOA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		private MAMNOPKFBDA System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public CPLIBDBIBMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x659CD20", Offset = "0x659BB20", VA = "0x18659CD20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x659D180", Offset = "0x659BF80", VA = "0x18659D180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x659D0D0", Offset = "0x659BED0", VA = "0x18659D0D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MAMNOPKFBDA> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x659D0D0", Offset = "0x659BED0", VA = "0x18659D0D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource HCMBPLKJKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IBPIJCMLLGH PPDHICBEIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private AJPEINFEAOJ FOJGOEEEBBK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public IPFJJJBMNCG DPMMPPKNAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public DKHMEJAEAHB GPFBIBMDAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AJHHBOLKMEO OLLNEGCHHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public HAJEBJAEDHD DLMAKAPIIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LFGLPHMHHAH LLFKOOJPAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C80", Offset = "0x7A7A80", VA = "0x1807A8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public PKMALFKDGHB IFFGACBAHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E20", Offset = "0x7B4C20", VA = "0x1807B5E20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E80", Offset = "0x7B4C80", VA = "0x1807B5E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AHIGBCFDHEO BOPMLBIDLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E50", Offset = "0x7B4C50", VA = "0x1807B5E50", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EE0", Offset = "0x7B4CE0", VA = "0x1807B5EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public CCFMIKOOHDH NADDFMNFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F50", Offset = "0x7B4D50", VA = "0x1807B5F50", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DC0", Offset = "0x7B4BC0", VA = "0x1807B5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public ABNDDCPEALM JIJKIKPCPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8EF080", Offset = "0x8EDE80", VA = "0x1808EF080", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8EF160", Offset = "0x8EDF60", VA = "0x1808EF160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BPFLABMKPNN LJIHNJMBLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F00", Offset = "0x7B4D00", VA = "0x1807B5F00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E00", Offset = "0x7B4C00", VA = "0x1807B5E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NFICGBDNKPA DIJFKJDNNBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8716B0", Offset = "0x8704B0", VA = "0x1808716B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x871C10", Offset = "0x870A10", VA = "0x180871C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public HBFKIPEDJON PIPPHJONFAL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF610", Offset = "0x7AE410", VA = "0x1807AF610", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF680", Offset = "0x7AE480", VA = "0x1807AF680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public HNKMDNGIGFD MCMEBMHNMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6070", Offset = "0x9A4E70", VA = "0x1809A6070", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9B2690", Offset = "0x9B1490", VA = "0x1809B2690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public AMOIJJBNBDJ FBMHGGGOCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9B2520", Offset = "0x9B1320", VA = "0x1809B2520", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9B26D0", Offset = "0x9B14D0", VA = "0x1809B26D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public FDLEHNCOFFB MAMNEDLKEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x888960", Offset = "0x887760", VA = "0x180888960", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9B25F0", Offset = "0x9B13F0", VA = "0x1809B25F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public NABHGMPMEON FOMLLPDFADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7FEDD0", Offset = "0x7FDBD0", VA = "0x1807FEDD0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7FCB20", Offset = "0x7FB920", VA = "0x1807FCB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LDNBHONPDJP FEEJGLKHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7FEDA0", Offset = "0x7FDBA0", VA = "0x1807FEDA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7FD600", Offset = "0x7FC400", VA = "0x1807FD600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OKIDLBPFEKG HFEBDKGFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6A0", Offset = "0x7AE4A0", VA = "0x1807AF6A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7AF660", Offset = "0x7AE460", VA = "0x1807AF660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FMOKIODDCMD FAEIEAGJFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8951C0", Offset = "0x893FC0", VA = "0x1808951C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA220", Offset = "0x8B9020", VA = "0x1808BA220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JLHBLMECKDP BAGKGCDOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x867FA0", Offset = "0x866DA0", VA = "0x180867FA0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x867FC0", Offset = "0x866DC0", VA = "0x180867FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BBEJGMIDLCA IHJMJMCHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8950A0", Offset = "0x893EA0", VA = "0x1808950A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9B26B0", Offset = "0x9B14B0", VA = "0x1809B26B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public IANHOELLMDM JGJHKKIOMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x895170", Offset = "0x893F70", VA = "0x180895170", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9B2670", Offset = "0x9B1470", VA = "0x1809B2670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public NAFJINMIHEI CLJHDODKLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x91D030", Offset = "0x91BE30", VA = "0x18091D030", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B2650", Offset = "0x9B1450", VA = "0x1809B2650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public OHLHKODEAHG CGCJCLDEIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x91D040", Offset = "0x91BE40", VA = "0x18091D040", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B2850", Offset = "0x9B1650", VA = "0x1809B2850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public LFBGPCMLEHM MAHMFFPLIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x91CD80", Offset = "0x91BB80", VA = "0x18091CD80", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B2810", Offset = "0x9B1610", VA = "0x1809B2810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HDMDMODGHLD FKAOOJLEGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x807E10", Offset = "0x806C10", VA = "0x180807E10", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9B2770", Offset = "0x9B1570", VA = "0x1809B2770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BICCKJNHNDG IHCHJNACLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x87F3E0", Offset = "0x87E1E0", VA = "0x18087F3E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PGDMLCJHKPC FEPNNCACCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x91CEE0", Offset = "0x91BCE0", VA = "0x18091CEE0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JIFOLPFHJJB EOEOOMOJHNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x87F400", Offset = "0x87E200", VA = "0x18087F400", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public MAIOAFBCNPD FPMFKJENHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x87F3F0", Offset = "0x87E1F0", VA = "0x18087F3F0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E2C0", VA = "0x18087F4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private bool DFJCPLOFEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x65A01A0", Offset = "0x659EFA0", VA = "0x1865A01A0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private bool MDEHHGJCKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x65A0640", Offset = "0x659F440", VA = "0x1865A0640", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private CancellationToken LEHOHGLJJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x65A02B0", Offset = "0x659F0B0", VA = "0x1865A02B0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private IBPIJCMLLGH BOJICLAMKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action BFHLJLMOIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x65A0020", Offset = "0x659EE20", VA = "0x1865A0020", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x659FD10", Offset = "0x659EB10", VA = "0x18659FD10", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event MHHBJIMCKOP NFJNGCCBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x659FFC0", Offset = "0x659EDC0", VA = "0x18659FFC0", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x65A0350", Offset = "0x659F150", VA = "0x1865A0350", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event MHHBJIMCKOP LPDHCKOHIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x659FBC0", Offset = "0x659E9C0", VA = "0x18659FBC0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x65A0140", Offset = "0x659EF40", VA = "0x1865A0140", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event MHHBJIMCKOP CEMGAOMJLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x65A00E0", Offset = "0x659EEE0", VA = "0x1865A00E0", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x659FB60", Offset = "0x659E960", VA = "0x18659FB60", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<HGDMGBMIKKL, bool> IEPLAEIMALG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x659FC20", Offset = "0x659EA20", VA = "0x18659FC20", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x65A0250", Offset = "0x659F050", VA = "0x1865A0250", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x87F4C0", Offset = "0x87E2C0", VA = "0x18087F4C0", Slot = "35")]
	public void JKLKGPMNALI(MAIOAFBCNPD LLIGIJMDLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x65A06C0", Offset = "0x659F4C0", VA = "0x1865A06C0")]
	[UnityEngine.Scripting.Preserve]
	internal FDFCKBAKDOA([LICAMFFCLCL(null)] IBPIJCMLLGH PPDHICBEIFC, [LICAMFFCLCL(null)] IPFJJJBMNCG KMLMAPIMMEL, [LICAMFFCLCL(null)] DKHMEJAEAHB ICFJLOPGONC, [LICAMFFCLCL(null)] FPLJMDLJDMH ADOCEOOMFBH, [LICAMFFCLCL(null)] AJHHBOLKMEO BAOEGJPNBCE, [LICAMFFCLCL(null)] HAJEBJAEDHD NBCLJCLIKIM, [LICAMFFCLCL(null)] LFGLPHMHHAH JGKCIFLOEJH, [LICAMFFCLCL(null)] PKMALFKDGHB GCFNGCNCBFM, [LICAMFFCLCL(null)] AHIGBCFDHEO IDAKPHMCHLL, [LICAMFFCLCL(null)] CCFMIKOOHDH KFOOAHKAMOE, [LICAMFFCLCL(null)] ABNDDCPEALM BPGGEGPGKLD, [LICAMFFCLCL(null)] BPFLABMKPNN MEJMACPIFBF, [LICAMFFCLCL(null)] NFICGBDNKPA JHHCPAFMNAL, [LICAMFFCLCL(null)] HBFKIPEDJON BJHJKLDMAAB, [LICAMFFCLCL(null)] HNKMDNGIGFD AEEIODJBBHF, [LICAMFFCLCL(null)] AMOIJJBNBDJ CPMMIKOKPOH, [LICAMFFCLCL(null)] FDLEHNCOFFB CCDIOLMLNKF, [LICAMFFCLCL(null)] NABHGMPMEON BBFNLNJCJCP, [LICAMFFCLCL(null)] LDNBHONPDJP EIHIDHEDBBJ, [LICAMFFCLCL(null)] OKIDLBPFEKG HAKPKHECCHG, [LICAMFFCLCL(null)] JLHBLMECKDP KAKKKHEIBHO, [LICAMFFCLCL(null)] FMOKIODDCMD PDIFDKLADHM, [LICAMFFCLCL(null)] BBEJGMIDLCA GMJKMANMKNL, [LICAMFFCLCL(null)] IANHOELLMDM OPGMKPJDEFF, [LICAMFFCLCL(null)] NAFJINMIHEI BFFOMGKAAEB, [LICAMFFCLCL(null)] LFBGPCMLEHM LLPOOCEMMPM, [LICAMFFCLCL(null)] HDMDMODGHLD EDFNJPNLCOB, [LICAMFFCLCL(null)] BICCKJNHNDG OLMFCBMGDNE, [LICAMFFCLCL(null)] PGDMLCJHKPC HHMBCOKEGOC, [LICAMFFCLCL(null)] JIFOLPFHJJB PNKFBDDDLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x659FF10", Offset = "0x659ED10", VA = "0x18659FF10")]
	private void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x659FD70", Offset = "0x659EB70", VA = "0x18659FD70", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x65A0200", Offset = "0x659F000", VA = "0x1865A0200", Slot = "48")]
	private void IIDEKEOONCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x659FC80", Offset = "0x659EA80", VA = "0x18659FC80", Slot = "49")]
	private FJGLMBPEPDP BPNPCKGBGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x65A05B0", Offset = "0x659F3B0", VA = "0x1865A05B0", Slot = "50")]
	private PIOMBPDNICP NILHEFDBCFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x65A03B0", Offset = "0x659F1B0", VA = "0x1865A03B0", Slot = "51")]
	[AsyncStateMachine(typeof(HNCKGMGLGCM))]
	private Task<OMGIPDGCLFM> LKPDBGCMIJA(EMHEAHMEPJK BFMMNLLBIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x65A04C0", Offset = "0x659F2C0", VA = "0x1865A04C0", Slot = "52")]
	[AsyncStateMachine(typeof(DOJLKFCJMAO))]
	private Task LNBGKNALPJA(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x65A02D0", Offset = "0x659F0D0", VA = "0x1865A02D0")]
	[IteratorStateMachine(typeof(CPLIBDBIBMP))]
	private IEnumerable<MAMNOPKFBDA> LJIEICGCIIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x65A0080", Offset = "0x659EE80", VA = "0x1865A0080")]
	[CompilerGenerated]
	private void GHELAMOIOKO(MAMNOPKFBDA EIFNJBJEIMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LNKDNIOGKHE : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0xD01060", Offset = "0xCFFE60", VA = "0x180D01060")]
	public LNKDNIOGKHE(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal class ABPMFDPLBKK : FNNIKFODHJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MAMJLPNJEJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public ABPMFDPLBKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x65AF990", Offset = "0x65AE790", VA = "0x1865AF990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x65AFCD0", Offset = "0x65AEAD0", VA = "0x1865AFCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public ABPMFDPLBKK(IHLIMGHFCMP CAJNLCEPHNN, FPLJMDLJDMH ADOCEOOMFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6594210", Offset = "0x6593010", VA = "0x186594210", Slot = "4")]
	[AsyncStateMachine(typeof(MAMJLPNJEJB))]
	public Task<bool> DIFNJCKGAOH(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6594300", Offset = "0x6593100", VA = "0x186594300")]
	[CompilerGenerated]
	private object MJKNGPANOHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class KEBNGPAPALJ : FNNIKFODHJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct GDPIOGBBHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public KEBNGPAPALJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x65A31D0", Offset = "0x65A1FD0", VA = "0x1865A31D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x65A38E0", Offset = "0x65A26E0", VA = "0x1865A38E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x65AD150", Offset = "0x65ABF50", VA = "0x1865AD150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public KEBNGPAPALJ(IHLIMGHFCMP CAJNLCEPHNN, FPLJMDLJDMH ADOCEOOMFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF40", Offset = "0x65ABD40", VA = "0x1865ACF40", Slot = "4")]
	[AsyncStateMachine(typeof(GDPIOGBBHKD))]
	public Task<bool> DIFNJCKGAOH(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x65AD070", Offset = "0x65ABE70", VA = "0x1865AD070")]
	[CompilerGenerated]
	private object FPGIBPJIAHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal class LMJMEHNAGDI : FNNIKFODHJF
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JIPELJACEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LMJMEHNAGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public HNAIHGNMDMN result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public EJEIFLCIKHD newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JIPELJACEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x65A7B00", Offset = "0x65A6900", VA = "0x1865A7B00")]
		internal object FLCKPJIEGOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x65A7A90", Offset = "0x65A6890", VA = "0x1865A7A90")]
		internal object EJPOFGFOHCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x65A79F0", Offset = "0x65A67F0", VA = "0x1865A79F0")]
		internal object AFEAKADBFPP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct CMJPJHEEGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LMJMEHNAGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private JIPELJACEPA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<HNAIHGNMDMN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x659C280", Offset = "0x659B080", VA = "0x18659C280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x659CBB0", Offset = "0x659B9B0", VA = "0x18659CBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x65AEA50", Offset = "0x65AD850", VA = "0x1865AEA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public LMJMEHNAGDI(IHLIMGHFCMP CAJNLCEPHNN, FPLJMDLJDMH ADOCEOOMFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x65AE930", Offset = "0x65AD730", VA = "0x1865AE930", Slot = "4")]
	[AsyncStateMachine(typeof(CMJPJHEEGHN))]
	public Task<bool> DIFNJCKGAOH(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal interface FNNIKFODHJF
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> DIFNJCKGAOH(CancellationToken HHBHDBLGMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct HNIFHIBNNAO
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class CBLFKONMLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public IHLIMGHFCMP manager;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CBLFKONMLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x659AB90", Offset = "0x6599990", VA = "0x18659AB90")]
		internal Task KKIAMCGEGDK(LMCJHJIAIGC data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct FKJACPIBOJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public HNIFHIBNNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private EMHEAHMEPJK <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<MEKFINGEDEJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x65A1D10", Offset = "0x65A0B10", VA = "0x1865A1D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x65A22A0", Offset = "0x65A10A0", VA = "0x1865A22A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LFLKLNPAAND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public HNIFHIBNNAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x65AE050", Offset = "0x65ACE50", VA = "0x1865AE050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x65AE370", Offset = "0x65AD170", VA = "0x1865AE370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken HHBHDBLGMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly IHLIMGHFCMP IEHBMNBOFCL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private IPFJJJBMNCG DPMMPPKNAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x65A5B40", Offset = "0x65A4940", VA = "0x1865A5B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x65A5750", Offset = "0x65A4550", VA = "0x1865A5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x65A57A0", Offset = "0x65A45A0", VA = "0x1865A57A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private CCFMIKOOHDH NADDFMNFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x65A5700", Offset = "0x65A4500", VA = "0x1865A5700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AC80", Offset = "0x1D89A80", VA = "0x181D8AC80")]
	public HNIFHIBNNAO(CancellationToken HHBHDBLGMFA, IHLIMGHFCMP IEHBMNBOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x65A5580", Offset = "0x65A4380", VA = "0x1865A5580")]
	public static KPMLADPGEIC BJPENNLPJOE(IHLIMGHFCMP IEHBMNBOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x65A5820", Offset = "0x65A4620", VA = "0x1865A5820")]
	[AsyncStateMachine(typeof(FKJACPIBOJB))]
	public Task<bool> MICHEHPNDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x65A5930", Offset = "0x65A4730", VA = "0x1865A5930")]
	private bool NMBPIAOCPOE([Out] EMHEAHMEPJK BFMMNLLBIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x65A5630", Offset = "0x65A4430", VA = "0x1865A5630")]
	[AsyncStateMachine(typeof(LFLKLNPAAND))]
	private Task CNGJKPIPBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x65A5450", Offset = "0x65A4250", VA = "0x1865A5450")]
	private Task<MEKFINGEDEJ> AKNFIENBCOI(EMHEAHMEPJK ADNFGGDLJIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct NBLDDFIGNLA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly HNKMDNGIGFD AEEIODJBBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid MBCGHBNLJEN;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private Task<(OMGIPDGCLFM, Task)> BEIPKFNIHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x65B0990", Offset = "0x65AF790", VA = "0x1865B0990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B95900", Offset = "0x3B94700", VA = "0x183B95900")]
	public NBLDDFIGNLA(HNKMDNGIGFD AEEIODJBBHF, Guid MBCGHBNLJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x65B0940", Offset = "0x65AF740", VA = "0x1865B0940")]
	public TaskAwaiter<(OMGIPDGCLFM, Task)> KEPGPNEAKDP()
	{
		return default(TaskAwaiter<(OMGIPDGCLFM, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x65B0870", Offset = "0x65AF670", VA = "0x1865B0870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct PPEMMKGPNFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(OMGIPDGCLFM, Task)> OBOFHGCBLHE;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public Task<(OMGIPDGCLFM, Task)> BEIPKFNIHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x65B24E0", Offset = "0x65B12E0", VA = "0x1865B24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x65B2520", Offset = "0x65B1320", VA = "0x1865B2520")]
	public PPEMMKGPNFN(TimeSpan GAODDMEEHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x65B2360", Offset = "0x65B1160", VA = "0x1865B2360")]
	public void CIGHKNKIIJC(Task LEACLIFJLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x65B2450", Offset = "0x65B1250", VA = "0x1865B2450")]
	public void INEHINAJEMA(OMGIPDGCLFM DCGGFGCLELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x65B2400", Offset = "0x65B1200", VA = "0x1865B2400")]
	public void FHBOHACEDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x65B22D0", Offset = "0x65B10D0", VA = "0x1865B22D0")]
	internal void CGCDPAFMALJ(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BCEONLBECKD
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LJIBAKGMJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public MFFPGPFJMLA subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LJIBAKGMJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x65AE3D0", Offset = "0x65AD1D0", VA = "0x1865AE3D0")]
		internal bool CGMNCEKNJKA(ALMLFHPANKN s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6594BC0", Offset = "0x65939C0", VA = "0x186594BC0")]
	public static MIGCEKPLBCD IKNJBMGGGFK(long PGPIHDGPHMP, long FDDHOJFABCM, string OFEONHHMBHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x65948D0", Offset = "0x65936D0", VA = "0x1865948D0")]
	public static MIGCEKPLBCD IKNJBMGGGFK(long PGPIHDGPHMP, long FDDHOJFABCM, GLFMJDNKFLA KOLMPBPLBDO, long FFOOPFLIOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6594C50", Offset = "0x6593A50", VA = "0x186594C50")]
	public static MIGCEKPLBCD IKNJBMGGGFK(JOHBNOCABDJ JJKPJPKFDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6594990", Offset = "0x6593790", VA = "0x186594990")]
	public static MIGCEKPLBCD IKNJBMGGGFK(KEHHDGIBOGN PMJDLKJGPAI, MFFPGPFJMLA KJHJGGMMNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6594650", Offset = "0x6593450", VA = "0x186594650")]
	public static MIGCEKPLBCD CBCDFACLKOO(this MIGCEKPLBCD FCMJAHOHNCO, KEHHDGIBOGN MOEGHGCIAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6594740", Offset = "0x6593540", VA = "0x186594740")]
	public static MIGCEKPLBCD IGOFJDGPCMD(this MIGCEKPLBCD FCMJAHOHNCO, MFFPGPFJMLA MHPDGOMDAJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[RecRoom.NoEngine.Common.Preserve]
internal class CAOHABCPGPB : AHIGBCFDHEO, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct HENADANCJJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CAOHABCPGPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x65A4680", Offset = "0x65A3480", VA = "0x1865A4680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x65A4D10", Offset = "0x65A3B10", VA = "0x1865A4D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly EOHKIDCJHLO FIMNDGGLDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string PNDOKJEJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task GLGLEMNFGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool KGDICINMOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x659A970", Offset = "0x6599770", VA = "0x18659A970", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public Task MADAHHEIAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x659A7C0", Offset = "0x65995C0", VA = "0x18659A7C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0", Slot = "7")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x659A9A0", Offset = "0x65997A0", VA = "0x18659A9A0", Slot = "6")]
	public void LBHGPNCLJAF(Task IMKKNGNMOEA, string MGKAHINPLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x659A850", Offset = "0x6599650", VA = "0x18659A850")]
	[AsyncStateMachine(typeof(HENADANCJJC))]
	private Task FBJDBEMHGGM(Task JCJGGPBJALF, string MGKAHINPLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x659AB00", Offset = "0x6599900", VA = "0x18659AB00")]
	public CAOHABCPGPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class DCIBDPJKAKO : OHLHKODEAHG, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool PPJEKOMEIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private EIABKDOGICB GGKDNEKDIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private LFBGPCMLEHM LLPOOCEMMPM;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public EIABKDOGICB AKHOCIBMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x659D530", Offset = "0x659C330", VA = "0x18659D530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x659D2F0", Offset = "0x659C0F0", VA = "0x18659D2F0", Slot = "7")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x659D5A0", Offset = "0x659C3A0", VA = "0x18659D5A0", Slot = "5")]
	public void PGMDIIOKCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x659D2B0", Offset = "0x659C0B0", VA = "0x18659D2B0", Slot = "6")]
	public void KBLFOEBCGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x659D470", Offset = "0x659C270", VA = "0x18659D470")]
	private Task ILNNENMDJPL(LKCAKFKAGBE AIFJDDMPMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x659D2B0", Offset = "0x659C0B0", VA = "0x18659D2B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DCIBDPJKAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JMAEAHCNBBK : LFBGPCMLEHM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private class EFDCFCFFLGF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly IEKKJHEMAIE FMJOMMKOKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly string JCMGBFKGKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly T IDLIOJCDHNC;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public T DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x99B200", Offset = "0x99A000", VA = "0x18099B200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3239D20", Offset = "0x3238B20", VA = "0x183239D20")]
		public EFDCFCFFLGF(IEKKJHEMAIE FMJOMMKOKGI, string JCMGBFKGKLO, T IDLIOJCDHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3239AC0", Offset = "0x32388C0", VA = "0x183239AC0")]
		private void DOIDMPOIPBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly IEKKJHEMAIE FMJOMMKOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly EFDCFCFFLGF<TimeSpan> OOACNJIDOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly EFDCFCFFLGF<TimeSpan> DPDENKDOOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly EFDCFCFFLGF<TimeSpan> PHFBIIMCCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly EFDCFCFFLGF<TimeSpan> PLFPGHODCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly EFDCFCFFLGF<bool> NGMBFOPJEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly EFDCFCFFLGF<bool> FFJKALNKFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly EFDCFCFFLGF<bool> GEACKKIIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly EFDCFCFFLGF<int> FLFMEGNOKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly EFDCFCFFLGF<bool> DLJCNAMKEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly EFDCFCFFLGF<bool> PGBJNGLLACM;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan BLPPGKEILDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x65A7E30", Offset = "0x65A6C30", VA = "0x1865A7E30", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public TimeSpan GEMEPGMJLNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x65A7DF0", Offset = "0x65A6BF0", VA = "0x1865A7DF0", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TimeSpan DKPDLMEMEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x65A7CF0", Offset = "0x65A6AF0", VA = "0x1865A7CF0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TimeSpan GBONGKFGKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x65A7C70", Offset = "0x65A6A70", VA = "0x1865A7C70", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CLBJGKFGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x65A7BF0", Offset = "0x65A69F0", VA = "0x1865A7BF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool GDPPPDCIKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D30", Offset = "0x65A6B30", VA = "0x1865A7D30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool NHAAFHEGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D70", Offset = "0x65A6B70", VA = "0x1865A7D70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int HCIOPOOANNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x65A7C30", Offset = "0x65A6A30", VA = "0x1865A7C30", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NIFDMLBPPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x65A7CB0", Offset = "0x65A6AB0", VA = "0x1865A7CB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OELGINOEDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x65A7DB0", Offset = "0x65A6BB0", VA = "0x1865A7DB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x65A7E70", Offset = "0x65A6C70", VA = "0x1865A7E70")]
	[UnityEngine.Scripting.Preserve]
	public JMAEAHCNBBK([LICAMFFCLCL(null)] IEKKJHEMAIE FMJOMMKOKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[UnityEngine.Scripting.Preserve]
internal class LCAIHBICFEG : ABNDDCPEALM, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class DAIONBEGLPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public PLLNCCBDCKN roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DAIONBEGLPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x659D1D0", Offset = "0x659BFD0", VA = "0x18659D1D0")]
		internal object OIDKNCCKICM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MLOMAAFBDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x65AD5E0", Offset = "0x65AC3E0", VA = "0x1865AD5E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x65ADD60", Offset = "0x65ACB60", VA = "0x1865ADD60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MHHBJIMCKOP IADKMHCOOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x65ADCC0", Offset = "0x65ACAC0", VA = "0x1865ADCC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x65ADF50", Offset = "0x65ACD50", VA = "0x1865ADF50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MHHBJIMCKOP DJOLNBENJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x65ADB20", Offset = "0x65AC920", VA = "0x1865ADB20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x65ADE00", Offset = "0x65ACC00", VA = "0x1865ADE00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MHHBJIMCKOP DOPJIEMBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x65AD540", Offset = "0x65AC340", VA = "0x1865AD540", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x65AD8B0", Offset = "0x65AC6B0", VA = "0x1865AD8B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<HGDMGBMIKKL, bool> ECNHHMDEJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x65ADBC0", Offset = "0x65AC9C0", VA = "0x1865ADBC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x65ADEA0", Offset = "0x65ACCA0", VA = "0x1865ADEA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "19")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x65AD6B0", Offset = "0x65AC4B0", VA = "0x1865AD6B0", Slot = "14")]
	public void CMHLHDAMDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x65ADFF0", Offset = "0x65ACDF0", VA = "0x1865ADFF0", Slot = "15")]
	public void PFMBGCPOHDD(PLLNCCBDCKN CAKCKKEGKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x65AE020", Offset = "0x65ACE20", VA = "0x1865AE020", Slot = "16")]
	public void PHLALOAEJJL(PLLNCCBDCKN CAKCKKEGKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x65AD680", Offset = "0x65AC480", VA = "0x1865AD680", Slot = "17")]
	public void BGNPHFPLJGN(PLLNCCBDCKN CAKCKKEGKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x65ADC70", Offset = "0x65ACA70", VA = "0x1865ADC70", Slot = "18")]
	public void KNJNGNOMDIB(HGDMGBMIKKL CPIHABMOFML, bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x65AD950", Offset = "0x65AC750", VA = "0x1865AD950")]
	private void EIPDNFJIBDM(MHHBJIMCKOP MBIEFODNHHN, PLLNCCBDCKN CAKCKKEGKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public LCAIHBICFEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[UnityEngine.Scripting.Preserve]
internal class HAHCDKIAFKF : BPFLABMKPNN, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct JEPEDPCPJIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public HAHCDKIAFKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x65A74B0", Offset = "0x65A62B0", VA = "0x1865A74B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x65A7990", Offset = "0x65A6790", VA = "0x1865A7990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct DFNLBABLFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public HAHCDKIAFKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x659D750", Offset = "0x659C550", VA = "0x18659D750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x659DDB0", Offset = "0x659CBB0", VA = "0x18659DDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class KNCGEIPBHAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KNCGEIPBHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x65AD420", Offset = "0x65AC220", VA = "0x1865AD420")]
		internal object KOBADKLOADM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct BLKPJOOOHJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public HAHCDKIAFKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private KNCGEIPBHAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x659A000", Offset = "0x6598E00", VA = "0x18659A000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x659A750", Offset = "0x6599550", VA = "0x18659A750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AKJNODEKCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AKJNODEKCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x65943E0", Offset = "0x65931E0", VA = "0x1865943E0")]
		internal object JMNLLFNHHHG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FNNIKFODHJF[] JMBFLHFLGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CancellationTokenSource HMAJEHPOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private int LAKKOKCPNDP;

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x65A3F80", Offset = "0x65A2D80", VA = "0x1865A3F80", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x65A3E40", Offset = "0x65A2C40", VA = "0x1865A3E40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x65A3D40", Offset = "0x65A2B40", VA = "0x1865A3D40", Slot = "8")]
	public void DFGOIMAHHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x65A4000", Offset = "0x65A2E00", VA = "0x1865A4000", Slot = "5")]
	public void HBJHKOKLNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x65A4420", Offset = "0x65A3220", VA = "0x1865A4420", Slot = "4")]
	[AsyncStateMachine(typeof(JEPEDPCPJIM))]
	public Task MHLNDDKLKOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x65A3950", Offset = "0x65A2750", VA = "0x1865A3950")]
	private void AFDDMEKNGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x65A44F0", Offset = "0x65A32F0", VA = "0x1865A44F0")]
	[AsyncStateMachine(typeof(DFNLBABLFHJ))]
	private Task PIOGMLMCDGD(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x65A41B0", Offset = "0x65A2FB0", VA = "0x1865A41B0")]
	[AsyncStateMachine(typeof(BLKPJOOOHJM))]
	private Task<bool> INBNIBGHFKC(int ENPOKNEMOMH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x65A3C60", Offset = "0x65A2A60", VA = "0x1865A3C60")]
	private void BKAHMICEMNA(int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x65A40D0", Offset = "0x65A2ED0", VA = "0x1865A40D0")]
	private void ICGOCPLPMJI(int ENPOKNEMOMH, bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x65A3E50", Offset = "0x65A2C50", VA = "0x1865A3E50")]
	private void ELDNKELIKBM(int ENPOKNEMOMH, Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x65A42F0", Offset = "0x65A30F0", VA = "0x1865A42F0")]
	private void MGCIPFLHLEL(CancellationToken HHBHDBLGMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HAHCDKIAFKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[RecRoom.NoEngine.Common.Preserve]
internal class JOOGDAKHGIB : NFICGBDNKPA, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct ELBICNINOAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public MAIOAFBCNPD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x659F120", Offset = "0x659DF20", VA = "0x18659F120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x659FA80", Offset = "0x659E880", VA = "0x18659FA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct IIOFBOCJIKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public MAIOAFBCNPD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private GAKKIOAFLLE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private LINFNOBOGPG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private GEKJJJHLPNL <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private MNBCHGOIPKA <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x65A63B0", Offset = "0x65A51B0", VA = "0x1865A63B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x65A6F70", Offset = "0x65A5D70", VA = "0x1865A6F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class LBJIPJGCECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Matchmaking.DBGPIOELHCI result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public EKBBDOPCBMK errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LBJIPJGCECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x65AD490", Offset = "0x65AC290", VA = "0x1865AD490")]
		internal object IEIELAJOILN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MMOPPFNGKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Task<MIGCEKPLBCD> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MMOPPFNGKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		internal Task<MIGCEKPLBCD> BPDIGFDDIAL(GAKKIOAFLLE<string>.AGJOEKMHOHC _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct BKOJBONKDGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public MAIOAFBCNPD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public GEKJJJHLPNL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private MMOPPFNGKBG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private GPACFPBPMNF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private LINFNOBOGPG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private OBCFLGGKGFN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Task<Matchmaking.NPAEOOOBGEM> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private NDMGEAOFJHB <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<Matchmaking.NPAEOOOBGEM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<MIGCEKPLBCD> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6594DE0", Offset = "0x6593BE0", VA = "0x186594DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6599FA0", Offset = "0x6598DA0", VA = "0x186599FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct FKIAPELEDLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x65A1260", Offset = "0x65A0060", VA = "0x1865A1260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x65A1CB0", Offset = "0x65A0AB0", VA = "0x1865A1CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IMNNOOFAJCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private IBPIJCMLLGH <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x65A6FD0", Offset = "0x65A5DD0", VA = "0x1865A6FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x65A7450", Offset = "0x65A6250", VA = "0x1865A7450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct OHIKMOKLGCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<Matchmaking.NPAEOOOBGEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private TaskAwaiter<Matchmaking.NPAEOOOBGEM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x65B0AE0", Offset = "0x65AF8E0", VA = "0x1865B0AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x65B0FE0", Offset = "0x65AFDE0", VA = "0x1865B0FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct FIACAGABABF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Matchmaking.NPAEOOOBGEM serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public GEKJJJHLPNL joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<HNHJEAKPNKI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x65A0B00", Offset = "0x659F900", VA = "0x1865A0B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x65A1200", Offset = "0x65A0000", VA = "0x1865A1200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class BAAJECEKJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BAAJECEKJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6594450", Offset = "0x6593250", VA = "0x186594450")]
		internal object LNCMNMNOBMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6594550", Offset = "0x6593350", VA = "0x186594550")]
		internal string PKHBEMIDHAI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct JMLBGGODKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private BAAJECEKJCN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x65A82E0", Offset = "0x65A70E0", VA = "0x1865A82E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x65A8EB0", Offset = "0x65A7CB0", VA = "0x1865A8EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct ECHLDAPINBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public GEKJJJHLPNL joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public MIGCEKPLBCD initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public EJEIFLCIKHD targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public GPACFPBPMNF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x659E2D0", Offset = "0x659D0D0", VA = "0x18659E2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x659EBE0", Offset = "0x659D9E0", VA = "0x18659EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct CKDLDNOLNLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private LINFNOBOGPG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x659ABE0", Offset = "0x65999E0", VA = "0x18659ABE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x659C220", Offset = "0x659B020", VA = "0x18659C220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct IEGNOBDKIKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public JOOGDAKHGIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x65A5B90", Offset = "0x65A4990", VA = "0x1865A5B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x65A6350", Offset = "0x65A5150", VA = "0x1865A6350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class NAJBNBEEHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NAJBNBEEHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x65B06A0", Offset = "0x65AF4A0", VA = "0x1865B06A0")]
		internal object KAGMOFHLDNF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class HJLIIHNLNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HJLIIHNLNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x65A50C0", Offset = "0x65A3EC0", VA = "0x1865A50C0")]
		internal void OJKACDOAIJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class FBGMAFGCMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public FBGMAFGCMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x659FAE0", Offset = "0x659E8E0", VA = "0x18659FAE0")]
		internal object OGHIEJIKODE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class CNBBOKCAPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CNBBOKCAPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x659CC20", Offset = "0x659BA20", VA = "0x18659CC20")]
		internal string NNMEPMCFKLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly KNPFMNBIIDA ABODPBFFLHF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly KNPFMNBIIDA CGIMFIOPPNL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly KNPFMNBIIDA JHMNCDHHGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string IDELAGMINEN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string ANGNFEKLKNG;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly string OKGDAPACKED;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public static readonly Guid LAMMKEHPCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private PKMALFKDGHB GCFNGCNCBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private DKHMEJAEAHB ICFJLOPGONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private BPFLABMKPNN MEJMACPIFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private AHIGBCFDHEO IDAKPHMCHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private ABNDDCPEALM BPGGEGPGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private JIFOLPFHJJB PNKFBDDDLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private PGDMLCJHKPC HHMBCOKEGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private IDisposable GOGMMPPJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly EOHKIDCJHLO LHPKBCFGEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly EOHKIDCJHLO PLPAAKDEOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NDMGEAOFJHB JIHBFMJOCMO;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TaskStatus NPFELIOIGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA34F40", Offset = "0xA33D40", VA = "0x180A34F40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA7E110", Offset = "0xA7CF10", VA = "0x180A7E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x65AB2F0", Offset = "0x65AA0F0", VA = "0x1865AB2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x65A9AE0", Offset = "0x65A88E0", VA = "0x1865A9AE0", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x65A9200", Offset = "0x65A8000", VA = "0x1865A9200", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x65ABCB0", Offset = "0x65AAAB0", VA = "0x1865ABCB0", Slot = "5")]
	[AsyncStateMachine(typeof(ELBICNINOAD))]
	public Task MEIFLICLJFD(EJEIFLCIKHD MPMDCLFHGCI, MAIOAFBCNPD FLKBBGDFLEE, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x65AAEE0", Offset = "0x65A9CE0", VA = "0x1865AAEE0")]
	[AsyncStateMachine(typeof(IIOFBOCJIKF))]
	private Task ILOOLKPMICG(EJEIFLCIKHD MPMDCLFHGCI, MAIOAFBCNPD FLKBBGDFLEE, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x65AB4F0", Offset = "0x65AA2F0", VA = "0x1865AB4F0")]
	private static void KOCMADBHFGI(JIFOLPFHJJB PNKFBDDDLOF, EJEIFLCIKHD MPMDCLFHGCI, Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x65A9250", Offset = "0x65A8050", VA = "0x1865A9250")]
	private static void EKLHJBGFGKD(MNBCHGOIPKA BABIIOEEMHL, Exception PIJHOBKPGID, [Optional] List<int> MILJGHOAOOD, int LAKKOKCPNDP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC440", Offset = "0x65AB240", VA = "0x1865AC440")]
	[AsyncStateMachine(typeof(BKOJBONKDGM))]
	private Task PBDFJGFBLII(GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, EJEIFLCIKHD MPMDCLFHGCI, MAIOAFBCNPD FLKBBGDFLEE, GEKJJJHLPNL DOKPLAIHFBD, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1A0", Offset = "0x65A9FA0", VA = "0x1865AB1A0")]
	private void JDNOEHBKPGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x65AA090", Offset = "0x65A8E90", VA = "0x1865AA090")]
	[AsyncStateMachine(typeof(FKIAPELEDLD))]
	private Task FGBJOLHCHGJ(GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x65AA660", Offset = "0x65A9460", VA = "0x1865AA660")]
	private void HBHBBEDDHOE(EJEIFLCIKHD MPMDCLFHGCI, CancellationToken JPLHPFGGALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x65AC0B0", Offset = "0x65AAEB0", VA = "0x1865AC0B0")]
	private void NLMIHKOJGCO(EJEIFLCIKHD MPMDCLFHGCI, GEKJJJHLPNL DOKPLAIHFBD, OperationCanceledException KNCJINPGLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x65AA1C0", Offset = "0x65A8FC0", VA = "0x1865AA1C0")]
	private void GBGKLIEIODG(EJEIFLCIKHD MPMDCLFHGCI, GEKJJJHLPNL DOKPLAIHFBD, Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x65ABAA0", Offset = "0x65AA8A0", VA = "0x1865ABAA0")]
	private void LJMKOAMOKLK(EJEIFLCIKHD MPMDCLFHGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x65AC6C0", Offset = "0x65AB4C0", VA = "0x1865AC6C0")]
	private static PLLNCCBDCKN PEBBIBBKGAG(EJEIFLCIKHD MPMDCLFHGCI)
	{
		return default(PLLNCCBDCKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x65A9020", Offset = "0x65A7E20", VA = "0x1865A9020")]
	[AsyncStateMachine(typeof(IMNNOOFAJCL))]
	private Task AEHGIMELLDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x65AA990", Offset = "0x65A9790", VA = "0x1865AA990")]
	[AsyncStateMachine(typeof(OHIKMOKLGCD))]
	private Task<Matchmaking.NPAEOOOBGEM> HGEEKHEHELB(EJEIFLCIKHD MPMDCLFHGCI, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x65A8F10", Offset = "0x65A7D10", VA = "0x1865A8F10")]
	private static HNHJEAKPNKI ABJMNNFBOJC(Matchmaking.NPAEOOOBGEM PBODOFCFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x65AA3F0", Offset = "0x65A91F0", VA = "0x1865AA3F0")]
	[AsyncStateMachine(typeof(FIACAGABABF))]
	private Task GDLGFEAPGMB(Matchmaking.NPAEOOOBGEM PBODOFCFNFL, GEKJJJHLPNL DOKPLAIHFBD, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken FLADIFFJPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x65AADA0", Offset = "0x65A9BA0", VA = "0x1865AADA0")]
	[AsyncStateMachine(typeof(JMLBGGODKJK))]
	private Task IHILPPHMMCJ(EJEIFLCIKHD MPMDCLFHGCI, CancellationTokenSource BDCFLKDAKGK, Task PBEDHIIDJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x65AB030", Offset = "0x65A9E30", VA = "0x1865AB030")]
	[AsyncStateMachine(typeof(ECHLDAPINBA))]
	private Task JBAOHEHNAKO(MIGCEKPLBCD HJCPCBDDCNF, GPACFPBPMNF GDPGEOBPGAM, EJEIFLCIKHD BDKFDFHBGIA, GEKJJJHLPNL JAEHNFKFDJB, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken LAGJJCDBJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x65AB8B0", Offset = "0x65AA6B0", VA = "0x1865AB8B0")]
	private GEKJJJHLPNL LIAKNKOBFMC(GEKJJJHLPNL JAEHNFKFDJB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x65AAC70", Offset = "0x65A9A70", VA = "0x1865AAC70")]
	[AsyncStateMachine(typeof(CKDLDNOLNLF))]
	private Task HLDBLDMLKAL(GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x65AC5A0", Offset = "0x65AB3A0", VA = "0x1865AC5A0")]
	[AsyncStateMachine(typeof(IEGNOBDKIKL))]
	private Task PCDCOHIPGNC(LMCJHJIAIGC OMHIFBJFAGA, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x65AAAF0", Offset = "0x65A98F0", VA = "0x1865AAAF0")]
	private static void HGNGECEJEAP(EJEIFLCIKHD MPMDCLFHGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x65ABEE0", Offset = "0x65AACE0", VA = "0x1865ABEE0")]
	private void MOPDBPPKLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x65AA540", Offset = "0x65A9340", VA = "0x1865AA540")]
	private void GEGCEEBCFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x65A9FA0", Offset = "0x65A8DA0", VA = "0x1865A9FA0")]
	private void FCLKBKLGLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x65AA5D0", Offset = "0x65A93D0", VA = "0x1865AA5D0")]
	private void GFMHLKAAGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x65ABDF0", Offset = "0x65AABF0", VA = "0x1865ABDF0")]
	private static void MLKGENGNGGJ(EJEIFLCIKHD MPMDCLFHGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x65A90F0", Offset = "0x65A7EF0", VA = "0x1865A90F0")]
	private static CancellationTokenRegistration AMPOJLLJKLI(EJEIFLCIKHD MPMDCLFHGCI, CancellationToken FLADIFFJPLA)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x65AC340", Offset = "0x65AB140", VA = "0x1865AC340")]
	private static void ONOEGPKFJKN(EJEIFLCIKHD MPMDCLFHGCI, Exception PIJHOBKPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x65AB340", Offset = "0x65AA140", VA = "0x1865AB340")]
	private void KHCACFEMHCA(EJEIFLCIKHD MPMDCLFHGCI, Task PBEDHIIDJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x65AA030", Offset = "0x65A8E30", VA = "0x1865AA030")]
	private static void FDPKAFHEJCK(Func<string> BAPJOIDEOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x65AC940", Offset = "0x65AB740", VA = "0x1865AC940")]
	public JOOGDAKHGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x65AC2E0", Offset = "0x65AB0E0", VA = "0x1865AC2E0")]
	[CompilerGenerated]
	internal static (int, int?) NPLLCKDPEEP(EKBBDOPCBMK KIPCEGJGNGF)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[RecRoom.NoEngine.Common.Preserve]
internal class PEAEGAHAFJO : HBFKIPEDJON, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct NDBJJLFEHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PEAEGAHAFJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public LMCJHJIAIGC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x65CB6B0", Offset = "0x65CA4B0", VA = "0x1865CB6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x65CBA70", Offset = "0x65CA870", VA = "0x1865CBA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class HAKBOLDMCGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public PEAEGAHAFJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public LMCJHJIAIGC roomData;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HAKBOLDMCGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x65B9F50", Offset = "0x65B8D50", VA = "0x1865B9F50")]
		internal List<Task> GLCNNNHDPCK(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MMFOMFHPDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public KPMLADPGEIC taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x65CAD50", Offset = "0x65C9B50", VA = "0x1865CAD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x65CB0E0", Offset = "0x65C9EE0", VA = "0x1865CB0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct NKLHDPJBJPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public PEAEGAHAFJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x65CCD60", Offset = "0x65CBB60", VA = "0x1865CCD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x65CD020", Offset = "0x65CBE20", VA = "0x1865CD020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly HashSet<KPMLADPGEIC> OJODNMDGCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private DKHMEJAEAHB ICFJLOPGONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NLMPFCMDIAG EJICEEGEJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private OBJKJEKNELG OKLCKMFGBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private IDisposable GOGMMPPJHBE;

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x65B19F0", Offset = "0x65B07F0", VA = "0x1865B19F0", Slot = "5")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x65B1540", Offset = "0x65B0340", VA = "0x1865B1540", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x65B2170", Offset = "0x65B0F70", VA = "0x1865B2170", Slot = "4")]
	public bool PNFFNMIBMMI(KPMLADPGEIC LMIAMJGGAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x65B1E50", Offset = "0x65B0C50", VA = "0x1865B1E50")]
	private void LLNPKHKIJGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x65B1C70", Offset = "0x65B0A70", VA = "0x1865B1C70")]
	private void IJNDCDCFFGO(LMCJHJIAIGC JJGMEBEMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x65B13D0", Offset = "0x65B01D0", VA = "0x1865B13D0")]
	[AsyncStateMachine(typeof(NDBJJLFEHBG))]
	private Task CEDNFDLLNFL(LMCJHJIAIGC JJGMEBEMOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x65B1F80", Offset = "0x65B0D80", VA = "0x1865B1F80")]
	private Func<CancellationToken, List<Task>> MAKMCMIOBHO(LMCJHJIAIGC JJGMEBEMOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x65B15A0", Offset = "0x65B03A0", VA = "0x1865B15A0")]
	private List<Task> ECBBOALLIDO(LMCJHJIAIGC JJGMEBEMOEB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x65B2050", Offset = "0x65B0E50", VA = "0x1865B2050")]
	[AsyncStateMachine(typeof(MMFOMFHPDKM))]
	private Task MFKMDFIAPFM(KPMLADPGEIC MICMNEHFBMA, LMCJHJIAIGC OMHIFBJFAGA, CancellationToken NBGOKNOECBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x65B1300", Offset = "0x65B0100", VA = "0x1865B1300")]
	[AsyncStateMachine(typeof(NKLHDPJBJPD))]
	private Task AHCLAIAFHIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x65B14C0", Offset = "0x65B02C0", VA = "0x1865B14C0")]
	private void DFGOIMAHHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x65B21D0", Offset = "0x65B0FD0", VA = "0x1865B21D0")]
	public PEAEGAHAFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[UnityEngine.Scripting.Preserve]
internal sealed class LHKILPBLJMO : HNKMDNGIGFD, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class MKCFGLNINPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MKCFGLNINPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x65CACF0", Offset = "0x65C9AF0", VA = "0x1865CACF0")]
		internal object LILPFGKICGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class ENPMHAKMDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ENPMHAKMDAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x65B8F80", Offset = "0x65B7D80", VA = "0x1865B8F80")]
		internal object ENIPAHGNBAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class CAAPKCIMNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CAAPKCIMNMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class ELGJPJMFMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ELGJPJMFMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x65B8F20", Offset = "0x65B7D20", VA = "0x1865B8F20")]
		internal object BGBGJAJJOJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class ELGDMKLGHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ELGDMKLGHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x65B8EC0", Offset = "0x65B7CC0", VA = "0x1865B8EC0")]
		internal object MBALFGMCBLP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private readonly Dictionary<Guid, PPEMMKGPNFN> AEEIODJBBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private readonly TimeSpan CPCBOBLMINI;

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "9")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x65C8BB0", Offset = "0x65C79B0", VA = "0x1865C8BB0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x65C8250", Offset = "0x65C7050", VA = "0x1865C8250", Slot = "4")]
	public NBLDDFIGNLA ANMBPKAMKOK(Guid MBCGHBNLJEN)
	{
		return default(NBLDDFIGNLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x65C8BC0", Offset = "0x65C79C0", VA = "0x1865C8BC0", Slot = "5")]
	public bool JJGPDDBMEBN(Guid MBCGHBNLJEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x65C8650", Offset = "0x65C7450", VA = "0x1865C8650", Slot = "6")]
	public bool CHMBHJJPAEC(Guid MBCGHBNLJEN, Task LEACLIFJLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x65C8470", Offset = "0x65C7270", VA = "0x1865C8470", Slot = "7")]
	public bool CAIMEDADOCA(Guid MBCGHBNLJEN, OMGIPDGCLFM DCGGFGCLELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x65C8DD0", Offset = "0x65C7BD0", VA = "0x1865C8DD0", Slot = "8")]
	public Task<(OMGIPDGCLFM, Task)> NMMNLJGJDEJ(Guid MBCGHBNLJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x65C8980", Offset = "0x65C7780", VA = "0x1865C8980")]
	private void DPEOCILAOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x65C8E40", Offset = "0x65C7C40", VA = "0x1865C8E40")]
	public LHKILPBLJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[RecRoom.NoEngine.Common.Preserve]
internal class MBFLBDBMIEI : AMOIJJBNBDJ, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private class PBODLKICCPF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly EJEIFLCIKHD MOGGLGBCOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private readonly CancellationTokenSource HMAJEHPOLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public readonly CancellationToken LDAEPLDKKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private bool MEGPHEDOLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool OADMEOKPNBL;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x65CE710", Offset = "0x65CD510", VA = "0x1865CE710")]
		public PBODLKICCPF(EJEIFLCIKHD MOGGLGBCOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x65CE590", Offset = "0x65CD390", VA = "0x1865CE590")]
		public void DFGOIMAHHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x65CE6E0", Offset = "0x65CD4E0", VA = "0x1865CE6E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EDPAMIMHLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public LKCAKFKAGBE disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EDPAMIMHLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x65B85D0", Offset = "0x65B73D0", VA = "0x1865B85D0")]
		internal object LOJCIDAAMPA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct IKAAMJFOGLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public LKCAKFKAGBE disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public MBFLBDBMIEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x65BD140", Offset = "0x65BBF40", VA = "0x1865BD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x65BD4F0", Offset = "0x65BC2F0", VA = "0x1865BD4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class IHLHLGNCLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IHLHLGNCLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x65BD050", Offset = "0x65BBE50", VA = "0x1865BD050")]
		internal object LNOECDOKGPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct NEEHHNCJBLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public MBFLBDBMIEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private LINFNOBOGPG <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x65CBAD0", Offset = "0x65CA8D0", VA = "0x1865CBAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x920680", Offset = "0x91F480", VA = "0x180920680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class ANGGMPNPIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public EJEIFLCIKHD newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ANGGMPNPIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x65B34C0", Offset = "0x65B22C0", VA = "0x1865B34C0")]
		internal object APBNOAILEAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x65B3440", Offset = "0x65B2240", VA = "0x1865B3440")]
		internal object AJIIPNKAPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x65B3480", Offset = "0x65B2280", VA = "0x1865B3480")]
		internal object AKLPMFHKPBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class ADPKJEKMJII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ADPKJEKMJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x65B31C0", Offset = "0x65B1FC0", VA = "0x1865B31C0")]
		internal void MGEMLIOFDOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct CPBFFLNDBPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public EJEIFLCIKHD newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public MBFLBDBMIEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public MAIOAFBCNPD customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private ANGGMPNPIBN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x65B69F0", Offset = "0x65B57F0", VA = "0x1865B69F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x65B7970", Offset = "0x65B6770", VA = "0x1865B7970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly GBFPGFOOIEJ.FOGICGJCGBC EECFOOOLCAC;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly GOGFDPHPOKA LAINCIKINBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private DKHMEJAEAHB ICFJLOPGONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private BPFLABMKPNN MEJMACPIFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private LFBGPCMLEHM LLPOOCEMMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NFICGBDNKPA JHHCPAFMNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private long AIHIEDLOLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private PBODLKICCPF ICKBOJAEOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private bool LHMMBMAJDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Task KLIFKFBLDGH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x65CA430", Offset = "0x65C9230", VA = "0x1865CA430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool PCGKCLPCKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xD078C0", Offset = "0xD066C0", VA = "0x180D078C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x65CA200", Offset = "0x65C9000", VA = "0x1865CA200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x65C9DE0", Offset = "0x65C8BE0", VA = "0x1865C9DE0", Slot = "4")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x65C9970", Offset = "0x65C8770", VA = "0x1865C9970", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x65CA210", Offset = "0x65C9010", VA = "0x1865CA210")]
	[AsyncStateMachine(typeof(IKAAMJFOGLB))]
	private Task IHNDOKKIPOG(LKCAKFKAGBE KFOCJCKCHGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x65CA480", Offset = "0x65C9280", VA = "0x1865CA480")]
	private void KJBHCLOCPOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x65CA720", Offset = "0x65C9520", VA = "0x1865CA720")]
	private void MACFLDLGCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x65CA080", Offset = "0x65C8E80", VA = "0x1865CA080")]
	private void FNANLBBEOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x65C9AE0", Offset = "0x65C88E0", VA = "0x1865C9AE0")]
	private bool EEKFGHOEOJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x65C9850", Offset = "0x65C8650", VA = "0x1865C9850")]
	[AsyncStateMachine(typeof(NEEHHNCJBLE))]
	private void COGOABGGAAO(int ODBNCIFPAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x65C9B50", Offset = "0x65C8950", VA = "0x1865C9B50")]
	private void EPEFCNODEPF([Out] IDisposable CCELIJHCJCK, [Out] IDisposable NGBNBPBJKIC, [Out] IDisposable EDFKJANHOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x65CA620", Offset = "0x65C9420", VA = "0x1865CA620")]
	private bool KJJFELFHBME(EJEIFLCIKHD MOGGLGBCOPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65C9920", Offset = "0x65C8720", VA = "0x1865C9920")]
	private void CPFGHDMAAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x65CA300", Offset = "0x65C9100", VA = "0x1865CA300")]
	[AsyncStateMachine(typeof(CPBFFLNDBPH))]
	private Task ILOOLKPMICG(EJEIFLCIKHD MOGGLGBCOPI, MAIOAFBCNPD FLKBBGDFLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x65CAC80", Offset = "0x65C9A80", VA = "0x1865CAC80")]
	public MBFLBDBMIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[UnityEngine.Scripting.Preserve]
internal sealed class JAAPJLOPCME : FDLEHNCOFFB, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct KJIFINBJMGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AsyncTaskMethodBuilder<LFKCPECOHNF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public JAAPJLOPCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter<LFKCPECOHNF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x65C5980", Offset = "0x65C4780", VA = "0x1865C5980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x65C5C10", Offset = "0x65C4A10", VA = "0x1865C5C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class CLNCAKCCOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public GPALKAPGCML message;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CLNCAKCCOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x65B4FD0", Offset = "0x65B3DD0", VA = "0x1865B4FD0")]
		internal object CBNBMHGIDEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class AEGKPFAGHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public GPALKAPGCML messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AEGKPFAGHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x65B3260", Offset = "0x65B2060", VA = "0x1865B3260")]
		internal object GNBGFJHAJHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class DMOKNHGEGOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DMOKNHGEGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x65B8510", Offset = "0x65B7310", VA = "0x1865B8510")]
		internal object JHGLEMGBKKB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private struct JFPJKAJILJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public JAAPJLOPCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter<IFEGHCNBDPC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x65BF880", Offset = "0x65BE680", VA = "0x1865BF880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x65C0140", Offset = "0x65BEF40", VA = "0x1865C0140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class GLLJJMEHKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public GPALKAPGCML operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GLLJJMEHKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x65B9EF0", Offset = "0x65B8CF0", VA = "0x1865B9EF0")]
		internal object BMBCBJFJEPK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct ICLOBLGKBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public GPALKAPGCML operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JAAPJLOPCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private GEKJJJHLPNL <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x65BB6B0", Offset = "0x65BA4B0", VA = "0x1865BB6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x65BC220", Offset = "0x65BB020", VA = "0x1865BC220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct KJJDIEEPNFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<IFEGHCNBDPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public JAAPJLOPCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private DPFPOGBCKFP.DAJJAKJNIMB <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private GEKJJJHLPNL <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x65C5C80", Offset = "0x65C4A80", VA = "0x1865C5C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x65C61A0", Offset = "0x65C4FA0", VA = "0x1865C61A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class NJLOGLDLDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public IFEGHCNBDPC operation;

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NJLOGLDLDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x65CCCE0", Offset = "0x65CBAE0", VA = "0x1865CCCE0")]
		internal object HMKAFIDNEFA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private struct DMFNHGINELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public IFEGHCNBDPC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public JAAPJLOPCME <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private GAKKIOAFLLE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x65B7E70", Offset = "0x65B6C70", VA = "0x1865B7E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x65B84B0", Offset = "0x65B72B0", VA = "0x1865B84B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class AHKNCCINDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AHKNCCINDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x65B32C0", Offset = "0x65B20C0", VA = "0x1865B32C0")]
		internal object FNGNGOGCHCA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class DFEDHBPEMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DFEDHBPEMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x65B7E10", Offset = "0x65B6C10", VA = "0x1865B7E10")]
		internal object KPGDNICFECL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private AHIGBCFDHEO IDAKPHMCHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private NABHGMPMEON BBFNLNJCJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private FMOKIODDCMD PDIFDKLADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private TaskCompletionSource<LFKCPECOHNF> NJEJJIFIBIH;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x65BE190", Offset = "0x65BCF90", VA = "0x1865BE190", Slot = "7")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x65BE4E0", Offset = "0x65BD2E0", VA = "0x1865BE4E0", Slot = "6")]
	[AsyncStateMachine(typeof(KJIFINBJMGL))]
	public Task<LFKCPECOHNF> KINHOABJEKL(CancellationToken JKAGPAFMMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x65BDC50", Offset = "0x65BCA50", VA = "0x1865BDC50", Slot = "4")]
	public void AGLIFPKGIID(GPALKAPGCML EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x65BECA0", Offset = "0x65BDAA0", VA = "0x1865BECA0", Slot = "5")]
	public void PFHOGOIEFAM(GPALKAPGCML IEEFGNFLPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x65BE980", Offset = "0x65BD780", VA = "0x1865BE980")]
	[AsyncStateMachine(typeof(JFPJKAJILJH))]
	private Task OFLALDHHEPN(GPALKAPGCML MIMLCIHLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x65BE280", Offset = "0x65BD080", VA = "0x1865BE280")]
	[AsyncStateMachine(typeof(ICLOBLGKBOI))]
	private Task GHKIEAEPEHP(GPALKAPGCML NABACJJMFIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x65BE390", Offset = "0x65BD190", VA = "0x1865BE390")]
	[AsyncStateMachine(typeof(KJJDIEEPNFI))]
	private Task<IFEGHCNBDPC> GIJBMPJEHJK(GPALKAPGCML MIMLCIHLPAB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x65BDFE0", Offset = "0x65BCDE0", VA = "0x1865BDFE0")]
	private GEKJJJHLPNL EKCBKGEKEGF(GPALKAPGCML MHOEGLJDFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x65BE070", Offset = "0x65BCE70", VA = "0x1865BE070")]
	[AsyncStateMachine(typeof(DMFNHGINELN))]
	private Task ENNPOGLKPMH(IFEGHCNBDPC EJLMAECJKCH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x65BEA90", Offset = "0x65BD890", VA = "0x1865BEA90")]
	private IFEGHCNBDPC OMBEIGHIBFH(GPALKAPGCML MIMLCIHLPAB, GEKJJJHLPNL GAOONIBKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2753500", Offset = "0x2752300", VA = "0x182753500")]
	private T LDCPKIOEFAN<T>(T NKKIECLCEML) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x65BE5F0", Offset = "0x65BD3F0", VA = "0x1865BE5F0")]
	private IFEGHCNBDPC LCMNAMAFHMM(GPALKAPGCML MIMLCIHLPAB, GEKJJJHLPNL GAOONIBKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JAAPJLOPCME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[UnityEngine.Scripting.Preserve]
internal sealed class JGGDGIANNHL : NABHGMPMEON, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FLIPNLGCLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public FLIPNLGCLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x65B9BD0", Offset = "0x65B89D0", VA = "0x1865B9BD0")]
		internal object DKFMHEGNHGK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JHNDLLEKKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JHNDLLEKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x65C3EC0", Offset = "0x65C2CC0", VA = "0x1865C3EC0")]
		internal object ADADKPFBJNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private BBEJGMIDLCA GMJKMANMKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private FDLEHNCOFFB CCDIOLMLNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private HNKMDNGIGFD AEEIODJBBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private NAFJINMIHEI BFFOMGKAAEB;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x65C2F30", Offset = "0x65C1D30", VA = "0x1865C2F30", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x65C23A0", Offset = "0x65C11A0", VA = "0x1865C23A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x65C3840", Offset = "0x65C2640", VA = "0x1865C3840", Slot = "4")]
	public NBLDDFIGNLA OBKPACDJJEI(GPALKAPGCML GGNHLGBJFIL)
	{
		return default(NBLDDFIGNLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x65C2190", Offset = "0x65C0F90", VA = "0x1865C2190", Slot = "5")]
	public void CMBBOCLHDOA(Guid MBCGHBNLJEN, Task LEACLIFJLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x65C30A0", Offset = "0x65C1EA0", VA = "0x1865C30A0")]
	private void FFPFGHAHMNL(byte IJHAGMKPHPE, int NGBMJIKJPPO, object PODJLDAIBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x65C2450", Offset = "0x65C1250", VA = "0x1865C2450")]
	private void EAPMHDKNPMP(OLNFHCLLCKG BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x65C1E80", Offset = "0x65C0C80", VA = "0x1865C1E80")]
	private void CLEANKONALO(OLNFHCLLCKG BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x65C3600", Offset = "0x65C2400", VA = "0x1865C3600")]
	private void KPIHNPHCCPN(OLNFHCLLCKG BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x65C3C80", Offset = "0x65C2A80", VA = "0x1865C3C80")]
	private OMGIPDGCLFM OHEMJDLKMIL(GPALKAPGCML MHOEGLJDFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x65C3170", Offset = "0x65C1F70", VA = "0x1865C3170")]
	private void HADLEOHHHDL(GPALKAPGCML NABACJJMFIO, OMGIPDGCLFM DCGGFGCLELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x65C29F0", Offset = "0x65C17F0", VA = "0x1865C29F0")]
	private bool EJJKPHHJHFA(GPALKAPGCML NABACJJMFIO, OMGIPDGCLFM DCGGFGCLELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x65C3380", Offset = "0x65C2180", VA = "0x1865C3380")]
	private bool IDIBGJICGPP(GPALKAPGCML LIHAEFEFDEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x65C2CA0", Offset = "0x65C1AA0", VA = "0x1865C2CA0")]
	private bool EKPHDBPJCOH(byte IJHAGMKPHPE, ExitGames.Client.Photon.Hashtable BBMDMLIDKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JGGDGIANNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[UnityEngine.Scripting.Preserve]
internal sealed class HGOPECGNKOH : LDNBHONPDJP, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class CMACANDHIFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public LFKCPECOHNF operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public HGOPECGNKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public GPALKAPGCML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CMACANDHIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x65B5030", Offset = "0x65B3E30", VA = "0x1865B5030")]
		internal object FENMDEFDNJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x65B50A0", Offset = "0x65B3EA0", VA = "0x1865B50A0")]
		internal object GFKJBFFFKJB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private struct IMBHEBGDJKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public HGOPECGNKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public GPALKAPGCML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x65BD550", Offset = "0x65BC350", VA = "0x1865BD550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x65BDBE0", Offset = "0x65BC9E0", VA = "0x1865BDBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class LNMJIGCBKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public LFKCPECOHNF operationType;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LNMJIGCBKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x65C9580", Offset = "0x65C8380", VA = "0x1865C9580")]
		internal object OMDANMGJFOA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class NLJLJOLOJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NLJLJOLOJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x65CD0F0", Offset = "0x65CBEF0", VA = "0x1865CD0F0")]
		internal object DMBLJHJMPEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x65CD080", Offset = "0x65CBE80", VA = "0x1865CD080")]
		internal object DAOBGJJLFCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x65CD160", Offset = "0x65CBF60", VA = "0x1865CD160")]
		internal object KJMHIBPBOKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private struct CHOCMKHLMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public HGOPECGNKOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private NLJLJOLOJDC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private NBLDDFIGNLA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private OMGIPDGCLFM <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private TaskAwaiter<(OMGIPDGCLFM validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x65B46B0", Offset = "0x65B34B0", VA = "0x1865B46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x65B4F60", Offset = "0x65B3D60", VA = "0x1865B4F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private BBEJGMIDLCA GMJKMANMKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private NABHGMPMEON BBFNLNJCJCP;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x65BA1E0", Offset = "0x65B8FE0", VA = "0x1865BA1E0", Slot = "5")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x65B9F80", Offset = "0x65B8D80", VA = "0x1865B9F80", Slot = "4")]
	[AsyncStateMachine(typeof(IMBHEBGDJKP))]
	private Task<OMGIPDGCLFM> BKOEGGMIMEL(GPALKAPGCML MHOEGLJDFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x65BA290", Offset = "0x65B9090", VA = "0x1865BA290")]
	private bool KIAFOEPPKLI(LFKCPECOHNF CPIHABMOFML, [Out] OMGIPDGCLFM BGCCPJGDEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x65BA0A0", Offset = "0x65B8EA0", VA = "0x1865BA0A0")]
	[AsyncStateMachine(typeof(CHOCMKHLMOO))]
	private Task<OMGIPDGCLFM> DAMDDEJKFJO(GPALKAPGCML MIMLCIHLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HGOPECGNKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class CMJNKEIBDEI : OKIDLBPFEKG, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct HPELBCEGDOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<MIGCEKPLBCD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public CMJNKEIBDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private TaskAwaiter<KEHHDGIBOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x65BA530", Offset = "0x65B9330", VA = "0x1865BA530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x65BA9E0", Offset = "0x65B97E0", VA = "0x1865BA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HHJKDJOFGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HHJKDJOFGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x65BA480", Offset = "0x65B9280", VA = "0x1865BA480")]
		internal object ICEMEKOIGCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct KOBFIKMDAMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<KEHHDGIBOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public CMJNKEIBDEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EJEIFLCIKHD targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private HHJKDJOFGII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<KEHHDGIBOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x65C7510", Offset = "0x65C6310", VA = "0x1865C7510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x65C7B00", Offset = "0x65C6900", VA = "0x1865C7B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class DNKCMEAJDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DNKCMEAJDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x142FD20", Offset = "0x142EB20", VA = "0x18142FD20")]
		internal bool HHBPJOLEKGL(ALMLFHPANKN sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly (GLFMJDNKFLA superRoomData, long subRoomDataSaveId) GKLEJFBIIHJ;

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x65B5330", Offset = "0x65B4130", VA = "0x1865B5330", Slot = "5")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x65B51D0", Offset = "0x65B3FD0", VA = "0x1865B51D0", Slot = "4")]
	[AsyncStateMachine(typeof(HPELBCEGDOJ))]
	public Task<MIGCEKPLBCD> AGMPEHGMODG(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, EJEIFLCIKHD MPMDCLFHGCI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x65B56E0", Offset = "0x65B44E0", VA = "0x1865B56E0")]
	[AsyncStateMachine(typeof(KOBFIKMDAMK))]
	private Task<KEHHDGIBOGN> IGDAPMNHMJL(EJEIFLCIKHD MPMDCLFHGCI, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x65B5840", Offset = "0x65B4640", VA = "0x1865B5840")]
	private MIGCEKPLBCD MKANNIPPLCK(EJEIFLCIKHD MPMDCLFHGCI, KEHHDGIBOGN DGCMNINLNDE, long NECGEBINIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x65B53A0", Offset = "0x65B41A0", VA = "0x1865B53A0")]
	private (GLFMJDNKFLA, long) HPGNCEIKMHJ(EJEIFLCIKHD MPMDCLFHGCI, KEHHDGIBOGN DGCMNINLNDE, long NECGEBINIAB)
	{
		return default((GLFMJDNKFLA, long));
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CMJNKEIBDEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[UnityEngine.Scripting.Preserve]
internal sealed class KGDBBGICOBO : FMOKIODDCMD, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class CDLDHCDEOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CDLDHCDEOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x65B4450", Offset = "0x65B3250", VA = "0x1865B4450")]
		internal object KEBPKCOBMHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private struct EOIKMAMDAGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public KGDBBGICOBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public GEKJJJHLPNL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x65B8FE0", Offset = "0x65B7DE0", VA = "0x1865B8FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x65B95F0", Offset = "0x65B83F0", VA = "0x1865B95F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct OLDENBOLMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public KGDBBGICOBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public GEKJJJHLPNL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<EEJNGABEMDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x65CDB90", Offset = "0x65CC990", VA = "0x1865CDB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x65CE190", Offset = "0x65CCF90", VA = "0x1865CE190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JLFGNEMLODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JLFGNEMLODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x65C4140", Offset = "0x65C2F40", VA = "0x1865C4140")]
		internal object LMDEAMGGAKL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct ICKCMIOEOPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GPALKAPGCML request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public KGDBBGICOBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public GEKJJJHLPNL pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private HNACEJGGJPE <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private GCDALOOBJGE <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<EEJNGABEMDO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x65BAA50", Offset = "0x65B9850", VA = "0x1865BAA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x65BB640", Offset = "0x65BA440", VA = "0x1865BB640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private OHLHKODEAHG EELGEJJDDOE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private EIABKDOGICB AKHOCIBMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x65C43F0", Offset = "0x65C31F0", VA = "0x1865C43F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x65C4360", Offset = "0x65C3160", VA = "0x1865C4360", Slot = "8")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x65C4A50", Offset = "0x65C3850", VA = "0x1865C4A50", Slot = "4")]
	[AsyncStateMachine(typeof(EOIKMAMDAGG))]
	public Task<GPALKAPGCML> PMDCMNCAGAE(GPALKAPGCML MIMLCIHLPAB, GEKJJJHLPNL GAOONIBKNFH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x65C4210", Offset = "0x65C3010", VA = "0x1865C4210", Slot = "5")]
	[AsyncStateMachine(typeof(OLDENBOLMDI))]
	public Task<GPALKAPGCML> BCJMOGFAAIO(CancellationToken HHBHDBLGMFA, GEKJJJHLPNL GAOONIBKNFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x65C44B0", Offset = "0x65C32B0", VA = "0x1865C44B0", Slot = "6")]
	public KLBPLCPJKOF LGCLLDLOMHE(IFEGHCNBDPC HHLFOBCDJNP, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x65C4820", Offset = "0x65C3620", VA = "0x1865C4820", Slot = "7")]
	public KLBPLCPJKOF OOHEEJOEEGM(IFEGHCNBDPC HHLFOBCDJNP, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x65C46C0", Offset = "0x65C34C0", VA = "0x1865C46C0")]
	[AsyncStateMachine(typeof(ICKCMIOEOPN))]
	private Task<GPALKAPGCML> LGGEEKDFPNO(GPALKAPGCML MIMLCIHLPAB, GEKJJJHLPNL GAOONIBKNFH, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x277DED0", Offset = "0x277CCD0", VA = "0x18277DED0")]
	private static byte[] JDGNKHKIPEF(GPALKAPGCML EMKENBOOEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KGDBBGICOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[UnityEngine.Scripting.Preserve]
internal sealed class KGIEDKIIGLO : BBEJGMIDLCA, MAMNOPKFBDA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private HAJEBJAEDHD NBCLJCLIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private AHIGBCFDHEO IDAKPHMCHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private JLHBLMECKDP KAKKKHEIBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private NFICGBDNKPA JHHCPAFMNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private HBFKIPEDJON BJHJKLDMAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private LFBGPCMLEHM LLPOOCEMMPM;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x65C5020", Offset = "0x65C3E20", VA = "0x1865C5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private static OMGIPDGCLFM IOCDEJHLGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x65BC760", Offset = "0x65BB560", VA = "0x1865BC760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x65C4BB0", Offset = "0x65C39B0", VA = "0x1865C4BB0", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x65C5070", Offset = "0x65C3E70", VA = "0x1865C5070", Slot = "4")]
	public OMGIPDGCLFM LGAJPBLMDLB(MNFCKJNKANA EDANDKPIAHA, LFKCPECOHNF IFKFMEODFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x65C4D20", Offset = "0x65C3B20", VA = "0x1865C4D20", Slot = "5")]
	public OMGIPDGCLFM IJDOIHKIMOM(MNFCKJNKANA MCHEPFGOPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x65BC4A0", Offset = "0x65BB2A0", VA = "0x1865BC4A0")]
	private static OMGIPDGCLFM ICDCKKHLJLH(GPBCNGKODLJ IIMECKHJEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KGIEDKIIGLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class JICPFGIFFJG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x65C3F30", Offset = "0x65C2D30", VA = "0x1865C3F30")]
	public JICPFGIFFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5B84510", Offset = "0x5B83310", VA = "0x185B84510")]
	public JICPFGIFFJG(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class CNADJLFLFOL : CCFMIKOOHDH, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PNHKNOKLGBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public EMHEAHMEPJK autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private GAKKIOAFLLE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private OPDIGCDFMMG <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x65D0AB0", Offset = "0x65CF8B0", VA = "0x1865D0AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x65D1640", Offset = "0x65D0440", VA = "0x1865D1640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct POHCOIIIAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x65D16B0", Offset = "0x65D04B0", VA = "0x1865D16B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x65D1E00", Offset = "0x65D0C00", VA = "0x1865D1E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct EPMJOENECGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x65B9660", Offset = "0x65B8460", VA = "0x1865B9660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x65B9B70", Offset = "0x65B8970", VA = "0x1865B9B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct IHFENMKMKKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x65BC8A0", Offset = "0x65BB6A0", VA = "0x1865BC8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x65BCFF0", Offset = "0x65BBDF0", VA = "0x1865BCFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct CELDGGLIBKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x65B44B0", Offset = "0x65B32B0", VA = "0x1865B44B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x65B4650", Offset = "0x65B3450", VA = "0x1865B4650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct EIPEIPEFEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x65B8660", Offset = "0x65B7460", VA = "0x1865B8660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x65B8D80", Offset = "0x65B7B80", VA = "0x1865B8D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct PHECHCJPEPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x65CF770", Offset = "0x65CE570", VA = "0x1865CF770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x65CFBE0", Offset = "0x65CE9E0", VA = "0x1865CFBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct LCIPGOMDGHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public CNADJLFLFOL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public CJNNGPMEKJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private GAKKIOAFLLE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x65C7CB0", Offset = "0x65C6AB0", VA = "0x1865C7CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x65C81F0", Offset = "0x65C6FF0", VA = "0x1865C81F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private IPFJJJBMNCG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private FMOKIODDCMD PDIFDKLADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private AHIGBCFDHEO IDAKPHMCHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private HBFKIPEDJON BJHJKLDMAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private CancellationTokenSource IMACLAIIHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private Task HAFDGBKCACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private TaskCompletionSource<int> NIAIFADCMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private int DJKMKPMKNHL;

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x65B6240", Offset = "0x65B5040", VA = "0x1865B6240", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x89B4A0", Offset = "0x89A2A0", VA = "0x18089B4A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x65B6820", Offset = "0x65B5620", VA = "0x1865B6820")]
	private void MFFMIIBDHAP(float LMKDMPPLLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x65B65F0", Offset = "0x65B53F0", VA = "0x1865B65F0", Slot = "4")]
	[AsyncStateMachine(typeof(PNHKNOKLGBC))]
	public Task<OMGIPDGCLFM> ICIFKGPEMCM(EMHEAHMEPJK BFMMNLLBIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x65B63F0", Offset = "0x65B51F0", VA = "0x1865B63F0", Slot = "5")]
	[AsyncStateMachine(typeof(POHCOIIIAIK))]
	public Task GJGBDJEDCEN([Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x89B4A0", Offset = "0x89A2A0", VA = "0x18089B4A0")]
	public void EFMHACEKJEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x65B5CE0", Offset = "0x65B4AE0", VA = "0x1865B5CE0")]
	private OPDIGCDFMMG BEPNIDBBOJC(EMHEAHMEPJK BFMMNLLBIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x65B6060", Offset = "0x65B4E60", VA = "0x1865B6060")]
	[AsyncStateMachine(typeof(EPMJOENECGG))]
	private Task CIFKGAFAKFG(LMCJHJIAIGC AIFJDDMPMMF, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x65B6720", Offset = "0x65B5520", VA = "0x1865B6720")]
	[AsyncStateMachine(typeof(IHFENMKMKKM))]
	private Task ILNJMANHDPD(CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x65B6150", Offset = "0x65B4F50", VA = "0x1865B6150")]
	[AsyncStateMachine(typeof(CELDGGLIBKF))]
	private Task CKHFIBAIIHL([Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x65B6900", Offset = "0x65B5700", VA = "0x1865B6900")]
	[AsyncStateMachine(typeof(EIPEIPEFEFI))]
	private Task OLNJCEGHLLK(CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x65B5E50", Offset = "0x65B4C50", VA = "0x1865B5E50")]
	[AsyncStateMachine(typeof(PHECHCJPEPA))]
	private Task BHDDLJBBKEF(CancellationToken EEFILKKCLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x65B5A50", Offset = "0x65B4850", VA = "0x1865B5A50")]
	private Task AEGKBCIMJIH(CJNNGPMEKJP KGAGAFGNMKC, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x65B5F50", Offset = "0x65B4D50", VA = "0x1865B5F50")]
	[AsyncStateMachine(typeof(LCIPGOMDGHC))]
	private Task CFJLFMJNBPD(CJNNGPMEKJP KGAGAFGNMKC, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x65B64E0", Offset = "0x65B52E0", VA = "0x1865B64E0")]
	private bool GPMNPLOMCNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public CNADJLFLFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[UnityEngine.Scripting.Preserve]
internal class OCENLAJMENL : JLHBLMECKDP, MAMNOPKFBDA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct CDJFDPCBNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public OCENLAJMENL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private GAKKIOAFLLE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x65B3E90", Offset = "0x65B2C90", VA = "0x1865B3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x65B43F0", Offset = "0x65B31F0", VA = "0x1865B43F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private LFGLPHMHHAH JGKCIFLOEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private BBEJGMIDLCA GMJKMANMKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private FMOKIODDCMD PDIFDKLADHM;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x65CD4E0", Offset = "0x65CC2E0", VA = "0x1865CD4E0", Slot = "6")]
	public void FCIFMHNEBDM(IHLIMGHFCMP CAJNLCEPHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x65CD490", Offset = "0x65CC290", VA = "0x1865CD490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x65CD910", Offset = "0x65CC710", VA = "0x1865CD910", Slot = "5")]
	[AsyncStateMachine(typeof(CDJFDPCBNFO))]
	public Task LCILIPDBLBH(string CIPMAAMIEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x65CD7C0", Offset = "0x65CC5C0", VA = "0x1865CD7C0", Slot = "4")]
	public OMGIPDGCLFM GPMNPLOMCNH(MNFCKJNKANA EDANDKPIAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x65CD820", Offset = "0x65CC620", VA = "0x1865CD820")]
	private LLFMDHPDPFN KCBDPPKHEDH(string CIPMAAMIEBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public OCENLAJMENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class CBGNGNGHHPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x65B3BF0", Offset = "0x65B29F0", VA = "0x1865B3BF0")]
	public static void LFBABDDDADB(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x65B3560", Offset = "0x65B2360", VA = "0x1865B3560")]
	internal static void DAEIOJPGJCN(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x65B36C0", Offset = "0x65B24C0", VA = "0x1865B36C0")]
	internal static void EFNEOIFBMLP(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x65B37A0", Offset = "0x65B25A0", VA = "0x1865B37A0")]
	internal static void GOCHKDMCECI(IBPIJCMLLGH PPDHICBEIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class JDKEGCOAMJA : FIGMHPCPFPI<GPALKAPGCML>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class PCOBIHLFOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public GPALKAPGCML message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public PCOBIHLFOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x65CE9E0", Offset = "0x65CD7E0", VA = "0x1865CE9E0")]
		internal object JIOOPJBAMIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public static readonly JDKEGCOAMJA AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x65BF470", Offset = "0x65BE270", VA = "0x1865BF470")]
	public ExitGames.Client.Photon.Hashtable FILLENIGNNA(GPALKAPGCML EMKENBOOEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x65BF000", Offset = "0x65BDE00", VA = "0x1865BF000", Slot = "5")]
	protected override void CGEPNFPLIIL(GPALKAPGCML EMKENBOOEOH, IDictionary<object, object> OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x65BF130", Offset = "0x65BDF30", VA = "0x1865BF130", Slot = "6")]
	public override GPALKAPGCML CINNELLPCMC(IDictionary<object, object> OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x65BF360", Offset = "0x65BE160", VA = "0x1865BF360")]
	private static void FDPKAFHEJCK(string KAOAFEJOOJA, GPALKAPGCML EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x65BF840", Offset = "0x65BE640", VA = "0x1865BF840")]
	public JDKEGCOAMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x65BF500", Offset = "0x65BE300", VA = "0x1865BF500")]
	[CompilerGenerated]
	internal static string NMDCNKFOMKF(MIGCEKPLBCD FCMJAHOHNCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class IDEADLIBBIB
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public static OMGIPDGCLFM IOCDEJHLGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x65BC760", Offset = "0x65BB560", VA = "0x1865BC760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x65BC280", Offset = "0x65BB080", VA = "0x1865BC280")]
	public static bool BFFLGOHBPPG(this OMGIPDGCLFM DCGGFGCLELD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x65BC4A0", Offset = "0x65BB2A0", VA = "0x1865BC4A0")]
	public static OMGIPDGCLFM ICDCKKHLJLH(GPBCNGKODLJ FBNLHBPPKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x65BC2A0", Offset = "0x65BB0A0", VA = "0x1865BC2A0")]
	public static OMGIPDGCLFM CGLMDFEOOAP(IEnumerable<OMGIPDGCLFM> PFFGMEIJJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x65BC500", Offset = "0x65BB300", VA = "0x1865BC500")]
	public static string KFMMPCDGAPD(this OMGIPDGCLFM BGCCPJGDEGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class DEHIKNPPJDO : CFHPNKIOFMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate OMGIPDGCLFM BHHBDNAABIG([NotNull] MNFCKJNKANA IDFJHCCCIDK);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class HMBKCDFNIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public MNFCKJNKANA photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HMBKCDFNIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5D59840", Offset = "0x5D58640", VA = "0x185D59840")]
		internal OMGIPDGCLFM FMPGLNGLEGK(BHHBDNAABIG v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	protected readonly HashSet<BHHBDNAABIG> FKLPMDMMLGI;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x65B7CC0", Offset = "0x65B6AC0", VA = "0x1865B7CC0", Slot = "4")]
	public void JAKAHEHCMCF(BHHBDNAABIG DJMPHGMBNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x65B7D20", Offset = "0x65B6B20", VA = "0x1865B7D20", Slot = "5")]
	public void MKGHEHNALIP(BHHBDNAABIG DJMPHGMBNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x65B7C70", Offset = "0x65B6A70", VA = "0x1865B7C70", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x65B79D0", Offset = "0x65B67D0", VA = "0x1865B79D0")]
	protected OMGIPDGCLFM AHEJNPCKKHL(MNFCKJNKANA MCHEPFGOPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x65B7D80", Offset = "0x65B6B80", VA = "0x1865B7D80")]
	protected DEHIKNPPJDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class JKDKMJIJNGC : DEHIKNPPJDO, HAJEBJAEDHD, CFHPNKIOFMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class DOMHHBMBCOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public OMGIPDGCLFM result;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DOMHHBMBCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x65B8570", Offset = "0x65B7370", VA = "0x1865B8570")]
		internal object ADMFNNCNJCM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x65B3430", Offset = "0x65B2230", VA = "0x1865B3430")]
	[UnityEngine.Scripting.Preserve]
	public JKDKMJIJNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x65C3F70", Offset = "0x65C2D70", VA = "0x1865C3F70", Slot = "8")]
	public OMGIPDGCLFM HDDFOJGKPGO(MNFCKJNKANA MCHEPFGOPKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class AJKKDNNFNPD : DEHIKNPPJDO, LFGLPHMHHAH, CFHPNKIOFMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class CCACKJHLMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public OMGIPDGCLFM result;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CCACKJHLMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x65B3E30", Offset = "0x65B2C30", VA = "0x1865B3E30")]
		internal object ECIKAOLMDAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x65B3430", Offset = "0x65B2230", VA = "0x1865B3430")]
	[UnityEngine.Scripting.Preserve]
	public AJKKDNNFNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x65B3320", Offset = "0x65B2120", VA = "0x1865B3320", Slot = "8")]
	public OMGIPDGCLFM GPMNPLOMCNH(MNFCKJNKANA NGFKMPBFIHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class LPJIBMEGAMN
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class IIBDLIGGEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public GAKKIOAFLLE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IIBDLIGGEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x65BD0C0", Offset = "0x65BBEC0", VA = "0x1865BD0C0")]
		internal object OBGEHGGPOMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x65C96B0", Offset = "0x65C84B0", VA = "0x1865C96B0")]
	public static GAKKIOAFLLE<string> CNHMJAHLODJ(KNPFMNBIIDA PGKJJCPHNLC, [Optional] string DAFGMOEPNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x65C9790", Offset = "0x65C8590", VA = "0x1865C9790")]
	public static void KGDAJKFPLNA(GAKKIOAFLLE<string> JNIKEBIHBPI, KNPFMNBIIDA PGKJJCPHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x65C95F0", Offset = "0x65C83F0", VA = "0x1865C95F0")]
	public static string BHIMCLKPPAM(GPALKAPGCML MHOEGLJDFCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal static class KONMHHKFDBD
{
	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x65C7CA0", Offset = "0x65C6AA0", VA = "0x1865C7CA0")]
	public static void PDHOALLBMNO(this IPFJJJBMNCG KMLMAPIMMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x65C7B70", Offset = "0x65C6970", VA = "0x1865C7B70")]
	public static void FHGPFOKBEDE(this IPFJJJBMNCG KMLMAPIMMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x65C7B80", Offset = "0x65C6980", VA = "0x1865C7B80")]
	private static void OCNMPEJMJKK(this IPFJJJBMNCG KMLMAPIMMEL, bool NBFGJAFPJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class NBNJAAGACKK : CFGNMIKKGMK, ABPLIGPPDCL, PPBBDOOAMKG, GPJCCKLCOOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private readonly ABPLIGPPDCL BEOCLOJGKEA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public MNFCKJNKANA EDMAPIBKBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x65CB410", Offset = "0x65CA210", VA = "0x1865CB410", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int GNOPNFOCDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x65CB660", Offset = "0x65CA460", VA = "0x1865CB660", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int MEEBPEDFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x65CB510", Offset = "0x65CA310", VA = "0x1865CB510", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public int MJLIOKMNCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CJACIFMIPIJ.OKHPHMMDGAN CJAKBCIOPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GCHONKCAOAD JIGAJABBEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x65CB370", Offset = "0x65CA170", VA = "0x1865CB370", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x65CB140", Offset = "0x65C9F40", VA = "0x1865CB140", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> OCJEMJAEHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<MNFCKJNKANA> CHKLGPCKCOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action BMAGMCAGFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x65CB2D0", Offset = "0x65CA0D0", VA = "0x1865CB2D0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x65CB230", Offset = "0x65CA030", VA = "0x1865CB230", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xD03D50", Offset = "0xD02B50", VA = "0x180D03D50")]
	public NBNJAAGACKK(ABPLIGPPDCL BEOCLOJGKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x65CB460", Offset = "0x65CA260", VA = "0x1865CB460", Slot = "8")]
	public bool GJGFJGADPLD(byte IJHAGMKPHPE, ExitGames.Client.Photon.Hashtable LBNDKCHFJJG, INJOLKENMBK EFGHADEHKHE, SendOptions GPMLIFMGFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x65CB560", Offset = "0x65CA360", VA = "0x1865CB560", Slot = "16")]
	public MNFCKJNKANA KNGKMKMHILE(int IAADOHAINLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "19")]
	public void AKIDGLHCFKM(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "20")]
	public void MLBMJGOMFIE(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "21")]
	public void GDPKDACFHOI(object NBGOKNOECBH, bool CNHKBPCNOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x65CB1E0", Offset = "0x65C9FE0", VA = "0x1865CB1E0", Slot = "22")]
	public IDisposable AGEPAADLHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "23")]
	private bool BDAPJPNAFKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "24")]
	public void BGDCPLFLPIJ(StringBuilder GOKFJHEEHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x65CB640", Offset = "0x65CA440", VA = "0x1865CB640", Slot = "25")]
	public bool LIADFDKJKPJ(bool HPJMGJOBPHM, [Out] string OLGJDMIGDKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xBB1B70", Offset = "0xBB0970", VA = "0x180BB1B70", Slot = "28")]
	public void HDNOIKBMCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal struct OLNFHCLLCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private readonly IDictionary<object, object> BBMDMLIDKCP;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	public OLNFHCLLCKG(IDictionary<object, object> BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x65CE4E0", Offset = "0x65CD2E0", VA = "0x1865CE4E0")]
	public bool KLKOOKDHONN([Out] GPALKAPGCML EMKENBOOEOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x65CE200", Offset = "0x65CD000", VA = "0x1865CE200")]
	public Guid BCCHNLNHNFI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65CE2B0", Offset = "0x65CD0B0", VA = "0x1865CE2B0")]
	public OMGIPDGCLFM EBLLBPBGDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x65CE3F0", Offset = "0x65CD1F0", VA = "0x1865CE3F0")]
	public static ExitGames.Client.Photon.Hashtable IKNJBMGGGFK(GPALKAPGCML EMKENBOOEOH, OMGIPDGCLFM DCGGFGCLELD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal static class NGMJNNGBEMH
{
	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x65CCC60", Offset = "0x65CBA60", VA = "0x1865CCC60")]
	public static bool JFMHJGGPLFI(this EJEIFLCIKHD BKHNKMBACHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct OBJKJEKNELG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct GDMGMIELMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public OBJKJEKNELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x65B9C40", Offset = "0x65B8A40", VA = "0x1865B9C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x65B9E20", Offset = "0x65B8C20", VA = "0x1865B9E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private readonly CancellationTokenSource HMAJEHPOLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private bool FCGEEBKFDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private Task IMKKNGNMOEA;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x65CD330", Offset = "0x65CC130", VA = "0x1865CD330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x65CD360", Offset = "0x65CC160", VA = "0x1865CD360")]
	public OBJKJEKNELG(CancellationToken HHBHDBLGMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x65CD220", Offset = "0x65CC020", VA = "0x1865CD220")]
	[AsyncStateMachine(typeof(GDMGMIELMHG))]
	public Task GFOOAJLHNKJ(Func<CancellationToken, List<Task>> FINIMHCLPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x65CD1D0", Offset = "0x65CBFD0", VA = "0x1865CD1D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct IDNLODOLKLA<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct FNGGHOIIBIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<NOMKHBFBACK<TData>, KOAMPGHKKDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public IDNLODOLKLA<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<FBEPHKHKLJE<byte[], KOAMPGHKKDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x35DDDB0", Offset = "0x35DCBB0", VA = "0x1835DDDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x35DEE70", Offset = "0x35DDC70", VA = "0x1835DEE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly JPLBMCFEOGE<TGetDataArg, TData> PHADKJKPPMM;

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	internal IDNLODOLKLA(JPLBMCFEOGE<TGetDataArg, TData> DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3847B10", Offset = "0x3846910", VA = "0x183847B10")]
	[AsyncStateMachine(typeof(IDNLODOLKLA<, >.FNGGHOIIBIP))]
	public Task<FBEPHKHKLJE<NOMKHBFBACK<TData>, KOAMPGHKKDA>> NLJMPOMMKLM(TGetDataArg MLBFGGJBJJC, string AMMLALJNFHK, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class IECKMNJDEAE
{
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x24183A0", Offset = "0x24171A0", VA = "0x1824183A0")]
	public static IDNLODOLKLA<TGetDataArg, TData> KJKFMOENPNA<TGetDataArg, TData>(JPLBMCFEOGE<TGetDataArg, TData> DNHMNAAINOD)
	{
		return default(IDNLODOLKLA<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct EKBBDOPCBMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	public readonly int IJADOMHMOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	public readonly int? BAKPNDLHLKB;

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B95EA0", Offset = "0x3B94CA0", VA = "0x183B95EA0")]
	public EKBBDOPCBMK(int IAOHADBACOG, [Optional] int? IMFONJCFPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x65B8DE0", Offset = "0x65B7BE0", VA = "0x1865B8DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface NJGPLODOGEA<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGHMEOEEILH();

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NJGPLODOGEA<T> APANDIDCKHL(string LPMAAHFLADH);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NJGPLODOGEA<T> AABGBFENJJE(LHLPEIKJMKB<T> CPADOGGFIPB);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJGPLODOGEA<T> LMFIPOJBMDE(int KIPCEGJGNGF);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NJGPLODOGEA<T> GIMAPMMLEPK(int KIPCEGJGNGF, LJGIGNIKNPE<T> CGNHHLGCBKD);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public interface JIFOLPFHJJB
{
	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJGPLODOGEA<T> JBJOGFMFBDB<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKGKAOIGHEH PHHLAMGFPLB(Exception PIJHOBKPGID);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EKBBDOPCBMK OMAFEKNGABC(Exception PIJHOBKPGID);
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate string LHLPEIKJMKB<in T>(T PIJHOBKPGID) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public delegate int LJGIGNIKNPE<in T>(T PIJHOBKPGID) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class JGDKCCFEKEH : JIFOLPFHJJB
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate string JLLKFPHAGPB(Exception PIJHOBKPGID);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private delegate int COOHMLCHDPK(Exception PIJHOBKPGID);

	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	private class HJMGALPIGGG<T> : NJGPLODOGEA<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class BFKJMJKNNDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public BFKJMJKNNDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			internal string CFDFJNDEEBK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class GELLIKFHKAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public LHLPEIKJMKB<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public GELLIKFHKAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x3692C90", Offset = "0x3691A90", VA = "0x183692C90")]
			internal string CGNKBDKNECJ(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class MIODCGGCLAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public LJGIGNIKNPE<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public MIODCGGCLAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3692C90", Offset = "0x3691A90", VA = "0x183692C90")]
			internal int FBJLABEENJL(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private readonly JGDKCCFEKEH PNKFBDDDLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private readonly Type CKHJDLPDAMF;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x378B450", Offset = "0x378A250", VA = "0x18378B450")]
		internal HJMGALPIGGG(JGDKCCFEKEH PNKFBDDDLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x378B3E0", Offset = "0x378A1E0", VA = "0x18378B3E0", Slot = "4")]
		public void JGHMEOEEILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x378B1B0", Offset = "0x3789FB0", VA = "0x18378B1B0", Slot = "5")]
		public NJGPLODOGEA<T> APANDIDCKHL(string LPMAAHFLADH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x378B0A0", Offset = "0x3789EA0", VA = "0x18378B0A0", Slot = "6")]
		public NJGPLODOGEA<T> AABGBFENJJE(LHLPEIKJMKB<T> CPADOGGFIPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x378B410", Offset = "0x378A210", VA = "0x18378B410", Slot = "7")]
		public NJGPLODOGEA<T> LMFIPOJBMDE(int KIPCEGJGNGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x378B2C0", Offset = "0x378A0C0", VA = "0x18378B2C0", Slot = "8")]
		public NJGPLODOGEA<T> GIMAPMMLEPK(int KIPCEGJGNGF, LJGIGNIKNPE<T> CGNHHLGCBKD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	private class OAOANNNPOHE<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private bool CCOFKCNNKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private readonly List<Type> HIPHBIGBKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private readonly Dictionary<Type, TVal> NCHBILLKCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private readonly Dictionary<Type, int> KDFKABJJMCP;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public IReadOnlyList<Type> OLDMGLKKGHC
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x3F50050", Offset = "0x3F4EE50", VA = "0x183F50050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3F50320", Offset = "0x3F4F120", VA = "0x183F50320")]
		public OAOANNNPOHE(Dictionary<Type, int> KDFKABJJMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FD50", Offset = "0x3F4EB50", VA = "0x183F4FD50")]
		public void ANMBPKAMKOK(Type JCMGBFKGKLO, TVal NGFDKOKHGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3F501D0", Offset = "0x3F4EFD0", VA = "0x183F501D0")]
		public bool OJJGBIINHEN(Type CKHJDLPDAMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FFD0", Offset = "0x3F4EDD0", VA = "0x183F4FFD0")]
		public bool HACPMGPHDFE(TVal NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3F50010", Offset = "0x3F4EE10", VA = "0x183F50010")]
		public TVal IKJEAFPPDKF(Type HFFNCGFKMBJ)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FE90", Offset = "0x3F4EC90", VA = "0x183F4FE90")]
		[CompilerGenerated]
		private int EBEOENPNJMP(Type BGPFCJKHBLJ, Type JAEHCEMKMKI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class PDCACMPBIFH : IEnumerable<EKBBDOPCBMK>, IEnumerable, IEnumerator<EKBBDOPCBMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private EKBBDOPCBMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public JGDKCCFEKEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private IEnumerator<EKBBDOPCBMK> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		private EKBBDOPCBMK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x32C3630", Offset = "0x32C2430", VA = "0x1832C3630", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(EKBBDOPCBMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x65CF5D0", Offset = "0x65CE3D0", VA = "0x1865CF5D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public PDCACMPBIFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x65CF620", Offset = "0x65CE420", VA = "0x1865CF620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x65CEFC0", Offset = "0x65CDDC0", VA = "0x1865CEFC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x65CF470", Offset = "0x65CE270", VA = "0x1865CF470")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x65CEF70", Offset = "0x65CDD70", VA = "0x1865CEF70")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x65CF580", Offset = "0x65CE380", VA = "0x1865CF580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x65CF4C0", Offset = "0x65CE2C0", VA = "0x1865CF4C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EKBBDOPCBMK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x65CF4C0", Offset = "0x65CE2C0", VA = "0x1865CF4C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private static readonly EKBBDOPCBMK CCJMPHCPNMI;

	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private static readonly Dictionary<Type, int> CABKLIDEBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	private readonly HashSet<Type> ODGOCKAADMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	private readonly OAOANNNPOHE<int> DAKAGPOMBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private readonly OAOANNNPOHE<COOHMLCHDPK> FOACOEFPFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private readonly OAOANNNPOHE<JLLKFPHAGPB> CDOMKEMLKEK;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x65C1170", Offset = "0x65BFF70", VA = "0x1865C1170")]
	[NAAAALLPNIA(PBKIGNPNCFO.GameOnly)]
	private static void LHBJIPOANBJ(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x65C1B40", Offset = "0x65C0940", VA = "0x1865C1B40")]
	[RecRoom.NoEngine.Common.Preserve]
	public JGDKCCFEKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x259ACE0", Offset = "0x2599AE0", VA = "0x18259ACE0", Slot = "4")]
	public NJGPLODOGEA<T> JBJOGFMFBDB<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x65C19E0", Offset = "0x65C07E0", VA = "0x1865C19E0", Slot = "5")]
	public JKGKAOIGHEH PHHLAMGFPLB(Exception PIJHOBKPGID)
	{
		return default(JKGKAOIGHEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x65C17E0", Offset = "0x65C05E0", VA = "0x1865C17E0", Slot = "6")]
	public EKBBDOPCBMK OMAFEKNGABC(Exception? PIJHOBKPGID)
	{
		return default(EKBBDOPCBMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x65C10D0", Offset = "0x65BFED0", VA = "0x1865C10D0", Slot = "7")]
	[IteratorStateMachine(typeof(PDCACMPBIFH))]
	public IEnumerable<EKBBDOPCBMK> LDIGJOKECEK(Exception PIJHOBKPGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x65C0CB0", Offset = "0x65BFAB0", VA = "0x1865C0CB0", Slot = "8")]
	public string GHBOFGLFOHE(Exception? PIJHOBKPGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x65C08C0", Offset = "0x65BF6C0", VA = "0x1865C08C0")]
	private string BCMBPINPJDH(AggregateException ILBLNGNFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x65C11E0", Offset = "0x65BFFE0", VA = "0x1865C11E0")]
	private void MOENKPDIKPL(Type CKHJDLPDAMF, int KIPCEGJGNGF, COOHMLCHDPK? GADAMCMNENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x65C1590", Offset = "0x65C0390", VA = "0x1865C1590")]
	private void ODGLNEINKMM(Type CKHJDLPDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x65C0E00", Offset = "0x65BFC00", VA = "0x1865C0E00")]
	private void HBOGBGDKIIG(Type CKHJDLPDAMF, JLLKFPHAGPB EEELFGEFKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x65C0740", Offset = "0x65BF540", VA = "0x1865C0740")]
	private static int ALFOCELNMHF(Type CKHJDLPDAMF, Dictionary<Type, int> KDFKABJJMCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x275BB30", Offset = "0x275A930", VA = "0x18275BB30")]
	private static bool IOAFLFFIDKB<TVal>(OAOANNNPOHE<TVal> NCNPEIAEPGG, Type CKHJDLPDAMF, [Out] TVal NKKIECLCEML) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x65C0BD0", Offset = "0x65BF9D0", VA = "0x1865C0BD0")]
	[CompilerGenerated]
	internal static int CLCOMKLEGME(Type IBFLOHCGHLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct JKGKAOIGHEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	public readonly EKBBDOPCBMK LMKPBEKBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public readonly string NDBLDIEAAOP;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x65C4120", Offset = "0x65C2F20", VA = "0x1865C4120")]
	public JKGKAOIGHEH(string KPPOEFDDIGA, EKBBDOPCBMK KIPCEGJGNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x65C4080", Offset = "0x65C2E80", VA = "0x1865C4080")]
	public string ICGBOACLAAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public class PKMALFKDGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private readonly HFAMIEFFJOH HMBIGKJBJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string DIMEKEHNLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private long? OJKCOLPNJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? PLGPIEBLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private long? JGILADAMNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private string CFGBCMFFKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private PPMHDMBDFMJ NNBEDNPKOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private long? HMJOAPECEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private bool EDMHEBKNCGM;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string CKOPMBBHMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public long PLDFADMBDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x65D0760", Offset = "0x65CF560", VA = "0x1865D0760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long NNGDCEPJJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x65CFC40", Offset = "0x65CEA40", VA = "0x1865CFC40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public long PJLLFMKBDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x65D0130", Offset = "0x65CEF30", VA = "0x1865D0130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string CAFMIAEAHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x65D08A0", Offset = "0x65CF6A0", VA = "0x1865D08A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PPMHDMBDFMJ MIMPOBAGOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD16CC0", Offset = "0xD15AC0", VA = "0x180D16CC0")]
		get
		{
			return default(PPMHDMBDFMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x65D0980", Offset = "0x65CF780", VA = "0x1865D0980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public long NHCJEPPDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x65D07C0", Offset = "0x65CF5C0", VA = "0x1865D07C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x65D0A70", Offset = "0x65CF870", VA = "0x1865D0A70")]
	[UnityEngine.Scripting.Preserve]
	public PKMALFKDGHB([LICAMFFCLCL(null)] HFAMIEFFJOH HMBIGKJBJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x65D0510", Offset = "0x65CF310", VA = "0x1865D0510")]
	private void FENMGENMFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x65CFCA0", Offset = "0x65CEAA0", VA = "0x1865CFCA0")]
	public void CFIFKDLOCJL(long CGIDLDOBHII, long NECGEBINIAB, [Optional] long? HDGHLCECFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x65D08E0", Offset = "0x65CF6E0", VA = "0x1865D08E0")]
	public void OMIFEACEDJB(long HDGHLCECFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x65D0820", Offset = "0x65CF620", VA = "0x1865D0820")]
	public void LOMJCIJCDBN(string DMMCEAOIKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x65D0190", Offset = "0x65CEF90", VA = "0x1865D0190")]
	public void EPDFCNNBMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class KLBPLCPJKOF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct JGBJCGMHACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public GPALKAPGCML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public KLBPLCPJKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter<EIABKDOGICB.HMKGLMPFJEN<GPALKAPGCML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x65C01A0", Offset = "0x65BEFA0", VA = "0x1865C01A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x65C06D0", Offset = "0x65BF4D0", VA = "0x1865C06D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct DNBGBNBKOAF<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class IGDCGCBAALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public GPALKAPGCML roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IGDCGCBAALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x65BC7C0", Offset = "0x65BB5C0", VA = "0x1865BC7C0")]
		internal GPALKAPGCML HOGMPJOHJMF(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct LJIGPFINFCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public AsyncTaskMethodBuilder<EIABKDOGICB.HMKGLMPFJEN<GPALKAPGCML>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public GPALKAPGCML roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public KLBPLCPJKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private HNACEJGGJPE <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private TaskAwaiter<EIABKDOGICB.HMKGLMPFJEN<GPALKAPGCML>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x65C8F00", Offset = "0x65C7D00", VA = "0x1865C8F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x65C9510", Offset = "0x65C8310", VA = "0x1865C9510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct PDKBHNOPGMG<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public KLBPLCPJKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x4018970", Offset = "0x4017770", VA = "0x184018970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x324AA50", Offset = "0x3249850", VA = "0x18324AA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private struct PCJGEJLCDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public KLBPLCPJKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x65CE7C0", Offset = "0x65CD5C0", VA = "0x1865CE7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x65CE980", Offset = "0x65CD780", VA = "0x1865CE980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class OCLKBNPHGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public OCLKBNPHGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x65CDA10", Offset = "0x65CC810", VA = "0x1865CDA10")]
		internal object EOKJFPFFOFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x65CDA70", Offset = "0x65CC870", VA = "0x1865CDA70")]
		internal bool PMGLBPDGKCN(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class OKLJEOMJOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public OKLJEOMJOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x65CDB30", Offset = "0x65CC930", VA = "0x1865CDB30")]
		internal object HGIDAKCJGMD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class JOKHGECEMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JOKHGECEMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x65C41A0", Offset = "0x65C2FA0", VA = "0x1865C41A0")]
		internal object KJBLONIBEKH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class GHKPFDDDMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GHKPFDDDMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x65B9E80", Offset = "0x65B8C80", VA = "0x1865B9E80")]
		internal object DFGELNFIGPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class PDABNJACGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public KLBPLCPJKOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public PDABNJACGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x65CED30", Offset = "0x65CDB30", VA = "0x1865CED30")]
		internal object JIOOPJBAMIB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private static readonly Guid HHJDAMDHEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public readonly IFEGHCNBDPC IGHPOLKLKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	private readonly EIABKDOGICB DBLHABNIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly PPBBDOOAMKG KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private readonly GPJCCKLCOOB KGAKHNHOBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private bool FMKBHJLLABP;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x65C72E0", Offset = "0x65C60E0", VA = "0x1865C72E0")]
	public KLBPLCPJKOF(IFEGHCNBDPC EJLMAECJKCH, EIABKDOGICB DBLHABNIMHH, PPBBDOOAMKG KMLMAPIMMEL, GPJCCKLCOOB KGAKHNHOBDL, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x65C66F0", Offset = "0x65C54F0", VA = "0x1865C66F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x65C66F0", Offset = "0x65C54F0", VA = "0x1865C66F0")]
	public void NIOLDCGCHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x65C6350", Offset = "0x65C5150", VA = "0x1865C6350")]
	public void ALHNMMIBDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x65C6BF0", Offset = "0x65C59F0", VA = "0x1865C6BF0")]
	public void GPPBDAFHOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x65C6CB0", Offset = "0x65C5AB0", VA = "0x1865C6CB0")]
	[AsyncStateMachine(typeof(JGBJCGMHACG))]
	internal Task<GPALKAPGCML> HOJLMBDBBAJ(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, GPALKAPGCML MHOEGLJDFCB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x277DED0", Offset = "0x277CCD0", VA = "0x18277DED0")]
	private static byte[] DCNFOELMIOD<T>(T EMKENBOOEOH) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x277DEE0", Offset = "0x277CCE0", VA = "0x18277DEE0")]
	private static T ELFCCLHFIHM<T>(MessageParser<T> IKKDFEHMMBJ, byte[] EMKENBOOEOH, T IJJEODPJDDN) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x65C6AB0", Offset = "0x65C58B0", VA = "0x1865C6AB0")]
	[AsyncStateMachine(typeof(LJIGPFINFCC))]
	private Task<EIABKDOGICB.HMKGLMPFJEN<GPALKAPGCML>> GKHHEPLFCPB(GPALKAPGCML MHOEGLJDFCB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x277E2E0", Offset = "0x277D0E0", VA = "0x18277E2E0")]
	[AsyncStateMachine(typeof(PDKBHNOPGMG<>))]
	internal Task<T> KFPFNDHCEFO<T>(CancellationToken JPLHPFGGALJ, Func<CancellationToken, Task<T>> DDKIFNNIHAH, int JBEICCDHJLO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x65C6FA0", Offset = "0x65C5DA0", VA = "0x1865C6FA0")]
	[AsyncStateMachine(typeof(PCJGEJLCDKM))]
	internal Task KFPFNDHCEFO(CancellationToken JPLHPFGGALJ, Func<CancellationToken, Task> DDKIFNNIHAH, int JBEICCDHJLO = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x65C6A30", Offset = "0x65C5830", VA = "0x1865C6A30")]
	public FCLDKIKNJAB FNCLOEHMKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x65C6E10", Offset = "0x65C5C10", VA = "0x1865C6E10")]
	public BCKAKNDMCGG IBLPFJACLEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x65C70D0", Offset = "0x65C5ED0", VA = "0x1865C70D0")]
	public AONIJFKCNON KIMBHHAKMLL([Optional] KNPFMNBIIDA? PGKJJCPHNLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x65C6410", Offset = "0x65C5210", VA = "0x1865C6410")]
	public void AMICEGNICJB(Func<Guid, bool> HDONDBNAOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x65C6E90", Offset = "0x65C5C90", VA = "0x1865C6E90")]
	public void JADLOMGFDNN(Func<Guid, bool> EGFNLGJFGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x65C6570", Offset = "0x65C5370", VA = "0x1865C6570")]
	public Guid DDEENKPIPJO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x65C6810", Offset = "0x65C5610", VA = "0x1865C6810")]
	public void FAJDHOAPLDD(Guid KFHLFDKKPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x65C6210", Offset = "0x65C5010", VA = "0x1865C6210")]
	public void AJIAPEKKHMC(GPALKAPGCML PGAPGGGBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x65C6920", Offset = "0x65C5720", VA = "0x1865C6920")]
	public void FDPKAFHEJCK(string NNKIDHMLEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x277E560", Offset = "0x277D360", VA = "0x18277E560")]
	private T LDCPKIOEFAN<T>(T NKKIECLCEML) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x65C7220", Offset = "0x65C6020", VA = "0x1865C7220")]
	public void PLLHPKJMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x277E030", Offset = "0x277CE30", VA = "0x18277E030")]
	[CompilerGenerated]
	internal static string IFKCANEFDAA<T>(byte[] JAHCJGGEGHK, int ENMILGMCCJJ, DNBGBNBKOAF<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal sealed class KHJJCGDHHEM : IFEGHCNBDPC
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class AOBOMAGIPCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AOBOMAGIPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x65D5020", Offset = "0x65D3E20", VA = "0x1865D5020")]
		internal object IAAMCOOOKCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct AJKGONMGEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public KHJJCGDHHEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private IAMLLOCNKFO <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private BCKAKNDMCGG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x65D4260", Offset = "0x65D3060", VA = "0x1865D4260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x65D4A40", Offset = "0x65D3840", VA = "0x1865D4A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct OKPDMBNAHHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public KHJJCGDHHEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private bool <omIsEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private bool <omShouldBeEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private TaskAwaiter<KEHHDGIBOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x65E8930", Offset = "0x65E7730", VA = "0x1865E8930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x65E8FE0", Offset = "0x65E7DE0", VA = "0x1865E8FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private struct MJGBFDPNFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public KHJJCGDHHEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter<MFFPGPFJMLA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x65E6A50", Offset = "0x65E5850", VA = "0x1865E6A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x65E6D70", Offset = "0x65E5B70", VA = "0x1865E6D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private sealed class IIJCPEHDLHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public IAMLLOCNKFO presence;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IIJCPEHDLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x65E15A0", Offset = "0x65E03A0", VA = "0x1865E15A0")]
		internal object LOHOKEKIDNA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly KNPFMNBIIDA HFEPNKKIBOM;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly KNPFMNBIIDA BAMDOCKBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private readonly MIGCEKPLBCD HJCPCBDDCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private readonly EJEIFLCIKHD KMPDFMEOLKA;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x65C57F0", Offset = "0x65C45F0", VA = "0x1865C57F0")]
	public KHJJCGDHHEM(MIGCEKPLBCD HJCPCBDDCNF, EJEIFLCIKHD KMPDFMEOLKA, Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65C54D0", Offset = "0x65C42D0", VA = "0x1865C54D0", Slot = "7")]
	[AsyncStateMachine(typeof(AJKGONMGEGN))]
	protected override Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x65C5610", Offset = "0x65C4410", VA = "0x1865C5610")]
	[AsyncStateMachine(typeof(OKPDMBNAHHN))]
	private Task POIGBAPIGKJ(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x65C53C0", Offset = "0x65C41C0", VA = "0x1865C53C0")]
	[AsyncStateMachine(typeof(MJGBFDPNFFP))]
	private Task<byte> GIAJCFDJCIP(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x65C51E0", Offset = "0x65C3FE0", VA = "0x1865C51E0")]
	private IAMLLOCNKFO BLAHLJMHLJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class OPDIGCDFMMG : IFEGHCNBDPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct CAALAIIJNPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public OPDIGCDFMMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<JOHBNOCABDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x65D7F40", Offset = "0x65D6D40", VA = "0x1865D7F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x65D88C0", Offset = "0x65D76C0", VA = "0x1865D88C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private readonly int PIDCNJBFHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private readonly EMHEAHMEPJK ABCDHNPFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	public readonly long HLEBPLLIAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	public readonly long LDCKELEDJMK;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JOHBNOCABDJ CPDHNMJHJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F50", Offset = "0x7B4D50", VA = "0x1807B5F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DC0", Offset = "0x7B4BC0", VA = "0x1807B5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x65E9160", Offset = "0x65E7F60", VA = "0x1865E9160")]
	public OPDIGCDFMMG(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ, int PIDCNJBFHJO, EMHEAHMEPJK ABCDHNPFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x65E9040", Offset = "0x65E7E40", VA = "0x1865E9040", Slot = "7")]
	[AsyncStateMachine(typeof(CAALAIIJNPG))]
	protected override Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal abstract class LNKACMDBFFD : IFEGHCNBDPC
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class EIAEGPOMALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public LNKACMDBFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public IOBNCJEDIHK playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EIAEGPOMALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x65DA7E0", Offset = "0x65D95E0", VA = "0x1865DA7E0")]
		internal Task BKCJONFIJPA(GAKKIOAFLLE<string>.AGJOEKMHOHC postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x65DA820", Offset = "0x65D9620", VA = "0x1865DA820")]
		internal object HANODDHIBCL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct BLEHNBFDCPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public LNKACMDBFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private EIAEGPOMALJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x65D7230", Offset = "0x65D6030", VA = "0x1865D7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x65D79F0", Offset = "0x65D67F0", VA = "0x1865D79F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct FJLIIIGAAGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public IOBNCJEDIHK playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public LNKACMDBFFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x65DC680", Offset = "0x65DB480", VA = "0x1865DC680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x65DCC10", Offset = "0x65DBA10", VA = "0x1865DCC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x65E5F20", Offset = "0x65E4D20", VA = "0x1865E5F20")]
	public LNKACMDBFFD(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ, string MIKLEJNHJHA, HGDMGBMIKKL CPIHABMOFML, bool LBOHPKOCPBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x65E5DE0", Offset = "0x65E4BE0", VA = "0x1865E5DE0", Slot = "7")]
	[AsyncStateMachine(typeof(BLEHNBFDCPM))]
	protected override Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NNJJNKLLPIM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x65E5CA0", Offset = "0x65E4AA0", VA = "0x1865E5CA0")]
	[AsyncStateMachine(typeof(FJLIIIGAAGO))]
	private Task JAOHMDHPOCB(IDisposable FLMHEEFHFFA, IOBNCJEDIHK JOLNCDEKHEE, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class FBNDMJHNJHG : IFEGHCNBDPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct IBOLDEPBBPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public FBNDMJHNJHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private TaskAwaiter<KCEBKGLNFIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x65E01E0", Offset = "0x65DEFE0", VA = "0x1865E01E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x65E0750", Offset = "0x65DF550", VA = "0x1865E0750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private readonly CJNNGPMEKJP KGAGAFGNMKC;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x65DC160", Offset = "0x65DAF60", VA = "0x1865DC160")]
	public FBNDMJHNJHG(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ, CJNNGPMEKJP KGAGAFGNMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x65DC080", Offset = "0x65DAE80", VA = "0x1865DC080", Slot = "6")]
	protected override string KAHMDHHCFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x65DBF60", Offset = "0x65DAD60", VA = "0x1865DBF60", Slot = "7")]
	[AsyncStateMachine(typeof(IBOLDEPBBPB))]
	protected override Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal abstract class IFEGHCNBDPC : GGBPLCLBGEG
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public delegate Task EMDBLEIOHON(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class IKKMAALOJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public IFEGHCNBDPC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IKKMAALOJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x65E16E0", Offset = "0x65E04E0", VA = "0x1865E16E0")]
		internal Task COHJIBECGIA(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private sealed class BNPFBPIBEAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public IKKMAALOJHH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BNPFBPIBEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x65D7A50", Offset = "0x65D6850", VA = "0x1865D7A50")]
		internal object FCMJHMLNJKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x65D7B10", Offset = "0x65D6910", VA = "0x1865D7B10")]
		internal object LBEPCIJOBLA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct EIGBBLNFPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public IFEGHCNBDPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public Func<IFEGHCNBDPC, GAKKIOAFLLE<string>.AGJOEKMHOHC, KLBPLCPJKOF> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IKKMAALOJHH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private KLBPLCPJKOF <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<GPALKAPGCML> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x65DA8B0", Offset = "0x65D96B0", VA = "0x1865DA8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x65DBAB0", Offset = "0x65DA8B0", VA = "0x1865DBAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct IAGEDMGIOAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x65DF550", Offset = "0x65DE350", VA = "0x1865DF550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x65DFFD0", Offset = "0x65DEDD0", VA = "0x1865DFFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct JJKHBPNOGJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public IFEGHCNBDPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x65E1810", Offset = "0x65E0610", VA = "0x1865E1810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x65E1B70", Offset = "0x65E0970", VA = "0x1865E1B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public readonly Guid JJECAHGHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public readonly ByteString EIHEPIPANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public readonly GEKJJJHLPNL JLMHFBGOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	protected readonly string DHGKKOJEJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private readonly bool LBOHPKOCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private readonly Queue<EMDBLEIOHON> FOMHHNIFLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	private readonly OBCFLGGKGFN KCNCNOOFNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly HGDMGBMIKKL CPIHABMOFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private bool HKFJHJKBLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	public PPMHDMBDFMJ DFNBGOFAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public PPMHDMBDFMJ DCJAPFFFKPC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IHLIMGHFCMP EGABLPPILFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x65E0FB0", Offset = "0x65DFDB0", VA = "0x1865E0FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public AJHHBOLKMEO OLLNEGCHHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x65E0C20", Offset = "0x65DFA20", VA = "0x1865E0C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x65E1000", Offset = "0x65DFE00", VA = "0x1865E1000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event LJHDLCEKKCK HPGGPGNCECM
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x65E0EA0", Offset = "0x65DFCA0", VA = "0x1865E0EA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x65E1340", Offset = "0x65E0140", VA = "0x1865E1340", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x65E1440", Offset = "0x65E0240", VA = "0x1865E1440")]
	protected IFEGHCNBDPC(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ, string MIKLEJNHJHA, HGDMGBMIKKL CPIHABMOFML, bool LBOHPKOCPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x65E1080", Offset = "0x65DFE80", VA = "0x1865E1080", Slot = "6")]
	protected virtual string KAHMDHHCFPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x65E13E0", Offset = "0x65E01E0", VA = "0x1865E13E0")]
	public void PNPKHGLOOPM(EMDBLEIOHON MICMNEHFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x65E0C70", Offset = "0x65DFA70", VA = "0x1865E0C70")]
	protected void EIDJGBDJOBD(float KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x65E11F0", Offset = "0x65DFFF0", VA = "0x1865E11F0")]
	[AsyncStateMachine(typeof(EIGBBLNFPGA))]
	public Task MICHEHPNDIJ(CancellationToken HHBHDBLGMFA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, [Optional] Func<IFEGHCNBDPC, GAKKIOAFLLE<string>.AGJOEKMHOHC, KLBPLCPJKOF> GFGNCNGHIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x65E10C0", Offset = "0x65DFEC0", VA = "0x1865E10C0")]
	[AsyncStateMachine(typeof(IAGEDMGIOAP))]
	private static Task LJHMKDOPKOJ(Func<CancellationToken, Task> OMIFDGHHHEH, Func<CancellationToken, Task> MDLEGCBFAAB, CancellationToken JPLHPFGGALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x65E0AD0", Offset = "0x65DF8D0", VA = "0x1865E0AD0")]
	private void AHBEHJMFJLL(bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x65E0EC0", Offset = "0x65DFCC0", VA = "0x1865E0EC0")]
	private void HFAGGBBBBOA(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x65E0D80", Offset = "0x65DFB80", VA = "0x1865E0D80")]
	[AsyncStateMachine(typeof(JJKHBPNOGJA))]
	private Task GKENNFFIGPL(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x65E1360", Offset = "0x65E0160", VA = "0x1865E1360")]
	public GPALKAPGCML NNLPCONGPBF(HNACEJGGJPE GHLLAEAIJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x65E0C90", Offset = "0x65DFA90", VA = "0x1865E0C90")]
	[CompilerGenerated]
	private Task FNPLKLAFAIF(CancellationToken GBMCNPIMCLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal sealed class KBAPPHCOIGB : LNKACMDBFFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct ADLKBBBIAEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public KBAPPHCOIGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private PLLNCCBDCKN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private BCKAKNDMCGG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x65D28A0", Offset = "0x65D16A0", VA = "0x1865D28A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x65D3010", Offset = "0x65D1E10", VA = "0x1865D3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private readonly MIGCEKPLBCD LGKHCAIHLEN;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x65E2800", Offset = "0x65E1600", VA = "0x1865E2800")]
	public KBAPPHCOIGB(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, MIGCEKPLBCD LGKHCAIHLEN, GEKJJJHLPNL LPLLEIGGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x65E26B0", Offset = "0x65E14B0", VA = "0x1865E26B0", Slot = "8")]
	[AsyncStateMachine(typeof(ADLKBBBIAEB))]
	protected override Task NNJJNKLLPIM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class LLFMDHPDPFN : IFEGHCNBDPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LDJHAKCHEDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public LLFMDHPDPFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private TaskAwaiter<KCEBKGLNFIO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x65E3240", Offset = "0x65E2040", VA = "0x1865E3240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x65E35F0", Offset = "0x65E23F0", VA = "0x1865E35F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private readonly string LKEDABJCIIK;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x65E5BF0", Offset = "0x65E49F0", VA = "0x1865E5BF0")]
	public LLFMDHPDPFN(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, GEKJJJHLPNL LPLLEIGGKFJ, string LKEDABJCIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x65E5AE0", Offset = "0x65E48E0", VA = "0x1865E5AE0", Slot = "7")]
	[AsyncStateMachine(typeof(LDJHAKCHEDE))]
	protected override Task KAAECEMOHHM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class FLBJKGBPILP : LNKACMDBFFD
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private sealed class JNMDKNHDALF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public JNMDKNHDALF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<KCEBKGLNFIO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private TaskAwaiter<GPALKAPGCML> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x65EC410", Offset = "0x65EB210", VA = "0x1865EC410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x65EC8D0", Offset = "0x65EB6D0", VA = "0x1865EC8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public FLBJKGBPILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public AONIJFKCNON serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public FFPAFJNHHFB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public FCLDKIKNJAB uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public JNINHFANBCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JNMDKNHDALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x65E1BD0", Offset = "0x65E09D0", VA = "0x1865E1BD0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<GPALKAPGCML> LEFPBAHGNGG(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct LGMFHCEDNLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public FLBJKGBPILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private JNMDKNHDALF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private PLLNCCBDCKN <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private BCKAKNDMCGG <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x65E3650", Offset = "0x65E2450", VA = "0x1865E3650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x65E44F0", Offset = "0x65E32F0", VA = "0x1865E44F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly KNPFMNBIIDA HFEPNKKIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private readonly int LOPPOEBHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	[CanBeNull]
	private readonly FBONFFODNOH LEICDGOKMKC;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x65DD130", Offset = "0x65DBF30", VA = "0x1865DD130")]
	public FLBJKGBPILP(Guid MBCGHBNLJEN, IHLIMGHFCMP CAJNLCEPHNN, int LOPPOEBHBNL, FBONFFODNOH LEICDGOKMKC, GEKJJJHLPNL LPLLEIGGKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x65DCE40", Offset = "0x65DBC40", VA = "0x1865DCE40", Slot = "8")]
	[AsyncStateMachine(typeof(LGMFHCEDNLL))]
	protected override Task NNJJNKLLPIM(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x65DCF80", Offset = "0x65DBD80", VA = "0x1865DCF80")]
	private void PGNABMJKEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x65DCC70", Offset = "0x65DBA70", VA = "0x1865DCC70")]
	private void EEEFELCCCDP(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, PLLNCCBDCKN CAKCKKEGKCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal abstract class LGOEPLFIONL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly IFEGHCNBDPC IGHPOLKLKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly KLBPLCPJKOF AGMELNMLOBF;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x65E4570", Offset = "0x65E3370", VA = "0x1865E4570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x65E45C0", Offset = "0x65E33C0", VA = "0x1865E45C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x65E4650", Offset = "0x65E3450", VA = "0x1865E4650")]
	protected LGOEPLFIONL(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x65E4550", Offset = "0x65E3350", VA = "0x1865E4550")]
	protected void FDPKAFHEJCK(string NNKIDHMLEPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct NCICHDGDNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public Dictionary<Guid, List<EOHKILIIFJF>> CAOCOFPCCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public Dictionary<Guid, List<EOHKILIIFJF>> KONOHPKEECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public Dictionary<Guid, List<EOHKILIIFJF>> HJJKGCOGJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public List<Guid> CJHOANOKLIO;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65E6EF0", Offset = "0x65E5CF0", VA = "0x1865E6EF0")]
	public static NCICHDGDNLF IKJEAFPPDKF(FPLJMDLJDMH ADOCEOOMFBH, PPMHDMBDFMJ EBGEDIIODLK, LMCJHJIAIGC BAAEMDIMOJD)
	{
		return default(NCICHDGDNLF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct JKKDKHMAICP
{
	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	public static JKKDKHMAICP IKNJBMGGGFK()
	{
		return default(JKKDKHMAICP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal struct KFIGKKKPOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly KEHHDGIBOGN PLCFMAFMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly ALMLFHPANKN LAFMGPJICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly string DJCBKALPECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public readonly GLFMJDNKFLA KOLMPBPLBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public readonly GLFMJDNKFLA PFPFOEJKIFC;

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x65E3080", Offset = "0x65E1E80", VA = "0x1865E3080")]
	public KFIGKKKPOJO(KEHHDGIBOGN PLCFMAFMELF, ALMLFHPANKN LAFMGPJICEH, string DJCBKALPECG, GLFMJDNKFLA KOLMPBPLBDO, GLFMJDNKFLA PFPFOEJKIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IBALPIJFNGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly KLBPLCPJKOF NMLDEEFGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly Guid KFHLFDKKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private bool BECNKAICFJI;

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x65E0030", Offset = "0x65DEE30", VA = "0x1865E0030")]
	public static IBALPIJFNGD DDEENKPIPJO(KLBPLCPJKOF NMLDEEFGJOH)
	{
		return default(IBALPIJFNGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B3710", Offset = "0x8B2510", VA = "0x1808B3710")]
	public void BFGJEFANGLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x65E0090", Offset = "0x65DEE90", VA = "0x1865E0090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x65E0190", Offset = "0x65DEF90", VA = "0x1865E0190")]
	private IBALPIJFNGD(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x65E0090", Offset = "0x65DEE90", VA = "0x1865E0090")]
	private void FAJDHOAPLDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x65E00F0", Offset = "0x65DEEF0", VA = "0x1865E00F0")]
	private Func<Guid, bool> MBNFOEAKAMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class BCKAKNDMCGG : LGOEPLFIONL, GGBPLCLBGEG
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public delegate Task<PPMHDMBDFMJ> BHHGFJEOHKD(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO NNGFPEIKHGH, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct KFFKGDJHBPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public MIGCEKPLBCD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private IBALPIJFNGD <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x65E28B0", Offset = "0x65E16B0", VA = "0x1865E28B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x65E3020", Offset = "0x65E1E20", VA = "0x1865E3020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private struct FDPMMOEBJAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public MIGCEKPLBCD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x65DC200", Offset = "0x65DB000", VA = "0x1865DC200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x65DC610", Offset = "0x65DB410", VA = "0x1865DC610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct BCFODCAOMJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public MIGCEKPLBCD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x65D5090", Offset = "0x65D3E90", VA = "0x1865D5090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x65D5520", Offset = "0x65D4320", VA = "0x1865D5520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[CompilerGenerated]
	private sealed class DCNNPJNKHFJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public AsyncTaskMethodBuilder<KFIGKKKPOJO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public DCNNPJNKHFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private KFIGKKKPOJO <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter<KFIGKKKPOJO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x65EAAD0", Offset = "0x65E98D0", VA = "0x1865EAAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x65EB260", Offset = "0x65EA060", VA = "0x1865EB260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public AsyncTaskMethodBuilder<LMCJHJIAIGC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public DCNNPJNKHFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private LMCJHJIAIGC <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter<LMCJHJIAIGC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x65EB2D0", Offset = "0x65EA0D0", VA = "0x1865EB2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0x65EB920", Offset = "0x65EA720", VA = "0x1865EB920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public DCNNPJNKHFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<PPMHDMBDFMJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private CHLGKLFCPLO <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x65E9730", Offset = "0x65E8530", VA = "0x1865E9730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x65EAA70", Offset = "0x65E9870", VA = "0x1865EAA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public MIGCEKPLBCD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public OBCFLGGKGFN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public OBCFLGGKGFN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public KFIGKKKPOJO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public OBCFLGGKGFN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public LMCJHJIAIGC phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public LECDIHBIMKG.GOEEDBCANPN <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DCNNPJNKHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x65D96D0", Offset = "0x65D84D0", VA = "0x1865D96D0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<KFIGKKKPOJO> KFDEIBLGHJK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x65D9810", Offset = "0x65D8610", VA = "0x1865D9810")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<LMCJHJIAIGC> KPJKJOBGHGA(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x65D9690", Offset = "0x65D8490", VA = "0x1865D9690")]
		internal void EFGLFEGAPOK(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x65D9590", Offset = "0x65D8390", VA = "0x1865D9590")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task DOCGLPABFAK(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct CJJBOANIHJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public MIGCEKPLBCD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private DCNNPJNKHFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter<KFIGKKKPOJO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private TaskAwaiter<LMCJHJIAIGC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x65D8920", Offset = "0x65D7720", VA = "0x1865D8920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x65D9530", Offset = "0x65D8330", VA = "0x1865D9530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct GGNDIENBFHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x65DE8D0", Offset = "0x65DD6D0", VA = "0x1865DE8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x65DF010", Offset = "0x65DDE10", VA = "0x1865DF010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct JOPMIKDPMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x65E1CF0", Offset = "0x65E0AF0", VA = "0x1865E1CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x65E2650", Offset = "0x65E1450", VA = "0x1865E2650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct AHKDKNKOFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x65D3070", Offset = "0x65D1E70", VA = "0x1865D3070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x65D41F0", Offset = "0x65D2FF0", VA = "0x1865D41F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private struct LIDJPJDDLKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x65E46B0", Offset = "0x65E34B0", VA = "0x1865E46B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x65E5A70", Offset = "0x65E4870", VA = "0x1865E5A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct EKFFDBEPACM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public PPMHDMBDFMJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public LMCJHJIAIGC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x65DBB10", Offset = "0x65DA910", VA = "0x1865DBB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x65DBDA0", Offset = "0x65DABA0", VA = "0x1865DBDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private sealed class LOMHFIDFDHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public LOMHFIDFDHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private LINFNOBOGPG <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x65EB990", Offset = "0x65EA790", VA = "0x1865EB990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x65EBFB0", Offset = "0x65EADB0", VA = "0x1865EBFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public BHHGFJEOHKD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public PPMHDMBDFMJ originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LOMHFIDFDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x65E5F70", Offset = "0x65E4D70", VA = "0x1865E5F70")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<PPMHDMBDFMJ> CJCNKHJFILJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct NNBPDCHCHFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public BHHGFJEOHKD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x65E7FF0", Offset = "0x65E6DF0", VA = "0x1865E7FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x65E84F0", Offset = "0x65E72F0", VA = "0x1865E84F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct DPFJMMHIJIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public OBCFLGGKGFN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private PPMHDMBDFMJ <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private IEnumerator<PPMHDMBDFMJ> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x65DA250", Offset = "0x65D9050", VA = "0x1865DA250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x65DA780", Offset = "0x65D9580", VA = "0x1865DA780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct BPIAJDCCINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x65D7BD0", Offset = "0x65D69D0", VA = "0x1865D7BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x65D7EE0", Offset = "0x65D6CE0", VA = "0x1865D7EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct OBAEBLHAEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public BCKAKNDMCGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x65E8680", Offset = "0x65E7480", VA = "0x1865E8680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x65E88D0", Offset = "0x65E76D0", VA = "0x1865E88D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EOHKIDCJHLO IPDEPMPIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly EOHKIDCJHLO CDLILOOBIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly PKMALFKDGHB GCFNGCNCBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private readonly GJBLCBPFPFA LMHFBLJEMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly IKDDHHDPMFG BBDPFOINNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly GPACFPBPMNF EGFEDGDPACN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private IHLIMGHFCMP EGABLPPILFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x65D5F10", Offset = "0x65D4D10", VA = "0x1865D5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event LJHDLCEKKCK HPGGPGNCECM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x65D5F60", Offset = "0x65D4D60", VA = "0x1865D5F60", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x65D67E0", Offset = "0x65D55E0", VA = "0x1865D67E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x65D6E80", Offset = "0x65D5C80", VA = "0x1865D6E80")]
	public BCKAKNDMCGG(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x65D6A20", Offset = "0x65D5820", VA = "0x1865D6A20")]
	[AsyncStateMachine(typeof(KFFKGDJHBPP))]
	public Task PENMJCIPMNN(MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x65D5D60", Offset = "0x65D4B60", VA = "0x1865D5D60")]
	[AsyncStateMachine(typeof(FDPMMOEBJAP))]
	private Task<GPALKAPGCML> FOCACAKEFOP(MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x65D68E0", Offset = "0x65D56E0", VA = "0x1865D68E0")]
	[AsyncStateMachine(typeof(BCFODCAOMJE))]
	private Task PBFECKKDJHA(MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x65D66A0", Offset = "0x65D54A0", VA = "0x1865D66A0")]
	[AsyncStateMachine(typeof(CJJBOANIHJL))]
	private Task MCFLNAJEONL(MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken ANFNEFDNECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x65D6420", Offset = "0x65D5220", VA = "0x1865D6420")]
	[AsyncStateMachine(typeof(GGNDIENBFHI))]
	private Task KHNLBNDLMDA(GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x65D5580", Offset = "0x65D4380", VA = "0x1865D5580")]
	[AsyncStateMachine(typeof(JOPMIKDPMLF))]
	private Task APKEICEFHJM(LMCJHJIAIGC OMHIFBJFAGA, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x65D5990", Offset = "0x65D4790", VA = "0x1865D5990")]
	[AsyncStateMachine(typeof(AHKDKNKOFOP))]
	private Task<PPMHDMBDFMJ> DIKKPEENGOK(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x65D60C0", Offset = "0x65D4EC0", VA = "0x1865D60C0")]
	[AsyncStateMachine(typeof(LIDJPJDDLKC))]
	private Task<PPMHDMBDFMJ> JBBNCHEJGIO(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x65D6D00", Offset = "0x65D5B00", VA = "0x1865D6D00")]
	[AsyncStateMachine(typeof(EKFFDBEPACM))]
	private Task<PPMHDMBDFMJ> PHDDLOGFPBL(PPMHDMBDFMJ EBGEDIIODLK, LMCJHJIAIGC BAAEMDIMOJD, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA, bool FIJJNFCGMIM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x65D6240", Offset = "0x65D5040", VA = "0x1865D6240")]
	private bool JGKNNJIIMMH(LMCJHJIAIGC FFHHCPPACNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x65D6B70", Offset = "0x65D5970", VA = "0x1865D6B70")]
	[AsyncStateMachine(typeof(NNBPDCHCHFF))]
	protected Task<PPMHDMBDFMJ> PFELPHAOKPM(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA, BHHGFJEOHKD EBECOMLBJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x65D5840", Offset = "0x65D4640", VA = "0x1865D5840")]
	[AsyncStateMachine(typeof(DPFJMMHIJIK))]
	private Task CIBEEDPNPBL(LMCJHJIAIGC OMHIFBJFAGA, OBCFLGGKGFN GDPGEOBPGAM, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x65D6350", Offset = "0x65D5150", VA = "0x1865D6350")]
	private void JIOEBHIDGNF(PPMHDMBDFMJ JEEJJFALFOD, OBCFLGGKGFN GDPGEOBPGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x65D63E0", Offset = "0x65D51E0", VA = "0x1865D63E0")]
	private void JPGAMHKGNEG(PPMHDMBDFMJ HJIGJBGOPNH, [Out] PPMHDMBDFMJ CMHCKGBJGMI, [Out] PPMHDMBDFMJ APHBBNBGGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x65D5D20", Offset = "0x65D4B20", VA = "0x1865D5D20")]
	private Task<KFIGKKKPOJO> FEJJOMOGAFH(MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x65D63A0", Offset = "0x65D51A0", VA = "0x1865D63A0")]
	private Task<LMCJHJIAIGC> JPEAFMJIHAE(KFIGKKKPOJO OMHIFBJFAGA, LECDIHBIMKG.GOEEDBCANPN FMHMDPBHEPJ, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x65D6550", Offset = "0x65D5350", VA = "0x1865D6550")]
	[AsyncStateMachine(typeof(BPIAJDCCINK))]
	private Task LHKANBGJBME(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA, bool CCDLBPBMJMH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x65D5AF0", Offset = "0x65D48F0", VA = "0x1865D5AF0")]
	[AsyncStateMachine(typeof(OBAEBLHAEMO))]
	private Task DMHLCLNJEFN(LMCJHJIAIGC OMHIFBJFAGA, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x65D5F80", Offset = "0x65D4D80", VA = "0x1865D5F80")]
	private Task ILHFGBFDIJH(LMCJHJIAIGC OMHIFBJFAGA, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x65D5820", Offset = "0x65D4620", VA = "0x1865D5820")]
	private Task CGFCCECBBEM(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x65D5F40", Offset = "0x65D4D40", VA = "0x1865D5F40")]
	private Task GMICMFKLDMP(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x65D56D0", Offset = "0x65D44D0", VA = "0x1865D56D0")]
	private Task CEPFCCPEDDK(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x65D6800", Offset = "0x65D5600", VA = "0x1865D6800")]
	private static Task OLEAFJPPLHA(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x65D6330", Offset = "0x65D5130", VA = "0x1865D6330")]
	private Task JIHJGOFNNPN(LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x65D5BE0", Offset = "0x65D49E0", VA = "0x1865D5BE0")]
	private Task DMKMOILLDOA(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x65D5EC0", Offset = "0x65D4CC0", VA = "0x1865D5EC0")]
	private void GBNNLACBNIP(MIGCEKPLBCD MIMLCIHLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x65D6530", Offset = "0x65D5330", VA = "0x1865D6530")]
	public void LGGCAOGOPEA(long HDGHLCECFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private static void KMIPIMFOEAF(KEHHDGIBOGN PLCFMAFMELF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct IEKGHEPIAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private LMCJHJIAIGC OMHIFBJFAGA;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x65E07B0", Offset = "0x65DF5B0", VA = "0x1865E07B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x65E09F0", Offset = "0x65DF7F0", VA = "0x1865E09F0")]
	public static Task MICHEHPNDIJ(IHLIMGHFCMP CAJNLCEPHNN, LMCJHJIAIGC OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x65E0800", Offset = "0x65DF600", VA = "0x1865E0800")]
	private void MICHEHPNDIJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal struct DPKGHBKIHJG
{
	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x65D6800", Offset = "0x65D5600", VA = "0x1865D6800")]
	public static Task MICHEHPNDIJ(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct KOMNFIHLCIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct ALOCGFPIEPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x65D4AA0", Offset = "0x65D38A0", VA = "0x1865D4AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x65D4FC0", Offset = "0x65D3DC0", VA = "0x1865D4FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x65E3100", Offset = "0x65E1F00", VA = "0x1865E3100")]
	[AsyncStateMachine(typeof(ALOCGFPIEPI))]
	public static Task MICHEHPNDIJ(KLBPLCPJKOF NMLDEEFGJOH, LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal struct HGDIGPKDKCM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct FLNDCBOMDIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private PPMHDMBDFMJ <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private IHLIMGHFCMP <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private FPLJMDLJDMH <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private LINFNOBOGPG <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private List<(PersistenceView, OBGGKDBBBAO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private OBGGKDBBBAO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x65DD1E0", Offset = "0x65DBFE0", VA = "0x1865DD1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x65DDE40", Offset = "0x65DCC40", VA = "0x1865DDE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x65DF270", Offset = "0x65DE070", VA = "0x1865DF270")]
	[AsyncStateMachine(typeof(FLNDCBOMDIG))]
	public static Task MICHEHPNDIJ(KLBPLCPJKOF NMLDEEFGJOH, LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x65DF070", Offset = "0x65DDE70", VA = "0x1865DF070")]
	private static void FIHKHHDMKHH(PersistenceView JNGHLJPLHEB, OBGGKDBBBAO BKFACKEMDIF, LMCJHJIAIGC OMHIFBJFAGA, PPMHDMBDFMJ EBGEDIIODLK, bool HCGHNOKHDBG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct MOAFMBJOIHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct PMLBGEKFLBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public IHLIMGHFCMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x65E9290", Offset = "0x65E8090", VA = "0x1865E9290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x65E96D0", Offset = "0x65E84D0", VA = "0x1865E96D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x65E6DE0", Offset = "0x65E5BE0", VA = "0x1865E6DE0")]
	[AsyncStateMachine(typeof(PMLBGEKFLBL))]
	public static Task MICHEHPNDIJ(IHLIMGHFCMP CAJNLCEPHNN, LMCJHJIAIGC OMHIFBJFAGA, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct NHBFANMGMLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private struct DGBGCDJGNHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public IHLIMGHFCMP roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x65D9930", Offset = "0x65D8730", VA = "0x1865D9930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x65D9B40", Offset = "0x65D8940", VA = "0x1865D9B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private sealed class NNHEACENIFK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013E")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public NNHEACENIFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x65EC020", Offset = "0x65EAE20", VA = "0x1865EC020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x65EC3B0", Offset = "0x65EB1B0", VA = "0x1865EC3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NNHEACENIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x65E8560", Offset = "0x65E7360", VA = "0x1865E8560")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task ABCANKPAFPP(GAKKIOAFLLE<string>.AGJOEKMHOHC timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private struct MCHOCJOJHMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public NHBFANMGMLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x65E6090", Offset = "0x65E4E90", VA = "0x1865E6090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x65E69F0", Offset = "0x65E57F0", VA = "0x1865E69F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class HHFJODHLCIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public CHJKKBHBLDL version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HHFJODHLCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x65DF470", Offset = "0x65DE270", VA = "0x1865DF470")]
		internal object DJPPGNPFCME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x65DF3C0", Offset = "0x65DE1C0", VA = "0x1865DF3C0")]
		internal object AAMKAAMEICM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private LMCJHJIAIGC OMHIFBJFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private KLBPLCPJKOF NMLDEEFGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private bool CCDLBPBMJMH;

	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private static readonly ByteString IEKJJLEBFOI;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x65E7BA0", Offset = "0x65E69A0", VA = "0x1865E7BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private HJMCDAJJEDH FBCOBBINODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x65E7BF0", Offset = "0x65E69F0", VA = "0x1865E7BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65E7CD0", Offset = "0x65E6AD0", VA = "0x1865E7CD0")]
	[AsyncStateMachine(typeof(DGBGCDJGNHI))]
	public static Task MICHEHPNDIJ(IHLIMGHFCMP CAJNLCEPHNN, LMCJHJIAIGC OMHIFBJFAGA, KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA, bool CCDLBPBMJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x65E7E20", Offset = "0x65E6C20", VA = "0x1865E7E20")]
	[AsyncStateMachine(typeof(MCHOCJOJHMP))]
	private Task MICHEHPNDIJ(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x65E7500", Offset = "0x65E6300", VA = "0x1865E7500")]
	private void HLEBMEFIGHK([NotNull] LBFMLKMCDDP OOCAEIBFMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x65E7C90", Offset = "0x65E6A90", VA = "0x1865E7C90")]
	private bool LDGFNBAKHHG(CHJKKBHBLDL ILCLKBNEPAJ, LBFMLKMCDDP OOCAEIBFMFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct DOBLBKBJIDH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct GGKGHPDLLKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		public AsyncTaskMethodBuilder<LMCJHJIAIGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		public DOBLBKBJIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		public LECDIHBIMKG.GOEEDBCANPN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private TaskAwaiter<(FBEPHKHKLJE<JCBPMOHPGAJ, KOAMPGHKKDA>, FBEPHKHKLJE<NOMKHBFBACK<LBFMLKMCDDP>, KOAMPGHKKDA>, FBEPHKHKLJE<NOMKHBFBACK<PGADOMLEMBK>, KOAMPGHKKDA>, FBEPHKHKLJE<NOMKHBFBACK<OLOGHCFCDMC>, KOAMPGHKKDA>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x65DDEA0", Offset = "0x65DCCA0", VA = "0x1865DDEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x65DE860", Offset = "0x65DD660", VA = "0x1865DE860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct CDJLALGFHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JCBPMOHPGAJ, KOAMPGHKKDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		public DOBLBKBJIDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public LECDIHBIMKG.GOEEDBCANPN downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private TaskAwaiter<FBEPHKHKLJE<JCBPMOHPGAJ, KOAMPGHKKDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x65F0020", Offset = "0x65EEE20", VA = "0x1865F0020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x65F05E0", Offset = "0x65EF3E0", VA = "0x1865F05E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	private IDNLODOLKLA<GLFMJDNKFLA, PGADOMLEMBK> AJIKEOJHNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	private IDNLODOLKLA<GLFMJDNKFLA, LBFMLKMCDDP> BDGNKKIHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private IDNLODOLKLA<long, OLOGHCFCDMC> EFKMHHHFIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private GFBFKPIFILG ADPCHDHFCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	private KEHHDGIBOGN PLCFMAFMELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private ALMLFHPANKN LAFMGPJICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private string DJCBKALPECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private GLFMJDNKFLA KOLMPBPLBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private GLFMJDNKFLA PFPFOEJKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private long HDGHLCECFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI;

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x65D9BA0", Offset = "0x65D89A0", VA = "0x1865D9BA0")]
	public static Task<LMCJHJIAIGC> EEDIJGABOOO(IHLIMGHFCMP CAJNLCEPHNN, [In] KFIGKKKPOJO OMHIFBJFAGA, LECDIHBIMKG.GOEEDBCANPN FMHMDPBHEPJ, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x65DA0C0", Offset = "0x65D8EC0", VA = "0x1865DA0C0")]
	[AsyncStateMachine(typeof(GGKGHPDLLKM))]
	private Task<LMCJHJIAIGC> MICHEHPNDIJ(LECDIHBIMKG.GOEEDBCANPN FMHMDPBHEPJ, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x65D9F10", Offset = "0x65D8D10", VA = "0x1865D9F10")]
	[AsyncStateMachine(typeof(CDJLALGFHPE))]
	private Task<FBEPHKHKLJE<JCBPMOHPGAJ, KOAMPGHKKDA>> LDLMONPHALE(string DJCBKALPECG, long HDGHLCECFGL, LECDIHBIMKG.GOEEDBCANPN FMHMDPBHEPJ, GAKKIOAFLLE<string>.AGJOEKMHOHC EJILKENLMBB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct HKHGEEEJFHM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private struct EJPKLBPAGMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public AsyncTaskMethodBuilder<KFIGKKKPOJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public HKHGEEEJFHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private TaskAwaiter<KFIGKKKPOJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x65F2670", Offset = "0x65F1470", VA = "0x1865F2670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x65F2A70", Offset = "0x65F1870", VA = "0x1865F2A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct FJEMMJOKEHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public AsyncTaskMethodBuilder<KFIGKKKPOJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public HKHGEEEJFHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private TaskAwaiter<KFIGKKKPOJO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x65F5230", Offset = "0x65F4030", VA = "0x1865F5230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x65F5660", Offset = "0x65F4460", VA = "0x1865F5660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class GPFBGGBKAGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GPFBGGBKAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x142FD20", Offset = "0x142EB20", VA = "0x18142FD20")]
		internal bool OIAGEGLBLFI(ALMLFHPANKN sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct KLKGGBMHGBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public AsyncTaskMethodBuilder<KFIGKKKPOJO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public GLFMJDNKFLA superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public FPLJMDLJDMH callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private GPFBGGBKAGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public HDMDMODGHLD roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private KEHHDGIBOGN <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private ALMLFHPANKN <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private GLFMJDNKFLA <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private GLFMJDNKFLA <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private TaskAwaiter<KEHHDGIBOGN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private TaskAwaiter<NMJKHCKLOOK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private TaskAwaiter<MFFPGPFJMLA> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x65FE760", Offset = "0x65FD560", VA = "0x1865FE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x65FF8A0", Offset = "0x65FE6A0", VA = "0x1865FF8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private PKMALFKDGHB GCFNGCNCBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private HDMDMODGHLD EDFNJPNLCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private long CGIDLDOBHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	private long NECGEBINIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private long FFOOPFLIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private string OFEONHHMBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private GLFMJDNKFLA ALPAENLEHAE;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x65F9450", Offset = "0x65F8250", VA = "0x1865F9450")]
	public static Task<KFIGKKKPOJO> EEDIJGABOOO(IHLIMGHFCMP CAJNLCEPHNN, MIGCEKPLBCD MIMLCIHLPAB, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x65F99D0", Offset = "0x65F87D0", VA = "0x1865F99D0")]
	[AsyncStateMachine(typeof(EJPKLBPAGMM))]
	private Task<KFIGKKKPOJO> MICHEHPNDIJ(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x65F9870", Offset = "0x65F8670", VA = "0x1865F9870")]
	[AsyncStateMachine(typeof(FJEMMJOKEHA))]
	private Task<KFIGKKKPOJO> FEJJOMOGAFH(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x65F96D0", Offset = "0x65F84D0", VA = "0x1865F96D0")]
	[AsyncStateMachine(typeof(KLKGGBMHGBK))]
	private static Task<KFIGKKKPOJO> FEJJOMOGAFH(FPLJMDLJDMH ADOCEOOMFBH, HDMDMODGHLD EDFNJPNLCOB, long CGIDLDOBHII, long NECGEBINIAB, long FFOOPFLIOJA, string OFEONHHMBHP, GLFMJDNKFLA ALPAENLEHAE, CancellationToken HHBHDBLGMFA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x65F9420", Offset = "0x65F8220", VA = "0x1865F9420")]
	private void BHNEBJKLADL(KEHHDGIBOGN PLCFMAFMELF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal struct PLKOJBFKBBA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct LNKIFOOMPPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public PLKOJBFKBBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6600C10", Offset = "0x65FFA10", VA = "0x186600C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x66011A0", Offset = "0x65FFFA0", VA = "0x1866011A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400054D")]
	private FPLJMDLJDMH ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400054E")]
	private LMCJHJIAIGC OMHIFBJFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400054F")]
	private GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000550")]
	private float DCDMGHLJKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000551")]
	private float PGJDKPDFPPJ;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6604C70", Offset = "0x6603A70", VA = "0x186604C70")]
	public static Task BADGECAMMCM(IHLIMGHFCMP CAJNLCEPHNN, LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x66050B0", Offset = "0x6603EB0", VA = "0x1866050B0")]
	[AsyncStateMachine(typeof(LNKIFOOMPPK))]
	public Task MICHEHPNDIJ(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6604F70", Offset = "0x6603D70", VA = "0x186604F70")]
	private static void GKBHHKPIGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6604E10", Offset = "0x6603C10", VA = "0x186604E10")]
	private void ECOHFKHAABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x6604BB0", Offset = "0x66039B0", VA = "0x186604BB0")]
	private static float AGNBFHAKDMN(FPLJMDLJDMH ADOCEOOMFBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x66051D0", Offset = "0x6603FD0", VA = "0x1866051D0")]
	private static float NFHODFADEDE()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal struct FLPJHIIBBBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct KMIKLPDDODC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public KLBPLCPJKOF operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private IFEGHCNBDPC <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private IHLIMGHFCMP <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private ABHLPJJGGCC.LLHLLKKADPJ <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x65FF910", Offset = "0x65FE710", VA = "0x1865FF910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x66002B0", Offset = "0x65FF0B0", VA = "0x1866002B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct DKNODMLJKNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x65F1DB0", Offset = "0x65F0BB0", VA = "0x1865F1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x65F20A0", Offset = "0x65F0EA0", VA = "0x1865F20A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x65F59E0", Offset = "0x65F47E0", VA = "0x1865F59E0")]
	[AsyncStateMachine(typeof(KMIKLPDDODC))]
	public static Task MICHEHPNDIJ(KLBPLCPJKOF NMLDEEFGJOH, LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x65F5970", Offset = "0x65F4770", VA = "0x1865F5970")]
	private static Task<GPALKAPGCML> KKMILFLNDIF(KLBPLCPJKOF NMLDEEFGJOH, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x65F58B0", Offset = "0x65F46B0", VA = "0x1865F58B0")]
	[AsyncStateMachine(typeof(DKNODMLJKNG))]
	private static Task JPJPKLDIGCB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal struct NLLMCIIOBBJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct IDCGIPFDBNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		public NLLMCIIOBBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x65FB530", Offset = "0x65FA330", VA = "0x1865FB530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x65FBBE0", Offset = "0x65FA9E0", VA = "0x1865FBBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private sealed class GPLMFJOKKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GPLMFJOKKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x65F8770", Offset = "0x65F7570", VA = "0x1865F8770")]
		internal object FEEFPAMBCIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct GHEKGHMKCHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public NLLMCIIOBBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private EPPOKHFEGGE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x65F6200", Offset = "0x65F5000", VA = "0x1865F6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x65F67C0", Offset = "0x65F55C0", VA = "0x1865F67C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private bool LAEOBNMPBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private CancellationToken HHBHDBLGMFA;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x6601FB0", Offset = "0x6600DB0", VA = "0x186601FB0")]
	public static Task IPGDFHNNEMJ(IHLIMGHFCMP CAJNLCEPHNN, bool LAEOBNMPBHC, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken FLADIFFJPLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x6602150", Offset = "0x6600F50", VA = "0x186602150")]
	[AsyncStateMachine(typeof(IDCGIPFDBNG))]
	private Task MICHEHPNDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x6602020", Offset = "0x6600E20", VA = "0x186602020")]
	[AsyncStateMachine(typeof(GHEKGHMKCHM))]
	private Task KMAMJOOIADB(bool BGIBKNJLMHA, string AOIKHKIKFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	private bool PPBMMJACAHN(bool LAEOBNMPBHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct OOJPFKOJJEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct GMKCCDOBFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public OOJPFKOJJEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x65F7780", Offset = "0x65F6580", VA = "0x1865F7780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x65F7CF0", Offset = "0x65F6AF0", VA = "0x1865F7CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class LLIBPIGAJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LLIBPIGAJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6600BC0", Offset = "0x65FF9C0", VA = "0x186600BC0")]
		internal object FEEFPAMBCIB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct JCHNAKGLBED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public OOJPFKOJJEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private EPPOKHFEGGE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x65FC800", Offset = "0x65FB600", VA = "0x1865FC800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x65FCDC0", Offset = "0x65FBBC0", VA = "0x1865FCDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000580")]
	private ACDLDEACLCB CBKJGOMLONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private bool HMIMDFFFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000584")]
	private LMCJHJIAIGC OMHIFBJFAGA;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x6603240", Offset = "0x6602040", VA = "0x186603240")]
	public static Task<Scene> BGGCCFLMHDM(IHLIMGHFCMP CAJNLCEPHNN, ACDLDEACLCB DGKHLKKPILE, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x66034B0", Offset = "0x66022B0", VA = "0x1866034B0")]
	[AsyncStateMachine(typeof(GMKCCDOBFHL))]
	private Task<Scene> MICHEHPNDIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x6603480", Offset = "0x6602280", VA = "0x186603480")]
	private bool LCABFIJGHEI(LMCJHJIAIGC OMHIFBJFAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x66032C0", Offset = "0x66020C0", VA = "0x1866032C0")]
	private void IJKDHDKKLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x6603330", Offset = "0x6602130", VA = "0x186603330")]
	[AsyncStateMachine(typeof(JCHNAKGLBED))]
	private Task<Scene> KMAMJOOIADB(string AOIKHKIKFNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal struct IKDDHHDPMFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct FCFOECCDFGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public IKDDHHDPMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public PPMHDMBDFMJ nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public LMCJHJIAIGC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private TaskAwaiter<PPMHDMBDFMJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x65F3720", Offset = "0x65F2520", VA = "0x1865F3720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x65F4200", Offset = "0x65F3000", VA = "0x1865F4200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct BMECBPEMBEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder<PPMHDMBDFMJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public IKDDHHDPMFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public PPMHDMBDFMJ state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x65EFC30", Offset = "0x65EEA30", VA = "0x1865EFC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x65EFF10", Offset = "0x65EED10", VA = "0x1865EFF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	private readonly KLBPLCPJKOF NMLDEEFGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private readonly PKMALFKDGHB GCFNGCNCBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private readonly GJBLCBPFPFA LMHFBLJEMIP;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private IFEGHCNBDPC IGHPOLKLKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x4ED92B0", Offset = "0x4ED80B0", VA = "0x184ED92B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x65FBF70", Offset = "0x65FAD70", VA = "0x1865FBF70")]
	public IKDDHHDPMFG(KLBPLCPJKOF NMLDEEFGJOH, PKMALFKDGHB GCFNGCNCBFM, GJBLCBPFPFA LMHFBLJEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x65FBC40", Offset = "0x65FAA40", VA = "0x1865FBC40")]
	[AsyncStateMachine(typeof(FCFOECCDFGB))]
	public Task<PPMHDMBDFMJ> AIMOECCFOPH(PPMHDMBDFMJ CKOHEOAOOEI, LMCJHJIAIGC BAAEMDIMOJD, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA, bool FIJJNFCGMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x65FBDE0", Offset = "0x65FABE0", VA = "0x1865FBDE0")]
	[AsyncStateMachine(typeof(BMECBPEMBEG))]
	private Task<PPMHDMBDFMJ> PKJONHFJHNP(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, PPMHDMBDFMJ DCBJOKKHJFC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x65FBF40", Offset = "0x65FAD40", VA = "0x1865FBF40")]
	private bool PPLMNPFLIKI(PPMHDMBDFMJ OJANHCHBEFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x65FBDC0", Offset = "0x65FABC0", VA = "0x1865FBDC0")]
	private void FDPKAFHEJCK(string BAPJOIDEOML)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct JBGAGGLCHGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct BELEOFCNGOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		public IFEGHCNBDPC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private LINFNOBOGPG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private List<(PersistenceView, OBGGKDBBBAO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private (PersistenceView, OBGGKDBBBAO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x65EF2C0", Offset = "0x65EE0C0", VA = "0x1865EF2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x65EF8D0", Offset = "0x65EE6D0", VA = "0x1865EF8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x65FC640", Offset = "0x65FB440", VA = "0x1865FC640")]
	[AsyncStateMachine(typeof(BELEOFCNGOD))]
	public static Task MICHEHPNDIJ(IFEGHCNBDPC EJLMAECJKCH, LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct BDPHJLPPJFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CompilerGenerated]
	private struct LHGJNDBGCKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public IFEGHCNBDPC operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CHLGKLFCPLO timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private CHJKKBHBLDL <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private LINFNOBOGPG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private List<(PersistenceView, OBGGKDBBBAO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private OBGGKDBBBAO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x6600310", Offset = "0x65FF110", VA = "0x186600310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x6600B60", Offset = "0x65FF960", VA = "0x186600B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x65EF180", Offset = "0x65EDF80", VA = "0x1865EF180")]
	[AsyncStateMachine(typeof(LHGJNDBGCKC))]
	public static Task MICHEHPNDIJ(IFEGHCNBDPC EJLMAECJKCH, LMCJHJIAIGC OMHIFBJFAGA, CHLGKLFCPLO CFHLPJGKMFB, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal struct ABHLPJJGGCC
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct LLHLLKKADPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public List<MKHPKNOMIPE> ABPENHECHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public List<OBGGKDBBBAO> JHBDPKFAKOL;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x89F0F0", Offset = "0x89DEF0", VA = "0x18089F0F0")]
		public LLHLLKKADPJ(List<MKHPKNOMIPE> ABPENHECHOE, List<OBGGKDBBBAO> JHBDPKFAKOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class HIEJONHHPEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public IEnumerable<MKHPKNOMIPE> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HIEJONHHPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x65F8D10", Offset = "0x65F7B10", VA = "0x1865F8D10")]
		internal object GMHAIECDLAG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private IHLIMGHFCMP CAJNLCEPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private LMCJHJIAIGC OMHIFBJFAGA;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FPLJMDLJDMH CEHOOJDJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x65ED2F0", Offset = "0x65EC0F0", VA = "0x1865ED2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x65ED340", Offset = "0x65EC140", VA = "0x1865ED340")]
	public static LLHLLKKADPJ MICHEHPNDIJ(IHLIMGHFCMP CAJNLCEPHNN, LMCJHJIAIGC OMHIFBJFAGA)
	{
		return default(LLHLLKKADPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x65ED3A0", Offset = "0x65EC1A0", VA = "0x1865ED3A0")]
	private LLHLLKKADPJ MICHEHPNDIJ()
	{
		return default(LLHLLKKADPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x65ECD40", Offset = "0x65EBB40", VA = "0x1865ECD40")]
	private LLHLLKKADPJ AJIAAINDJMF(LBFMLKMCDDP OOCAEIBFMFH, CHJKKBHBLDL ADMLGLPHLFJ)
	{
		return default(LLHLLKKADPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x65ED600", Offset = "0x65EC400", VA = "0x1865ED600")]
	private bool NBAEDGABGOB(IEnumerable<MKHPKNOMIPE> ABPENHECHOE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal struct MAJIIGCCJBM
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class KACOHCNCKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public ABHLPJJGGCC.LLHLLKKADPJ instantiations;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KACOHCNCKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x65FCF80", Offset = "0x65FBD80", VA = "0x1865FCF80")]
		internal object ABCANKPAFPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private sealed class EJGAMJHLLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EJGAMJHLLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x65F25E0", Offset = "0x65F13E0", VA = "0x1865F25E0")]
		internal object COHJIBECGIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x6601200", Offset = "0x6600000", VA = "0x186601200")]
	public static void MICHEHPNDIJ(IFEGHCNBDPC EJLMAECJKCH, LMCJHJIAIGC OMHIFBJFAGA, ABHLPJJGGCC.LLHLLKKADPJ EPMPODCIKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
internal class GJBLCBPFPFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct GPIGNFIHIDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public PPMHDMBDFMJ operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public LMCJHJIAIGC deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x65F7FA0", Offset = "0x65F6DA0", VA = "0x1865F7FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x65F8710", Offset = "0x65F7510", VA = "0x1865F8710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private sealed class ENEBMLEDEDO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public ENEBMLEDEDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x66053F0", Offset = "0x66041F0", VA = "0x1866053F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x66056B0", Offset = "0x66044B0", VA = "0x1866056B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ENEBMLEDEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x65F2AE0", Offset = "0x65F18E0", VA = "0x1865F2AE0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task IEEEEINEDNJ(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct PBIAAKGJBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private ENEBMLEDEDO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x6604190", Offset = "0x6602F90", VA = "0x186604190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x66046C0", Offset = "0x66034C0", VA = "0x1866046C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct KBGFNJHCHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		private Dictionary<Guid, List<EOHKILIIFJF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x65FE010", Offset = "0x65FCE10", VA = "0x1865FE010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x65FE5C0", Offset = "0x65FD3C0", VA = "0x1865FE5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct NNPPAOODCIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private Dictionary<Guid, List<EOHKILIIFJF>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x6602240", Offset = "0x6601040", VA = "0x186602240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x66028C0", Offset = "0x66016C0", VA = "0x1866028C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private sealed class NJIFCCBGJNE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public EOHKILIIFJF handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public NJIFCCBGJNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x66051F0", Offset = "0x6603FF0", VA = "0x1866051F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x6605390", Offset = "0x6604190", VA = "0x186605390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public IMNIBPIMBNE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public List<EOHKILIIFJF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NJIFCCBGJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x6601EC0", Offset = "0x6600CC0", VA = "0x186601EC0")]
		internal object HIGBFPLKAJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x6601DD0", Offset = "0x6600BD0", VA = "0x186601DD0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task GPFABOOJIOC(EOHKILIIFJF handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x6601CE0", Offset = "0x6600AE0", VA = "0x186601CE0")]
		internal object BFGHNNDNLOI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct EOBBFILEPEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public IMNIBPIMBNE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public List<EOHKILIIFJF> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private NJIFCCBGJNE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x65F2BD0", Offset = "0x65F19D0", VA = "0x1865F2BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x65F30A0", Offset = "0x65F1EA0", VA = "0x1865F30A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct FBLHLFNPLNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x65F3100", Offset = "0x65F1F00", VA = "0x1865F3100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x65F36C0", Offset = "0x65F24C0", VA = "0x1865F36C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class HOLIGGADPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HOLIGGADPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x65FB4C0", Offset = "0x65FA2C0", VA = "0x1865FB4C0")]
		internal object DOBEBNONLIA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct HEIDAJEHCGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public LMCJHJIAIGC data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x65F87F0", Offset = "0x65F75F0", VA = "0x1865F87F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x65F8CB0", Offset = "0x65F7AB0", VA = "0x1865F8CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class MOECOKNPDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MOECOKNPDCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x66017B0", Offset = "0x66005B0", VA = "0x1866017B0")]
		internal object HCJPBIKNEDN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct HMFCJIAHFDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public GJBLCBPFPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x65F9B20", Offset = "0x65F8920", VA = "0x1865F9B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x65FA160", Offset = "0x65F8F60", VA = "0x1865FA160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[CompilerGenerated]
	private sealed class DEKNLDPFLNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DEKNLDPFLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x65F0DF0", Offset = "0x65EFBF0", VA = "0x1865F0DF0")]
		internal object MLEGMFPGDFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private readonly KLBPLCPJKOF NMLDEEFGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private NCICHDGDNLF LMHFBLJEMIP;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IFEGHCNBDPC IGHPOLKLKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x1008500", Offset = "0x1007300", VA = "0x181008500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public GJBLCBPFPFA(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x65F7290", Offset = "0x65F6090", VA = "0x1865F7290")]
	[AsyncStateMachine(typeof(GPIGNFIHIDC))]
	public Task MICHEHPNDIJ(PPMHDMBDFMJ EBGEDIIODLK, LMCJHJIAIGC BAAEMDIMOJD, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x65F6D80", Offset = "0x65F5B80", VA = "0x1865F6D80")]
	[AsyncStateMachine(typeof(PBIAAKGJBAO))]
	private Task IBIIMKBBBBJ(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x65F7640", Offset = "0x65F6440", VA = "0x1865F7640")]
	[AsyncStateMachine(typeof(KBGFNJHCHJN))]
	private Task OFNIKFDALAP(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x65F7010", Offset = "0x65F5E10", VA = "0x1865F7010")]
	[AsyncStateMachine(typeof(NNPPAOODCIG))]
	private Task JINMCLPLLDP(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x65F6EC0", Offset = "0x65F5CC0", VA = "0x1865F6EC0")]
	[AsyncStateMachine(typeof(EOBBFILEPEA))]
	private Task JCMNFFHHMDN(Guid KCGBAGBNEDE, List<EOHKILIIFJF> KNENNBJOPDF, IMNIBPIMBNE JNHCAMHJFMF, LMCJHJIAIGC OMHIFBJFAGA, CancellationToken NBGOKNOECBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x65F73E0", Offset = "0x65F61E0", VA = "0x1865F73E0")]
	[AsyncStateMachine(typeof(FBLHLFNPLNE))]
	private Task MNHOCDCHJHM(LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x65F6B90", Offset = "0x65F5990", VA = "0x1865F6B90")]
	[AsyncStateMachine(typeof(HEIDAJEHCGK))]
	private Task DHLICIAJFCM(Guid GNHKKGAEELE, LMCJHJIAIGC OMHIFBJFAGA, GAKKIOAFLLE<string>.AGJOEKMHOHC JNIKEBIHBPI, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x65F7150", Offset = "0x65F5F50", VA = "0x1865F7150")]
	[AsyncStateMachine(typeof(HMFCJIAHFDE))]
	private Task LFEKCLBBHEJ(Guid GNHKKGAEELE, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x65F7520", Offset = "0x65F6320", VA = "0x1865F7520")]
	private void NMHGKECIJCP(Guid GNHKKGAEELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x65F6CD0", Offset = "0x65F5AD0", VA = "0x1865F6CD0")]
	private void HIGHAACBOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x65F6A00", Offset = "0x65F5800", VA = "0x1865F6A00")]
	public Guid CKJEJLMLANJ(PPMHDMBDFMJ JEEJJFALFOD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x65F6820", Offset = "0x65F5620", VA = "0x1865F6820")]
	[CompilerGenerated]
	private object BDOCAMIPPIJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public readonly struct JNINHFANBCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public readonly bool PDDBMPCAGDD;

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xC37340", Offset = "0xC36140", VA = "0x180C37340")]
	public JNINHFANBCC(bool GPMPPJJNJKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
public readonly struct KCEBKGLNFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public readonly LBFMLKMCDDP? BNBLAKJFNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	public readonly AGMIIJHAKOF EMPJNNLBILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	public readonly string? EFOMOIAHCGK;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IReadOnlyCollection<string> ACJKHAEHOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x65FE620", Offset = "0x65FD420", VA = "0x1865FE620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IReadOnlyDictionary<long, int> IAEGOBKIOED
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x65FE640", Offset = "0x65FD440", VA = "0x1865FE640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x65FE660", Offset = "0x65FD460", VA = "0x1865FE660")]
	public KCEBKGLNFIO(LBFMLKMCDDP? JJGMEBEMOEB, AGMIIJHAKOF EPCPBBHEGDF, string? DJCBKALPECG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal class AONIJFKCNON : LGOEPLFIONL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct FLPPHOADIOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public AsyncTaskMethodBuilder<KCEBKGLNFIO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		public AONIJFKCNON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		public FCLFNEOHAGE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		public FFPAFJNHHFB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private LINFNOBOGPG <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x65F5B20", Offset = "0x65F4920", VA = "0x1865F5B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x65F6190", Offset = "0x65F4F90", VA = "0x1865F6190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class BLGFAMDKEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public FCLFNEOHAGE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public AONIJFKCNON <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BLGFAMDKEFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x65EF930", Offset = "0x65EE730", VA = "0x1865EF930")]
		internal Task GBEMALHIGBG(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x65EFB50", Offset = "0x65EE950", VA = "0x1865EFB50")]
		internal Task POAJJGCDFFE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private sealed class ODLCEBIBEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public BLGFAMDKEFM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public ODLCEBIBEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6602920", Offset = "0x6601720", VA = "0x186602920")]
		internal object LJOEFNDBAIA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private sealed class FLFECNAFELM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public BLGFAMDKEFM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public FLFECNAFELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x65F5870", Offset = "0x65F4670", VA = "0x1865F5870")]
		internal Task ENGOPBGMAFL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private struct FICOOJCMOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public FCLFNEOHAGE serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public AONIJFKCNON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private ODLCEBIBEFJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private LINFNOBOGPG <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x65F4960", Offset = "0x65F3760", VA = "0x1865F4960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x65F51D0", Offset = "0x65F3FD0", VA = "0x1865F51D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private static readonly TimeSpan OICHINJHCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private readonly IGGKILFIFEK CIKDMGDKFAF;

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x65EEB40", Offset = "0x65ED940", VA = "0x1865EEB40")]
	public AONIJFKCNON(KLBPLCPJKOF NMLDEEFGJOH, IGGKILFIFEK CIKDMGDKFAF, KNPFMNBIIDA PGKJJCPHNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x65EE280", Offset = "0x65ED080", VA = "0x1865EE280")]
	[AsyncStateMachine(typeof(FLPPHOADIOD))]
	public Task<KCEBKGLNFIO> FILLENIGNNA(long NECGEBINIAB, FFPAFJNHHFB KCFOCIPAKBM, FCLFNEOHAGE GHPEJLLJDJL, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x65EDAF0", Offset = "0x65EC8F0", VA = "0x1865EDAF0")]
	[AsyncStateMachine(typeof(FICOOJCMOND))]
	private Task ADACAJBDMOC(FCLFNEOHAGE GHPEJLLJDJL, IEnumerable<PersistenceView> KIOEBKJIKLA, StringBuilder KBLOLCIOKDA, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x65EDC30", Offset = "0x65ECA30", VA = "0x1865EDC30")]
	private KCEBKGLNFIO EDFMABCDBLH(long NECGEBINIAB, FFPAFJNHHFB KCFOCIPAKBM, FCLFNEOHAGE GHPEJLLJDJL, IEnumerable<PersistenceView> KIOEBKJIKLA, StringBuilder KBLOLCIOKDA)
	{
		return default(KCEBKGLNFIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x65EE0C0", Offset = "0x65ECEC0", VA = "0x1865EE0C0")]
	private LBFMLKMCDDP FHADJIJDAFM(long NECGEBINIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x65EE3E0", Offset = "0x65ED1E0", VA = "0x1865EE3E0")]
	private void ONBAEDJHHMC(LBFMLKMCDDP DDONBMNOMIG, StringBuilder KBLOLCIOKDA, IEnumerable<PersistenceView> KIOEBKJIKLA, [In] MNNMMOFPILD MGGKKMBDFDL, CHFBMNGAMPB ABLFODBKLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x65EE630", Offset = "0x65ED430", VA = "0x1865EE630")]
	private void PGAEPFNDDFG(LBFMLKMCDDP DDONBMNOMIG, StringBuilder KBLOLCIOKDA, PersistenceView JNGHLJPLHEB, CHFBMNGAMPB ABLFODBKLDD, [In] MNNMMOFPILD MGGKKMBDFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class FCLDKIKNJAB : LGOEPLFIONL
{
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private sealed class DLOPJGHCMOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public DLJOHAEOFOF.FNFILMIPHID roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DLOPJGHCMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x65F2100", Offset = "0x65F0F00", VA = "0x1865F2100")]
		internal object FINEGIFPCDB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct OOCFNNKOMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public AsyncTaskMethodBuilder<(DLJOHAEOFOF.FNFILMIPHID roomDataUpload, DLJOHAEOFOF.FNFILMIPHID subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public KCEBKGLNFIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public FCLDKIKNJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private DLOPJGHCMOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private TaskAwaiter<DLJOHAEOFOF.FNFILMIPHID> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x6602990", Offset = "0x6601790", VA = "0x186602990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x66031D0", Offset = "0x6601FD0", VA = "0x1866031D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct HJOOMPGAAHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public AsyncTaskMethodBuilder<JOHBNOCABDJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public FCLDKIKNJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public KCEBKGLNFIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public FBONFFODNOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private TaskAwaiter<(DLJOHAEOFOF.FNFILMIPHID roomDataUpload, DLJOHAEOFOF.FNFILMIPHID subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private TaskAwaiter<JOHBNOCABDJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x65F8D90", Offset = "0x65F7B90", VA = "0x1865F8D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x65F93B0", Offset = "0x65F81B0", VA = "0x1865F93B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	private struct DOPBLMHIEJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		public AsyncTaskMethodBuilder<NMJKHCKLOOK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		public FCLDKIKNJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public KCEBKGLNFIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private TaskAwaiter<(DLJOHAEOFOF.FNFILMIPHID roomDataUpload, DLJOHAEOFOF.FNFILMIPHID subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private TaskAwaiter<NMJKHCKLOOK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x65F2150", Offset = "0x65F0F50", VA = "0x1865F2150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x65F2570", Offset = "0x65F1370", VA = "0x1865F2570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private sealed class APEFMEANNIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			public APEFMEANNIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private GPALKAPGCML <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			private TaskAwaiter<NMJKHCKLOOK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private TaskAwaiter<JOHBNOCABDJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private TaskAwaiter<GPALKAPGCML> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x6605710", Offset = "0x6604510", VA = "0x186605710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x66066A0", Offset = "0x66054A0", VA = "0x1866066A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public FCLDKIKNJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public KCEBKGLNFIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public FBONFFODNOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public JNINHFANBCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public APEFMEANNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x65EEB90", Offset = "0x65ED990", VA = "0x1865EEB90")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<GPALKAPGCML> GEDHOGNMEHA(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct DDJHJHABCKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		public AsyncTaskMethodBuilder<GPALKAPGCML> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		public FCLDKIKNJAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		public KCEBKGLNFIO roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public FBONFFODNOH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public JNINHFANBCC roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<GPALKAPGCML> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x65F0A70", Offset = "0x65EF870", VA = "0x1865F0A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x65F0D80", Offset = "0x65EFB80", VA = "0x1865F0D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private static readonly KNPFMNBIIDA HFEPNKKIBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private readonly OKIDLBPFEKG HAKPKHECCHG;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private IHLIMGHFCMP EGABLPPILFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x65D5F10", Offset = "0x65D4D10", VA = "0x1865D5F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x65F48D0", Offset = "0x65F36D0", VA = "0x1865F48D0")]
	public FCLDKIKNJAB(KLBPLCPJKOF NMLDEEFGJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x65F4410", Offset = "0x65F3210", VA = "0x1865F4410")]
	[AsyncStateMachine(typeof(OOCFNNKOMFG))]
	private Task<(DLJOHAEOFOF.FNFILMIPHID, DLJOHAEOFOF.FNFILMIPHID)> ELJAIMALPGJ(KCEBKGLNFIO OJIODHBMPBL, long CGIDLDOBHII, long FDDHOJFABCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x65F46C0", Offset = "0x65F34C0", VA = "0x1865F46C0")]
	[AsyncStateMachine(typeof(HJOOMPGAAHD))]
	public Task<JOHBNOCABDJ> PPJFFABKMJH(int LOPPOEBHBNL, [CanBeNull] FBONFFODNOH LEICDGOKMKC, KCEBKGLNFIO OJIODHBMPBL, long CGIDLDOBHII, long FDDHOJFABCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x65F4550", Offset = "0x65F3350", VA = "0x1865F4550")]
	[AsyncStateMachine(typeof(DOPBLMHIEJI))]
	private Task<NMJKHCKLOOK> FMPJIKLAEIJ(string OFEONHHMBHP, int LOPPOEBHBNL, KCEBKGLNFIO OJIODHBMPBL, long CGIDLDOBHII, long FDDHOJFABCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x65F4270", Offset = "0x65F3070", VA = "0x1865F4270")]
	[AsyncStateMachine(typeof(DDJHJHABCKP))]
	public Task<GPALKAPGCML> DCKOLFEJGJM(int LOPPOEBHBNL, FBONFFODNOH? LEICDGOKMKC, KCEBKGLNFIO OJIODHBMPBL, long CGIDLDOBHII, long FDDHOJFABCM, JNINHFANBCC KFLMOAHLHGB, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public abstract class KLMFOIJKOAP<T> where T : KLMFOIJKOAP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068E")]
	internal readonly IHLIMGHFCMP DLCEJMMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private int? ILIGHKJOEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	protected readonly Guid JJECAHGHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	protected readonly LFKCPECOHNF ECFOOLFPDIB;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	protected T MOCHACIJIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B0A4D0", Offset = "0x3B092D0", VA = "0x183B0A4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A530", Offset = "0x3B09330", VA = "0x183B0A530")]
	internal KLMFOIJKOAP(IHLIMGHFCMP GNDNNJHCHEL, LFKCPECOHNF IFKFMEODFKA, [Optional] Guid? MBCGHBNLJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A240", Offset = "0x3B09040", VA = "0x183B0A240")]
	private GPALKAPGCML HNIMPOJLGOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	protected virtual void MHABMKGIGIO(GPALKAPGCML EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A320", Offset = "0x3B09120", VA = "0x183B0A320")]
	public T JOFOAMKPODF(MNFCKJNKANA NGFKMPBFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A1B0", Offset = "0x3B08FB0", VA = "0x183B0A1B0")]
	public T EAMNNCFFFLL(int LAAHDJJIIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A3B0", Offset = "0x3B091B0", VA = "0x183B0A3B0", Slot = "5")]
	public virtual Task<OMGIPDGCLFM> KHDIECABHJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
public class FJGLMBPEPDP : KLMFOIJKOAP<FJGLMBPEPDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	private MIGCEKPLBCD FCMJAHOHNCO;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x65F57A0", Offset = "0x65F45A0", VA = "0x1865F57A0")]
	internal FJGLMBPEPDP(IHLIMGHFCMP GNDNNJHCHEL, LFKCPECOHNF IFKFMEODFKA, [Optional] Guid? MBCGHBNLJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x5C5AEC0", Offset = "0x5C59CC0", VA = "0x185C5AEC0")]
	public FJGLMBPEPDP NOLAAIDLBCA(MIGCEKPLBCD FCMJAHOHNCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x65F56D0", Offset = "0x65F44D0", VA = "0x1865F56D0", Slot = "4")]
	protected override void MHABMKGIGIO(GPALKAPGCML EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
public class PIOMBPDNICP : KLMFOIJKOAP<PIOMBPDNICP>
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal enum HHBLPOGKPIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private struct CPFFCCCCPCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		public AsyncTaskMethodBuilder<OMGIPDGCLFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		public PIOMBPDNICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private TaskAwaiter<OMGIPDGCLFM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x65F0650", Offset = "0x65EF450", VA = "0x1865F0650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x65F0A00", Offset = "0x65EF800", VA = "0x1865F0A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	private HHBLPOGKPIH JLCPGCPHANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	private string OAOEOECLINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private FBONFFODNOH FCMJAHOHNCO;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x6604A40", Offset = "0x6603840", VA = "0x186604A40")]
	internal PIOMBPDNICP(IHLIMGHFCMP GNDNNJHCHEL, LFKCPECOHNF IFKFMEODFKA, [Optional] Guid? MBCGHBNLJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x6604720", Offset = "0x6603520", VA = "0x186604720")]
	public PIOMBPDNICP GIPFJDLBNDO(string JFBABPIJMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x6604750", Offset = "0x6603550", VA = "0x186604750")]
	public PIOMBPDNICP KDCFFNBKDJE(bool FHLLGGNCCKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x6604A10", Offset = "0x6603810", VA = "0x186604A10")]
	public PIOMBPDNICP OIGDOCNPNCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x6604860", Offset = "0x6603660", VA = "0x186604860", Slot = "4")]
	protected override void MHABMKGIGIO(GPALKAPGCML EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x6604770", Offset = "0x6603570", VA = "0x186604770", Slot = "5")]
	[AsyncStateMachine(typeof(CPFFCCCCPCN))]
	public override Task<OMGIPDGCLFM> KHDIECABHJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x66049D0", Offset = "0x66037D0", VA = "0x1866049D0")]
	[DebuggerHidden]
	[CompilerGenerated]
	private Task<OMGIPDGCLFM> NEBKDILPNOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal static class GPGHIEOGGFF
{
	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x65F7E50", Offset = "0x65F6C50", VA = "0x1865F7E50")]
	public static void PDHJLJECNMC(this IAMLLOCNKFO AOADMEILCOA, EJEIFLCIKHD KMPDFMEOLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x65F7DD0", Offset = "0x65F6BD0", VA = "0x1865F7DD0")]
	public static void HGNGECEJEAP(this EJEIFLCIKHD BKHNKMBACHF, [Optional] string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
public static class JDMANKFJEJB
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x65FCE30", Offset = "0x65FBC30", VA = "0x1865FCE30")]
	public static GLFMJDNKFLA CGLEJIKHDOD(this EBEKGCHOIDD IIJCBCEMIGK)
	{
		return default(GLFMJDNKFLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x65FCED0", Offset = "0x65FBCD0", VA = "0x1865FCED0")]
	public static EBEKGCHOIDD HGFFNOAPCFJ(this GLFMJDNKFLA HJNGLMDKGHM)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public GPBCNGKODLJ ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public GPBCNGKODLJ HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private static GPBCNGKODLJ[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private Dictionary<GPBCNGKODLJ, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x6606DA0", Offset = "0x6605BA0", VA = "0x186606DA0")]
		public bool BJEOMJNBBCP(GPBCNGKODLJ FBNLHBPPKOC, [Out] ResultConfig LLPOOCEMMPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x6607560", Offset = "0x6606360", VA = "0x186607560")]
		public ResultConfig PHJNEBAIKIM(GPBCNGKODLJ IIMECKHJEHG, [Optional] HashSet<GPBCNGKODLJ> KHHOKPBANBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x6607370", Offset = "0x6606170", VA = "0x186607370", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x6606E10", Offset = "0x6605C10", VA = "0x186606E10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x831660", Offset = "0x830460", VA = "0x180831660")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public static class BAECJJKAJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x65EECC0", Offset = "0x65EDAC0", VA = "0x1865EECC0")]
	[NAAAALLPNIA(PBKIGNPNCFO.GameOnly)]
	private static void LDHJJHENCJM(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public interface EMHEAHMEPJK : IEquatable<EMHEAHMEPJK>
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	DateTime HDKPOOLDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAIIKIMBAII();

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OODIGFMPINE(long CGIDLDOBHII, long NECGEBINIAB, [Out] KCEBKGLNFIO OJIODHBMPBL);
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
internal class PALAOGPOAFE : BICCKJNHNDG
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private sealed class GNMABPBOMBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public CJNNGPMEKJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GNMABPBOMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x65F7D60", Offset = "0x65F6B60", VA = "0x1865F7D60")]
		internal object IIPHMHOIPKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly CKAMDLJHIGH HMBKOKLEGHC;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<EMHEAHMEPJK> EGBPKPLDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6603960", Offset = "0x6602760", VA = "0x186603960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6603A10", Offset = "0x6602810", VA = "0x186603A10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	[UnityEngine.Scripting.Preserve]
	public PALAOGPOAFE([LICAMFFCLCL(null)] CKAMDLJHIGH HMBKOKLEGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x66035D0", Offset = "0x66023D0", VA = "0x1866035D0", Slot = "6")]
	public bool ACKGHOOKJKP(long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL, CJNNGPMEKJP KGAGAFGNMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x1964640", Offset = "0x1963440", VA = "0x181964640")]
	private void FOAGIIJDHBM(EMHEAHMEPJK ABCDHNPFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x6603BF0", Offset = "0x66029F0", VA = "0x186603BF0", Slot = "7")]
	public bool INNMMGGMAOG(long CGIDLDOBHII, long NECGEBINIAB, [Out] EMHEAHMEPJK BFMMNLLBIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x66038B0", Offset = "0x66026B0", VA = "0x1866038B0", Slot = "8")]
	public bool CGDCNKCFGNO(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, [Out] EMHEAHMEPJK BFMMNLLBIHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x6603D60", Offset = "0x6602B60", VA = "0x186603D60")]
	private void NCAMPKHOANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x6603AC0", Offset = "0x66028C0", VA = "0x186603AC0", Slot = "9")]
	public void HABFECHEHNP(long CGIDLDOBHII, long NECGEBINIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
internal abstract class HNGDGIDIPOH : CKAMDLJHIGH
{
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	protected enum GDOMBPAINDD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class DHHEAILLONG : IEnumerable<EMHEAHMEPJK>, IEnumerable, IEnumerator<EMHEAHMEPJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private EMHEAHMEPJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public HNGDGIDIPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		private CJNNGPMEKJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public CJNNGPMEKJP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		private EMHEAHMEPJK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public DHHEAILLONG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x65F0E60", Offset = "0x65EFC60", VA = "0x1865F0E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x65F1140", Offset = "0x65EFF40", VA = "0x1865F1140", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x65F1090", Offset = "0x65EFE90", VA = "0x1865F1090", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EMHEAHMEPJK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x65F1090", Offset = "0x65EFE90", VA = "0x1865F1090", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private sealed class BPPMLADNGPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CJNNGPMEKJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public BPPMLADNGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x65EFF80", Offset = "0x65EED80", VA = "0x1865EFF80")]
		internal object BCJIPDDLCJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private sealed class JBJBMLNKCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public HNGDGIDIPOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JBJBMLNKCJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x65FC780", Offset = "0x65FB580", VA = "0x1865FC780")]
		internal void MGIFHOLDCDC(OOHIOGBEIAI.FMDHOEOACBD ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	protected readonly string OMAEJMKAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly object POPMNOBHLHE;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x65FB420", Offset = "0x65FA220", VA = "0x1865FB420")]
	protected HNGDGIDIPOH([CanBeNull] string JEEHDLMILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x65FAA20", Offset = "0x65F9820", VA = "0x1865FAA20", Slot = "5")]
	public bool CAFGMPLPBFK(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, [Out] EMHEAHMEPJK ABCDHNPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x65FAC10", Offset = "0x65F9A10", VA = "0x1865FAC10", Slot = "6")]
	[IteratorStateMachine(typeof(DHHEAILLONG))]
	public IEnumerable<EMHEAHMEPJK> EJAHECKIMDN(CJNNGPMEKJP KGAGAFGNMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FLMHNAMPIGO(Stream NKJGCHKMNKP, long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool OFICOHJMHCK(Stream ECIAHNIPLNP, long CGIDLDOBHII, long NECGEBINIAB, KBOJNHEBMNH EJHFKPLKBHH, [Out] KCEBKGLNFIO OJIODHBMPBL);

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x65FACA0", Offset = "0x65F9AA0", VA = "0x1865FACA0", Slot = "7")]
	public EMHEAHMEPJK MJAFPNBILMA(long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL, CJNNGPMEKJP KGAGAFGNMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NAKIPNDLLEN(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo CJPHJEFMKEC(CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x65FB020", Offset = "0x65F9E20", VA = "0x1865FB020")]
	protected void OBIECCHGCHH(OOHIOGBEIAI.FMDHOEOACBD JJCOMCMGECF, string BAPJOIDEOML, FileInfo KIPAKKJPAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x65FB090", Offset = "0x65F9E90", VA = "0x1865FB090")]
	internal bool PBICKMHEOKE(FileInfo ODOAPHHKAKH, long CGIDLDOBHII, long NECGEBINIAB, [Out] KCEBKGLNFIO OJIODHBMPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	private void IGNFIFGJIBE(Exception ICJFBBEMBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
internal class DIHKJAKDBJO : HNGDGIDIPOH
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public override JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC750", Offset = "0xAAB550", VA = "0x180AAC750", Slot = "8")]
		get
		{
			return default(JINAGMAFFBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x65F1CF0", Offset = "0x65F0AF0", VA = "0x1865F1CF0")]
	public DIHKJAKDBJO([Optional] string JEEHDLMILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x65F1530", Offset = "0x65F0330", VA = "0x1865F1530")]
	private void GNLDBNICHJE(CJNNGPMEKJP KGAGAFGNMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x65F12A0", Offset = "0x65F00A0", VA = "0x1865F12A0", Slot = "9")]
	internal override void FLMHNAMPIGO(Stream NKJGCHKMNKP, long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x65F16A0", Offset = "0x65F04A0", VA = "0x1865F16A0", Slot = "10")]
	internal override bool OFICOHJMHCK(Stream ECIAHNIPLNP, long CGIDLDOBHII, long NECGEBINIAB, KBOJNHEBMNH EJHFKPLKBHH, [Out] KCEBKGLNFIO OJIODHBMPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x65F15B0", Offset = "0x65F03B0", VA = "0x1865F15B0", Slot = "11")]
	protected override FileInfo NAKIPNDLLEN(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x65F1190", Offset = "0x65EFF90", VA = "0x1865F1190", Slot = "12")]
	protected override DirectoryInfo CJPHJEFMKEC(CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal sealed class KAMELIBFJCM : HNGDGIDIPOH
{
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	private static readonly byte[] JCMGBFKGKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	private readonly byte[] AHLPAHMMNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private readonly byte[] HHNCAENEKJB;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public override JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x55230E0", Offset = "0x5521EE0", VA = "0x1855230E0", Slot = "8")]
		get
		{
			return default(JINAGMAFFBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x65FDEB0", Offset = "0x65FCCB0", VA = "0x1865FDEB0")]
	public KAMELIBFJCM([Optional] string JEEHDLMILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x65FD140", Offset = "0x65FBF40", VA = "0x1865FD140", Slot = "9")]
	internal override void FLMHNAMPIGO(Stream NKJGCHKMNKP, long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x65FD5F0", Offset = "0x65FC3F0", VA = "0x1865FD5F0", Slot = "10")]
	internal override bool OFICOHJMHCK(Stream ECIAHNIPLNP, long CGIDLDOBHII, long NECGEBINIAB, KBOJNHEBMNH EJHFKPLKBHH, [Out] KCEBKGLNFIO OJIODHBMPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x65FD400", Offset = "0x65FC200", VA = "0x1865FD400")]
	private void HPIADPGBPHA(byte[] JAHCJGGEGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x65FD4C0", Offset = "0x65FC2C0", VA = "0x1865FD4C0", Slot = "11")]
	protected override FileInfo NAKIPNDLLEN(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x65FD030", Offset = "0x65FBE30", VA = "0x1865FD030", Slot = "12")]
	protected override DirectoryInfo CJPHJEFMKEC(CJNNGPMEKJP KGAGAFGNMKC, GDOMBPAINDD DICGPLLCNDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public enum JINAGMAFFBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
internal class HMJIIBNGKBF : CKAMDLJHIGH
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[CompilerGenerated]
	private sealed class NFLAKECJDBP : IEnumerable<EMHEAHMEPJK>, IEnumerable, IEnumerator<EMHEAHMEPJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private EMHEAHMEPJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		public HMJIIBNGKBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private CJNNGPMEKJP autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		public CJNNGPMEKJP <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private JINAGMAFFBC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private IEnumerator<EMHEAHMEPJK> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		private EMHEAHMEPJK System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public NFLAKECJDBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x6601C50", Offset = "0x6600A50", VA = "0x186601C50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x6601820", Offset = "0x6600620", VA = "0x186601820", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x6601B00", Offset = "0x6600900", VA = "0x186601B00")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x6601C00", Offset = "0x6600A00", VA = "0x186601C00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x6601B50", Offset = "0x6600950", VA = "0x186601B50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EMHEAHMEPJK> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6601B50", Offset = "0x6600950", VA = "0x186601B50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private readonly JINAGMAFFBC[] IHCEHELJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private readonly Dictionary<JINAGMAFFBC, CKAMDLJHIGH> MODKGAGIFGP;

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x65FA3A0", Offset = "0x65F91A0", VA = "0x1865FA3A0", Slot = "4")]
		get
		{
			return default(JINAGMAFFBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x65FA6D0", Offset = "0x65F94D0", VA = "0x1865FA6D0")]
	[UnityEngine.Scripting.Preserve]
	public HMJIIBNGKBF(params CKAMDLJHIGH[] NEBCOOEFHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x65FA1C0", Offset = "0x65F8FC0", VA = "0x1865FA1C0", Slot = "5")]
	public bool CAFGMPLPBFK(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, [Out] EMHEAHMEPJK ABCDHNPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x65FA3D0", Offset = "0x65F91D0", VA = "0x1865FA3D0")]
	private void HMMNHBFFEPL(int CLAHMDJHPCD, long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x65FA310", Offset = "0x65F9110", VA = "0x1865FA310", Slot = "6")]
	[IteratorStateMachine(typeof(NFLAKECJDBP))]
	public IEnumerable<EMHEAHMEPJK> EJAHECKIMDN(CJNNGPMEKJP KGAGAFGNMKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x65FA5F0", Offset = "0x65F93F0", VA = "0x1865FA5F0", Slot = "7")]
	public EMHEAHMEPJK MJAFPNBILMA(long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL, CJNNGPMEKJP KGAGAFGNMKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
internal static class AMAJIGEDLAA
{
	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x65ED850", Offset = "0x65EC650", VA = "0x1865ED850")]
	internal static byte[] EGAHEEKDCJJ(byte[] JAHCJGGEGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x65ED7D0", Offset = "0x65EC5D0", VA = "0x1865ED7D0")]
	public static void BOBGCNHGJGL(Stream MKCMLPKFPPN, byte[] BPNAEOFGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x65ED910", Offset = "0x65EC710", VA = "0x1865ED910")]
	public static bool HAIKCLMDOGN(Stream MKCMLPKFPPN, long PCNEMIKINFB, KBOJNHEBMNH IMLJBMDAGJJ, [Out] byte[] PFBBLDKGNHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal sealed class IPFIPGELAFE : EMHEAHMEPJK, IEquatable<EMHEAHMEPJK>, IEquatable<IPFIPGELAFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private readonly HNGDGIDIPOH ACPPIHCMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	public readonly FileInfo ECLMPAEMGAF;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1F052B0", Offset = "0x1F040B0", VA = "0x181F052B0", Slot = "9")]
		get
		{
			return default(JINAGMAFFBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DateTime HDKPOOLDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x65FC320", Offset = "0x65FB120", VA = "0x1865FC320", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x65FC530", Offset = "0x65FB330", VA = "0x1865FC530")]
	public IPFIPGELAFE(HNGDGIDIPOH IDGDHHJIOCG, FileInfo ODOAPHHKAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x65FC480", Offset = "0x65FB280", VA = "0x1865FC480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x65FBFD0", Offset = "0x65FADD0", VA = "0x1865FBFD0", Slot = "5")]
	public void BAIIKIMBAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x65FC440", Offset = "0x65FB240", VA = "0x1865FC440", Slot = "6")]
	public bool OODIGFMPINE(long CGIDLDOBHII, long NECGEBINIAB, [Out] KCEBKGLNFIO OJIODHBMPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x65FC090", Offset = "0x65FAE90", VA = "0x1865FC090", Slot = "7")]
	public bool Equals(EMHEAHMEPJK FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x65FC260", Offset = "0x65FB060", VA = "0x1865FC260", Slot = "8")]
	public bool Equals(IPFIPGELAFE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x65FC170", Offset = "0x65FAF70", VA = "0x1865FC170", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x65FC3B0", Offset = "0x65FB1B0", VA = "0x1865FC3B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public delegate void KBOJNHEBMNH(OOHIOGBEIAI.FMDHOEOACBD LPNMKDLKDPP, string EMKENBOOEOH);
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal interface CKAMDLJHIGH
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	JINAGMAFFBC GHNNPHNLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAFGMPLPBFK(long CGIDLDOBHII, long NECGEBINIAB, CJNNGPMEKJP KGAGAFGNMKC, [Out] EMHEAHMEPJK ABCDHNPFOAB);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<EMHEAHMEPJK> EJAHECKIMDN(CJNNGPMEKJP KGAGAFGNMKC);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMHEAHMEPJK MJAFPNBILMA(long CGIDLDOBHII, long NECGEBINIAB, KCEBKGLNFIO OJIODHBMPBL, CJNNGPMEKJP KGAGAFGNMKC);
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
