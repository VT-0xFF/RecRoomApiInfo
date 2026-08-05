using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8297A60", Offset = "0x8296860", VA = "0x188297A60", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GLPHBDOKMGK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8290B80", Offset = "0x828F980", VA = "0x188290B80")]
	public static void IABALGJGCCP(this Rigidbody OBAPGEABIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8290D10", Offset = "0x828FB10", VA = "0x188290D10")]
	public static void IABALGJGCCP(this Rigidbody OBAPGEABIGN, Vector3 AKFOCAPNEJG, Quaternion EOMJHFCHJBF, Vector3 FCKMEJIKFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct OEPFMPMHIKM : IReadOnlyList<JDKDDPDJCCM>, IEnumerable<JDKDDPDJCCM>, IEnumerable, IReadOnlyCollection<JDKDDPDJCCM>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FFJLONIPPFH : IEnumerator<JDKDDPDJCCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly BPAIJKJGNLD NMBGECILFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator DOHHLDONBML;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JDKDDPDJCCM BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x828FA10", Offset = "0x828E810", VA = "0x18828FA10", Slot = "4")]
			get
			{
				return default(JDKDDPDJCCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x828F9C0", Offset = "0x828E7C0", VA = "0x18828F9C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53D9CB0", Offset = "0x53D8AB0", VA = "0x1853D9CB0")]
		public FFJLONIPPFH(BPAIJKJGNLD NMBGECILFAB, NativeArray<LocalId>.Enumerator DOHHLDONBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x828F900", Offset = "0x828E700", VA = "0x18828F900", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x828F940", Offset = "0x828E740", VA = "0x18828F940", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x828F980", Offset = "0x828E780", VA = "0x18828F980", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NIPKNLAGELI DADONNGONOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> NNMEILBDPAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JDKDDPDJCCM CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x829DB60", Offset = "0x829C960", VA = "0x18829DB60", Slot = "4")]
		get
		{
			return default(JDKDDPDJCCM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x829D1B0", Offset = "0x829BFB0", VA = "0x18829D1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int DFLOBPJKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x829CFF0", Offset = "0x829BDF0", VA = "0x18829CFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HFECACFKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x829D120", Offset = "0x829BF20", VA = "0x18829D120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> DKEEEAKDEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5950", Offset = "0x2BD4750", VA = "0x182BD5950")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> GFBKPKNGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x829D5D0", Offset = "0x829C3D0", VA = "0x18829D5D0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x829DAB0", Offset = "0x829C8B0", VA = "0x18829DAB0")]
	public OEPFMPMHIKM(int COJMCLGONLG, BPAIJKJGNLD NMBGECILFAB, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x829DAA0", Offset = "0x829C8A0", VA = "0x18829DAA0")]
	public OEPFMPMHIKM(NIPKNLAGELI DADONNGONOC, NativeArray<LocalId> NNMEILBDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x829D8F0", Offset = "0x829C6F0", VA = "0x18829D8F0")]
	public OEPFMPMHIKM(NIPKNLAGELI DADONNGONOC, NativeArray<Entity> NNMEILBDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x829D960", Offset = "0x829C760", VA = "0x18829D960")]
	internal OEPFMPMHIKM(BPAIJKJGNLD NMBGECILFAB, NativeArray<Entity> DIDGDGLCMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x829D880", Offset = "0x829C680", VA = "0x18829D880")]
	internal OEPFMPMHIKM(BPAIJKJGNLD NMBGECILFAB, NativeArray<LocalId> NNMEILBDPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x829D7D0", Offset = "0x829C5D0", VA = "0x18829D7D0")]
	public OEPFMPMHIKM(BPAIJKJGNLD NMBGECILFAB, int IDFEOHMGIAF, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x829D9F0", Offset = "0x829C7F0", VA = "0x18829D9F0")]
	public OEPFMPMHIKM(OEPFMPMHIKM IFBKMMAGBEP, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x829D210", Offset = "0x829C010", VA = "0x18829D210")]
	public void HPANNKPMOKF(List<JDKDDPDJCCM> ECEBLBALENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x829D160", Offset = "0x829BF60", VA = "0x18829D160")]
	public void HBFGCGLNBHP(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x829CF50", Offset = "0x829BD50", VA = "0x18829CF50")]
	public OEPFMPMHIKM AJBMEKOGIKE(Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x829D480", Offset = "0x829C280", VA = "0x18829D480")]
	public Span<JDKDDPDJCCM> LHABBHLGMLC()
	{
		return default(Span<JDKDDPDJCCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x829D040", Offset = "0x829BE40", VA = "0x18829D040")]
	public OEPFMPMHIKM CKPEHEGCAFA(int DKBLEPBOJIC, int IDFEOHMGIAF)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x829D0E0", Offset = "0x829BEE0", VA = "0x18829D0E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x829D630", Offset = "0x829C430", VA = "0x18829D630")]
	public FFJLONIPPFH OMGGHMFPBJO()
	{
		return default(FFJLONIPPFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x829D6F0", Offset = "0x829C4F0", VA = "0x18829D6F0", Slot = "6")]
	private IEnumerator<JDKDDPDJCCM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x829D760", Offset = "0x829C560", VA = "0x18829D760", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GDMDCBJICCF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B81DC0", Offset = "0x3B80BC0", VA = "0x183B81DC0")]
	public static CPOPDMAPGMA<T> HIHGBPCNIND<T>(this OEPFMPMHIKM GGCHDPHENOB) where T : Component
	{
		return default(CPOPDMAPGMA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct EDGBMDEGHHB : IList<JDKDDPDJCCM>, ICollection<JDKDDPDJCCM>, IEnumerable<JDKDDPDJCCM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MJLMBLHMEAD : IEnumerator<JDKDDPDJCCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BPAIJKJGNLD NMBGECILFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator DOHHLDONBML;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JDKDDPDJCCM BNFIAAPBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8297FC0", Offset = "0x8296DC0", VA = "0x188297FC0", Slot = "4")]
			get
			{
				return default(JDKDDPDJCCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8297F70", Offset = "0x8296D70", VA = "0x188297F70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x53D9CB0", Offset = "0x53D8AB0", VA = "0x1853D9CB0")]
		public MJLMBLHMEAD(BPAIJKJGNLD NMBGECILFAB, NativeArray<LocalId>.Enumerator DOHHLDONBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8297EB0", Offset = "0x8296CB0", VA = "0x188297EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8297EF0", Offset = "0x8296CF0", VA = "0x188297EF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8297F30", Offset = "0x8296D30", VA = "0x188297F30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BPAIJKJGNLD NMBGECILFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> NNMEILBDPAF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JDKDDPDJCCM CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x828EAD0", Offset = "0x828D8D0", VA = "0x18828EAD0", Slot = "4")]
		get
		{
			return default(JDKDDPDJCCM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x828EBC0", Offset = "0x828D9C0", VA = "0x18828EBC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x828E3C0", Offset = "0x828D1C0", VA = "0x18828E3C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x828E3C0", Offset = "0x828D1C0", VA = "0x18828E3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> DKEEEAKDEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BD5950", Offset = "0x2BD4750", VA = "0x182BD5950")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool ECOGGGAIBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x828EA50", Offset = "0x828D850", VA = "0x18828EA50")]
	public EDGBMDEGHHB(BPAIJKJGNLD NMBGECILFAB, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x828E9C0", Offset = "0x828D7C0", VA = "0x18828E9C0")]
	public EDGBMDEGHHB(BPAIJKJGNLD NMBGECILFAB, int IDFEOHMGIAF, Allocator DFGMDNGNOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x828E400", Offset = "0x828D200", VA = "0x18828E400")]
	public OEPFMPMHIKM IAFIABBEGGL()
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x828E0E0", Offset = "0x828CEE0", VA = "0x18828E0E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x828E120", Offset = "0x828CF20", VA = "0x18828E120", Slot = "13")]
	public bool Contains(JDKDDPDJCCM EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x828E1B0", Offset = "0x828CFB0", VA = "0x18828E1B0", Slot = "14")]
	public void CopyTo(JDKDDPDJCCM[] COPOPHFGNFG, int PENDJAKLNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x828E060", Offset = "0x828CE60", VA = "0x18828E060", Slot = "11")]
	public void Add(JDKDDPDJCCM EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x828E5A0", Offset = "0x828D3A0", VA = "0x18828E5A0", Slot = "7")]
	public void Insert(int CKFKPOAGPKN, JDKDDPDJCCM EHKDLJBBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x828E730", Offset = "0x828D530", VA = "0x18828E730", Slot = "15")]
	public bool Remove(JDKDDPDJCCM EHKDLJBBGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x828E510", Offset = "0x828D310", VA = "0x18828E510", Slot = "6")]
	public int IndexOf(JDKDDPDJCCM EHKDLJBBGDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x828E6E0", Offset = "0x828D4E0", VA = "0x18828E6E0", Slot = "8")]
	public void RemoveAt(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x828E380", Offset = "0x828D180", VA = "0x18828E380", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x828E650", Offset = "0x828D450", VA = "0x18828E650")]
	public MJLMBLHMEAD OMGGHMFPBJO()
	{
		return default(MJLMBLHMEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x828E800", Offset = "0x828D600", VA = "0x18828E800", Slot = "16")]
	private IEnumerator<JDKDDPDJCCM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x828E8E0", Offset = "0x828D6E0", VA = "0x18828E8E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IHJLBKFJFKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDKDDPDJCCM BKCNAOEALPI(JDKDDPDJCCM NNMEILBDPAF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ELCNHDAMALI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface DLJDLJOEGGA : DNJNFCPFBDD, AEEMGADOCFD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	OIPGDOEHLDA PKKAEFFHLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NIPKNLAGELI JJIIHNMOCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface AEEMGADOCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CBELIOGKNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface AALAIJBPKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBCMDFJCILO(bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKDKKBLDFOH();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface FACIFILABIL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DPOPBNPEJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OMLDGPEJHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NJCFOEHLPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MLOEHGGAHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JPBEJDGDPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOJHOGPMOAH(bool IDKBJKINDBO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CGEGDJBDJMA(ByteString HNLOALEHBMO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FMFKICBAJFO();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENIDJEMFLNM();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BHDPDFPNBPP();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface HPOJOGMGCFK
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GFFDGLCCIJL PKKAEFFHLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	MHEFHOADEFB GHGJDBNPJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	GFGMPGJEPMF NHLDCIBHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	DLJDLJOEGGA NDOBFMKDGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IMKKKNMLKJL IACBDDPPJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	FACIFILABIL DKMDCPEEOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ABBJJOAJNJJ FGMMGKBADDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IAGLFNADJLM HIAOLGMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	OCKCODPKJMC PEJGMGBECOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	EDOOOMLBJKI LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	ADJGBFGNAOC ECEPLGMOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	GKAMJKLBMPO GMBBEGAPBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	EHEFMNJLHMM JKFKDIAIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	JDOGMDHELLG HNMMDDGJIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	AFCFFJNALAO HCLCCHNDDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AKMHCHKAIFI HNIPFHNBANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CNJCLMAKHNE BHKOCOJAHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AKCJBCJCJCD BGCACNGMIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AEHJLAMNOJF LGHFLCFHBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	JGPMNBLHELC PAGFIOOLOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	JJCBFBHJJLC CCAOHPCCJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NAJKJLCDLOL DAFDHMNABBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	CAHPIPLDCGP JHFLBJNHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	DFBJDJEKDBJ AGCIEJLEJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LHMALMHGBGP NGEMHNBALJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JKHHLOLPLFC AENEMCDJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	ICGPKIBCHFK EMNPLGABNON
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ONKJPPPCEMH FHCNMBKLLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	EIBMPDFBJFM INIKKICIODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FHOMIEOPOBL DMPCKJNHOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MODFEFDOPCN HHGCCIBDEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OJAIIPJBJMI GHBCNHCCMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BAAFKHPJNHL JMCMAINODMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PFNANCDILGF ICPJLNCBIKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	OAHMMIEHPPN MFJMFLBGIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	HIKCCKAFNKH OLHKFBICFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AOJNJKOEMJE PPJFKOBBNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(KNHIAIPGDOE))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct JDKDDPDJCCM : IComparable<JDKDDPDJCCM>, IEquatable<JDKDDPDJCCM>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JDKDDPDJCCM POJIIGPHFHP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JJCEJMEPMPL = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int DMIBLCDGEBM = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int MJKGGECKKAG = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AIHFHEAKGJL = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OPKFGAAECNB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8288FB0", Offset = "0x8287DB0", VA = "0x188288FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DLJDLJOEGGA NDOBFMKDGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x82949C0", Offset = "0x82937C0", VA = "0x1882949C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LocalId KICKDBAOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8294790", Offset = "0x8293590", VA = "0x188294790")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	internal NIPKNLAGELI JJIIHNMOCGE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82943D0", Offset = "0x82931D0", VA = "0x1882943D0")]
		get
		{
			return default(NIPKNLAGELI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool FGHKILHPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82943E0", Offset = "0x82931E0", VA = "0x1882943E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private bool IGENFECPCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82947D0", Offset = "0x82935D0", VA = "0x1882947D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8294BE0", Offset = "0x82939E0", VA = "0x188294BE0")]
	public JDKDDPDJCCM(BPAIJKJGNLD EFGBAELMAGP, LocalId OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8294B50", Offset = "0x8293950", VA = "0x188294B50")]
	public JDKDDPDJCCM(NIPKNLAGELI DADONNGONOC, LocalId OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
	public AIJLMLNJMHO CEKCCOBGACA()
	{
		return default(AIJLMLNJMHO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8294980", Offset = "0x8293780", VA = "0x188294980")]
	public static LocalId JGGBAIGHKJA(JDKDDPDJCCM AOHLKKCMINF)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8294940", Offset = "0x8293740", VA = "0x188294940")]
	public static Entity JGGBAIGHKJA(JDKDDPDJCCM AOHLKKCMINF)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8294820", Offset = "0x8293620", VA = "0x188294820")]
	public static bool HAHIHKOBLPE(JDKDDPDJCCM LKPLCEODICL, JDKDDPDJCCM MANCHAKPLNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x82881F0", Offset = "0x8286FF0", VA = "0x1882881F0")]
	public static bool KKINNKAIEFB(JDKDDPDJCCM LKPLCEODICL, JDKDDPDJCCM MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8294A20", Offset = "0x8293820", VA = "0x188294A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x82945F0", Offset = "0x82933F0", VA = "0x1882945F0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8294500", Offset = "0x8293300", VA = "0x188294500", Slot = "4")]
	public int CompareTo(JDKDDPDJCCM LOKLFHKEJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "5")]
	public bool Equals(JDKDDPDJCCM LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AGEFPHGGNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8288BF0", Offset = "0x82879F0", VA = "0x188288BF0")]
	public static CAPEGOJHEPC LGKCFJLCJFJ(this JDKDDPDJCCM MKPNGAKJFMP)
	{
		return default(CAPEGOJHEPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class KNHIAIPGDOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct NIPKNLAGELI : IEquatable<NIPKNLAGELI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte DADONNGONOC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] FLKIPICBFGF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static BPAIJKJGNLD IBHHFBLJOCJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static DLJDLJOEGGA DKAAHKMBFIG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static BPAIJKJGNLD[] PALMCJAEBBF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static DLJDLJOEGGA[] BNPNOKELNNM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> EEKIKIEFGKD;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public DLJDLJOEGGA NDOBFMKDGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x829AAE0", Offset = "0x82998E0", VA = "0x18829AAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public BPAIJKJGNLD BLAKHGIDBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x829A5B0", Offset = "0x82993B0", VA = "0x18829A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x829B380", Offset = "0x829A180", VA = "0x18829B380")]
	static NIPKNLAGELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E250", Offset = "0x2C0D050", VA = "0x182C0E250")]
	internal NIPKNLAGELI(byte BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71030F0", Offset = "0x7101EF0", VA = "0x1871030F0", Slot = "4")]
	public bool Equals(NIPKNLAGELI LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x829A510", Offset = "0x8299310", VA = "0x18829A510", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1015FD0", Offset = "0x1014DD0", VA = "0x181015FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x829B2C0", Offset = "0x829A0C0", VA = "0x18829B2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x829ADD0", Offset = "0x8299BD0", VA = "0x18829ADD0")]
	private static BPAIJKJGNLD ODLEKOIHGOF(byte DADONNGONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x829B210", Offset = "0x829A010", VA = "0x18829B210")]
	private static DLJDLJOEGGA PPALGNBNDFK(byte DADONNGONOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x829A6A0", Offset = "0x82994A0", VA = "0x18829A6A0")]
	private static object GCLNOHAJBIK(byte DADONNGONOC, object[] FEBLBJIINOM, object JILABBLHNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x829A500", Offset = "0x8299300", VA = "0x18829A500")]
	private static int DEABBDDOOHF(byte DADONNGONOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x829A690", Offset = "0x8299490", VA = "0x18829A690")]
	private static int FLFMKFPMILI(byte DADONNGONOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x829A480", Offset = "0x8299280", VA = "0x18829A480")]
	private static (int, int) BNCDHAEFHBH(byte DADONNGONOC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x829AAD0", Offset = "0x82998D0", VA = "0x18829AAD0")]
	private static byte HMHHPMBFBPF(int DMIBKIHBLCP, int CKFKPOAGPKN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x829A810", Offset = "0x8299610", VA = "0x18829A810")]
	internal static NIPKNLAGELI HIMDKAKGPHI(DLJDLJOEGGA BDMEPNIKLIO, BPAIJKJGNLD EJOEOKEBELB)
	{
		return default(NIPKNLAGELI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x829ABC0", Offset = "0x82999C0", VA = "0x18829ABC0")]
	internal static void NDMNNAOCPHL(NIPKNLAGELI DADONNGONOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x829AE80", Offset = "0x8299C80", VA = "0x18829AE80")]
	private static void PEOMGDHCLME(int COJMCLGONLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JKOLIENMEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	SubGraph,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	SceneMainInitial,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	SceneMainJoining,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	SceneAdditive
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MNNOHHGOLPF
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool CJLKOHMGLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LANMOOEJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool NLBBMOPNOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool HEDIJOOIEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MDPNNBBHKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NDOMGADCJEF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBMCMMBDIIJ(IIOMDIPKFAE CHDHLAGMCKI, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NPGHCPKHIPO(IIOMDIPKFAE LDLGEJJMAHD, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPBNLAIIKIM(GJHMCNCFKOC MDDBKONNADO, int CKFKPOAGPKN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IOEOOPELPIP : IIOMDIPKFAE, MNNOHHGOLPF
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int DGJJOLMCMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CABAONJOALK(NLLJEMJBCGH KDLDDCCMAJC, int CKFKPOAGPKN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IIOMDIPKFAE : MNNOHHGOLPF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum HEJKGBFAJDN
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Physical = 4
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JIGNGGMAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GJAJFIIGNHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GOMPDBGGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NLLJEMJBCGH
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool HOLPMNEPGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	FHBADAKFFGA FNDMBIFEPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	FJKJAGMEHBI DKCJJNFIGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float3 BKNMJONCLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	quaternion DPJLAFKHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float3 JGFJLPLNFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	LENDJGLLJJI OHKKCFOKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BCFNPAGCDOG JEKBJHDPEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float DBMGMMPBOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 LAGAFFABKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float KFCMAPNCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	BKLCIIPAJGH JMIFPABPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IKNMGEKKLCD
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float3 NHPCBBHHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float3 HJAIPMMABIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion LJOMFNLOMEH(float3 FCLBCGKIEBI);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FJKJAGMEHBI
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool FGPEGJHCFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool OAFBPIDLCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GDBCHBAMBED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	float DPNNBLMCMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	int KJMOFKDALPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	int DAFGBBJHKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIGOENOFFNE(IKNMGEKKLCD KDLDDCCMAJC, int CKFKPOAGPKN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface NBOGEOCMIJA
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Guid OAKJMBJPLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LFFHPFIEDLO(Guid BLOACKLMMCE, Guid BPBNOKKGEDO, Guid JEKPEGLHGIG);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CBJCJIKJPLN(Guid BLOACKLMMCE, Guid[] FMAFEIGFOOM, Guid JEKPEGLHGIG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BLCKKAFJEKG(Guid AIHPKIPEANN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task INHAPFJHLPL(JDKDDPDJCCM BEGHACNOJOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDKICDFODGB(Guid AIHPKIPEANN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EIAIGCHGDAJ(LDJIJLOMIKP NKIKLEKPKNB, Guid NDBCFGPIMHO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MMEKFHGHDHL(Guid AIHPKIPEANN, bool IDKBJKINDBO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOKCKCGFJCL(Guid AIHPKIPEANN, CAPEGOJHEPC ADOLGBMNOIK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JEFLKEHLJNH(CAPEGOJHEPC ADOLGBMNOIK);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OLBLKGHBJGK(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface EOPHEMDGEFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface IPAOKKBNOIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "0")]
	void KJHJCMDOBEI(bool GPJMDAINDNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface MHEFHOADEFB
{
	[Cpp2IlInjected.Token(Token = "0x17000066")]
	IPAOKKBNOIJ LACFGMHCAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	LDCGEKOOGEM EJNMBFMGKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	EJFAEIPLNOC GDKLMBJEOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	IFKHJKCPCBN KDIIFMHLNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EIICPHLDMIF OCCDPGEMKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GLADLDHIKFE NGGGCNFGJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	LBBILBILCNA LIHDMLGAPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	KIDGLJHNGJE OFLNGCNHMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface LDCGEKOOGEM
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string HDDLBFELMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface PKFKMIJFBHL
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGINLCJPCPN(Action LJIGAFKJJAI, bool CGFADDFOMNL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJGBLPMGIOA(string GGDFKFACHGG);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MKKMJKKDMJC(string GGDFKFACHGG, int JILABBLHNAO);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKNKELBLAMM([Out] bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IHPONDPDNEL([Out] bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JLIGJOBHIGL([Out] int BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface EJFAEIPLNOC
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "0")]
	void DPFLLGPDNDE(bool IDKBJKINDBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface IFKHJKCPCBN
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid FEGFNNICBKK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid DFDFMLKNLMN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid KCFNJFBKMDH;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid GCHBCJCONMB;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool DONCEGCHJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool AKGGCIBHHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool HBBNKNBKNLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "2")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool LDJPEOEEDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x82935A0", Offset = "0x82923A0", VA = "0x1882935A0", Slot = "4")]
	string[] LKJHDOPJIDF(NPBBPECINAL EABDNKGEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMMOLFNPJDM();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8293630", Offset = "0x8292430", VA = "0x188293630", Slot = "6")]
	Guid PJINOGGACIL(Guid LKDFMIKGCIE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int APJMADAJHHP(NPBBPECINAL EABDNKGEENP);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DDIHFPOBOOM(NPBBPECINAL EABDNKGEENP, NativeArray<OGHPHPGJNPP> JNBOPCPJDKM, NativeList<UniformTRS> EFCFPJIENFA);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int NKMBDFOINAD(Guid OKDHAOKOGCM);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NDGFGNFGHPK(string FLHKIEKANIH, [Out] Guid OKDHAOKOGCM);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string OBPHLPIAGBN(Guid OKDHAOKOGCM);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EEJNPGAHNGL(RRObjectPrefabData AELOLHHNCEA, [Out] LocalId ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CPOPDMAPGMA<byte[]> IAGDLGMIIIE(NativeArray<OGHPHPGJNPP> KEKPBJLAKCN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFNGONMOONA(byte[] HIIPCIINJIC);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GameObject CINIGHLGHDH(string FLHKIEKANIH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BICCKCHODKO(Transform OLPMPAIMKPI, RRObjectPrefabData DOHOGBGJEHC, HLIDELEPHMC IEOOLFDDEEF);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BGADEINPEHI(NPBBPECINAL EABDNKGEENP, NativeParallelHashMap<Guid, LocalId> HONGFKNNEFC, [Out] Exception HIKJGCCPIBF);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GDIDBAJJMLF(NPBBPECINAL EABDNKGEENP, NativeParallelHashMap<Guid, LocalId> HONGFKNNEFC, [Out] NativeArray<LocalId> DIDGDGLCMEE, [Out] NativeArray<LocalId> BJABKGICJPF, [Out] NativeArray<AuthoredLocalPoseData> KDFAOGAFJDC, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "19")]
	void MNODHEHNEKA(NPBBPECINAL JBNEABKLADH, NativeArray<int> LMONDNDJEIO, GDLAFIILODC<GameObject> AOFCFHCNECI, CPOPDMAPGMA<GameObject> ILJODHDIBNA, JKOLIENMEOO GGOFFBHICPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ECFHPFLIOMH();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "21")]
	void MJPBHLKEAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "22")]
	void JNDECONFHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "23")]
	bool LCGLMGAPBDE(NPBBPECINAL EABDNKGEENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "24")]
	NDOMGADCJEF NIBMEANLKMB(NPBBPECINAL EABDNKGEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "25")]
	void IIIDOCJCBKG(Guid ALPNJHDBADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "26")]
	bool AJIJDLDDFHE(Guid ALPNJHDBADE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x8293660", Offset = "0x8292460", VA = "0x188293660")]
	static IFKHJKCPCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface LPLLPDKJJEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	long KBCCNOJFIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long JIMIBMCEMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface EIICPHLDMIF
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool JGMPFJHBDML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int IJCHILKMBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int JEONCIPDDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int FBPFALFLPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool PBFDJBEMKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int OAHODONCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "6")]
	void PMCFFFONDEC(AIOPDAJOKPF JBODBHEGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
	void KGFKIIMOEIB(bool DICJPLEJGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "8")]
	bool JGFEKBGNEIK(GLHCBKLDIDI DGOGGKOBPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
	void MMDFDKLFBEA(object OFCPJKNFOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "10")]
	void HIHMPFKJGPO(object OFCPJKNFOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JAGJHBBLAAC(Action<object> MCCCBAKLLNB);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JLJMBLHDLEB(Action<object> MCCCBAKLLNB);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "13")]
	void OEHJDNKCBLM(NativeArray<ViewId> JDLKAIIMKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "14")]
	void GLPKACGIMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "15")]
	void NIGOMJHOFNE(CMJKCOGJCOD DGPNPBEKOOD, ReadOnlySpan<byte> BOIPFNOKGBJ, GLHCBKLDIDI FIHFPAKJDIB, bool ILDKHDCAEAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "16")]
	void NIGOMJHOFNE(CMJKCOGJCOD DGPNPBEKOOD, ReadOnlySpan<byte> DPAFIOCGJKJ, bool ILDKHDCAEAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "17")]
	void NIGOMJHOFNE(CMJKCOGJCOD DGPNPBEKOOD, ReadOnlySpan<byte> DPAFIOCGJKJ, ReadOnlySpan<byte> POGGJDEELNI, bool ILDKHDCAEAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "18")]
	void FIJLHNLJPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "19")]
	void HKEDEAIPPGP(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "20")]
	void LJJKMBAEMNJ(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "21")]
	void EPLNAMEMIEN(Dictionary<object, object> HPKNOEDHCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "22")]
	void NFKMMOODNCA(NativeList<CAPEGOJHEPC> ABKLCIIGIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "24")]
	void ENKGBEENLFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "25")]
	void IIELLNMFOFA(List<object> HIEOEHIBOHN, int HBNCFIPENFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "26")]
	void ONJGFBCKFIJ(int OHLPJOJPIDL, object IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "27")]
	void HDALMNFEABP(GLHCBKLDIDI DGOGGKOBPII, Dictionary<object, object> MDOGLHGIMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "28")]
	void JCGEKJAIEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "29")]
	void ACEJKJOCDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class KEIFIJOMIPE
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x82967D0", Offset = "0x82955D0", VA = "0x1882967D0")]
	public static GDFKLAPHDOB EHOOLCKGJLP(this EIICPHLDMIF FHICECHOKKP, object OCGDLEBGIMO)
	{
		return default(GDFKLAPHDOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GDFKLAPHDOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EIICPHLDMIF FHICECHOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object OCGDLEBGIMO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x828FE50", Offset = "0x828EC50", VA = "0x18828FE50")]
	public GDFKLAPHDOB(EIICPHLDMIF FHICECHOKKP, object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x828FE00", Offset = "0x828EC00", VA = "0x18828FE00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOKBCIDGKFN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void EECONGLOCEK(ViewId JGOGKOHBDFC, EKOKDMBBAMI LMLJEKBBPAK, int DFODLDMBKGD);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "0")]
	void GACDMJAOKOI(EECONGLOCEK NMBPHJEGCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "1")]
	void BBNIOPPCDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "2")]
	void KOFCACNINJF(DBMIIECHDHJ BKMCGGEFFOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface JCFEADNOJHK
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface GLADLDHIKFE
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct MJBNJHNDJEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GLADLDHIKFE PBODNOBOADD;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8297E20", Offset = "0x8296C20", VA = "0x188297E20")]
		public MJBNJHNDJEM(GLADLDHIKFE PBODNOBOADD, string NCPFIOFEKBK, string CBNKIFBJGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8297DC0", Offset = "0x8296BC0", VA = "0x188297DC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct FMOFGCPFBLO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GLADLDHIKFE PBODNOBOADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task JNOGJECEFDN;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x828FDB0", Offset = "0x828EBB0", VA = "0x18828FDB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "0")]
	void CMAMMEDDHAI(string IIHOFBLPONF, float CFEOPLEMNPG = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "1")]
	void HGABLBPNCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMLNKOJOEAE(bool MLOMNKOOHLI, string NCPFIOFEKBK, string CBNKIFBJGNO);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "3")]
	void OAKKMGGGALJ(string IIHOFBLPONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class AHLKBHFHEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8288CA0", Offset = "0x8287AA0", VA = "0x188288CA0")]
	public static GLADLDHIKFE.MJBNJHNDJEM LKOKJKKIKGI(this GLADLDHIKFE FHICECHOKKP, string NCPFIOFEKBK, string CBNKIFBJGNO)
	{
		return default(GLADLDHIKFE.MJBNJHNDJEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface FKDKLINANOG
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KIHIPHKBCGA(GameObject JLNNGPHDMLM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HPCAFIAFMHH(GameObject JLNNGPHDMLM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KAJEOONBJGK(int DGOGGKOBPII);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object DKOEGKCNNDJ(JDKDDPDJCCM OPKFGAAECNB, GameObject JLNNGPHDMLM, Action<JDKDDPDJCCM, int> JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOEJBPGFBLA(GameObject JLNNGPHDMLM, object OMKJGNCNEHG);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLLKCHOAFFO
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJNEFHNILA(OGAPBCAHLMD FCEAMCDDCEK, DCJLBCLCFAB GBENKEHPCAE);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface OIGMHIPNGMF
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEJFHFKCOKJ(object MKPNGAKJFMP, NativeList<byte> BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object KIDJPDKJMHF(NativeArray<byte> BOIPFNOKGBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface NNOAGJGKADD
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool DPLIINIMPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate HANKIBENBEB(HGOBILCNGDO KELBHPOKGGP, Action<HGOBILCNGDO> JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNIJCPGDDGL(HGOBILCNGDO KELBHPOKGGP, Delegate JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate JDIJNKPIOKJ(HGOBILCNGDO KELBHPOKGGP, Action<HGOBILCNGDO> NNNNFKFHAPA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKIKDJIFMNB(HGOBILCNGDO KELBHPOKGGP, Delegate JCDKDANAIEK);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OLOGEBJDKLN(HGOBILCNGDO KELBHPOKGGP);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HGOBILCNGDO NJPOCGAJKMD(GameObject JLNNGPHDMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface MLCNOLGCIBP
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int AAHEBJHNABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int BGKCOIIMBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool FIGMIMCIHME
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool HAKDANLDDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool EMGLKIAABHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JDKDDPDJCCM OLHIJIKEEFP(int DGOGGKOBPII);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AKKCLFCIHMJ(GameObject EICOFDACEGP, JobHandle PAPHAMJDGHK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HJFMGPKIICN
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCJNEFHNILA(int FLHCGDNOCHL, DCJLBCLCFAB MPCCFAHBPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface LBBILBILCNA
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool DPOPBNPEJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface DJHIFFLMBDL
{
	[Cpp2IlInjected.Token(Token = "0x17000083")]
	JLDCHECNAIA BCOFHGJJHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	CHEKCMOLHDO KNJJIBAEODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool EIGNNLEFJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBGAGFHEKOK(Transform OLPMPAIMKPI);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGJOMLACLEL(Transform OLPMPAIMKPI, HMDPDMKPOCJ AOFPJJKFHPN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFKJAPKCMDH(Transform OLPMPAIMKPI, CKJLKPAHMFI KMKJPPGBBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface KIDGLJHNGJE
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AMONCODMFAK;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface LBHGLOICNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLAFDFNGDJF();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface CJAHNAOPOAB
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJJALEEBKBE(GameObject JLNNGPHDMLM, ODHAEMGJCLL PNJEPNCEJNE, EOMNDEHMIFN CIFIFLMOPEE);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPMLKPEIDII(JDKDDPDJCCM OPKFGAAECNB, bool FPGLILPHPNK, float3 NGKOBAHKOPM, quaternion NFDBAHBBOGM);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KLHOPGKNJHO(OEPFMPMHIKM BKCIHHJHPMO);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABCIGOIDNGH(AIJLMLNJMHO PBHKHJPMFCF, AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOGEOBNEGGF(AIJLMLNJMHO PBHKHJPMFCF, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFCGBHHBAJE(OEPFMPMHIKM PKFGBEMGGOP);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLEKNPPANGN(NPBBPECINAL DEFAOIMGIPN, ReadOnlySpan<Guid> HALGPAGKKEC, ReadOnlySpan<int> JCIGFKNJFHK, CPOPDMAPGMA<GameObject> LOAJMKHPMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DNFLMMNAEJP(IIJPOAKLDNG KPNIMMJCFHO);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGFHBLCJFCP(MLPGINFDHIJ LNLOEKHPJBA, MLPGINFDHIJ FLPOAFHPDPP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BNJAAPFKHKK(MLPGINFDHIJ LNLOEKHPJBA, MLPGINFDHIJ FLPOAFHPDPP);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PLEENOIEOKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> BOIPFNOKGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle DADONNGONOC;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x829F390", Offset = "0x829E190", VA = "0x18829F390")]
	public PLEENOIEOKO(ReadOnlyMemory<byte> BCHNIEHJGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x829F350", Offset = "0x829E150", VA = "0x18829F350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FHKKBDOPOGN
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	V0PreObjectModel = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	V1ObjectModelHierarchy = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	V2ObjectModelHierarchy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	V3Entities050 = 3,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	V4Entities050Compressed = 4,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	V5BumpObjectModelVersionMay2024 = 5,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	OldestCompatibleVersion = 3,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	LatestVersion = 5
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NPBBPECINAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString MDEANNJEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object BEEOKFOOFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object LPKFGMPLBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> HDELJALDPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool LDBFLMCPPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public FPMAJFIICKB.AGEAIHKJLAA? MOLLMEJDIDB;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x829B930", Offset = "0x829A730", VA = "0x18829B930")]
	public NPBBPECINAL(ByteString MDEANNJEJBK, [Optional] object BEEOKFOOFLC, [Optional] object LPKFGMPLBCH, [Optional] IEnumerable<string> HDELJALDPGB, bool LDBFLMCPPMD = true, [Optional] FPMAJFIICKB.AGEAIHKJLAA? MOLLMEJDIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CGDKDGNPKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object AGAEIFILLGE;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct OGHPHPGJNPP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum IHAABCBPDGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		IsInvalid = 1,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		IsStudioPrefab = 2,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		IsBetaOnly = 4,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		IsDevOnly = 8,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		IsR1Only = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		IsR1Upgrade = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		IsAllowedDevOnly = 0x40
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public RRObjectPrefabData IDHDJHNLLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid ABICANLPDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid NONMOGHCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid JHGILHMGPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid ENBFCDKAMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public IHAABCBPDGN AALJBKNKHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 NAGCOBHDCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int DGGLDKCLGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public NKIJNEJGNDA MOHCPAGKGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int ACDLHFBJDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int CAOOOCCMPNB;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Guid DFJFLMCNKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x53D6540", Offset = "0x53D5340", VA = "0x1853D6540")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool NAAIPPNCLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x829DC10", Offset = "0x829CA10", VA = "0x18829DC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool EAOJPKHIFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x829DBE0", Offset = "0x829C9E0", VA = "0x18829DBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool MEKPMHCCPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x829DC00", Offset = "0x829CA00", VA = "0x18829DC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool KFLHGJKOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x829DBF0", Offset = "0x829C9F0", VA = "0x18829DBF0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct OBKIPPPAHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly PBPAOKMLJKI DKBLEPBOJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly PBPAOKMLJKI CNDOBMAKBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint KONDKDJMJFL;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x829BBF0", Offset = "0x829A9F0", VA = "0x18829BBF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct EFEKBLOFBKD
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly OBKIPPPAHKA LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8287C00", Offset = "0x8286A00", VA = "0x188287C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct ACBCILPLFFH
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly OBKIPPPAHKA LJIGAFKJJAI;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8287C00", Offset = "0x8286A00", VA = "0x188287C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct COOOHCPLBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint KONDKDJMJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool LLBKICJJNKD;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x828BA70", Offset = "0x828A870", VA = "0x18828BA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PBPAOKMLJKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int DOBKAGHAEBK;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x829EBB0", Offset = "0x829D9B0", VA = "0x18829EBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface MAFGJBDJOBP
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	PDEOHPIEFIN AMIGKEPFDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LDJIJLOMIKP
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface PNCFPBHDADE
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LLHOPEDLDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F0D0", Offset = "0x3C5DED0", VA = "0x183C5F0D0")]
	public static AIJLMLNJMHO CEKCCOBGACA<T>(this T OPKFGAAECNB) where T : LDJIJLOMIKP
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x82979E0", Offset = "0x82967E0", VA = "0x1882979E0")]
	public static MonoBehaviour KBBAOIGDEDH(this LDJIJLOMIKP OPKFGAAECNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8297920", Offset = "0x8296720", VA = "0x188297920")]
	public static GameObject GJPFCDPKGGA(this LDJIJLOMIKP OPKFGAAECNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface KOCFBCIEHBM : LDJIJLOMIKP
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(JDKDDPDJCCM ANPENHHJGPC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MMIGEFKDMJE : LDJIJLOMIKP
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface NKCPDMFAKCK
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void BBCBMBAELGE(AGBPHOGPDLJ AELJADIBBGD);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event BBCBMBAELGE CNJGMLIAPJP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface OKDBLFHINMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface AKKOEBCFIEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface HEKNGABBAOC
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(JDKDDPDJCCM FJAEJPDBFOA);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool NIOGIBLGCBF);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFINPBANFIK(JDKDDPDJCCM AMECNEFIPBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LGMHKNJKMFG
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(OPDBNCCBFHO LIHIOFNKEOE);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface OPDBNCCBFHO
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GameObject JLNNGPHDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Transform OLPMPAIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	DPBLEIDODAC ABIGPDADELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool BEDOJAICHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OFJBLLBGDEO(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IDNEBGPAEGO GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class PCNEIABNIHA
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x829EC10", Offset = "0x829DA10", VA = "0x18829EC10")]
	public static void ENEMNFCBAID(this OPDBNCCBFHO BNHFIJBCOJI, HLIDELEPHMC IEOOLFDDEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface DPBLEIDODAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	OPDBNCCBFHO KMPJPDOJMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	GameObject GJPFCDPKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Transform HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	DPBLEIDODAC KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	int PMOGKCHOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool HOLBLDFKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool OLOGEBJDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool JFHEADJNHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	FHIEKILDCOB GKEEJIGDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	PAAFNDDMBFD NPFBHJHKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	float ALOEDFDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Vector3 PJEFBKPCBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Vector3 PPFBKGBPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Vector3 EPHIJFBBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 EPJELJJHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	bool MOLDNMJKALN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	bool BDIAGIILAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	bool ELPKNLHNDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool LDLFJPGODMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Vector3 HPPAPHLGNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Vector3 KPKIPNFFABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 AKLIPNIGHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Vector3 GLMFMPGHMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float ELNFAFPIPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	float IALPHLPGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Vector3 LMMHGMMJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Quaternion JFMGCINFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	float BBJBPNLBEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	float LOPDJJCJILO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool NFNDCILINAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	CBJAHEEHPCM OJAJFEEKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool NHFGNMMGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Transform JJFFAELKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Vector3 HOPBKGMFHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	float EBBHPDLLJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	float BHBLGOFMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Quaternion LPHDFMFPCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	Vector3 NHPCBBHHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	Quaternion HAEAKBALEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	RigidbodyConstraints HBAOEIKODDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool CAIMGNIAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	CollisionDetectionMode PHENLJMPFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool MENIBLCOEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NCFBIGMDCOK HIIENGHKEIH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCFBIGMDCOK POIAJKFOIJG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event NCFBIGMDCOK FFAOAODBIJN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NCFBIGMDCOK BDCDDPPKIEO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NCFBIGMDCOK DAJHEHJOCME;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NCFBIGMDCOK IJMJHFCNAJJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NCFBIGMDCOK BMCAJPHDEFL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EBILHFJIDMN HKFFKBEFDOH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CNPJGKPMCGN, CNPJGKPMCGN> AEOPKKKILGM;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DPBLEIDODAC EIFCKAIBFKK(int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MJFGNCJKDGI((Quaternion rot, Vector3 moments) KOAILPGHGOM);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void HEMMENFMKAL();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GKAMMBGMKJB();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void BOPGCJILNLM();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void LOAANMKDKIJ();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void IALDJKPIPLJ(DPBLEIDODAC BNECONOIKOE, bool DJGMHEMHHPA = false);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void LAFNKMOEHGF(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MJGBMMDLPMN(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 PGMCIMFBFFL(Vector3 DEEDLFLENGK);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 EPKGFAPFPHD(Vector3 LLAKBEKJKJD);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void LFOOCAGFFJK();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void AELBOKFFMOD();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void GECEDJONIFI();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void LDBJJPBFJOG(Vector3 BLBNBDFIMNA, Vector3 BPPNHBPFKIK);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void LLGPEKAKLEB(Vector3 ADFHMMCFFLO, Vector3 DMILHKKHJKK);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void DLIMHJKELMI(Vector3 BPMIEEKMOOO);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void NEHDDKABHFH(HABPAFPJJJJ KLNJBBBKJCO, Vector3 DOOFBAFADGL, float LCINEAPPHPI, float GECGBFGHNIB = 8f, float IAOKKLJMKPD = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void AECKGAOBPJD(HDKAGLOAMDF HHPOMFKHONG, Vector3 FHDIIOHIJPM, float FALGOEEDNBH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void DACPAKELHKF(HDKAGLOAMDF HHPOMFKHONG, Vector3 NOLDGDLLBBL, float MOJCPCKJGIA = 7f, float OEOJAMPNJLC = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 IHMGJAOIHIF(Vector3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 LHONBILCJGP(Vector3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void PCBIKLDEPOD();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void PEHENHDBJIB(DPBLEIDODAC IMDHGEHNKDM, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DCLLLLMNLKG(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void DFCHELDJHDP();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void LOAAIBACFCK();

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void AILODFEAFEE();

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool DIACFMMGCLC();

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void CMKADIODPEO();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void JJKBGICHEAL(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void KOMKILCDHBE(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CKHEDNCAHPO(object OCGDLEBGIMO, bool FGMALLCGIFL);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void JHDMBLACBGC(Vector3 NEDCMPBJGFN, Quaternion KPABIJHGHOL);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void GPMBLDOEFGA(Vector3 EEJOIEKMLLG, Quaternion IEMENDNBBCL);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool KNECLCJKENB(float PGBCNNCAMLP);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void JJPAKMAIGII(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LDLIPDINNFN(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void OIPNOACLCAI(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void AHKKFALKFJA(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void OMAFGAKEBCC(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KHBECMPPEIJ(Vector3 ADJOPEHJOFG, Vector3 EMECBHNHILC, ForceMode GGOMBHIMGME);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void JIDEELPJIKP(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void CNAMIAHONOJ(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool AJNBGOOKCDE(Vector3 NCJMIJBPLIB, [Out] RaycastHit MKFBNOBLHEA, float NGOCCMOBNDC);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void LEEMBAJDKPG();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface PAAFNDDMBFD
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ABAAACJCGOF : PAAFNDDMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public ABAAACJCGOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "0")]
	void PEHJJGFBKAF(Vector3 HEMBEDMEHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "1")]
	void LNAFFGNLCFP(Vector3 BBFHLEIKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "2")]
	void HOJJJCELAPG(Vector3 HEMBEDMEHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "3")]
	void LNJALEFKNBA(Vector3 BBFHLEIKDJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FHIEKILDCOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DBKBIHOFMMN();

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DGFLKJKEIAO();

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OBEBKFJCBBO(float MGHHGMFMBKD, float LDMDANBILND);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void NCFBIGMDCOK(OPDBNCCBFHO MFONGCALGMO);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum NJGDPBOGCCF
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	ChildAdded,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	ChildRemoved,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ParentChanged,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	HierarchyMassUpdated,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	SleepChanged,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	DistanceBandChanged,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	IsKinematicChanged,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Discontinuity,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Destroyed,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HABPAFPJJJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate void EBILHFJIDMN(OPDBNCCBFHO MFONGCALGMO, bool DJGMHEMHHPA = false);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum HDKAGLOAMDF
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct IDNEBGPAEGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody GEEACKEHDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object JPJFDCGGAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 PPFGELDDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 IIMONNAPLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public CLOJPGAOOMI CJGCNOHEHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool ALLEJOFPMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool MFCANJLPJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool MGBLNBLFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool OJIIPHJNCIK;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct AIJLMLNJMHO : IEquatable<AIJLMLNJMHO>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly AIJLMLNJMHO MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GameObject JLNNGPHDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8289200", Offset = "0x8288000", VA = "0x188289200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CAPEGOJHEPC AAJNFEAFNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8289030", Offset = "0x8287E30", VA = "0x188289030")]
		get
		{
			return default(CAPEGOJHEPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public INGCOGFFNEN CNHNMKGMDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8289480", Offset = "0x8288280", VA = "0x188289480")]
		get
		{
			return default(INGCOGFFNEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public RRObjectPrefabData LOLEKLCDHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8289700", Offset = "0x8288500", VA = "0x188289700")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool IKBNLDLCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8289B90", Offset = "0x8288990", VA = "0x188289B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool BICHINIDECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8288EA0", Offset = "0x8287CA0", VA = "0x188288EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool HOLPMNEPGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8289420", Offset = "0x8288220", VA = "0x188289420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool LDHFJIEFMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8289520", Offset = "0x8288320", VA = "0x188289520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool PPPMPBIBGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8289010", Offset = "0x8287E10", VA = "0x188289010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool FAJEBOHIKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x82895F0", Offset = "0x82883F0", VA = "0x1882895F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool JJFOMINKNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8289170", Offset = "0x8287F70", VA = "0x188289170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool ALDLJNJHFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8288D30", Offset = "0x8287B30", VA = "0x188288D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool EOHEBMKKBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8289BB0", Offset = "0x82889B0", VA = "0x188289BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool FIJMNAHGFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x82895B0", Offset = "0x82883B0", VA = "0x1882895B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool DPGEKBOMNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8289930", Offset = "0x8288730", VA = "0x188289930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool EIOJNJJPHED
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8289570", Offset = "0x8288370", VA = "0x188289570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool HFPIHCBDDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x82896C0", Offset = "0x82884C0", VA = "0x1882896C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool DKJOCFHDIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x82899C0", Offset = "0x82887C0", VA = "0x1882899C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool JJOOMFCALCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8289A80", Offset = "0x8288880", VA = "0x188289A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public NEOEMNECCPO HIDFFBIECNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(NEOEMNECCPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public NOPJAFJCELK BGIBOKFBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(NOPJAFJCELK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NFBFKDBBBJM JKFKDIAIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(NFBFKDBBBJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DGCMLJCKJDF BMMGPFKLBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DGCMLJCKJDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public AAKBPENLLKA MLJOCMLAJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AAKBPENLLKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public ODAEKJICHPE AMDDMFCFNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(ODAEKJICHPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public HMPDGPFIAMF CMIACHIMEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(HMPDGPFIAMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public PIFAMGFPCKF IDPHMLMNNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(PIFAMGFPCKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public BMMEFNBNMHN EMBGDJOCFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(BMMEFNBNMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public BPLCNLAALJA HNMMDDGJIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(BPLCNLAALJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public GOACANOEFPC JMLHPNCEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(GOACANOEFPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public DMCGNDLDDNL AMJJCMIIIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DMCGNDLDDNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public KHLNBLHOBKK BHKHBEGEIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(KHLNBLHOBKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public KDPHBDGFHDP FHNCGGAPOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(KDPHBDGFHDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public KHNGNIGDFJG AKIMIGGCHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(KHNGNIGDFJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool MEHEBNABCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8288DB0", Offset = "0x8287BB0", VA = "0x188288DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool HGLFPLBGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8289AC0", Offset = "0x82888C0", VA = "0x188289AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool AGDBODAIMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8289620", Offset = "0x8288420", VA = "0x188289620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool FGHKILHPKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8288DA0", Offset = "0x8287BA0", VA = "0x188288DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool OPPDKEKICFH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8289660", Offset = "0x8288460", VA = "0x188289660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool NHKIKKDFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8289B00", Offset = "0x8288900", VA = "0x188289B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public bool CJKBPPBCKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8289440", Offset = "0x8288240", VA = "0x188289440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public DKDBIKPMIGP HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DKDBIKPMIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IJIMKMJHPMJ LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IJIMKMJHPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8288FB0", Offset = "0x8287DB0", VA = "0x188288FB0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static AIJLMLNJMHO JGGBAIGHKJA(JDKDDPDJCCM ANPENHHJGPC)
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8289A00", Offset = "0x8288800", VA = "0x188289A00")]
	public JECMMHKCCMF LLPBINDAKNK()
	{
		return default(JECMMHKCCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8289540", Offset = "0x8288340", VA = "0x188289540")]
	public EJLDNDOEMAH HGJIOMFDBED()
	{
		return default(EJLDNDOEMAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8289970", Offset = "0x8288770", VA = "0x188289970")]
	public AMFKOAHBIDM LGDKFFKOOOH()
	{
		return default(AMFKOAHBIDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8288D70", Offset = "0x8287B70", VA = "0x188288D70")]
	public LKAIBONPCFM AFPKGOENDPG()
	{
		return default(LKAIBONPCFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x82891B0", Offset = "0x8287FB0", VA = "0x1882891B0")]
	public OLNGCJFIONO EMHDCPOCNPH()
	{
		return default(OLNGCJFIONO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8288EC0", Offset = "0x8287CC0", VA = "0x188288EC0")]
	public HNMPMFNMNCA BKGDIMEHNAI()
	{
		return default(HNMPMFNMNCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8289BF0", Offset = "0x82889F0", VA = "0x188289BF0")]
	public MLPGINFDHIJ PMIMDIBGKED()
	{
		return default(MLPGINFDHIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8289B40", Offset = "0x8288940", VA = "0x188289B40")]
	public ADDKEPHPGED NKJHPJCMPHH()
	{
		return default(ADDKEPHPGED);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8289830", Offset = "0x8288630", VA = "0x188289830")]
	public void KCGKHNNAOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x8288F10", Offset = "0x8287D10", VA = "0x188288F10")]
	public void BOGGHIAGAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x82890D0", Offset = "0x8287ED0", VA = "0x1882890D0")]
	public bool DOGDFJFEMEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8289C40", Offset = "0x8288A40", VA = "0x188289C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public AIJLMLNJMHO(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(AIJLMLNJMHO BNECONOIKOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JDKDDPDJCCM JGGBAIGHKJA(AIJLMLNJMHO BNECONOIKOE)
	{
		return default(JDKDDPDJCCM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x8288020", Offset = "0x8286E20", VA = "0x188288020")]
	public static bool HAHIHKOBLPE(AIJLMLNJMHO LKPLCEODICL, AIJLMLNJMHO MANCHAKPLNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x82881F0", Offset = "0x8286FF0", VA = "0x1882881F0")]
	public static bool KKINNKAIEFB(AIJLMLNJMHO LKPLCEODICL, AIJLMLNJMHO MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x8289390", Offset = "0x8288190", VA = "0x188289390", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(AIJLMLNJMHO LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct KHLNBLHOBKK : IEquatable<KHLNBLHOBKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private BAAFKHPJNHL FNDOFECCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8296860", Offset = "0x8295660", VA = "0x188296860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8296A40", Offset = "0x8295840", VA = "0x188296A40")]
	public void HNKDJDKGOHL(uint PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8296E00", Offset = "0x8295C00", VA = "0x188296E00")]
	public bool MEIFCBKHDEA([Out] uint PPPFBKMGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8296D00", Offset = "0x8295B00", VA = "0x188296D00")]
	public bool LFIODDOEPCH([Out] uint PPPFBKMGIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8296950", Offset = "0x8295750", VA = "0x188296950")]
	public void GDKGMKIHHJD(string PPPFBKMGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8296B50", Offset = "0x8295950", VA = "0x188296B50")]
	[CanBeNull]
	public string JDLAGBMBOGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8296F00", Offset = "0x8295D00", VA = "0x188296F00")]
	public bool PMBBMKILOHF([Out] string MEBIFHCKKFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8296C60", Offset = "0x8295A60", VA = "0x188296C60")]
	public void KNJDLNDJHGH(string MEBIFHCKKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public KHLNBLHOBKK(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x82968C0", Offset = "0x82956C0", VA = "0x1882968C0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(KHLNBLHOBKK LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct NEOEMNECCPO : IEquatable<NEOEMNECCPO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private ABBJJOAJNJJ CDPLAPBGLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8298A70", Offset = "0x8297870", VA = "0x188298A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private BAAFKHPJNHL JMCMAINODMB
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8298860", Offset = "0x8297660", VA = "0x188298860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool ECHOMAGNBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8298CB0", Offset = "0x8297AB0", VA = "0x188298CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool DJMFKKANFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8298C70", Offset = "0x8297A70", VA = "0x188298C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public bool BEJIPNJGBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8298700", Offset = "0x8297500", VA = "0x188298700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Guid GMOEDLFDMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8298AD0", Offset = "0x82978D0", VA = "0x188298AD0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Guid IKALCGFHMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8298E40", Offset = "0x8297C40", VA = "0x188298E40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Guid KEBHAOMHPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8298F60", Offset = "0x8297D60", VA = "0x188298F60")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public IJIMKMJHPMJ LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IJIMKMJHPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x8298EC0", Offset = "0x8297CC0", VA = "0x188298EC0")]
	public bool PHBHMDELOFO([Out] Guid AIHPKIPEANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x82987C0", Offset = "0x82975C0", VA = "0x1882987C0")]
	public bool BIPELBDOIDO([Out] Guid BPBNOKKGEDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x8298B50", Offset = "0x8297950", VA = "0x188298B50")]
	public void JEGKJOAFELJ(Guid HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8298D40", Offset = "0x8297B40", VA = "0x188298D40")]
	public void NDFAPAJKAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8298950", Offset = "0x8297750", VA = "0x188298950")]
	public Guid FANIMKIFNOD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public NEOEMNECCPO(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x82988C0", Offset = "0x82976C0", VA = "0x1882988C0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(NEOEMNECCPO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct AMFKOAHBIDM : IEquatable<AMFKOAHBIDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private OCKCODPKJMC GKNFJDJJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x828A3E0", Offset = "0x82891E0", VA = "0x18828A3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Vector3 GJBNFNPAADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x828A440", Offset = "0x8289240", VA = "0x18828A440")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Quaternion BLKIMMDHBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x828A210", Offset = "0x8289010", VA = "0x18828A210")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public AIJLMLNJMHO KOAFCIBKMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x828A350", Offset = "0x8289150", VA = "0x18828A350")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x8289DB0", Offset = "0x8288BB0", VA = "0x188289DB0")]
	public OEPFMPMHIKM AAJFPEALPLP(Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x828A170", Offset = "0x8288F70", VA = "0x18828A170")]
	public bool ILHEPHGIKNM(AIJLMLNJMHO CMDMCJGFCDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x828A020", Offset = "0x8288E20", VA = "0x18828A020")]
	public void ICGDBBOEDKB(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x8289E80", Offset = "0x8288C80", VA = "0x188289E80")]
	public void CMFACFDPNBA(float AMJKMJIBGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x828A590", Offset = "0x8289390", VA = "0x18828A590")]
	public void OFAGOMJKJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public AMFKOAHBIDM(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(AMFKOAHBIDM BNECONOIKOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JDKDDPDJCCM JGGBAIGHKJA(AMFKOAHBIDM BNECONOIKOE)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x8289F90", Offset = "0x8288D90", VA = "0x188289F90", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(AMFKOAHBIDM LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct JECMMHKCCMF : IEquatable<JECMMHKCCMF>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly JECMMHKCCMF MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private EDOOOMLBJKI KMJELOHHBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8294DB0", Offset = "0x8293BB0", VA = "0x188294DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<AIJLMLNJMHO> GIEBAJEANFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82952B0", Offset = "0x82940B0", VA = "0x1882952B0")]
		get
		{
			return default(Span<AIJLMLNJMHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x82953B0", Offset = "0x82941B0", VA = "0x1882953B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8294CA0", Offset = "0x8293AA0", VA = "0x188294CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public DKDBIKPMIGP HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DKDBIKPMIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public IJIMKMJHPMJ LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IJIMKMJHPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x8294E10", Offset = "0x8293C10", VA = "0x188294E10")]
	public void GCEOCBBFHLB(JECMMHKCCMF LOKLFHKEJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public JECMMHKCCMF(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(JECMMHKCCMF BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8294D20", Offset = "0x8293B20", VA = "0x188294D20", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(JECMMHKCCMF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static AIJLMLNJMHO JGGBAIGHKJA(JECMMHKCCMF FEOFEEGOGIO)
	{
		return default(AIJLMLNJMHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public struct POOIDDAMLPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> NGHKKFKEBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private EFKFDJFEDAB BPPKGNNLOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool IJHOIHKCLJE;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		[CompilerGenerated]
		readonly get
		{
			return default(AIJLMLNJMHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OPANGBLCLKE CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x829F620", Offset = "0x829E420", VA = "0x18829F620")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x829F750", Offset = "0x829E550", VA = "0x18829F750")]
	internal POOIDDAMLPG(AIJLMLNJMHO MKPNGAKJFMP, bool IJHOIHKCLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x829F440", Offset = "0x829E240", VA = "0x18829F440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3D74CA0", Offset = "0x3D73AA0", VA = "0x183D74CA0")]
	public void OKLNCPEFHBN<T>(OPANGBLCLKE MAHBBBBCDEL, T BNECONOIKOE, [Optional] T JILABBLHNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x829F570", Offset = "0x829E370", VA = "0x18829F570")]
	public void EBNLHEFHMEO(OPANGBLCLKE MAHBBBBCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xAE3600", Offset = "0xAE2400", VA = "0x180AE3600")]
	public Dictionary<int, object> ILBJEDMANCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x829F6E0", Offset = "0x829E4E0", VA = "0x18829F6E0")]
	private readonly void PPOKDMDAFBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class MHGDJHGENOE
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x8297C00", Offset = "0x8296A00", VA = "0x188297C00")]
	public static POOIDDAMLPG IMGNMDGKDAD(this AIJLMLNJMHO MKPNGAKJFMP)
	{
		return default(POOIDDAMLPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct KDPHBDGFHDP : IEquatable<KDPHBDGFHDP>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly KDPHBDGFHDP MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private bool DPGEKBOMNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x82966B0", Offset = "0x82954B0", VA = "0x1882966B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 OKNEPAAPMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x8296410", Offset = "0x8295210", VA = "0x188296410")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x82965D0", Offset = "0x82953D0", VA = "0x1882965D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8296630", Offset = "0x8295430", VA = "0x188296630")]
	public Vector3 KFCANHGLAKC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x8296390", Offset = "0x8295190", VA = "0x188296390")]
	public void DCFOCPHPNLC([In] Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x82964C0", Offset = "0x82952C0", VA = "0x1882964C0")]
	public void EPICJABONEL([In] Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x82962E0", Offset = "0x82950E0", VA = "0x1882962E0")]
	public bool AJACPOLEPBM([In] Vector3 BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public KDPHBDGFHDP(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x8296540", Offset = "0x8295340", VA = "0x188296540", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(KDPHBDGFHDP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x82966F0", Offset = "0x82954F0", VA = "0x1882966F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct KNJAPMPFMPP : IEquatable<KNJAPMPFMPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8297720", Offset = "0x8296520", VA = "0x188297720", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(KNJAPMPFMPP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct ADDKEPHPGED : IEquatable<ADDKEPHPGED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private HIKCCKAFNKH OLHKFBICFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8288210", Offset = "0x8287010", VA = "0x188288210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool MJKMABMACIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8288030", Offset = "0x8286E30", VA = "0x188288030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool MFPLDCFHNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8288350", Offset = "0x8287150", VA = "0x188288350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public AACFAAJHHIH KMHPAGNMEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8287CA0", Offset = "0x8286AA0", VA = "0x188287CA0")]
		get
		{
			return default(AACFAAJHHIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool HGIMEHFIGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8288270", Offset = "0x8287070", VA = "0x188288270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool FOGIBIGGNND
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8288520", Offset = "0x8287320", VA = "0x188288520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool AEDICOGDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8288160", Offset = "0x8286F60", VA = "0x188288160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8288480", Offset = "0x8287280", VA = "0x188288480")]
	public bool MKKNPPNKLPK(ADDKEPHPGED CAJOIDJHOBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8287F80", Offset = "0x8286D80", VA = "0x188287F80")]
	public bool GCKIHMMOBEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x82882B0", Offset = "0x82870B0", VA = "0x1882882B0")]
	public bool LMGFNPGGILO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8287DD0", Offset = "0x8286BD0", VA = "0x188287DD0")]
	public ReadOnlySpan<JDKDDPDJCCM> DDLHPGGNNKH()
	{
		return default(ReadOnlySpan<JDKDDPDJCCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public ADDKEPHPGED(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8288020", Offset = "0x8286E20", VA = "0x188288020")]
	public static bool HAHIHKOBLPE(ADDKEPHPGED LKPLCEODICL, ADDKEPHPGED MANCHAKPLNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x82881F0", Offset = "0x8286FF0", VA = "0x1882881F0")]
	public static bool KKINNKAIEFB(ADDKEPHPGED LKPLCEODICL, ADDKEPHPGED MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8287EF0", Offset = "0x8286CF0", VA = "0x188287EF0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(ADDKEPHPGED LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct MLPGINFDHIJ : IEquatable<MLPGINFDHIJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MLPGINFDHIJ MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private HIKCCKAFNKH HPCPOAOICNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x82981E0", Offset = "0x8296FE0", VA = "0x1882981E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool HJLJJFEGONB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x82982D0", Offset = "0x82970D0", VA = "0x1882982D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public DKDBIKPMIGP HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DKDBIKPMIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x82983D0", Offset = "0x82971D0", VA = "0x1882983D0")]
	public bool MKKNPPNKLPK(MLPGINFDHIJ LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8298330", Offset = "0x8297130", VA = "0x188298330")]
	public bool JDHGFCKHNHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8298090", Offset = "0x8296E90", VA = "0x188298090")]
	public bool COCOCHJJPGP([Out] MLPGINFDHIJ CIMBOMEHEMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8298170", Offset = "0x8296F70", VA = "0x188298170")]
	public void COHAEHHNELL(EJOMPKEOPGK DLAOKGLPMLD, bool MODEKBJELAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public MLPGINFDHIJ(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8288020", Offset = "0x8286E20", VA = "0x188288020")]
	public static bool HAHIHKOBLPE(MLPGINFDHIJ LKPLCEODICL, MLPGINFDHIJ MANCHAKPLNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x82881F0", Offset = "0x8286FF0", VA = "0x1882881F0")]
	public static bool KKINNKAIEFB(MLPGINFDHIJ LKPLCEODICL, MLPGINFDHIJ MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8298240", Offset = "0x8297040", VA = "0x188298240", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(MLPGINFDHIJ LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct IJIMKMJHPMJ : IEquatable<IJIMKMJHPMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private EDOOOMLBJKI KMJELOHHBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8293C50", Offset = "0x8292A50", VA = "0x188293C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public JDKDDPDJCCM BCIMJFGJLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8293780", Offset = "0x8292580", VA = "0x188293780")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public AIJLMLNJMHO BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8294100", Offset = "0x8292F00", VA = "0x188294100")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public AIJLMLNJMHO KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8294070", Offset = "0x8292E70", VA = "0x188294070")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8293CB0", Offset = "0x8292AB0", VA = "0x188293CB0")]
	public Span<AIJLMLNJMHO> FMLIGEBIHOI()
	{
		return default(Span<AIJLMLNJMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8293910", Offset = "0x8292710", VA = "0x188293910")]
	public Span<AIJLMLNJMHO> EBDMCFNGNKK()
	{
		return default(Span<AIJLMLNJMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8293810", Offset = "0x8292610", VA = "0x188293810")]
	public Span<AIJLMLNJMHO> DOEAKEEMHLJ()
	{
		return default(Span<AIJLMLNJMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8293DB0", Offset = "0x8292BB0", VA = "0x188293DB0")]
	public Span<AIJLMLNJMHO> HGEPCGONIEJ()
	{
		return default(Span<AIJLMLNJMHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8293EB0", Offset = "0x8292CB0", VA = "0x188293EB0")]
	public bool IALDJKPIPLJ(AIJLMLNJMHO CMDMCJGFCDK, bool JJPNGIOOAIB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8293A10", Offset = "0x8292810", VA = "0x188293A10")]
	public bool EBLNBCJFJDG(AIJLMLNJMHO NLIKAMKMMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8293B40", Offset = "0x8292940", VA = "0x188293B40")]
	public AIJLMLNJMHO FBBJCJKFEIG(uint LODAADCJLGO)
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8293FE0", Offset = "0x8292DE0", VA = "0x188293FE0")]
	public JECMMHKCCMF JJFIJECLPLF()
	{
		return default(JECMMHKCCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public IJIMKMJHPMJ(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(IJIMKMJHPMJ BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x8293AB0", Offset = "0x82928B0", VA = "0x188293AB0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(IJIMKMJHPMJ LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct NOPJAFJCELK : IEquatable<NOPJAFJCELK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string HAPNNFMFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x829B540", Offset = "0x829A340", VA = "0x18829B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public string KLJAAGEHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x829B440", Offset = "0x829A240", VA = "0x18829B440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string BKGHFLGCOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x829B390", Offset = "0x829A190", VA = "0x18829B390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string MAGEBNDFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x829B5D0", Offset = "0x829A3D0", VA = "0x18829B5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x829B870", Offset = "0x829A670", VA = "0x18829B870")]
	public bool PMBBMKILOHF([Out] string MEBIFHCKKFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public NOPJAFJCELK(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x829B4B0", Offset = "0x829A2B0", VA = "0x18829B4B0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(NOPJAFJCELK LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct IPNLFLJIDAL : IEquatable<IPNLFLJIDAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x8294190", Offset = "0x8292F90", VA = "0x188294190", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(IPNLFLJIDAL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public readonly struct JMMHEMNLDPA : IEquatable<JMMHEMNLDPA>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Flags]
	public enum HPHFKPCHNAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SUCCESS = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		ANCHOR_A_INVALID = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ANCHOR_B_INVALID = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		ANCHOR_A_ALREADY_CONNECTED = 4,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		ANCHOR_B_ALREADY_CONNECTED = 8
	}

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JMMHEMNLDPA MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8288FB0", Offset = "0x8287DB0", VA = "0x188288FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8295FC0", Offset = "0x8294DC0", VA = "0x188295FC0")]
	public static HPHFKPCHNAG MLNNBLIPCLJ(JMMHEMNLDPA LKPLCEODICL, JMMHEMNLDPA MANCHAKPLNN)
	{
		return default(HPHFKPCHNAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8295430", Offset = "0x8294230", VA = "0x188295430")]
	public bool AFKILNOJEEA([Out] GameObject CMDMCJGFCDK, [Out] GameObject JLNNGPHDMLM, [Out] AIJLMLNJMHO APKOLOEAFMJ, [Out] AIJLMLNJMHO KPMKINONNPG, [Out] Vector3 EMECBHNHILC, [Out] Vector3 BPFLMIAAGGP, [Out] Vector3 EAPLGBDEDBK, [Out] AIJLMLNJMHO FNLPNGJAJGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x82959F0", Offset = "0x82947F0", VA = "0x1882959F0")]
	public bool JEGNIPECOPI([Out] GameObject CMDMCJGFCDK, [Out] GameObject JLNNGPHDMLM, [Out] AIJLMLNJMHO APKOLOEAFMJ, [Out] AIJLMLNJMHO KPMKINONNPG, [Out] Vector3 EMECBHNHILC, [Out] Vector3 BPFLMIAAGGP, [Out] Vector3 EAPLGBDEDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8295C00", Offset = "0x8294A00", VA = "0x188295C00")]
	private void LFCKABHIBPP(Entity ALBBAEBLONH, EntityManager NEIOADOFHDD, MagneticAnchorData JCJBIKBIEFP, [Out] GameObject CMDMCJGFCDK, [Out] GameObject JLNNGPHDMLM, [Out] AIJLMLNJMHO APKOLOEAFMJ, [Out] AIJLMLNJMHO KPMKINONNPG, [Out] Vector3 EMECBHNHILC, [Out] Vector3 BPFLMIAAGGP, [Out] Vector3 EAPLGBDEDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public JMMHEMNLDPA(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8295960", Offset = "0x8294760", VA = "0x188295960", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(JMMHEMNLDPA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x82961E0", Offset = "0x8294FE0", VA = "0x1882961E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct LGCOFAFCJBD : IEquatable<LGCOFAFCJBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x82977B0", Offset = "0x82965B0", VA = "0x1882977B0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(LGCOFAFCJBD LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct KHNGNIGDFJG : IEquatable<KHNGNIGDFJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private AOJNJKOEMJE HPCPOAOICNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8297420", Offset = "0x8296220", VA = "0x188297420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public OCFBDHPDABC KIOHFGMLJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8297510", Offset = "0x8296310", VA = "0x188297510")]
		get
		{
			return default(OCFBDHPDABC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x82971A0", Offset = "0x8295FA0", VA = "0x1882971A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public CPOPDMAPGMA<string> ECFLJDCKLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8297310", Offset = "0x8296110", VA = "0x188297310")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8297550", Offset = "0x8296350", VA = "0x188297550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public CPOPDMAPGMA<string> FOKGLEMAADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8297080", Offset = "0x8295E80", VA = "0x188297080")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x82971F0", Offset = "0x8295FF0", VA = "0x1882971F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public KHNGNIGDFJG(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8297480", Offset = "0x8296280", VA = "0x188297480", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(KHNGNIGDFJG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct NFBFKDBBBJM : IEquatable<NFBFKDBBBJM>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly ComponentTypes FGNMEKOBLNJ;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NFBFKDBBBJM MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Collider KFLMNJHHAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8299410", Offset = "0x8298210", VA = "0x188299410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public AHEDCGBMDAC OJHEPKCNCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8299F50", Offset = "0x8298D50", VA = "0x188299F50")]
		get
		{
			return default(AHEDCGBMDAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x829A010", Offset = "0x8298E10", VA = "0x18829A010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public LAANAIEHAOK KMNPNPEMOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8299DB0", Offset = "0x8298BB0", VA = "0x188299DB0")]
		get
		{
			return default(LAANAIEHAOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8299F00", Offset = "0x8298D00", VA = "0x188299F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public ONEKGAHOHGI NAOMNFIMDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x82998A0", Offset = "0x82986A0", VA = "0x1882998A0")]
		get
		{
			return default(ONEKGAHOHGI);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8299560", Offset = "0x8298360", VA = "0x188299560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float KODHEGMCGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8299330", Offset = "0x8298130", VA = "0x188299330")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x82992E0", Offset = "0x82980E0", VA = "0x1882992E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool JIGNGGMAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8299DF0", Offset = "0x8298BF0", VA = "0x188299DF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8299370", Offset = "0x8298170", VA = "0x188299370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool FNFOONJHKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8299260", Offset = "0x8298060", VA = "0x188299260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8299B30", Offset = "0x8298930", VA = "0x188299B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool BADDBHJFLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8299D30", Offset = "0x8298B30", VA = "0x188299D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x82996A0", Offset = "0x82984A0", VA = "0x1882996A0")]
	public static bool FACKLMEIOJN(AIJLMLNJMHO NACLAOADMMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x82998E0", Offset = "0x82986E0", VA = "0x1882998E0")]
	public static bool GNHMKAHECGG(AIJLMLNJMHO NACLAOADMMG, [Out] NFBFKDBBBJM BMGCBKCFLOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8299BD0", Offset = "0x82989D0", VA = "0x188299BD0")]
	public bool HDCENLHNOGK([Out] HEKNGABBAOC AKMFHNGACJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8299170", Offset = "0x8297F70", VA = "0x188299170")]
	public bool BMBJBCKINAA([Out] JDKDDPDJCCM EGPDFGOHLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x82995B0", Offset = "0x82983B0", VA = "0x1882995B0")]
	public bool ENEACIDDJLK(GCLFJAMLBJN DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8299F90", Offset = "0x8298D90", VA = "0x188299F90")]
	public void NJPHHAPPCJN(GCLFJAMLBJN DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8299E60", Offset = "0x8298C60", VA = "0x188299E60")]
	public void MCCCANMCBCD(GCLFJAMLBJN DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public NFBFKDBBBJM(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8299610", Offset = "0x8298410", VA = "0x188299610", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(NFBFKDBBBJM LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x829A060", Offset = "0x8298E60", VA = "0x18829A060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct LKAIBONPCFM : IEquatable<LKAIBONPCFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool IHJEJCEJJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x82978D0", Offset = "0x82966D0", VA = "0x1882978D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public LKAIBONPCFM(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8297840", Offset = "0x8296640", VA = "0x188297840", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(LKAIBONPCFM LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct DGCMLJCKJDF : IEquatable<DGCMLJCKJDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private AFCFFJNALAO HCLCCHNDDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x828BDA0", Offset = "0x828ABA0", VA = "0x18828BDA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x828BE00", Offset = "0x828AC00", VA = "0x18828BE00")]
	public void KIMKKIGICGM(bool LPGHFDKIPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public DGCMLJCKJDF(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x828BD10", Offset = "0x828AB10", VA = "0x18828BD10", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(DGCMLJCKJDF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct OLNGCJFIONO : IEquatable<OLNGCJFIONO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	private ADJGBFGNAOC ECEPLGMOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x829E610", Offset = "0x829D410", VA = "0x18829E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public OCFBDHPDABC IFOLBLCIJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x829E510", Offset = "0x829D310", VA = "0x18829E510")]
		get
		{
			return default(OCFBDHPDABC);
		}
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x829DC20", Offset = "0x829CA20", VA = "0x18829DC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool NAAEDICOOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x829E240", Offset = "0x829D040", VA = "0x18829E240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x829E710", Offset = "0x829D510", VA = "0x18829E710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public CPOPDMAPGMA<string> GFOEOCKGAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x829E8D0", Offset = "0x829D6D0", VA = "0x18829E8D0")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x829E2D0", Offset = "0x829D0D0", VA = "0x18829E2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public CPOPDMAPGMA<string> HAHFNPJMJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x829DF70", Offset = "0x829CD70", VA = "0x18829DF70")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x829DD30", Offset = "0x829CB30", VA = "0x18829DD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public CPOPDMAPGMA<string> NPDMIFMDMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x829E120", Offset = "0x829CF20", VA = "0x18829E120")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x829DE50", Offset = "0x829CC50", VA = "0x18829DE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public CPOPDMAPGMA<string> AFAAHBFJJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x829E7B0", Offset = "0x829D5B0", VA = "0x18829E7B0")]
		get
		{
			return default(CPOPDMAPGMA<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x829E3F0", Offset = "0x829D1F0", VA = "0x18829E3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x829E670", Offset = "0x829D470", VA = "0x18829E670")]
	public bool MBOCJAGKIEP(JDKDDPDJCCM IFADLDJHCLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public OLNGCJFIONO(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JDKDDPDJCCM JGGBAIGHKJA(OLNGCJFIONO BNECONOIKOE)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x829E090", Offset = "0x829CE90", VA = "0x18829E090", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(OLNGCJFIONO LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct AAKBPENLLKA : IEquatable<AAKBPENLLKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool LLJDFGFMHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x82876E0", Offset = "0x82864E0", VA = "0x1882876E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool FIKHHDHFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8287030", Offset = "0x8285E30", VA = "0x188287030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool KEMELABOBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x82879C0", Offset = "0x82867C0", VA = "0x1882879C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8287210", Offset = "0x8286010", VA = "0x188287210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool BDJAPMAOCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x8287080", Offset = "0x8285E80", VA = "0x188287080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool NBGDGOJAKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8287A10", Offset = "0x8286810", VA = "0x188287A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool MBIJMLMNLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8286F10", Offset = "0x8285D10", VA = "0x188286F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public bool EJIBILKMCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x82873E0", Offset = "0x82861E0", VA = "0x1882873E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public bool OILLOFKDEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x8287A60", Offset = "0x8286860", VA = "0x188287A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool FJEOBKAMNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8286EC0", Offset = "0x8285CC0", VA = "0x188286EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool MIEMCMKCGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x82872E0", Offset = "0x82860E0", VA = "0x1882872E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool DFNPDAIOJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8287480", Offset = "0x8286280", VA = "0x188287480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool LPOADNGAPCB
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8287120", Offset = "0x8285F20", VA = "0x188287120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public bool LANMOOEJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8287230", Offset = "0x8286030", VA = "0x188287230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool NLBBMOPNOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x82876A0", Offset = "0x82864A0", VA = "0x1882876A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8286D50", Offset = "0x8285B50", VA = "0x188286D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool DCOEIFOBLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x82870D0", Offset = "0x8285ED0", VA = "0x1882870D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public KGLICKFNCGM LJDOFPALFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8287930", Offset = "0x8286730", VA = "0x188287930")]
		get
		{
			return default(KGLICKFNCGM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8287780", Offset = "0x8286580", VA = "0x188287780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool COIGOGAKICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x82877D0", Offset = "0x82865D0", VA = "0x1882877D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public EOMNDEHMIFN LAPPEKMOFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x82878F0", Offset = "0x82866F0", VA = "0x1882878F0")]
		get
		{
			return default(EOMNDEHMIFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8287430", Offset = "0x8286230", VA = "0x188287430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool NPDEGLONMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8287AB0", Offset = "0x82868B0", VA = "0x188287AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 DEOKOLBJONI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8286E40", Offset = "0x8285C40", VA = "0x188286E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 CGJMCHEEDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8286FB0", Offset = "0x8285DB0", VA = "0x188286FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool MMAMNDAJIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x82874D0", Offset = "0x82862D0", VA = "0x1882874D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool DAGCMFPBBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8287AF0", Offset = "0x82868F0", VA = "0x188287AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	private EntityManager IKHIKBCMLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8287280", Offset = "0x8286080", VA = "0x188287280")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8287720", Offset = "0x8286520", VA = "0x188287720")]
	public bool LKFGHEDLMEM(OGGBIIEINEJ DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8286DB0", Offset = "0x8285BB0", VA = "0x188286DB0")]
	public void APGNKPNBLGH(OGGBIIEINEJ DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8286F60", Offset = "0x8285D60", VA = "0x188286F60")]
	public bool DHFOGPJJJGP(ODHAEMGJCLL DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8287330", Offset = "0x8286130", VA = "0x188287330")]
	public void GOFHKLEGIBI(ODHAEMGJCLL DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8287290", Offset = "0x8286090", VA = "0x188287290")]
	public ODHAEMGJCLL FPEIECNOEII()
	{
		return default(ODHAEMGJCLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8287970", Offset = "0x8286770", VA = "0x188287970")]
	public bool NONPKIKOJPJ(ODHAEMGJCLL BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public AAKBPENLLKA(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x8287180", Offset = "0x8285F80", VA = "0x188287180", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(AAKBPENLLKA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct ODAEKJICHPE : IEquatable<ODAEKJICHPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	private AKCJBCJCJCD BGCACNGMIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x829C600", Offset = "0x829B400", VA = "0x18829C600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x829C040", Offset = "0x829AE40", VA = "0x18829C040")]
	public bool DFLGOAHDMCE(EOBJDHADOCF INALECHHMIH, List<AIJLMLNJMHO> NFMOHCFHBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x829C8A0", Offset = "0x829B6A0", VA = "0x18829C8A0")]
	public int PPNKLIKJIMG(EOBJDHADOCF INALECHHMIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x829C3E0", Offset = "0x829B1E0", VA = "0x18829C3E0")]
	public void HDAIDOGNHBK(List<AIJLMLNJMHO> NFMOHCFHBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x829C200", Offset = "0x829B000", VA = "0x18829C200")]
	public int GEOKHIPDOII(AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x829C770", Offset = "0x829B570", VA = "0x18829C770")]
	public AIJLMLNJMHO PLKOBJBJNEF(int CKFKPOAGPKN, EOBJDHADOCF INALECHHMIH)
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x829BE60", Offset = "0x829AC60", VA = "0x18829BE60")]
	public void BHCIHEMBLIC(AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x829BF90", Offset = "0x829AD90", VA = "0x18829BF90")]
	public bool BMFGKFIGMGK(AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x829C4F0", Offset = "0x829B2F0", VA = "0x18829C4F0")]
	public void HLMKEPINAMK(EOBJDHADOCF INALECHHMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x829C330", Offset = "0x829B130", VA = "0x18829C330")]
	public bool GMNPIGPANCH(AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x829C660", Offset = "0x829B460", VA = "0x18829C660")]
	public bool OCLIEELAEJF(EOBJDHADOCF INALECHHMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public ODAEKJICHPE(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x829C170", Offset = "0x829AF70", VA = "0x18829C170", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(ODAEKJICHPE LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct HMPDGPFIAMF : IEquatable<HMPDGPFIAMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x8292D30", Offset = "0x8291B30", VA = "0x188292D30")]
	public void NGPNLMGIKAF(bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x8292CA0", Offset = "0x8291AA0", VA = "0x188292CA0")]
	public void LNMJGIDDMBI(bool BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE590", Offset = "0x3BAD390", VA = "0x183BAE590")]
	public T MLLKFCEBFKP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public HMPDGPFIAMF(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x8292C10", Offset = "0x8291A10", VA = "0x188292C10", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(HMPDGPFIAMF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct PIFAMGFPCKF : IEquatable<PIFAMGFPCKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool BAOPABDHFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x829F020", Offset = "0x829DE20", VA = "0x18829F020")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x829F130", Offset = "0x829DF30", VA = "0x18829F130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CMPHIDHNPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x829EFA0", Offset = "0x829DDA0", VA = "0x18829EFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int COMEOKONPII
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x829F0F0", Offset = "0x829DEF0", VA = "0x18829F0F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x829F180", Offset = "0x829DF80", VA = "0x18829F180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public PIFAMGFPCKF(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x829F060", Offset = "0x829DE60", VA = "0x18829F060", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(PIFAMGFPCKF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct BMMEFNBNMHN : IEquatable<BMMEFNBNMHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int BIDNIDAOAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x828AD30", Offset = "0x8289B30", VA = "0x18828AD30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x828AED0", Offset = "0x8289CD0", VA = "0x18828AED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int FFFGLKGEBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x828AE50", Offset = "0x8289C50", VA = "0x18828AE50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x828ACE0", Offset = "0x8289AE0", VA = "0x18828ACE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public uint GOJFNIOHEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x828AE90", Offset = "0x8289C90", VA = "0x18828AE90")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x828AD70", Offset = "0x8289B70", VA = "0x18828AD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public BMMEFNBNMHN(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x828ADC0", Offset = "0x8289BC0", VA = "0x18828ADC0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(BMMEFNBNMHN LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public readonly struct BPLCNLAALJA : IEquatable<BPLCNLAALJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	private JDOGMDHELLG NILBPHOGGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x828AF20", Offset = "0x8289D20", VA = "0x18828AF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	private JJCBFBHJJLC CCAOHPCCJGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x828B9A0", Offset = "0x828A7A0", VA = "0x18828B9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public bool HCKPMIFLFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x828B230", Offset = "0x828A030", VA = "0x18828B230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public bool JOFHMHPHBNE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x828B8D0", Offset = "0x828A6D0", VA = "0x18828B8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool MGMNLMDJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x828B970", Offset = "0x828A770", VA = "0x18828B970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public bool ALODNPMGLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x828B0D0", Offset = "0x8289ED0", VA = "0x18828B0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public bool ACGEMABOIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x828B570", Offset = "0x828A370", VA = "0x18828B570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool BFBHAIDIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x828B6D0", Offset = "0x828A4D0", VA = "0x18828B6D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public bool DPMHBEOABBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x828B2C0", Offset = "0x828A0C0", VA = "0x18828B2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool EDLPFKBFMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x828B760", Offset = "0x828A560", VA = "0x18828B760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public bool EIBODDKJKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x828B5A0", Offset = "0x828A3A0", VA = "0x18828B5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x828BA00", Offset = "0x828A800", VA = "0x18828BA00")]
	public bool PLDJMBKKFAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x828AF80", Offset = "0x8289D80", VA = "0x18828AF80")]
	public AIJLMLNJMHO CBEAKDLONJP(AIJLMLNJMHO IMBAOPHEODM)
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x828B460", Offset = "0x828A260", VA = "0x18828B460")]
	public JDKDDPDJCCM HHOLAFHIFKE()
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x828B020", Offset = "0x8289E20", VA = "0x18828B020")]
	public bool CDBACJECIPA(JDKDDPDJCCM IMBAOPHEODM, [Out] JDKDDPDJCCM KHLPGANMIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public BPLCNLAALJA(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(BPLCNLAALJA BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x828B1A0", Offset = "0x8289FA0", VA = "0x18828B1A0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(BPLCNLAALJA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct EJLDNDOEMAH : IEquatable<EJLDNDOEMAH>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly EJLDNDOEMAH MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public HKBNCHJJIEK FNDMBIFEPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x828F060", Offset = "0x828DE60", VA = "0x18828F060")]
		get
		{
			return default(HKBNCHJJIEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public BCFNPAGCDOG JEKBJHDPEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x828F2B0", Offset = "0x828E0B0", VA = "0x18828F2B0")]
		get
		{
			return default(BCFNPAGCDOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x828EF00", Offset = "0x828DD00", VA = "0x18828EF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	public LENDJGLLJJI OHKKCFOKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x828F3F0", Offset = "0x828E1F0", VA = "0x18828F3F0")]
		get
		{
			return default(LENDJGLLJJI);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x828F0F0", Offset = "0x828DEF0", VA = "0x18828F0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public float BANONALPBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x828F270", Offset = "0x828E070", VA = "0x18828F270")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x828F0A0", Offset = "0x828DEA0", VA = "0x18828F0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public Vector3 PPHKJKMGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x828F370", Offset = "0x828E170", VA = "0x18828F370")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x828F2F0", Offset = "0x828E0F0", VA = "0x18828F2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public float KFCMAPNCGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x828F220", Offset = "0x828E020", VA = "0x18828F220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public BKLCIIPAJGH JMIFPABPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x828F530", Offset = "0x828E330", VA = "0x18828F530")]
		get
		{
			return default(BKLCIIPAJGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x828F4E0", Offset = "0x828E2E0", VA = "0x18828F4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public bool IGMKNKJDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x828EFA0", Offset = "0x828DDA0", VA = "0x18828EFA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x828F480", Offset = "0x828E280", VA = "0x18828F480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public DKDBIKPMIGP HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DKDBIKPMIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public IJIMKMJHPMJ LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IJIMKMJHPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x828EF50", Offset = "0x828DD50", VA = "0x18828EF50")]
	public EIHJBDFNKGB CIDFPOJJPLN()
	{
		return default(EIHJBDFNKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x828F430", Offset = "0x828E230", VA = "0x18828F430")]
	public HBGMJPLFBFM NEBFFHJCAIO()
	{
		return default(HBGMJPLFBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x828F1D0", Offset = "0x828DFD0", VA = "0x18828F1D0")]
	private bool FICIDELGLFP(BKLCIIPAJGH DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x828EFE0", Offset = "0x828DDE0", VA = "0x18828EFE0")]
	public void DDIAFBMLFKP(BKLCIIPAJGH DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public EJLDNDOEMAH(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(EJLDNDOEMAH BNECONOIKOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x82881F0", Offset = "0x8286FF0", VA = "0x1882881F0")]
	public static bool KKINNKAIEFB(EJLDNDOEMAH LKPLCEODICL, EJLDNDOEMAH MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x828F140", Offset = "0x828DF40", VA = "0x18828F140", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(EJLDNDOEMAH LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct EIHJBDFNKGB : IEquatable<EIHJBDFNKGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public EJLDNDOEMAH MICPALLACDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(EJLDNDOEMAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public FHBADAKFFGA OENJGGOHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x828EEC0", Offset = "0x828DCC0", VA = "0x18828EEC0")]
		get
		{
			return default(FHBADAKFFGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public EIHJBDFNKGB(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(EIHJBDFNKGB BNECONOIKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x828EE30", Offset = "0x828DC30", VA = "0x18828EE30", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(EIHJBDFNKGB LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
public readonly struct HBGMJPLFBFM : IEquatable<HBGMJPLFBFM>
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public static readonly HBGMJPLFBFM MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	private DFBJDJEKDBJ AGCIEJLEJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x82922E0", Offset = "0x82910E0", VA = "0x1882922E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public EJLDNDOEMAH MICPALLACDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(EJLDNDOEMAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public GGKKLOFKKIO NGAOAMLHFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8292560", Offset = "0x8291360", VA = "0x188292560")]
		get
		{
			return default(GGKKLOFKKIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x82921C0", Offset = "0x8290FC0", VA = "0x1882921C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public IEnumerable<FAOEDIHHGLD> NLDEFLNNFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8291B60", Offset = "0x8290960", VA = "0x188291B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public FAOEDIHHGLD CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8291DF0", Offset = "0x8290BF0", VA = "0x188291DF0")]
		get
		{
			return default(FAOEDIHHGLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8291D60", Offset = "0x8290B60", VA = "0x188291D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public DKDBIKPMIGP HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(DKDBIKPMIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x8292340", Offset = "0x8291140", VA = "0x188292340")]
	public FAOEDIHHGLD LGNINPLOOJF(float3? EMECBHNHILC, [Optional] quaternion? NOLDGDLLBBL, [Optional] Vector3? AMJKMJIBGNI)
	{
		return default(FAOEDIHHGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x8291F90", Offset = "0x8290D90", VA = "0x188291F90")]
	public FAOEDIHHGLD FKCAGLHHHHE(int CKFKPOAGPKN, float3? EMECBHNHILC, [Optional] quaternion? NOLDGDLLBBL, [Optional] Vector3? AMJKMJIBGNI)
	{
		return default(FAOEDIHHGLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8292710", Offset = "0x8291510", VA = "0x188292710")]
	public void OGMLKCBPBFI(int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8292680", Offset = "0x8291480", VA = "0x188292680")]
	public void MKDKKBLDFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public HBGMJPLFBFM(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x82896A0", Offset = "0x82884A0", VA = "0x1882896A0")]
	public static bool JGGBAIGHKJA(HBGMJPLFBFM BNECONOIKOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x8288020", Offset = "0x8286E20", VA = "0x188288020")]
	public static bool HAHIHKOBLPE(HBGMJPLFBFM LKPLCEODICL, HBGMJPLFBFM MANCHAKPLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x8291F00", Offset = "0x8290D00", VA = "0x188291F00", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(HBGMJPLFBFM LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct FAOEDIHHGLD : IEquatable<FAOEDIHHGLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public HBGMJPLFBFM DKCJJNFIGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x828F620", Offset = "0x828E420", VA = "0x18828F620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public float3 NHPCBBHHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x828F570", Offset = "0x828E370", VA = "0x18828F570")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x828F790", Offset = "0x828E590", VA = "0x18828F790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public quaternion HAEAKBALEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x828F8B0", Offset = "0x828E6B0", VA = "0x18828F8B0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x828F5D0", Offset = "0x828E3D0", VA = "0x18828F5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public float3 HJAIPMMABIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x828F7F0", Offset = "0x828E5F0", VA = "0x18828F7F0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x828F730", Offset = "0x828E530", VA = "0x18828F730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public NPPBMLMJGNJ GBMPLLPOGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x828F850", Offset = "0x828E650", VA = "0x18828F850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x828F8A0", Offset = "0x828E6A0", VA = "0x18828F8A0")]
	public void OFILNHDFENP(HBGMJPLFBFM BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public FAOEDIHHGLD(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x828F6A0", Offset = "0x828E4A0", VA = "0x18828F6A0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(FAOEDIHHGLD LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct HNMPMFNMNCA : IEquatable<HNMPMFNMNCA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public bool MCMFJOGKBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8292E50", Offset = "0x8291C50", VA = "0x188292E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public HNMPMFNMNCA(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8292DC0", Offset = "0x8291BC0", VA = "0x188292DC0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(HNMPMFNMNCA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct GOACANOEFPC : IEquatable<GOACANOEFPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	private JKHHLOLPLFC LDDCMIMHCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x8291860", Offset = "0x8290660", VA = "0x188291860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public bool HEJKGOGMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x82910D0", Offset = "0x828FED0", VA = "0x1882910D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8291250", Offset = "0x8290050", VA = "0x188291250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public bool NAINJHEIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x8290F70", Offset = "0x828FD70", VA = "0x188290F70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x8291520", Offset = "0x8290320", VA = "0x188291520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public float NOPIAIIGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x82914E0", Offset = "0x82902E0", VA = "0x1882914E0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8291580", Offset = "0x8290380", VA = "0x188291580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public bool JBJMDGOBPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8291350", Offset = "0x8290150", VA = "0x188291350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8291620", Offset = "0x8290420", VA = "0x188291620")]
	public void OIBGFJFBICK(int PBHKHJPMFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8291750", Offset = "0x8290550", VA = "0x188291750")]
	public bool PBGGMIGBOMK([Out] int PBHKHJPMFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x82912B0", Offset = "0x82900B0", VA = "0x1882912B0")]
	public void IKLIAJIJCEB(bool CMPNGCMDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x82915D0", Offset = "0x82903D0", VA = "0x1882915D0")]
	public bool ODAHELDGLKL(EHIJPFPOJLH DLAOKGLPMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8291050", Offset = "0x828FE50", VA = "0x188291050")]
	public void FAEBGNPDDMC(EHIJPFPOJLH DLAOKGLPMLD, bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x82913A0", Offset = "0x82901A0", VA = "0x1882913A0")]
	public void LBONKEFODEM(float FCJGAPHADPM, float OJCABKDGPJK, float FMDNBFHCEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x82918C0", Offset = "0x82906C0", VA = "0x1882918C0")]
	public void PPLMOAJEPDK(float3 LHEBGEMBBGN, quaternion NBDKEPJDAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x8290E40", Offset = "0x828FC40", VA = "0x188290E40")]
	public bool CFJDDBNCPNH([Out] float3 LHEBGEMBBGN, [Out] quaternion NBDKEPJDAOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8291120", Offset = "0x828FF20", VA = "0x188291120")]
	public bool GNPPNJMKHBM([Out] float MMEDHPPFIFM, [Out] float GDDDPIJOPCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x82916C0", Offset = "0x82904C0", VA = "0x1882916C0")]
	public void OLKLGLHEDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public GOACANOEFPC(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x8290FC0", Offset = "0x828FDC0", VA = "0x188290FC0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(GOACANOEFPC LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct DKDBIKPMIGP : IEquatable<DKDBIKPMIGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	private ICGPKIBCHFK EBIJGMPAGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x828CD30", Offset = "0x828BB30", VA = "0x18828CD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public Vector3 NHPCBBHHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x828C3C0", Offset = "0x828B1C0", VA = "0x18828C3C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x828CF30", Offset = "0x828BD30", VA = "0x18828CF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public Quaternion HAEAKBALEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x828DB70", Offset = "0x828C970", VA = "0x18828DB70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x828CA10", Offset = "0x828B810", VA = "0x18828CA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public Vector3 HOPBKGMFHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x828D660", Offset = "0x828C460", VA = "0x18828D660")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x828D4C0", Offset = "0x828C2C0", VA = "0x18828D4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public Quaternion LPHDFMFPCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x828C720", Offset = "0x828B520", VA = "0x18828C720")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x828D0B0", Offset = "0x828BEB0", VA = "0x18828D0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public float EBBHPDLLJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x828DD90", Offset = "0x828CB90", VA = "0x18828DD90")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x828D2C0", Offset = "0x828C0C0", VA = "0x18828D2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public float BHBLGOFMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x828DA00", Offset = "0x828C800", VA = "0x18828DA00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public Matrix4x4 CNPKKHPLFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x828CC60", Offset = "0x828BA60", VA = "0x18828CC60")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public IJIMKMJHPMJ LAFFJBHBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IJIMKMJHPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	private BPAIJKJGNLD JJLMCENHCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8288FB0", Offset = "0x8287DB0", VA = "0x188288FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x828CEE0", Offset = "0x828BCE0", VA = "0x18828CEE0")]
	public GKKGCGDMMHN INFKJPIBMIO()
	{
		return default(GKKGCGDMMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x828D8E0", Offset = "0x828C6E0", VA = "0x18828D8E0")]
	public void NNAJCDOMLCL([Out] Matrix4x4 NNHONNMDIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x828C560", Offset = "0x828B360", VA = "0x18828C560")]
	public void BADGEKOENDH([In] Vector3 APDNNMONKGG, [In] Quaternion MKHKGOGFEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x828C660", Offset = "0x828B460", VA = "0x18828C660")]
	public void BADGEKOENDH([In] RigidTransform FJMAKPDKOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x828D000", Offset = "0x828BE00", VA = "0x18828D000")]
	public void JDAGCEJFMHE([Out] RigidTransform FJMAKPDKOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x828BFB0", Offset = "0x828ADB0", VA = "0x18828BFB0")]
	public void AFFMIMOBMHK([In] Vector3 IMGFOLEBKMC, [In] Quaternion OIANICGPPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x828BEF0", Offset = "0x828ACF0", VA = "0x18828BEF0")]
	public void AFFMIMOBMHK([In] RigidTransform DGPLBJKFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x828D750", Offset = "0x828C550", VA = "0x18828D750")]
	public void NKHKKBHAAMH([Out] Vector3 IMGFOLEBKMC, [Out] Quaternion OIANICGPPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x828D830", Offset = "0x828C630", VA = "0x18828D830")]
	public void NKHKKBHAAMH([Out] RigidTransform FJMAKPDKOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x828C2C0", Offset = "0x828B0C0", VA = "0x18828C2C0")]
	public UniformTRS AJBFEGNNBCH()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x828C200", Offset = "0x828B000", VA = "0x18828C200")]
	public void AJBFEGNNBCH([Out] UniformTRS DGPLBJKFJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x828C930", Offset = "0x828B730", VA = "0x18828C930")]
	public UniformTRS BNOPGGOHGAI()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x828C870", Offset = "0x828B670", VA = "0x18828C870")]
	public void BNOPGGOHGAI([Out] UniformTRS FJMAKPDKOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x828CDF0", Offset = "0x828BBF0", VA = "0x18828CDF0")]
	public Vector3 IKPPHFBBGEC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x828C2F0", Offset = "0x828B0F0", VA = "0x18828C2F0")]
	public void ALBAKKJJDPA([In] Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x828CAE0", Offset = "0x828B8E0", VA = "0x18828CAE0")]
	public Vector3 EDLAABMFDPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x828DAA0", Offset = "0x828C8A0", VA = "0x18828DAA0")]
	public void ONHEGDIENND([In] Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x828D370", Offset = "0x828C170", VA = "0x18828D370")]
	public Quaternion LJOMFNLOMEH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x828D590", Offset = "0x828C390", VA = "0x18828D590")]
	public void MDAFHOJMLDL([In] Quaternion BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x828C0B0", Offset = "0x828AEB0", VA = "0x18828C0B0")]
	public Quaternion AHPBGMFCFEJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x828DCC0", Offset = "0x828CAC0", VA = "0x18828DCC0")]
	public void PMDMPGGAPHP([In] Quaternion BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x828D180", Offset = "0x828BF80", VA = "0x18828D180")]
	public float KDABANMIGIE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x828C4B0", Offset = "0x828B2B0", VA = "0x18828C4B0")]
	public void AMMCCOALHDO(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x828D220", Offset = "0x828C020", VA = "0x18828D220")]
	public float KKMFFMEBLKI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x828C960", Offset = "0x828B760", VA = "0x18828C960")]
	public void CJDGCPFKFHJ(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x828CCA0", Offset = "0x828BAA0", VA = "0x18828CCA0")]
	public Vector3 HFPLNBIOIPJ([In] Vector3 NCJMIJBPLIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public DKDBIKPMIGP(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x828CBD0", Offset = "0x828B9D0", VA = "0x18828CBD0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(DKDBIKPMIGP LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public readonly struct DMCGNDLDDNL : IEquatable<DMCGNDLDDNL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	private EIBMPDFBJFM INIKKICIODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x828E000", Offset = "0x828CE00", VA = "0x18828E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public AIJLMLNJMHO FNKEDPICBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(AIJLMLNJMHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	private HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x82872D0", Offset = "0x82860D0", VA = "0x1882872D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x828DEC0", Offset = "0x828CCC0", VA = "0x18828DEC0")]
	public void IALPACJKCJD(string PEGIKAFHCAA, EDGBMDEGHHB NMBGECILFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public DMCGNDLDDNL(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x828DE30", Offset = "0x828CC30", VA = "0x18828DE30", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(DMCGNDLDDNL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8287BE0", Offset = "0x82869E0", VA = "0x188287BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct HIIKECOHIBN : IEquatable<HIIKECOHIBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public OGAPBCAHLMD MLKOEGDMBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x8292A90", Offset = "0x8291890", VA = "0x188292A90")]
		get
		{
			return default(OGAPBCAHLMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public HIIKECOHIBN(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x8292B80", Offset = "0x8291980", VA = "0x188292B80", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(HIIKECOHIBN LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct IANKPEGHJMC : IEquatable<IANKPEGHJMC>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct BGFEFENBPBF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JDKDDPDJCCM OPKFGAAECNB;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x828ABC0", Offset = "0x82899C0", VA = "0x18828ABC0")]
		public BGFEFENBPBF(JDKDDPDJCCM OPKFGAAECNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x828AB30", Offset = "0x8289930", VA = "0x18828AB30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x82932B0", Offset = "0x82920B0", VA = "0x1882932B0")]
	public BGFEFENBPBF JBOLPLJBMOH()
	{
		return default(BGFEFENBPBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x8293400", Offset = "0x8292200", VA = "0x188293400")]
	public MIMNMKBHKJO OPHGKOAONMI(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(MIMNMKBHKJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x82930C0", Offset = "0x8291EC0", VA = "0x1882930C0")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> IBGBCOEKOOJ(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x82934F0", Offset = "0x82922F0", VA = "0x1882934F0")]
	public NativeArray<CAPEGOJHEPC> PMNANKGPJFG(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(NativeArray<CAPEGOJHEPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8292EC0", Offset = "0x8291CC0", VA = "0x188292EC0")]
	public NativeArray<CAPEGOJHEPC> DBCFNHHIKAN(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(NativeArray<CAPEGOJHEPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x82931F0", Offset = "0x8291FF0", VA = "0x1882931F0")]
	public OEPFMPMHIKM IEDBBBJABBI(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x8293000", Offset = "0x8291E00", VA = "0x188293000")]
	public OEPFMPMHIKM GHPPEPIHPIM(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8293340", Offset = "0x8292140", VA = "0x188293340")]
	public OEPFMPMHIKM NJEOADFMLJJ(Allocator DFGMDNGNOEN = Allocator.Temp)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public IANKPEGHJMC(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8292F70", Offset = "0x8291D70", VA = "0x188292F70", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(IANKPEGHJMC LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x828FD90", Offset = "0x828EB90", VA = "0x18828FD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct GDMFLBOICFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public int EDLEONMOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int PBHNNJBGGPD;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct FFKAMMEFNKE : IEquatable<FFKAMMEFNKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public IANKPEGHJMC ENIHFABBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IANKPEGHJMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public OMPEEJJJIHN PCINKEMPDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(OMPEEJJJIHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public HIIKECOHIBN LMLHMCHHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(HIIKECOHIBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x828FAE0", Offset = "0x828E8E0", VA = "0x18828FAE0")]
	public bool AKCGJACKHBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x828FC10", Offset = "0x828EA10", VA = "0x18828FC10")]
	public bool PMGDOJEHKNP([Out] Exception OLHKHMAKOHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public FFKAMMEFNKE(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JDKDDPDJCCM JGGBAIGHKJA(FFKAMMEFNKE BNECONOIKOE)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x828FB80", Offset = "0x828E980", VA = "0x18828FB80", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(FFKAMMEFNKE LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x828FD90", Offset = "0x828EB90", VA = "0x18828FD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct HECOEICBNBA : IDisposable, IEquatable<HECOEICBNBA>
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly HECOEICBNBA MHCIMCOEBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public FFKAMMEFNKE DAHCGELOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(FFKAMMEFNKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public IANKPEGHJMC ENIHFABBFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(IANKPEGHJMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x8292910", Offset = "0x8291710", VA = "0x188292910")]
	public void LADEKGMCDCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x82927B0", Offset = "0x82915B0", VA = "0x1882927B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public HECOEICBNBA(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x8292880", Offset = "0x8291680", VA = "0x188292880", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "5")]
	public bool Equals(HECOEICBNBA LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x8292990", Offset = "0x8291790", VA = "0x188292990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct OMPEEJJJIHN : IEquatable<OMPEEJJJIHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly JDKDDPDJCCM ANPENHHJGPC;

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public bool IHCLDJNAJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x829E9F0", Offset = "0x829D7F0", VA = "0x18829E9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	public OMPEEJJJIHN(JDKDDPDJCCM OPKFGAAECNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x82861B0", VA = "0x1882873B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x829EA80", Offset = "0x829D880", VA = "0x18829EA80", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x8287170", Offset = "0x8285F70", VA = "0x188287170", Slot = "4")]
	public bool Equals(OMPEEJJJIHN LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x828FD90", Offset = "0x828EB90", VA = "0x18828FD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class AFEBFNFNBGE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private struct CDGEFDBANHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Guid OKDHAOKOGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public DCPBKCGALLP IMJDBHMDBKE;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct DCPBKCGALLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int BNECONOIKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int PHAEOJDOJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int DMHBJPKKNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int GAPKHLDJGNK;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x828BBA0", Offset = "0x828A9A0", VA = "0x18828BBA0")]
		public bool MLAJFNDABNP([Out] CAPEGOJHEPC GOPPKIOICJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x828BC40", Offset = "0x828AA40", VA = "0x18828BC40")]
		public DCPBKCGALLP(CAPEGOJHEPC GOPPKIOICJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x82885B0", Offset = "0x82873B0", VA = "0x1882885B0")]
	public static Guid EDPMLEJBCPC(this CAPEGOJHEPC GOPPKIOICJL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x8288650", Offset = "0x8287450", VA = "0x188288650")]
	public static bool LDGNCPMECHD(this Guid OKDHAOKOGCM, [Out] CAPEGOJHEPC GOPPKIOICJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class MPNOGEAECIL
{
	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x8298470", Offset = "0x8297270", VA = "0x188298470")]
	public static HPOJOGMGCFK AFIEDGNBCBD(this JDKDDPDJCCM PPPFBKMGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x8298500", Offset = "0x8297300", VA = "0x188298500")]
	public static MODFEFDOPCN HHGCCIBDEIG(this JDKDDPDJCCM PPPFBKMGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x8298560", Offset = "0x8297360", VA = "0x188298560")]
	public static EntityManager IKHIKBCMLKE(this JDKDDPDJCCM PPPFBKMGIMA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3240", Offset = "0x3CA2040", VA = "0x183CA3240")]
	internal static bool HHINGPOMLCF<T>(this JDKDDPDJCCM PPPFBKMGIMA, bool GPJMDAINDNC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x82985F0", Offset = "0x82973F0", VA = "0x1882985F0")]
	public static bool NKJKHHEKHNA(this JDKDDPDJCCM PPPFBKMGIMA, IPPNBDGDCLE DAGPCGHBFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x3CA4E30", Offset = "0x3CA3C30", VA = "0x183CA4E30")]
	public static bool NBLFLOHKFOP<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2FC0", Offset = "0x3CA1DC0", VA = "0x183CA2FC0")]
	public static bool BJNBCDKHCCP<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CA34B0", Offset = "0x3CA22B0", VA = "0x183CA34B0")]
	[GJJEAFKABFF]
	public static T LIHGKICIJBD<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x3CA5830", Offset = "0x3CA4630", VA = "0x183CA5830")]
	[GJJEAFKABFF]
	public static T OFAHOBJPNOL<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3120", Offset = "0x3CA1F20", VA = "0x183CA3120")]
	public static bool EBKNEDPBJFP<T>(this JDKDDPDJCCM PPPFBKMGIMA, [Out] T BNECONOIKOE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3400", Offset = "0x3CA2200", VA = "0x183CA3400")]
	public static T KBMKLLHIBMJ<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CA85B0", Offset = "0x3CA73B0", VA = "0x183CA85B0")]
	public static T PANDJBIDOMN<T>(this JDKDDPDJCCM PPPFBKMGIMA) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal static class CMMNMNPFNJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public struct MIMNMKBHKJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private OEPFMPMHIKM GGCHDPHENOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IDBCCPGBCBO;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5F3E090", Offset = "0x5F3CE90", VA = "0x185F3E090")]
	public MIMNMKBHKJO(OEPFMPMHIKM GGCHDPHENOB, NativeArray<EntityRemapUtility.EntityRemapInfo> IDBCCPGBCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x8297D10", Offset = "0x8296B10", VA = "0x188297D10")]
	public LocalId BKCNAOEALPI(LocalId MKPNGAKJFMP)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x8297CC0", Offset = "0x8296AC0", VA = "0x188297CC0")]
	public LocalId BKCNAOEALPI(int CKFKPOAGPKN)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x8297D50", Offset = "0x8296B50", VA = "0x188297D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEAFACIBLHE
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NICDFCDCHLB(World HOJGMNLGPDE, NativeParallelHashSet<FixedString64Bytes> LAJAGOBOEPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BAAFKHPJNHL
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFIODDOEPCH(JDKDDPDJCCM AMECNEFIPBJ, [Out] uint PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MEIFCBKHDEA(JDKDDPDJCCM AMECNEFIPBJ, [Out] uint PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNKDJDKGOHL(JDKDDPDJCCM AMECNEFIPBJ, uint PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MFMLNFPJCHF(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string JDLAGBMBOGM(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDKGMKIHHJD(JDKDDPDJCCM AMECNEFIPBJ, string PPPFBKMGIMA);

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PMBBMKILOHF(JDKDDPDJCCM AMECNEFIPBJ, [Out] string MEBIFHCKKFO);

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KNJDLNDJHGH(JDKDDPDJCCM AMECNEFIPBJ, string MEBIFHCKKFO);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABBJJOAJNJJ
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	Guid OAKJMBJPLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	Guid PENBFBNCABL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECHOMAGNBPD(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CNIEELCEBCF(AIJLMLNJMHO MKPNGAKJFMP);

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid FANIMKIFNOD(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEGKJOAFELJ(JDKDDPDJCCM OPKFGAAECNB, Guid BPBNOKKGEDO);

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDFAPAJKAIM(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OECDEKEFCAP(JDKDDPDJCCM CCEEMHPLNFI, JDKDDPDJCCM CMDMCJGFCDK);

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AJDDFIKHOAM(JDKDDPDJCCM OPKFGAAECNB, CAPEGOJHEPC ADOLGBMNOIK);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ILADIDAPAKL
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	Guid OAKJMBJPLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KELOCENKCCP(NativeList<Guid> MANPAHBLLNF, NativeList<Guid> FMAFEIGFOOM, NativeList<FixedString64Bytes> FNHODKKBKOB);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AEHJLAMNOJF
{
	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEPFMPMHIKM OIMFMDAFKPI(Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OEPFMPMHIKM GEADGNPBAEL(Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BCPKGPIPPHC(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CMPHIDHNPGA(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KFPGDNGILED(JDKDDPDJCCM AMECNEFIPBJ, [Out] JDKDDPDJCCM JMMNMLGELPH);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BAOPABDHFMI(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PIHCLOPAOHL(JDKDDPDJCCM AMECNEFIPBJ, int FLHCGDNOCHL);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JDKDDPDJCCM CIPAOMCGBOG(JDKDDPDJCCM JMMNMLGELPH);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LKEEKCINFDI(OEPFMPMHIKM NNMEILBDPAF, bool BLOLPHJCFEO);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IGHEMGDHDNC(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HABBDANNOLP(JDKDDPDJCCM AMECNEFIPBJ, bool DIKMHMMHNEG);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OJAHMJJAJKK();

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MPEEDLPDFAD(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OCKCODPKJMC
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JDKDDPDJCCM, JDKDDPDJCCM> LJILGOIMFCD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JDKDDPDJCCM, JDKDDPDJCCM> FPCDPHEGBMN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JDKDDPDJCCM, JDKDDPDJCCM, JDKDDPDJCCM> FEOPMGFJOPI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JDKDDPDJCCM> NIMMLCJDCKB;

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ILHEPHGIKNM(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM BCHAJLPHOCJ);

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JDKDDPDJCCM IALLPLFKDOJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OEPFMPMHIKM AAJFPEALPLP(JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JDKDDPDJCCM CDPPCNFBANO(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ICGDBBOEDKB(JDKDDPDJCCM OPKFGAAECNB, Vector3 AHONFNANHOA, Quaternion CFNHDKBODKB);

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CMFACFDPNBA(JDKDDPDJCCM OPKFGAAECNB, float JPCENJALCCP);

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CHHDFNEALJI(JDKDDPDJCCM OPKFGAAECNB, [Out] JDKDDPDJCCM CMDMCJGFCDK);

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NNOLJBOJLCI(JDKDDPDJCCM OPKFGAAECNB, [Out] RigidTransform PDKCLPBMPFC);

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 BMHMBIINMEI(AMFKOAHBIDM IPCPMJOJNDE);

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion DOINGJIOKFL(AMFKOAHBIDM IPCPMJOJNDE);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class CKLHHOLIAOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OIHCNBECOFH
{
	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	object IOELIDJHBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IAGLFNADJLM
{
	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAKPLKOJPBK(JDKDDPDJCCM MKPNGAKJFMP, IIJPOAKLDNG KPNIMMJCFHO);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCLPKDPDGOJ(IIJPOAKLDNG KPNIMMJCFHO);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EAOLHMIIMOP(JDKDDPDJCCM OPKFGAAECNB, [Out] IIJPOAKLDNG AFNCIAAIODI);
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Flags]
public enum AIPKBIHGJEO
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HIKCCKAFNKH
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public ref struct BDCEIJCDAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ReadOnlySpan<JDKDDPDJCCM> LNHOEMDKKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public ReadOnlySpan<JDKDDPDJCCM> FNFNALNBPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public JDKDDPDJCCM LHEMCGICDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JDKDDPDJCCM NBKOBLBKPOF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLAGJBJNMIO(JDKDDPDJCCM JHJHPKBMHIF, JDKDDPDJCCM CNEFMKLFLOO);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FNDBGBJBOMM(JDKDDPDJCCM PEHLPDAABGI, bool ADJOPEHJOFG);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGIBLLMFNJH(JDKDDPDJCCM GDFCECMAAMK, JDKDDPDJCCM DIGMPMNFHBG);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBOKCGONCHF(JDKDDPDJCCM AGPNNEOOLAK, bool ADJOPEHJOFG);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AEDICOGDCNL(JDKDDPDJCCM AGPNNEOOLAK);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FOGIBIGGNND(JDKDDPDJCCM AGPNNEOOLAK);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JDKDDPDJCCM BCDCLFIFGBJ(JDKDDPDJCCM PEHLPDAABGI);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ReadOnlySpan<JDKDDPDJCCM> LJGAGKMCAEO(JDKDDPDJCCM AGPNNEOOLAK);

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ReadOnlySpan<JDKDDPDJCCM> FKGHGHNPFNO(JDKDDPDJCCM AGPNNEOOLAK);

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BDCEIJCDAOE EIFHJKBMJAP(JDKDDPDJCCM AGPNNEOOLAK, float FLPAMGIBAKO, float JOEEINLGLNC);

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JLAJMODIDDA(JDKDDPDJCCM AGPNNEOOLAK, [Out] AACFAAJHHIH OLJEMIPCECB);

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FPCAEAMIEKJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BGOKDPDJLAL(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public readonly struct FEHPJKCNCDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string GGDFKFACHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly T JILABBLHNAO;

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x4CA3DA0", Offset = "0x4CA2BA0", VA = "0x184CA3DA0")]
	public FEHPJKCNCDI(T JILABBLHNAO, [Optional][CallerMemberName] string GGDFKFACHGG)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public static readonly FEHPJKCNCDI<int> HLLHOHHNKOL;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly FEHPJKCNCDI<int> GOPOGFBJLIN;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly FEHPJKCNCDI<int> JNCHHDLABBC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public enum ACJOLJIILFO
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class LJNMNGGILHH
{
	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x141F480", Offset = "0x141E280", VA = "0x18141F480")]
	public static bool BGFNILCJJEC(this ACJOLJIILFO EOMNODKHFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1839550", Offset = "0x1838350", VA = "0x181839550")]
	public static bool OHIEKIIDENP(this ACJOLJIILFO EOMNODKHFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x3095CD0", Offset = "0x3094AD0", VA = "0x183095CD0")]
	public static bool BJEOPKBEDDI(this ACJOLJIILFO EOMNODKHFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x141F490", Offset = "0x141E290", VA = "0x18141F490")]
	public static bool FBNEGFMKFIC(this ACJOLJIILFO EOMNODKHFBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface FPMAJFIICKB
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum GHDNLJHFIPC
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public enum AGEAIHKJLAA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	GHDNLJHFIPC BAPCMLDCILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	bool EEBEELFNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	bool OBPKPFKOJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	AGEAIHKJLAA JEPLADGDGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.Application)]
public interface GFGMPGJEPMF
{
	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	ACJOLJIILFO JLNHMPHFLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	ACJOLJIILFO AJBMEKOGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	ACJOLJIILFO GNODFELOGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	ACJOLJIILFO LKMBLBJMLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	ACJOLJIILFO ONNCDJBBEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	ACJOLJIILFO CCNNOJGHDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	ACJOLJIILFO LAHMKAMNHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	ACJOLJIILFO BDMMAOAKCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	ACJOLJIILFO FDFPJFBCGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	ACJOLJIILFO JKFKDIAIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	ACJOLJIILFO PMANMANCKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	ACJOLJIILFO MDLJKOMJABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	ACJOLJIILFO KMDGLIDMEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	ACJOLJIILFO CFIKFKACJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	ACJOLJIILFO FAPCJIOGEIP
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	ACJOLJIILFO DEOHMCKBNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	ACJOLJIILFO ENDCEEMJMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	ACJOLJIILFO OBPPIDPIHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	ACJOLJIILFO IMDOLMMHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	ACJOLJIILFO FMCKFNFJJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LHCLHJGACJJ(FEHPJKCNCDI<int> FNFCFIGCMHH);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EDOOOMLBJKI
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NKCPDMFAKCK.BBCBMBAELGE CNJGMLIAPJP;

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JDKDDPDJCCM BFPBIEMMEFF(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OEPFMPMHIKM NJFDLFBPBON(Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NPPBMLMJGNJ NDNDKALOKKE(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GAELBMGKAGH(IEnumerable<JDKDDPDJCCM> HCPCPDIPOGC);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NPPBMLMJGNJ LLFDEFMDIFB(JDKDDPDJCCM CMDMCJGFCDK, JDKDDPDJCCM GGCHDPHENOB, bool EELIABHFIAA, JDKDDPDJCCM IMBAOPHEODM);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JDKDDPDJCCM AEBFDDKIMKJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IALDJKPIPLJ(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM CMDMCJGFCDK, bool JJPNGIOOAIB = false);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GGOIBIKBJMN(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM CMDMCJGFCDK);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OJFHJMCKOIJ(JDKDDPDJCCM AEOIFKMEEEJ, JDKDDPDJCCM OMJCEOBOCEN);

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	OEPFMPMHIKM BFAGOIMLKCD(JDKDDPDJCCM ANPENHHJGPC);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IIPMHLAHKDL(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM LFFENBJJAJK);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OEPFMPMHIKM FBHMOBPLBBA(OEPFMPMHIKM JKGNPCJCFMG, AIPKBIHGJEO AALJBKNKHCP, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EBLNBCJFJDG(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM NLIKAMKMMLM);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JDKDDPDJCCM IPEBEKFEANJ(JDKDDPDJCCM IMBAOPHEODM, JDKDDPDJCCM IEAFAEEGDBB);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FHHKBPEINPH(JDKDDPDJCCM IMBAOPHEODM, JDKDDPDJCCM IEAFAEEGDBB, [Out] JDKDDPDJCCM GIDECCJIHEH);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JDKDDPDJCCM ACJAJDLJCHB(JDKDDPDJCCM[] NNMEILBDPAF);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JDKDDPDJCCM FBBJCJKFEIG(JDKDDPDJCCM OPKFGAAECNB, uint LODAADCJLGO);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class OEMCADBAOBB
{
	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x829CEA0", Offset = "0x829BCA0", VA = "0x18829CEA0")]
	public static bool HOLBLDFKNNC(this EDOOOMLBJKI FDEBGGJNHID, JDKDDPDJCCM OPKFGAAECNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x829CB90", Offset = "0x829B990", VA = "0x18829CB90")]
	public static OEPFMPMHIKM FBHMOBPLBBA(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, AIPKBIHGJEO AALJBKNKHCP, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x829C9F0", Offset = "0x829B7F0", VA = "0x18829C9F0")]
	public static OEPFMPMHIKM EBDMCFNGNKK(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x829CE60", Offset = "0x829BC60", VA = "0x18829CE60")]
	public static OEPFMPMHIKM HGEPCGONIEJ(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x829CF10", Offset = "0x829BD10", VA = "0x18829CF10")]
	public static OEPFMPMHIKM ONJHDEGKJGO(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x829C9B0", Offset = "0x829B7B0", VA = "0x18829C9B0")]
	public static OEPFMPMHIKM DOEAKEEMHLJ(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x829CE20", Offset = "0x829BC20", VA = "0x18829CE20")]
	public static OEPFMPMHIKM FMLIGEBIHOI(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x829CB50", Offset = "0x829B950", VA = "0x18829CB50")]
	public static OEPFMPMHIKM FAGPMGMFLLD(this EDOOOMLBJKI CDKAHLOIJBE, JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x829CA30", Offset = "0x829B830", VA = "0x18829CA30")]
	public static OEPFMPMHIKM FAGPMGMFLLD(this EDOOOMLBJKI CDKAHLOIJBE, OEPFMPMHIKM OPKFGAAECNB, Allocator DFGMDNGNOEN)
	{
		return default(OEPFMPMHIKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KNCFPDKBHDF
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x82976C0", Offset = "0x82964C0", VA = "0x1882976C0", Slot = "0")]
	Task<FFKAMMEFNKE> LFMDIFMNHGF(NPBBPECINAL DEFAOIMGIPN, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "1")]
	void DOHDPHLKBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PFNANCDILGF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event NKCPDMFAKCK.BBCBMBAELGE CNJGMLIAPJP;

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JDKDDPDJCCM AEBFDDKIMKJ(JDKDDPDJCCM CCEEMHPLNFI);

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<JDKDDPDJCCM> MNNNHKDKLPD();

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<JDKDDPDJCCM> MHHMCPCDEAK(JDKDDPDJCCM CMDMCJGFCDK);

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NBAJHMKNKIB(JDKDDPDJCCM EAJDDAEHIGP, JDKDDPDJCCM AKOCIAHBFDC, [Out] NPPBMLMJGNJ EKDAILLDPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EKJCHNCFHJJ(JDKDDPDJCCM EAJDDAEHIGP, JDKDDPDJCCM IPGJCGMOMFK, [Out] NPPBMLMJGNJ EKDAILLDPHJ);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ENDKKMMJFJH(JDKDDPDJCCM EAJDDAEHIGP);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GGOIBIKBJMN(JDKDDPDJCCM NIKHAEJFBAK, JDKDDPDJCCM HCGMLNGABFM);

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NPPBMLMJGNJ IKEGBLKGCDN(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DBCPHJOAPCI
{
	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	bool AFKCKJAKAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	bool EGFCOFDOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	bool GABEMBHNMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GBFIEFKGGCE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANAAJFIEPBL
{
	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCDIFIJNEJN(JDKDDPDJCCM OPKFGAAECNB, IPPNBDGDCLE DAGPCGHBFAL);

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFBCEDCEKCE(JDKDDPDJCCM OPKFGAAECNB, IPPNBDGDCLE DAGPCGHBFAL);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface AOJNJKOEMJE
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPOPDMAPGMA<string> OHMMLMIKAHP(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CPOPDMAPGMA<string> AJNCCBBGGHM(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMBGLKEELNB(JDKDDPDJCCM OPKFGAAECNB, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKGLMIFFIHN(JDKDDPDJCCM OPKFGAAECNB, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBHPBPPACBL(JDKDDPDJCCM BKGGFDJEIBJ, JDKDDPDJCCM HNCPJGPCADK);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ADJGBFGNAOC
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCFBDHPDABC MBOLKHFJNGC(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMEGMGPIJLD(JDKDDPDJCCM AMECNEFIPBJ, OCFBDHPDABC CFBNCPPPJID);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OJPNNAKHDKO(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAEKBOMMKDP(JDKDDPDJCCM AMECNEFIPBJ, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CPOPDMAPGMA<string> KJCPJOPJPFD(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHPFJPFPDDM(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CPOPDMAPGMA<string> BFHKGAEIFCL(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPBJEHCJHCO(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CPOPDMAPGMA<string> IBFAAJOAGNH(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJBGGOFOMAE(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CPOPDMAPGMA<string> KDBHEABAAIE(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GIANACHCIBN(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MBOCJAGKIEP(JDKDDPDJCCM AMECNEFIPBJ, JDKDDPDJCCM IFADLDJHCLA);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CAHPIPLDCGP
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODFNLCIDHDN([In] float3 JKBPBEFFDAH, [In] float3 NCJMIJBPLIB, float NGOCCMOBNDC, [Out] EDGHDDDFBFB IAJOODBPJME, [Out] JDKDDPDJCCM BJIHLOBCEHA);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NFKEPLCLGBM([In] float3 JKBPBEFFDAH, float LNLGAMEGNNM, List<JDKDDPDJCCM> NNMEILBDPAF);

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FEJBNKIBKEH(Plane[] HBLEDMHMAOB, float3 JKBPBEFFDAH, float3 DOEACPNFOPC, quaternion NOLDGDLLBBL, List<JDKDDPDJCCM> NNMEILBDPAF);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IHHEAGKBAHL
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODFNLCIDHDN([In] NativeArray<Entity> DIDGDGLCMEE, [In] float3 JKBPBEFFDAH, [In] float3 NCJMIJBPLIB, [In] NativeArray<EDGHDDDFBFB> OMAJJKMJNEO);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> NFKEPLCLGBM([In] NativeArray<Entity> DIDGDGLCMEE, [In] float3 JKBPBEFFDAH, float LNLGAMEGNNM);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> FEJBNKIBKEH([In] NativeArray<Entity> DIDGDGLCMEE, [In] NativeArray<float4> KEFPNALEOME);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct ONDDCLACNKL : FOLAMDMFEJK, IEquatable<ONDDCLACNKL>
{
	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public int GBFKBOHPEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	public int CALPLMDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x30BACB0", Offset = "0x30B9AB0", VA = "0x1830BACB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x6E47E60", Offset = "0x6E46C60", VA = "0x186E47E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x829EB10", Offset = "0x829D910", VA = "0x18829EB10", Slot = "8")]
	public bool Equals(ONDDCLACNKL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x829EB60", Offset = "0x829D960", VA = "0x18829EB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct EDGHDDDFBFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float BCCLIHOBHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float3 LCJFLGICHDD;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FMADNNMFGDP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BPAIJKJGNLD
{
	[Cpp2IlInjected.Token(Token = "0x170001EF")]
	HPOJOGMGCFK AFIEDGNBCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F0")]
	NIPKNLAGELI JJIIHNMOCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<OEPFMPMHIKM, NativeArray<RRObjectPrefabData>> CGEHEGJOJGC;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<OEPFMPMHIKM> JACOHDLOAOP;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OEPFMPMHIKM LFFMMPGKDEL();

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "7")]
	INGCOGFFNEN DEOEGNAPGJJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData GLOINHALMPI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LLNLPFAEOMF(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AIJLMLNJMHO KCGKHNNAOEL(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MEHEBNABCBB(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AACIAMLHEKG(JDKDDPDJCCM OPKFGAAECNB, [Out] Transform OLPMPAIMKPI);

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JDKDDPDJCCM KKOPLJOCPCP(CAPEGOJHEPC GOPPKIOICJL);

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BOHAIAKPMMJ(CAPEGOJHEPC GOPPKIOICJL, [Out] JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CAPEGOJHEPC LGKCFJLCJFJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OEPFMPMHIKM KKOPLJOCPCP(NativeArray<CAPEGOJHEPC> GOPPKIOICJL, Allocator DFGMDNGNOEN, bool ELLKGJGBPDI = true);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool AAECAGMOAKF(NativeArray<CGLMIHLAAFA> KBBEPFDGENE, NativeArray<CAPEGOJHEPC> KOJJKCDCGGC, NativeArray<Entity> LONEHDPAEKN, CPOPDMAPGMA<EFKFDJFEDAB> LGBBPEMEILJ);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AIJLMLNJMHO KCKFPEMNGDD();

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AIJLMLNJMHO PCKHODFHJHP(RRObjectPrefabData OBELFNBLHMI, [Optional] PIFBFEKACLF HLGNKBGDBOL);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "20")]
	JECMMHKCCMF IICGKHBAFEN();

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HBGMJPLFBFM KGIMIMPCBJP();

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EIHJBDFNKGB MMJNEOLCECA(FHBADAKFFGA GFEEALJGLBA);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EMECBBBMCMI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool DOGDFJFEMEB(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "25")]
	OEPFMPMHIKM PFOGALHEILJ(OEPFMPMHIKM JPLOHBGMEHN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool FGHKILHPKEI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IGHNBJGAHGD(JDKDDPDJCCM OPKFGAAECNB, ComponentTypes BHFOMOBCJEB);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JDKDDPDJCCM FNLHEFIPJBG(Transform OLPMPAIMKPI);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class GGPAFAINIIH
{
	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x82907C0", Offset = "0x828F5C0", VA = "0x1882907C0")]
	internal static JDKDDPDJCCM KJIDDLGEOPC(this Entity ALBBAEBLONH, BPAIJKJGNLD NMBGECILFAB)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8290B70", Offset = "0x828F970", VA = "0x188290B70")]
	public static AIJLMLNJMHO OJGLNACFGNK(this BPAIJKJGNLD NMBGECILFAB, LocalId OPKFGAAECNB)
	{
		return default(AIJLMLNJMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8290870", Offset = "0x828F670", VA = "0x188290870")]
	public static JDKDDPDJCCM KKOPLJOCPCP(this BPAIJKJGNLD NMBGECILFAB, LocalId OPKFGAAECNB)
	{
		return default(JDKDDPDJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8290920", Offset = "0x828F720", VA = "0x188290920")]
	public static CAPEGOJHEPC LGKCFJLCJFJ(this BPAIJKJGNLD NMBGECILFAB, LocalId OPKFGAAECNB)
	{
		return default(CAPEGOJHEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x8290460", Offset = "0x828F260", VA = "0x188290460")]
	public static JECMMHKCCMF EFHBLJMEDCC(this BPAIJKJGNLD NMBGECILFAB, RigidTransform DGPLBJKFJOK)
	{
		return default(JECMMHKCCMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x8290610", Offset = "0x828F410", VA = "0x188290610")]
	public static EIHJBDFNKGB IPJJMLKCEPH(this BPAIJKJGNLD NMBGECILFAB, FHBADAKFFGA FBIBFNHIELC, RigidTransform DGPLBJKFJOK)
	{
		return default(EIHJBDFNKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x8290990", Offset = "0x828F790", VA = "0x188290990")]
	public static HBGMJPLFBFM MHPAEPKABHC(this BPAIJKJGNLD NMBGECILFAB, RigidTransform DGPLBJKFJOK)
	{
		return default(HBGMJPLFBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x8290B40", Offset = "0x828F940", VA = "0x188290B40")]
	private static void OGBIJKLHJLC(AIJLMLNJMHO NACLAOADMMG, RigidTransform DGPLBJKFJOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal interface GMLEAEELNAO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JDOGMDHELLG
{
	[Cpp2IlInjected.Token(Token = "0x170001F1")]
	bool FANBFDDOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F2")]
	JDKDDPDJCCM APIPCAAJEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F3")]
	AIJLMLNJMHO FAEPMCJAGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NOMELPFGNBP GKNPBOMDIPC;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JDKDDPDJCCM IPEBEKFEANJ(JDKDDPDJCCM IMBAOPHEODM, JDKDDPDJCCM IEAFAEEGDBB);

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FHHKBPEINPH(JDKDDPDJCCM IMBAOPHEODM, JDKDDPDJCCM IEAFAEEGDBB, [Out] JDKDDPDJCCM GIDECCJIHEH);

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HJINCGEHHNK();

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMFHGALHHHG();

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HCKPMIFLFLC(JDKDDPDJCCM IMBAOPHEODM);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BFBHAIDIBKG(JDKDDPDJCCM IMBAOPHEODM);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public delegate void NOMELPFGNBP(AIJLMLNJMHO JHFBKDNLKOM, AIJLMLNJMHO LDKPNMBKKJN);
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class JABIPNEBBBD
{
	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x82942A0", Offset = "0x82930A0", VA = "0x1882942A0")]
	public static bool EBGGJAENLLP(this JDOGMDHELLG BFMEHBLDAOO, AIJLMLNJMHO IMBAOPHEODM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x82942F0", Offset = "0x82930F0", VA = "0x1882942F0")]
	public static bool ELJJDLHNJHI(this JDOGMDHELLG BFMEHBLDAOO, JDKDDPDJCCM IMBAOPHEODM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x8294220", Offset = "0x8293020", VA = "0x188294220")]
	public static bool ALODNPMGLJJ(this JDOGMDHELLG BFMEHBLDAOO, JDKDDPDJCCM IMBAOPHEODM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OJAIIPJBJMI
{
	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJCDPEKMOML(NativeList<RRObjectPrefabData> DNLBJKOHJFG);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKCJBCJCJCD
{
	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFLGOAHDMCE(AIJLMLNJMHO NACLAOADMMG, EOBJDHADOCF INALECHHMIH, List<AIJLMLNJMHO> NFMOHCFHBBO);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PPNKLIKJIMG(AIJLMLNJMHO NACLAOADMMG, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDAIDOGNHBK(AIJLMLNJMHO NACLAOADMMG, List<AIJLMLNJMHO> NFMOHCFHBBO);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GEOKHIPDOII(AIJLMLNJMHO PBHKHJPMFCF, AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIJLMLNJMHO PLKOBJBJNEF(AIJLMLNJMHO PBHKHJPMFCF, int CKFKPOAGPKN, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHCIHEMBLIC(AIJLMLNJMHO PBHKHJPMFCF, AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BMFGKFIGMGK(AIJLMLNJMHO PBHKHJPMFCF, AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLMKEPINAMK(AIJLMLNJMHO PBHKHJPMFCF, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GMNPIGPANCH(AIJLMLNJMHO PBHKHJPMFCF, AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BMJKNGMGELJ(Entity PBHKHJPMFCF, Entity IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNGHDNFPKBA(Entity PBHKHJPMFCF, EOBJDHADOCF INALECHHMIH);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OCLIEELAEJF(AIJLMLNJMHO IMBAOPHEODM, EOBJDHADOCF INALECHHMIH);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JGPMNBLHELC
{
	[Cpp2IlInjected.Token(Token = "0x170001F4")]
	HIIKECOHIBN JBCEBKLJKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGAPBCAHLMD HMNIBMMIAHG(HIIKECOHIBN DHLFBBHICBC);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIIKECOHIBN KBCNLGGBDKL();

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIIKECOHIBN IKCMOGJPEMF();
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JJCBFBHJJLC
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CDBACJECIPA(JDKDDPDJCCM IMBAOPHEODM, [Out] JDKDDPDJCCM LMABEACKJHD);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NAJKJLCDLOL
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JDKDDPDJCCM> KEFAFHNIPHA;

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGPNLMGIKAF(JDKDDPDJCCM ANPENHHJGPC, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNMJGIDDMBI(JDKDDPDJCCM ANPENHHJGPC, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPFAFMOAGAM(JDKDDPDJCCM ANPENHHJGPC, int BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DFBJDJEKDBJ
{
	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JDKDDPDJCCM> PHAFMPKLFFE(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDKDDPDJCCM JHFPDPPCFKO(JDKDDPDJCCM OPKFGAAECNB, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FJGKPKFJCEA(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GGKKLOFKKIO CICDLKMFEAA(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFFBAHAGCHP(JDKDDPDJCCM OPKFGAAECNB, GGKKLOFKKIO OAEBFAAHGEJ);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JDKDDPDJCCM BCHIAFLEFHO(JDKDDPDJCCM OPKFGAAECNB, [Optional] float3? EMECBHNHILC, [Optional] quaternion? NOLDGDLLBBL, [Optional] float3? AMJKMJIBGNI);

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JDKDDPDJCCM ANOCMBNJKIF(JDKDDPDJCCM OPKFGAAECNB, int CKFKPOAGPKN, [Optional] float3? EMECBHNHILC, [Optional] quaternion? NOLDGDLLBBL, [Optional] float3? AMJKMJIBGNI);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFKDMJNLNJI(JDKDDPDJCCM OPKFGAAECNB, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BPHMBNPPHAA(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GFEHDLHLLEM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LHMALMHGBGP
{
	[Cpp2IlInjected.Token(Token = "0x170001F5")]
	bool MFIAADJONLO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDDMCDMDKJO();

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKLAMCHEGAP();

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCPEAJFHMIC();

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDOMJOGNPJO();

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJGPLBBIOKL();

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KDHLHHEAJBM();

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCFJNCJOGHL();

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDHCIAAFHDL();

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MJFFDOFLBGP();

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HEFKBOPKGLG();

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FAAIHFNKPDB();

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CIODJOLMOFI();
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JKHHLOLPLFC
{
	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBGGMIGBOMK(JDKDDPDJCCM IMBAOPHEODM, [Out] int PBHKHJPMFCF);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIBGFJFBICK(JDKDDPDJCCM IMBAOPHEODM, int PBHKHJPMFCF);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKLIAJIJCEB(JDKDDPDJCCM IMBAOPHEODM, bool CMPNGCMDDEG);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBONKEFODEM(JDKDDPDJCCM IMBAOPHEODM, float FCJGAPHADPM, float OJCABKDGPJK, float FMDNBFHCEHC);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GNPPNJMKHBM(JDKDDPDJCCM OPKFGAAECNB, [Out] float OJCABKDGPJK, [Out] float FMDNBFHCEHC);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPLMOAJEPDK(JDKDDPDJCCM IMBAOPHEODM, float3 EMECBHNHILC, quaternion NOLDGDLLBBL);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CFJDDBNCPNH(JDKDDPDJCCM IMBAOPHEODM, [Out] float3 EMECBHNHILC, [Out] quaternion NOLDGDLLBBL);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OLKLGLHEDKL(JDKDDPDJCCM IMBAOPHEODM);
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ICGPKIBCHFK
{
	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALBAKKJJDPA(Entity ALBBAEBLONH, [In] float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 IKPPHFBBGEC(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDAFHOJMLDL(Entity ALBBAEBLONH, [In] quaternion BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion LJOMFNLOMEH(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BADGEKOENDH(Entity ALBBAEBLONH, [In] float3 EMECBHNHILC, [In] quaternion NOLDGDLLBBL);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDAGCEJFMHE(Entity ALBBAEBLONH, [Out] RigidTransform NBNBHEDGHCG);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFFMIMOBMHK(Entity ALBBAEBLONH, [In] float3 EMECBHNHILC, [In] quaternion NOLDGDLLBBL);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NKHKKBHAAMH(Entity ALBBAEBLONH, [Out] float3 EMECBHNHILC, [Out] quaternion NOLDGDLLBBL);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NKHKKBHAAMH(Entity ALBBAEBLONH, [Out] RigidTransform NBNBHEDGHCG);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AMMCCOALHDO(Entity ALBBAEBLONH, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float KDABANMIGIE(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONHEGDIENND(Entity ALBBAEBLONH, [In] float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 EDLAABMFDPK(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PMDMPGGAPHP(Entity ALBBAEBLONH, [In] quaternion BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion AHPBGMFCFEJ(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CJDGCPFKFHJ(Entity ALBBAEBLONH, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float KKMFFMEBLKI(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IBDODDBNMEN(Entity ALBBAEBLONH, [Out] float4x4 NNHONNMDIEJ);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CBEHNAPAOJJ(Entity ALBBAEBLONH, [In] float4x4 NNHONNMDIEJ);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JIKJINFCEBG(Entity ALBBAEBLONH);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GPIEPLDDFOB(Entity ALBBAEBLONH, Entity MHFMOLFCLCB, Entity HCGMLNGABFM);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class FKCCJLHPIBB
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONKJPPPCEMH
{
	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLCCMLBONIP(bool ELBEIBGFCLG);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EIBMPDFBJFM
{
	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFOLCIHHJOI(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHINDBPNDPP(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEMAGMBDIIF(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCFPMGOBDAD(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NPHHKOIKGFB(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPALEHJJJCF(JDKDDPDJCCM AMECNEFIPBJ, CPOPDMAPGMA<string> JJCDINDALNK);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JFJIDIKMMIH(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int FAICDBCAOMD(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int LHNHAJOCLKA(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GDLAFIILODC<string> CKHCKDADMGO(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JDJLNMAOBKG(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GDLAFIILODC<string> MPFGEFNKDEB(JDKDDPDJCCM AMECNEFIPBJ);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GBLCAMAOLJF(JDKDDPDJCCM AMECNEFIPBJ, string PEGIKAFHCAA);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DDMPFFDLCEM(string PEGIKAFHCAA, EDGBMDEGHHB IPNKNACFDFF);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JDKDDPDJCCM HNNIMNNLNEP(string PEGIKAFHCAA);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MNFHIMAAAII(string PEGIKAFHCAA, EDGBMDEGHHB IPNKNACFDFF);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IALPACJKCJD(JDKDDPDJCCM OPNBIJJAFBI, string PEGIKAFHCAA, EDGBMDEGHHB IPNKNACFDFF);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GDLAFIILODC<string> HEKDDPIBHLE();
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class MDAODPEELIE
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LGIBOOIEIGG
{
	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World JILKJLDILDO(string PLCBOGEALJK = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World GNBNMBCCGGJ(string PLCBOGEALJK = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JGEDHMHBFJI(string PLCBOGEALJK = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World CHAJPHKKANI(string PLCBOGEALJK = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MODFEFDOPCN
{
	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	World GGDHLNNCPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	World OLHOKDELMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	EntityManager IKHIKBCMLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase FMNBENMCPAB(Type DGPNPBEKOOD);
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class DCPCAMKMHBL
{
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x828BC80", Offset = "0x828AA80", VA = "0x18828BC80")]
	public static ComponentSystemBase IEFEIDBELNK(this World HOJGMNLGPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x39E12D0", Offset = "0x39E00D0", VA = "0x1839E12D0")]
	public static T FMNBENMCPAB<T>(this MODFEFDOPCN DOKAGAJAJLH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CGNABPPPHBO
{
	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBOOODEHCNM(NativeListAsync<Entity> ALEOIKKGBIA);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMAFIPCEKEE(IDIIFHDOCJH GLEIEGAJEOE);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPLMPAMAKNA(NativeListAsync<Entity> BJNMOJBEPMO, bool OJBJGJCDAJO);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFLAJAOAODA();

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEHPPPMAFHM(Entity EGPDFGOHLFM);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface GKAMJKLBMPO
{
	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FLANGIKPHML(Collider AKMFHNGACJK, [Out] OLHOHDDEIDE KDAPGKEKDCM);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHEFMNJLHMM
{
	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider FOKNOBNFMDI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KBMHIPLMOOF(JDKDDPDJCCM FGKPNHPDDJJ, GameObject FLFNPLAKMCE, Vector3 APDNNMONKGG, Quaternion MKHKGOGFEPL);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMOINDLGLKM(GameObject AKMFHNGACJK);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider NIGOAANKHCI<TCollider>(GameObject FBHOAPKFLOK) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMBCGAGMAHI(Collider AKMFHNGACJK);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject ONGOFICOFFO<TCollider>(string GGDFKFACHGG) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HEKNGABBAOC LNEINIDLOEM(JDKDDPDJCCM FHBDDIAMPEI, JDKDDPDJCCM FDAEPGPDBNM, FHBADAKFFGA CDFOLBOBOMH, float3 JOPMAGMDNJG, quaternion CBMKPKKCFOO, float3 JMHOIIFJGPL);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HDCENLHNOGK(JDKDDPDJCCM OPKFGAAECNB, [Out] HEKNGABBAOC AKMFHNGACJK);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool COJMMKJHJHM(JDKDDPDJCCM OPKFGAAECNB, [Out] JDKDDPDJCCM EGPDFGOHLFM);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public enum GKJPGIBHHPH
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DCIIFADGPIA
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public struct JPJLLBJDKIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int CDFOLBOBOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GameObject FLFNPLAKMCE;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNLJMKDMDHA(JDKDDPDJCCM OPKFGAAECNB, AHEDCGBMDAC OBAMPLAEMFE, bool EMPICNLNEBA, GCLFJAMLBJN MEKGKNJNGJN);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJOPOJLLAOK(JDKDDPDJCCM OPKFGAAECNB, AHEDCGBMDAC OBAMPLAEMFE, bool EMPICNLNEBA, bool OJFGAKGJIBO, bool HDOGAMONNDE);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	COMMAFHFBJP PPNCHGFKONL(JDKDDPDJCCM EGPDFGOHLFM, List<JDKDDPDJCCM> GFDKIKNJGNP);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HEKNGABBAOC CACPICIBOGF(GameObject FIDKGLBJAKF, GameObject LCFAFKICIPC);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGDGNIPHLCG(GameObject FIDKGLBJAKF, List<GameObject> OMBANLHBJFB);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKOOJNBJAEF(GameObject LCFAFKICIPC);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NIGOAANKHCI<T>(GameObject FBHOAPKFLOK) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMBCGAGMAHI(Collider AKMFHNGACJK);

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject LCMDCBPPOKH<T>(string GGDFKFACHGG) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AFGDOPGJKLE(Collider AKMFHNGACJK, [Out] JDKDDPDJCCM PBHKHJPMFCF);

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GAJNGFICPLB(JDKDDPDJCCM OPKFGAAECNB, [Out] OLHOHDDEIDE KDAPGKEKDCM);

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<GKJPGIBHHPH> CNFNDBHKJNA(Allocator DFGMDNGNOEN = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] EBIBOEJFLFE();
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CNJCLMAKHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPPKNGDDBDO(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDEDMMPBEFN(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FDMNJJBJKHG(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JDKDDPDJCCM EIFCKAIBFKK(JDKDDPDJCCM OPKFGAAECNB, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OEPFMPMHIKM CMLJPBMAJBL(JDKDDPDJCCM OPKFGAAECNB, Allocator DFGMDNGNOEN = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFGHOHKOPDD(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO, JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JALECJIONKN(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AGIHLDEPLCH(JDKDDPDJCCM OPKFGAAECNB, [Out] JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NBNPKFJAICF(JDKDDPDJCCM OPKFGAAECNB, float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AKBIMANPGGK(JDKDDPDJCCM OPKFGAAECNB, [Out] float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AJCGCNIAPGK(JDKDDPDJCCM OPKFGAAECNB, float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MEAKKLOALOG(JDKDDPDJCCM OPKFGAAECNB, [Out] float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FEAENOBAKMI(JDKDDPDJCCM OPKFGAAECNB, (Quaternion rot, Vector3 moments) KOAILPGHGOM);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool AGBJKIAIBMA(JDKDDPDJCCM OPKFGAAECNB, [Out] quaternion EOMHGOPNFOC, [Out] float3 OHEJFLBJGLG);

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PJICDNGADJP(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 MANBMCLOLJL(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 EMKJNDOFOMI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OGMMOANGDCN(JDKDDPDJCCM OPKFGAAECNB, float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LNBCFLKMBNL(JDKDDPDJCCM OPKFGAAECNB, float3 BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float DNGCDONDCJF(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float JGGGBKFHJIN(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NLPAAADIEMB(JDKDDPDJCCM OPKFGAAECNB, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OLNDAAKLNOP(JDKDDPDJCCM OPKFGAAECNB, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode NICNNLDKMOF(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NNLFFLDPAOA(JDKDDPDJCCM OPKFGAAECNB, CollisionDetectionMode BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(Slot = "25")]
	CBJAHEEHPCM OLDMCBLLKKC(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KJPIHLDNIIH(JDKDDPDJCCM OPKFGAAECNB, CBJAHEEHPCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MIPBNGJFCHM(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AGPEEOMLKJO(JDKDDPDJCCM OPKFGAAECNB, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(Slot = "29")]
	JDKDDPDJCCM BFPBIEMMEFF(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CHELFDLHJNP(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(Slot = "31")]
	JDKDDPDJCCM AEBFDDKIMKJ(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void IALDJKPIPLJ(JDKDDPDJCCM OPKFGAAECNB, JDKDDPDJCCM BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "33")]
	CLOJPGAOOMI JLOIBJBIGFG(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LPONDOAOHBH(JDKDDPDJCCM OPKFGAAECNB, CLOJPGAOOMI CJGCNOHEHKE);

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GIJDGPFGMFP(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FBBDMKNOABN(JDKDDPDJCCM OPKFGAAECNB, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool HOCPKBMEPNC(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void HHAKNMKEDEO(JDKDDPDJCCM OPKFGAAECNB, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints MOIFEJLEFFL(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void OMEGIKKFPMH(JDKDDPDJCCM OPKFGAAECNB, RigidbodyConstraints BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float IEGPNAPBHAK(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void PCPIJIDLPFJ(JDKDDPDJCCM OPKFGAAECNB, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float BOGNIIJELAL(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MEFHMBMGFHO(JDKDDPDJCCM OPKFGAAECNB, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool FOMOCENAJOK(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void LBLOMGDJLLF(JDKDDPDJCCM OPKFGAAECNB, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool BFHIMMCINEH(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void GNGGELIEJFO(JDKDDPDJCCM OPKFGAAECNB, bool BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void GPEAINLCLBN(JDKDDPDJCCM OPKFGAAECNB, int BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "50")]
	FHIEKILDCOB NGAKJPFCPIE(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NEDAOGLEHFB(JDKDDPDJCCM OPKFGAAECNB, FHIEKILDCOB BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "52")]
	PAAFNDDMBFD DDFNOENCPMK(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CFHAIJPKOJD(JDKDDPDJCCM OPKFGAAECNB, PAAFNDDMBFD BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float ONANOBKKIHI(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void ADMNFNFLKFI(JDKDDPDJCCM OPKFGAAECNB, float BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void JCLMGJOHFMC(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void GKBJMGDKKDI(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool CIKPNBDGDJH(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void JKKCMAAOPNN(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void GIHNNJAGNAK(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool OLEMJNLONOM(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool CFHINBBPPNE(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody AEMLGJFCFHA(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GDNLMLFEMNA(JDKDDPDJCCM OPKFGAAECNB, Rigidbody GFGAJJMHNJH);

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OIPNOACLCAI(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void AHKKFALKFJA(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool ANOBAJIEJII(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MFPFFPFMMJG(JDKDDPDJCCM OPKFGAAECNB, float3 LNGDDNPHJHH);

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MHCCOMNLJFP(JDKDDPDJCCM OPKFGAAECNB, float3 BBFHLEIKDJM);

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool GEICHKPAAOM(JDKDDPDJCCM OPKFGAAECNB, [Out] float3 LNGDDNPHJHH);

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool PPOALGLEJPH(JDKDDPDJCCM OPKFGAAECNB, [Out] float3 BBFHLEIKDJM);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool NHFGNMMGLLC(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void BBEPJFOPEPJ(JDKDDPDJCCM OPKFGAAECNB, object OCGDLEBGIMO, bool FGMALLCGIFL);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void HKLMANKIFNA(JDKDDPDJCCM OPKFGAAECNB, bool PNHACEKGJMH);

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MOGFDLFIJAP(JDKDDPDJCCM OPKFGAAECNB);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool NJOEFCDHJAM(JDKDDPDJCCM OPKFGAAECNB);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OFJHJNPANHH
{
	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFDKEDNDPAE(Entity NCPIDGFDCKP);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKEAGADMHKA(Entity NCPIDGFDCKP);

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGBCPFLGPEH(Entity NCPIDGFDCKP);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AFCFFJNALAO
{
	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMEBHPKPBOF(JDKDDPDJCCM IMBAOPHEODM, bool LPGHFDKIPHA);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public delegate void EGJNGBHHFGD(DAACNJDBNOH LNNFHCJDIEL);
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public readonly ref struct DAACNJDBNOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly OEPFMPMHIKM PKFGBEMGGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NativeArray<byte> IDIAFCODBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly NativeArray<byte> JPAKIGPNDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly IPPNBDGDCLE DAGPCGHBFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly int CJOPIEKEJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly Type HFJOIMKHIBP;

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public OEPFMPMHIKM AIPGILPMLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x4F0D850", Offset = "0x4F0C650", VA = "0x184F0D850")]
		get
		{
			return default(OEPFMPMHIKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	public int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x828BB10", Offset = "0x828A910", VA = "0x18828BB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public IPPNBDGDCLE EOFJPGCPGON
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750")]
		get
		{
			return default(IPPNBDGDCLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x828BB60", Offset = "0x828A960", VA = "0x18828BB60")]
	public DAACNJDBNOH(OEPFMPMHIKM PKFGBEMGGOP, NativeArray<byte> IDIAFCODBKO, NativeArray<byte> JPAKIGPNDCM, IPPNBDGDCLE DAGPCGHBFAL, int CJOPIEKEJKF, Type HFJOIMKHIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x39D8190", Offset = "0x39D6F90", VA = "0x1839D8190")]
	public NativeArray<T> AJODLKGAGHH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x39D81D0", Offset = "0x39D6FD0", VA = "0x1839D81D0")]
	public NativeArray<T> AOPLDJOOLLF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x39D8210", Offset = "0x39D7010", VA = "0x1839D8210")]
	public (OEPFMPMHIKM, NativeArray<T>, NativeArray<T>) LHCLHJGACJJ<T>() where T : struct
	{
		return default((OEPFMPMHIKM, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x828BB30", Offset = "0x828A930", VA = "0x18828BB30")]
	public AGBPHOGPDLJ MJELEAHAKPL()
	{
		return default(AGBPHOGPDLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public interface HAJICKOLOHI
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	string PEIHAODLKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	HAJICKOLOHI DCOLHHOEPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	IEnumerable<HAJICKOLOHI> AGPHIABAFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface DBOBPDOMEFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	HAJICKOLOHI MCENBNKOBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	NativeArray<IPPNBDGDCLE> FEDDIFAFMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EKONIDMIFJF(IPPNBDGDCLE DAGPCGHBFAL, [Out] HAJICKOLOHI HKDEGGMBIMJ);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIMDKAKGPHI(IPPNBDGDCLE DAGPCGHBFAL, EGJNGBHHFGD HFMMFGMEBCD);

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDMNNAOCPHL(IPPNBDGDCLE DAGPCGHBFAL, EGJNGBHHFGD HFMMFGMEBCD);
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AKMHCHKAIFI
{
	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIMDKAKGPHI(IPPNBDGDCLE DAGPCGHBFAL, EGJNGBHHFGD HFMMFGMEBCD);

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDMNNAOCPHL(IPPNBDGDCLE DAGPCGHBFAL, EGJNGBHHFGD HFMMFGMEBCD);
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class PFMIGHHBAPD
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNAHFDACBPG
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	bool ALHFBGLPEII
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	OABFMMDDNOE BMJCFOJMEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHJEMFBMBFP(OGAPBCAHLMD GOPPKIOICJL, bool HDCCLLMFJFF);

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNANNMAEEFF(CAPEGOJHEPC GOPPKIOICJL, IPPNBDGDCLE DAGPCGHBFAL);

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGBNJIEDPLN(NativeArray<CAPEGOJHEPC> MGDKCNMIGMG);
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class OPDIPIDONCN
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly ref struct AGBPHOGPDLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly DAACNJDBNOH BOIPFNOKGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public OEPFMPMHIKM AIPGILPMLKO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x4F0D850", Offset = "0x4F0C650", VA = "0x184F0D850")]
		get
		{
			return default(OEPFMPMHIKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x8288BC0", Offset = "0x82879C0", VA = "0x188288BC0")]
	public AGBPHOGPDLJ(DAACNJDBNOH BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x8288670", Offset = "0x8287470", VA = "0x188288670")]
	public OEPFMPMHIKM AJODLKGAGHH()
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x82887A0", Offset = "0x82875A0", VA = "0x1882887A0")]
	public OEPFMPMHIKM AOPLDJOOLLF()
	{
		return default(OEPFMPMHIKM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x82888D0", Offset = "0x82876D0", VA = "0x1882888D0")]
	public (OEPFMPMHIKM, OEPFMPMHIKM, OEPFMPMHIKM) LHCLHJGACJJ()
	{
		return default((OEPFMPMHIKM, OEPFMPMHIKM, OEPFMPMHIKM));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class IMLHPHAECIJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public readonly struct OABFMMDDNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly NativeBitArray CJBDCOIGCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly NativeParallelHashMap<CAPEGOJHEPC, int> CNBMAFPINCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly NativeParallelHashSet<OGAPBCAHLMD> DPEODNMCNLH;

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public bool BEIGFKJBGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x829B9E0", Offset = "0x829A7E0", VA = "0x18829B9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public bool ALHFBGLPEII
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x829B9B0", Offset = "0x829A7B0", VA = "0x18829B9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7F0", Offset = "0x5FBA5F0", VA = "0x185FBB7F0")]
	public OABFMMDDNOE(NativeBitArray CJBDCOIGCFL, NativeParallelHashMap<CAPEGOJHEPC, int> CNBMAFPINCC, NativeParallelHashSet<OGAPBCAHLMD> DPEODNMCNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x829BA00", Offset = "0x829A800", VA = "0x18829BA00")]
	public bool MNANNMAEEFF(CAPEGOJHEPC GOPPKIOICJL, IPPNBDGDCLE DAGPCGHBFAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ANHJDHKJMJA
{
	[Cpp2IlInjected.Token(Token = "0x17000207")]
	CKJLKPAHMFI ADPGPPGOMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PNHNGEJMCJN
{
	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGCAJBDKLOH(JDKDDPDJCCM OPKFGAAECNB, FGKHGPMAONK BNECONOIKOE);

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFKLBEEHLLN BNNNPFJEGME();
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OLFKPPOLMHK
{
	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POACBPACPKK(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APDABNLOBJK(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase CCLCBHMHHFH(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEKBLMLLPLC(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNDPKDNAAFD(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KDCHCBJJHHH(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MAGHHDHMFEK(World HOJGMNLGPDE);

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> FNMPABBDBBI();
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FHOMIEOPOBL
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCDEPEENPKL(JDKDDPDJCCM ANPENHHJGPC, bool BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct KHJHIABHFFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly IEnumerable<NFKOLPGGFEN> AEACCKLIIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly IReadOnlyList<GameObject> DGKOCAOHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly IReadOnlyList<int> OKKJKHIGKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IReadOnlyList<(CAPEGOJHEPC, CAPEGOJHEPC)> MIAACNMMNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly int EPHHFKBLFJM;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct KMPJHMPOCMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public InventionIdData PPPFBKMGIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public InventionInstanceIdData AMFMAOCJCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public bool CHOANHCNIGE;

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x8297670", Offset = "0x8296470", VA = "0x188297670")]
	public KMPJHMPOCMC(long PPPFBKMGIMA, Guid AMFMAOCJCBP, bool CHOANHCNIGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ServiceLifetime(Lifetime.Application)]
public interface IMKKKNMLKJL
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFKAMMEFNKE LIBPAGGNKFM(NPBBPECINAL EABDNKGEENP, int AKCNICEMINJ = 0, bool ADOLNCPJLBP = false);

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HECOEICBNBA DBDLCLDDDCG(NPBBPECINAL EABDNKGEENP, JDKDDPDJCCM CMDMCJGFCDK, [In] UniformTRS APPGFEHHIFD, IJDLIAPMMBO MOFOHEKPLMC, [Optional] KMPJHMPOCMC JEKFHHCFCKO, bool PFFPCMEHAHF = true, bool DIIAJCNNJCE = false, bool ADOLNCPJLBP = false, bool GKLAMFLDCEO = false);

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CIKLCEAGENN CAJBHGPBIOL();

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CIKLCEAGENN LMHMKBCKOHI(OEPFMPMHIKM NNMEILBDPAF, [In] UniformTRS IJNCHCADILP, [Optional] IJDLIAPMMBO OAJIAHEGGDM);

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AKCGJACKHBO(JDKDDPDJCCM KHJNJKOADMN);

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PMGDOJEHKNP(JDKDDPDJCCM KHJNJKOADMN, [Out] Exception HIKJGCCPIBF);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<CAPEGOJHEPC> PMNANKGPJFG(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<CAPEGOJHEPC> DBCFNHHIKAN(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OEPFMPMHIKM IEDBBBJABBI(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OEPFMPMHIKM GHPPEPIHPIM(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OEPFMPMHIKM DICIJDCGDAG(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IBGBCOEKOOJ(JDKDDPDJCCM KHJNJKOADMN, Allocator DFGMDNGNOEN);

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PKLAMMNHEDP(JDKDDPDJCCM KHJNJKOADMN);

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int BBJDMAFKLGH(JDKDDPDJCCM KHJNJKOADMN, int LJEIHABMGGI);
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[ServiceLifetime(Lifetime.Application)]
public interface LPJPFEGDFEH
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xF17450", Offset = "0xF16250", VA = "0x180F17450", Slot = "0")]
	bool LHFNPLJCOCP(object IHKPBFJODHM, DBMIIECHDHJ FNOEODMFBNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class NGLJHLIICNB
{
	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x829A3A0", Offset = "0x82991A0", VA = "0x18829A3A0")]
	public static bool LHFNPLJCOCP(this LPJPFEGDFEH CDKAHLOIJBE, object IHKPBFJODHM, [Out] DBMIIECHDHJ FNOEODMFBNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum JCPGKGBFCPC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public interface DBMIIECHDHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	ONLKKBENBNL KICDHMJGHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	GLHCBKLDIDI IHPIJHOJMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	bool BFAOFGAGHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	bool NOKMKJBHGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object PDCADKNDDNG();

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x105F0E0", Offset = "0x105DEE0", VA = "0x18105F0E0", Slot = "5")]
	(GLHCBKLDIDI, Dictionary<object, object>) HBBHPECEDKJ()
	{
		return default((GLHCBKLDIDI, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
	(CAPEGOJHEPC, GLHCBKLDIDI) JBACAJBDPOF()
	{
		return default((CAPEGOJHEPC, GLHCBKLDIDI));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "7")]
	JKCFKFHFNKO<(CAPEGOJHEPC, GLHCBKLDIDI)> HOIEIMCFKMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x105F0E0", Offset = "0x105DEE0", VA = "0x18105F0E0", Slot = "8")]
	(CMJKCOGJCOD, byte[]) BOPMNDNKOHN()
	{
		return default((CMJKCOGJCOD, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x105F0E0", Offset = "0x105DEE0", VA = "0x18105F0E0", Slot = "9")]
	(AOOKKFJHCNC, byte[]) FLKAHOKNCLM()
	{
		return default((AOOKKFJHCNC, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x105F0E0", Offset = "0x105DEE0", VA = "0x18105F0E0", Slot = "10")]
	T LAHNBEBNEEN<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public static class PKGEJIAIDMM
{
	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x829F210", Offset = "0x829E010", VA = "0x18829F210")]
	public static bool DEOFDEMECEN(this DBMIIECHDHJ BKMCGGEFFOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public interface LLOLPHKCJCG : JKCFKFHFNKO<EKOKDMBBAMI>
{
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[DefaultMember("Item")]
public interface JKCFKFHFNKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	T CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	int PHDDEAOOOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public enum ONLKKBENBNL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public enum CMJKCOGJCOD : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public static class GENAIBOGLLK
{
	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8290420", Offset = "0x828F220", VA = "0x188290420")]
	public static CAPEGOJHEPC LPMOPCKNJKM(this FKIFJDJPCPP BOIPFNOKGBJ)
	{
		return default(CAPEGOJHEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x828FEE0", Offset = "0x828ECE0", VA = "0x18828FEE0")]
	public static CAPEGOJHEPC HKACBEIJNIL([In] this FKIFJDJPCPP BOIPFNOKGBJ)
	{
		return default(CAPEGOJHEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8211F10", Offset = "0x8210D10", VA = "0x188211F10")]
	public static CAPEGOJHEPC MPBGAGBKLPM(this FKIFJDJPCPP BOIPFNOKGBJ)
	{
		return default(CAPEGOJHEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x8211F10", Offset = "0x8210D10", VA = "0x188211F10")]
	public static ViewId IJABENAKDAO(this FKIFJDJPCPP BOIPFNOKGBJ)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x828FF30", Offset = "0x828ED30", VA = "0x18828FF30")]
	public static FixedString64Bytes IPBPJJEEHEL(this OGAPBCAHLMD PPPFBKMGIMA)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x8290190", Offset = "0x828EF90", VA = "0x188290190")]
	public static FixedString64Bytes JEDFIEPJLIB(this CAPEGOJHEPC PPPFBKMGIMA)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x8290100", Offset = "0x828EF00", VA = "0x188290100")]
	public static FixedString32Bytes IPBPJJEEHEL(this Entity ALBBAEBLONH)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPPALGIALEM : AIOPDAJOKPF
{
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public enum ILAGHJDJHGK
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JJDHMPFACLA
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<object> LLLPAGIANKA;

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "2")]
	void KIKPNOCFLGJ(object IHKPBFJODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "3")]
	void FKIIJNGLALK(AOOKKFJHCNC PBOOMELBCNJ, ReadOnlySpan<byte> OFCPJKNFOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	void JBPBINHGDHK(CMJKCOGJCOD DGPNPBEKOOD, ReadOnlySpan<byte> OFCPJKNFOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LKKLOLNFEFB
{
	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AOOKKFJHCNC BADEMMAACKH(ReadOnlySpan<byte> OFCPJKNFOPJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FNNGMCPAFGJ
{
	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MMDFDKLFBEA(AOOKKFJHCNC MAHBBBBCDEL, ReadOnlySpan<byte> OFCPJKNFOPJ);

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIIGHGPLHGL(ReadOnlySpan<AOOKKFJHCNC> PBGLDMALAKM);
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public struct IJGMAAFEBHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public AOOKKFJHCNC PBOOMELBCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public ReadOnlyMemory<byte> OFCPJKNFOPJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct AOOKKFJHCNC
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public static AOOKKFJHCNC CLNOECHGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public OGAPBCAHLMD FCEAMCDDCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public int IIDPNJEHLDN;

	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public static OGAPBCAHLMD MGFPADEFMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x828A750", Offset = "0x8289550", VA = "0x18828A750")]
		get
		{
			return default(OGAPBCAHLMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x53D5BC0", Offset = "0x53D49C0", VA = "0x1853D5BC0")]
	public AOOKKFJHCNC(OGAPBCAHLMD FCEAMCDDCEK, int IIDPNJEHLDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x828A920", Offset = "0x8289720", VA = "0x18828A920")]
	public static bool HAHIHKOBLPE([In] AOOKKFJHCNC PHLJLBDJNIE, [In] AOOKKFJHCNC GEOHFJAPCHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x828A7B0", Offset = "0x82895B0", VA = "0x18828A7B0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x828A8C0", Offset = "0x82896C0", VA = "0x18828A8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x828A9B0", Offset = "0x82897B0", VA = "0x18828A9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x828A7A0", Offset = "0x82895A0", VA = "0x18828A7A0")]
	public void DNJKCOADEJJ([Out] OGAPBCAHLMD KLGOHLFABCA, [Out] int IIDPNJEHLDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class LKJANIBPFHF
{
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct NFKOLPGGFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public Guid OKDHAOKOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public string FLHKIEKANIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Vector3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector3 AMJKMJIBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public int GCACFPGEKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public PIFBFEKACLF OAEBFAAHGEJ;

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x829A280", Offset = "0x8299080", VA = "0x18829A280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum HIMMJLBBPOP
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public static class AOPAGJJDKGN
{
	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x828AB00", Offset = "0x8289900", VA = "0x18828AB00")]
	public static bool EAKDONBHEFL(this HIMMJLBBPOP DGPNPBEKOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x828AAF0", Offset = "0x82898F0", VA = "0x18828AAF0")]
	public static bool BLEEPIBABFN(this HIMMJLBBPOP DGPNPBEKOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x828AB20", Offset = "0x8289920", VA = "0x18828AB20")]
	public static bool HPEMMKEMBOF(this HIMMJLBBPOP DGPNPBEKOOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[Flags]
public enum LBNLMHHANAM
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface IJDLIAPMMBO
{
	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKGEHFJFIBB([In] Guid GGCHDPHENOB, [Out] Guid KDLKIOAIFBA);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[Flags]
public enum ALGPJECKEDP
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface CIKLCEAGENN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	IHJLBKFJFKL AGCKHCMDDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString FOGKHEJGHOG();
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public enum NGALEJDHHDE
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct BGOBBMJJMAD : ISystemStateComponentData, IComponentData, IEquatable<BGOBBMJJMAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public float3 KNIALLIIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public float3 GEMNALEIBHL;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x828AC60", Offset = "0x8289A60", VA = "0x18828AC60", Slot = "4")]
	public bool Equals(BGOBBMJJMAD LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OAHMMIEHPPN
{
	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ReadOnlySpan<JDKDDPDJCCM> LIBACIKDNNB(JDKDDPDJCCM AGPNNEOOLAK);

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AMHBMIOLECE(JDKDDPDJCCM GALBKDNNBGF, [Out] JDKDDPDJCCM COBIJKNDHDC);
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BPMLFDLIFIB
{
	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBKOJPLFIDO(long LBGELNIEBKI);

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJPBEGFDIND(NativeParallelHashSet<long> OFCFKPMKLMN);

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIJOMJIBHOL(World HOJGMNLGPDE, NativeParallelHashMap<Guid, long> PNCIHFJAGLB);

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CEBJHADLHBA(CAPEGOJHEPC GOPPKIOICJL);

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AGJPMHIBIED(CAPEGOJHEPC GOPPKIOICJL, [Out] Guid PHDGIOGIJEO, [Out] long LBGELNIEBKI);

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAJJKJOFLGL(CAPEGOJHEPC GOPPKIOICJL, Guid PHDGIOGIJEO, long LBGELNIEBKI);

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJLCJAICHBO(Guid PHDGIOGIJEO);

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DEKHGGEHJKE(Guid PHDGIOGIJEO, [Out] int AFIDMIJDEMK, [Out] int PHNLEHLHOCC);

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MPHJLKONAHA(Guid PHDGIOGIJEO, int AFIDMIJDEMK, int PHNLEHLHOCC);

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OLNJKMFOLLI(Guid PHDGIOGIJEO);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000102")]
public class GNLNCCKEALF
{
	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GNLNCCKEALF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
