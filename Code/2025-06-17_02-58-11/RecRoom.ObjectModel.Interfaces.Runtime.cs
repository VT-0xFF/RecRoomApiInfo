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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F24A80", Offset = "0x7F23480", VA = "0x187F24A80", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CJMKOEIKCAH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F17740", Offset = "0x7F16140", VA = "0x187F17740")]
	public static void NHFMBOEIHEL(this Rigidbody PJEAJEOEHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F17610", Offset = "0x7F16010", VA = "0x187F17610")]
	public static void NHFMBOEIHEL(this Rigidbody PJEAJEOEHPE, Vector3 HKEIPMHEEAG, Quaternion AOLHEEIHCFK, Vector3 BPBKODNHGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KAGMCHPMLPA : IReadOnlyList<ENAPEPFMDAJ>, IEnumerable<ENAPEPFMDAJ>, IEnumerable, IReadOnlyCollection<ENAPEPFMDAJ>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct ADLEKPBOAHP : IEnumerator<ENAPEPFMDAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LIEJCDBGGEG CFOOPMPGJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator EJDGCMPDMMB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ENAPEPFMDAJ NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F11D60", Offset = "0x7F10760", VA = "0x187F11D60", Slot = "4")]
			get
			{
				return default(ENAPEPFMDAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F11D10", Offset = "0x7F10710", VA = "0x187F11D10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x526C2E0", Offset = "0x526ACE0", VA = "0x18526C2E0")]
		public ADLEKPBOAHP(LIEJCDBGGEG CFOOPMPGJIK, NativeArray<LocalId>.Enumerator EJDGCMPDMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F11C50", Offset = "0x7F10650", VA = "0x187F11C50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F11C90", Offset = "0x7F10690", VA = "0x187F11C90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F11CD0", Offset = "0x7F106D0", VA = "0x187F11CD0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BLMPLBHICCL GCKDJGKENJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> KBAPNJGAALD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ENAPEPFMDAJ OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F21540", Offset = "0x7F1FF40", VA = "0x187F21540", Slot = "4")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F20BA0", Offset = "0x7F1F5A0", VA = "0x187F20BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int OEMDIOECGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F20C00", Offset = "0x7F1F600", VA = "0x187F20C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OGNPMGIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F20DF0", Offset = "0x7F1F7F0", VA = "0x187F20DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> BHPCJPBKLGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98C0", Offset = "0x2AF82C0", VA = "0x182AF98C0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal NativeArray<Entity> KIKAFCIJOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F20E30", Offset = "0x7F1F830", VA = "0x187F20E30")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F21350", Offset = "0x7F1FD50", VA = "0x187F21350")]
	public KAGMCHPMLPA(int OOPBDBFKCBI, LIEJCDBGGEG CFOOPMPGJIK, Allocator NDKMELBEFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F21340", Offset = "0x7F1FD40", VA = "0x187F21340")]
	public KAGMCHPMLPA(BLMPLBHICCL GCKDJGKENJL, NativeArray<LocalId> KBAPNJGAALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F212D0", Offset = "0x7F1FCD0", VA = "0x187F212D0")]
	public KAGMCHPMLPA(BLMPLBHICCL GCKDJGKENJL, NativeArray<Entity> KBAPNJGAALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F214B0", Offset = "0x7F1FEB0", VA = "0x187F214B0")]
	internal KAGMCHPMLPA(LIEJCDBGGEG CFOOPMPGJIK, NativeArray<Entity> OBKJONELPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F21260", Offset = "0x7F1FC60", VA = "0x187F21260")]
	internal KAGMCHPMLPA(LIEJCDBGGEG CFOOPMPGJIK, NativeArray<LocalId> KBAPNJGAALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F211B0", Offset = "0x7F1FBB0", VA = "0x187F211B0")]
	public KAGMCHPMLPA(LIEJCDBGGEG CFOOPMPGJIK, int EIJGIDNMHGP, Allocator NDKMELBEFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F21400", Offset = "0x7F1FE00", VA = "0x187F21400")]
	public KAGMCHPMLPA(KAGMCHPMLPA OGELBJCBJHI, Allocator NDKMELBEFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F20930", Offset = "0x7F1F330", VA = "0x187F20930")]
	public void AHEPFHGKECD(List<ENAPEPFMDAJ> IBKFNAMHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F20F30", Offset = "0x7F1F930", VA = "0x187F20F30")]
	public void PGLLOOFDGCF(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F20C90", Offset = "0x7F1F690", VA = "0x187F20C90")]
	public KAGMCHPMLPA FDFMDNPNFDC(Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F20F80", Offset = "0x7F1F980", VA = "0x187F20F80")]
	public Span<ENAPEPFMDAJ> PJPLPCOHCEL()
	{
		return default(Span<ENAPEPFMDAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F20E90", Offset = "0x7F1F890", VA = "0x187F20E90")]
	public KAGMCHPMLPA MIMNDLDGOHJ(int HKECPJKDGLJ, int EIJGIDNMHGP)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F20C50", Offset = "0x7F1F650", VA = "0x187F20C50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F20D30", Offset = "0x7F1F730", VA = "0x187F20D30")]
	public ADLEKPBOAHP ICNPOCIJNJG()
	{
		return default(ADLEKPBOAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F210D0", Offset = "0x7F1FAD0", VA = "0x187F210D0", Slot = "6")]
	private IEnumerator<ENAPEPFMDAJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F21140", Offset = "0x7F1FB40", VA = "0x187F21140", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BJDMNEPGEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37F27C0", Offset = "0x37F11C0", VA = "0x1837F27C0")]
	public static HDGDEEMNBFK<T> FILLHMJHGCB<T>(this KAGMCHPMLPA AJHCLHGHINB) where T : Component
	{
		return default(HDGDEEMNBFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
public struct KCFNBNEHMGB : IList<ENAPEPFMDAJ>, ICollection<ENAPEPFMDAJ>, IEnumerable<ENAPEPFMDAJ>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BKMOCAKGILO : IEnumerator<ENAPEPFMDAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LIEJCDBGGEG CFOOPMPGJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator EJDGCMPDMMB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ENAPEPFMDAJ NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F14020", Offset = "0x7F12A20", VA = "0x187F14020", Slot = "4")]
			get
			{
				return default(ENAPEPFMDAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7F13FD0", Offset = "0x7F129D0", VA = "0x187F13FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x526C2E0", Offset = "0x526ACE0", VA = "0x18526C2E0")]
		public BKMOCAKGILO(LIEJCDBGGEG CFOOPMPGJIK, NativeArray<LocalId>.Enumerator EJDGCMPDMMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F13F10", Offset = "0x7F12910", VA = "0x187F13F10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F13F50", Offset = "0x7F12950", VA = "0x187F13F50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F13F90", Offset = "0x7F12990", VA = "0x187F13F90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LIEJCDBGGEG CFOOPMPGJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> KBAPNJGAALD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ENAPEPFMDAJ OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F22EF0", Offset = "0x7F218F0", VA = "0x187F22EF0", Slot = "4")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F22FE0", Offset = "0x7F219E0", VA = "0x187F22FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F227A0", Offset = "0x7F211A0", VA = "0x187F227A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F227A0", Offset = "0x7F211A0", VA = "0x187F227A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NativeList<LocalId> BHPCJPBKLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98C0", Offset = "0x2AF82C0", VA = "0x182AF98C0")]
		get
		{
			return default(NativeList<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool HDMPHDAENOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F22DE0", Offset = "0x7F217E0", VA = "0x187F22DE0")]
	public KCFNBNEHMGB(LIEJCDBGGEG CFOOPMPGJIK, Allocator NDKMELBEFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F22E60", Offset = "0x7F21860", VA = "0x187F22E60")]
	public KCFNBNEHMGB(LIEJCDBGGEG CFOOPMPGJIK, int EIJGIDNMHGP, Allocator NDKMELBEFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F22820", Offset = "0x7F21220", VA = "0x187F22820")]
	public KAGMCHPMLPA GPIPCHCEPMG()
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F22500", Offset = "0x7F20F00", VA = "0x187F22500", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F22540", Offset = "0x7F20F40", VA = "0x187F22540", Slot = "13")]
	public bool Contains(ENAPEPFMDAJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F225D0", Offset = "0x7F20FD0", VA = "0x187F225D0", Slot = "14")]
	public void CopyTo(ENAPEPFMDAJ[] KLDOGKPLNJA, int KFFMGEMIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F22480", Offset = "0x7F20E80", VA = "0x187F22480", Slot = "11")]
	public void Add(ENAPEPFMDAJ HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F22A50", Offset = "0x7F21450", VA = "0x187F22A50", Slot = "7")]
	public void Insert(int MNFHMLCLFEB, ENAPEPFMDAJ HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7F22B50", Offset = "0x7F21550", VA = "0x187F22B50", Slot = "15")]
	public bool Remove(ENAPEPFMDAJ HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F229C0", Offset = "0x7F213C0", VA = "0x187F229C0", Slot = "6")]
	public int IndexOf(ENAPEPFMDAJ HMJJODPHKCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F22B00", Offset = "0x7F21500", VA = "0x187F22B00", Slot = "8")]
	public void RemoveAt(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F227E0", Offset = "0x7F211E0", VA = "0x187F227E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F22930", Offset = "0x7F21330", VA = "0x187F22930")]
	public BKMOCAKGILO ICNPOCIJNJG()
	{
		return default(BKMOCAKGILO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F22C20", Offset = "0x7F21620", VA = "0x187F22C20", Slot = "16")]
	private IEnumerator<ENAPEPFMDAJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F22D00", Offset = "0x7F21700", VA = "0x187F22D00", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface INIMHOEKCBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENAPEPFMDAJ LENIEODPCKJ(ENAPEPFMDAJ KBAPNJGAALD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HDNFKJDJPNE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[ServiceLifetime(Lifetime.Application)]
public interface JBEFHHBKJDM : LLHABKOBNMJ, POCMHIMFGLC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PGOCJGJDHJC KDKLGDAKPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BLMPLBHICCL LOFOMIOAGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface POCMHIMFGLC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HIBBJOPICNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[ServiceLifetime(Lifetime.Application)]
public interface HBFKHHABFFE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOJEIOKCNNF(bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPMJEFEEPDP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HPILMDCPLGI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BBLNDNGBOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KLIJFMGIHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PDCCDHKDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JLHGKAJDKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MBBDLOKOIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFKJFMBKGEM(bool KALBLPGLPEO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NDGOFAIHFHK(ByteString IGDKPLEPAGI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CNPPIMLPDEJ();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LLALNMGDNHL();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AEIEDHCIPPF();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.Application)]
public interface EODLPAIPBLC
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	FKFJNEKJHIE KDKLGDAKPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	JOCAGFMDGBC CLIJIEEKFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KHAPJGKJHDD BPEIJJMEJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JBEFHHBKJDM DHJGDMPEEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	AGPJEJLJAFN JFFOPKNMPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	HPILMDCPLGI IDFKCFHFNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	AENANBBBHCL KIFBMAJAOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DIIBDIKPEII DGINCKPNLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	CIKMOHIBDEH GPININDLILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MPJMMKIMNOF HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KMJPJKPGPLG JGPICCBPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	HJHPEHKJOGC ANGPJLFKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	IOIBNFLPGLE ABBOMCKDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EHDKEPKIAIB CJHLLNMPNDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FDLHNDAJCDN MOGLNGIBNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	ONILDMOJOJL MAONPKKONJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CBIIKHEMLIG DLBNGAKJEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OEKDNANFKLA NGMHLHIMLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KMIJOPLDOIJ MIHGDFBKKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	EHKDKFHMKPF IEMFBPGCDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	EINGLJOFPPL OLEOJNIDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	DJAFIONDJDC FJPLICOFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	PMOEIDEIGJH MCHLFFPCEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	CBHGEONKCKO PDFLOKLECOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	PMJLOCGKOBI IEBIKAIBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	EEBNLPONHJM OHFPHBBNCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CAADPBPBGFN BDAHMDIAEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JNOJKPGFFIB NEGPLKOGPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PCFEOOONLAD JHCPKLMIINI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FCHEOJAONPM HMACIFBMODO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EGLJCDJPPKL OJJAAPMGEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JHJFCJGIDMB LANPCICOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KKAHPLHELKO ILCLMICCPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PMOEPKGMOEK MKCAKAALNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DebuggerTypeProxy(typeof(KHFHJNKHKLG))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct ENAPEPFMDAJ : IComparable<ENAPEPFMDAJ>, IEquatable<ENAPEPFMDAJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ENAPEPFMDAJ HLCKODHBFKH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int ALGIOLNDHMG = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int DCNAPOGGHID = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int GPHNJCGMMEF = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int GABBIJNIAGP = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId MBIJJAIIOHD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F120D0", Offset = "0x7F10AD0", VA = "0x187F120D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JBEFHHBKJDM DHJGDMPEEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F19E10", Offset = "0x7F18810", VA = "0x187F19E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LocalId EEBKEDHGPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F19DD0", Offset = "0x7F187D0", VA = "0x187F19DD0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal BLMPLBHICCL LOFOMIOAGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A010", Offset = "0x7F18A10", VA = "0x187F1A010")]
		get
		{
			return default(BLMPLBHICCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IAKPEOGICJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A070", Offset = "0x7F18A70", VA = "0x187F1A070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private bool MOFMMHCCFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A020", Offset = "0x7F18A20", VA = "0x187F1A020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A350", Offset = "0x7F18D50", VA = "0x187F1A350")]
	public ENAPEPFMDAJ(LIEJCDBGGEG FJEHJKCLPKF, LocalId MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A2C0", Offset = "0x7F18CC0", VA = "0x187F1A2C0")]
	public ENAPEPFMDAJ(BLMPLBHICCL GCKDJGKENJL, LocalId MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
	public DLOAIPKFGBA DOOIFCLFNNH()
	{
		return default(DLOAIPKFGBA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F19E70", Offset = "0x7F18870", VA = "0x187F19E70")]
	public static LocalId HNONLACFBHP(ENAPEPFMDAJ PHGPJJNEHGA)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19EB0", Offset = "0x7F188B0", VA = "0x187F19EB0")]
	public static Entity HNONLACFBHP(ENAPEPFMDAJ PHGPJJNEHGA)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F19EF0", Offset = "0x7F188F0", VA = "0x187F19EF0")]
	public static bool IDFALDDOLDN(ENAPEPFMDAJ MJGADEGDMOP, ENAPEPFMDAJ LJDEEJKPAEN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F18390", Offset = "0x7F16D90", VA = "0x187F18390")]
	public static bool JAIBCELPAPH(ENAPEPFMDAJ MJGADEGDMOP, ENAPEPFMDAJ LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A190", Offset = "0x7F18B90", VA = "0x187F1A190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C30", Offset = "0x7F18630", VA = "0x187F19C30", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F19B40", Offset = "0x7F18540", VA = "0x187F19B40", Slot = "4")]
	public int CompareTo(ENAPEPFMDAJ NDNHELJMDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "5")]
	public bool Equals(ENAPEPFMDAJ NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OPOFPGJMLLM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F27190", Offset = "0x7F25B90", VA = "0x187F27190")]
	public static ADLHINHFEDA KHIDFLKOANA(this ENAPEPFMDAJ OJDHMKOBKLD)
	{
		return default(ADLHINHFEDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class KHFHJNKHKLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct BLMPLBHICCL : IEquatable<BLMPLBHICCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly byte GCKDJGKENJL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static byte[] FMPLMPHMMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static LIEJCDBGGEG LDOBHKBPCEE;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static JBEFHHBKJDM JPGBHHENOOL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static LIEJCDBGGEG[] GAFEBBBFEDB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static JBEFHHBKJDM[] LJJFLEDGEBK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static Stack<byte> NDLKBDKKNJF;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JBEFHHBKJDM DHJGDMPEEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F146E0", Offset = "0x7F130E0", VA = "0x187F146E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LIEJCDBGGEG PGIGCPDBECK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F14B20", Offset = "0x7F13520", VA = "0x187F14B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F14F50", Offset = "0x7F13950", VA = "0x187F14F50")]
	static BLMPLBHICCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F0F0", Offset = "0x2B1DAF0", VA = "0x182B1F0F0")]
	internal BLMPLBHICCL(byte PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4CF0", Offset = "0x6DB36F0", VA = "0x186DB4CF0", Slot = "4")]
	public bool Equals(BLMPLBHICCL NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F14640", Offset = "0x7F13040", VA = "0x187F14640", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xF88870", Offset = "0xF87270", VA = "0x180F88870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F14E90", Offset = "0x7F13890", VA = "0x187F14E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F14280", Offset = "0x7F12C80", VA = "0x187F14280")]
	private static LIEJCDBGGEG EEPOEDJKGCG(byte GCKDJGKENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F14DF0", Offset = "0x7F137F0", VA = "0x187F14DF0")]
	private static JBEFHHBKJDM JNNNDDKCGLG(byte GCKDJGKENJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F14120", Offset = "0x7F12B20", VA = "0x187F14120")]
	private static object DPJDOKHJMIA(byte GCKDJGKENJL, object[] OKEIIBNBBOL, object ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F14100", Offset = "0x7F12B00", VA = "0x187F14100")]
	private static int BNLLJCBDMNG(byte GCKDJGKENJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F14110", Offset = "0x7F12B10", VA = "0x187F14110")]
	private static int DJAFGAAPNAI(byte GCKDJGKENJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F14320", Offset = "0x7F12D20", VA = "0x187F14320")]
	private static (int, int) EPGGIDABHNP(byte GCKDJGKENJL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F140F0", Offset = "0x7F12AF0", VA = "0x187F140F0")]
	private static byte BKIFOHGEEOE(int GPMAOGCPKOA, int MNFHMLCLFEB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F143A0", Offset = "0x7F12DA0", VA = "0x187F143A0")]
	internal static BLMPLBHICCL EPIAMCEAEFP(JBEFHHBKJDM LNKEEANFIDI, LIEJCDBGGEG BKOBJPKBCHC)
	{
		return default(BLMPLBHICCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F14C00", Offset = "0x7F13600", VA = "0x187F14C00")]
	internal static void IAJHDKMEFKB(BLMPLBHICCL GCKDJGKENJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F147C0", Offset = "0x7F131C0", VA = "0x187F147C0")]
	private static void HJNJFMKJCHH(int OOPBDBFKCBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum DJEONPIMAKI
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
public interface OFBBPNKCMLB
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool PCCFGBBLGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool OGGGNEJPGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DGAKBIIJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool DLCHBFNJDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LJBMOPNHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OPJMFCOJBOL
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EDPOIECKIEH(CFAPKJEDNDF DJGDNAKMFCE, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GOCLMDGBLHI(CFAPKJEDNDF AMEDJEPNINL, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LCCOBMHGCOO(AEODHIBIJCB KCOLAIFGDHN, int MNFHMLCLFEB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DLJBFHIEACK : CFAPKJEDNDF, OFBBPNKCMLB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	int DBCHEAONCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGGKHBMPHIL(IADKGCLBMPL EBHEGJDIFIE, int MNFHMLCLFEB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CFAPKJEDNDF : OFBBPNKCMLB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum LOPLBHNFDEF
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

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GBNJOMJPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MHCJMOBKOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HILNCFMNFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IADKGCLBMPL
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OLDNCFLAHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	AMKAGOPDJAP LKPMPLALMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PBDMDFJFEJM EKMFHHECCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float3 ICJIGFAHILA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	quaternion ACEAKNBEHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float3 BHCFCONIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CFDCEGNMEPB BOKLPDEMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	EALCMIHKJHP BMCDLJBPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float OABPIGFMENH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float3 JMGHBHLNEAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float PFGKDPJHOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	JBJNHLKNCIO ANLJNGGGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BCFLBLNOGDC
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float3 PLJHMEAKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float3 BOGMPKBDLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	quaternion GBOJMCDAMJE(float3 EDNIDDDKKDE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface PBDMDFJFEJM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool GNAMPCONKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool CNMKBLECDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool ONJONHGJOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	float FGPJFIIOKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int BKBEKHCFABE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int MGHGAHJBGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EONEEIPJPHF(BCFLBLNOGDC EBHEGJDIFIE, int MNFHMLCLFEB);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ServiceLifetime(Lifetime.Application)]
public interface BIJBDPPLFGL
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Guid KDPIFEDMNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BJIAGPNFHMM(Guid NIAFGOHDHED, Guid MKAMFGFDAIG, Guid MJKFGPFKGDL);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DBALEBPDAKD(Guid NIAFGOHDHED, Guid[] BOJPAHCEHJJ, Guid MJKFGPFKGDL);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LBJHENDEHLJ(Guid MNODKBPNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NGPENGIJBMJ(ENAPEPFMDAJ CPJOIAFJCIM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MCLMEOKMFKJ(Guid MNODKBPNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IBJEIHOFEHL(GNCFPGHIKOL CFCPDFODBBB, Guid OENOMEOACNE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AJJMGFGAEKH(Guid MNODKBPNLJF, bool KALBLPGLPEO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BILGFPGLIEO(Guid MNODKBPNLJF, ADLHINHFEDA ELDLGGCLIOA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NCIOKBNGKDH(ADLHINHFEDA ELDLGGCLIOA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKIEGNHCPDG(ENAPEPFMDAJ MBIJJAIIOHD);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[ServiceLifetime(Lifetime.Application)]
public interface DABNPIKGAJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ServiceLifetime(Lifetime.Application)]
public interface IFGENPBOMHD
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "0")]
	void CAFPCACHGPL(bool NDMOBAIGJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ServiceLifetime(Lifetime.Application)]
public interface JOCAGFMDGBC
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IFGENPBOMHD IMKHCMEDMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	IEAJGFIINKN OIIJBCCOBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	KMDFJIPGKKF GFAAOAOCFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	OPCIMABKHLF AACIJIKAHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	IBJABKDMFFE HBJFAAKFPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	DAGFKANJMPF MMNEGCOHHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	NFKCIFDJFPA AIEGMPBHBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	DNEFPAIGNAM OPPMLOEGFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ServiceLifetime(Lifetime.Application)]
public interface IEAJGFIINKN
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	string CHIPPGCPKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ServiceLifetime(Lifetime.Application)]
public interface HENDOANDFCC
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGBCFHABMFO(Action KPGBPPBMJJK, bool DGCOPFCDBHG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KAHCMJIFKBB(string GBCFHNGPBLM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int MJMDKPOHKJH(string GBCFHNGPBLM, int ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JLECKDCFGNM([Out] bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGKOCFPOMIO([Out] bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NCBEFIHLDAL([Out] int PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[ServiceLifetime(Lifetime.Application)]
public interface KMDFJIPGKKF
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "0")]
	void EDLOFDCGBDA(bool KALBLPGLPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[ServiceLifetime(Lifetime.Application)]
public interface OPCIMABKHLF
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected static readonly Guid APNLBKCKNNO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	static readonly Guid OIEMAGOKOPH;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	static readonly Guid LCNANGEMLJF;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	static readonly Guid DCJDODAHCIE;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool KIAADFFDCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool PLGECCAIELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool GEMCFCOPBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F26D40", Offset = "0x7F25740", VA = "0x187F26D40", Slot = "3")]
	string[] BABKNKJGCPP(NEGEMEPEKGJ NJPILGECKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLOJOBCMOBL();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F26DD0", Offset = "0x7F257D0", VA = "0x187F26DD0", Slot = "5")]
	Guid JILLLBDPFJN(Guid AJCNCJBEECH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NPKHAGEBJGD(NEGEMEPEKGJ NJPILGECKNH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KPGNKCLPBMB(NEGEMEPEKGJ NJPILGECKNH, NativeArray<LJIPKCOBJPE> PNOJGDPHNGO, NativeList<UniformTRS> IFNBDKLPHCD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int FIHHHGGAFKD(Guid FNKCCICOAII);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EJGKGDCHGMF(string DBLNPCOHJMA, [Out] Guid FNKCCICOAII);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string OKJMIHODHMP(Guid FNKCCICOAII);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OPNLKCIOLCI(RRObjectPrefabData NKJIHBBCCPN, [Out] LocalId FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HDGDEEMNBFK<byte[]> MMIBHBFNFBA(NativeArray<LJIPKCOBJPE> JKPNCFCNEOF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGGPABJLCHB(byte[] JAKKPHFINGE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GameObject NPLIIHAMIAP(string DBLNPCOHJMA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MALHCBOCBEO(Transform MNINMACDPEC, RRObjectPrefabData ODPFADECGIG, OKBMAOLKCPM GJIMIGJJJKI);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LKHACPBGECP(NEGEMEPEKGJ NJPILGECKNH, NativeParallelHashMap<Guid, LocalId> EOGGEOGOMJD, [Out] Exception EMKLCNOEBAG);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNFEPGKCFFA(NEGEMEPEKGJ NJPILGECKNH, NativeParallelHashMap<Guid, LocalId> EOGGEOGOMJD, [Out] NativeArray<LocalId> OBKJONELPMG, [Out] NativeArray<LocalId> CJKJLGMNLNL, [Out] NativeArray<AuthoredLocalPoseData> PJLBJJEMOPO, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "18")]
	void PDMCCFJGIGP(NEGEMEPEKGJ NIAPBNPEIPM, NativeArray<int> MGKBPDCLPBH, BBKFGDIALBG<GameObject> OGJPAHOIKIO, HDGDEEMNBFK<GameObject> DBIICEMFODA, DJEONPIMAKI NNJFNGJHCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HOFAGLFHDOA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
	void MEFHAHCIDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
	void CFABKKPIEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "22")]
	bool ACPAJBOLNLL(NEGEMEPEKGJ NJPILGECKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "23")]
	OPJMFCOJBOL PMKHLPBLPLP(NEGEMEPEKGJ NJPILGECKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "24")]
	void EJIHLHPDLDI(Guid FILKMFGCAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "25")]
	bool BPBCFIGEMJC(Guid FILKMFGCAEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F26E00", Offset = "0x7F25800", VA = "0x187F26E00")]
	static OPCIMABKHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[ServiceLifetime(Lifetime.Application)]
public interface HBLHEHIHKMM
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	long EJPLBNDACMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	long NMPJHNGJADI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "1")]
		get
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[ServiceLifetime(Lifetime.Application)]
public interface IBJABKDMFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool PFAKPFFMJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int KOGGOBOPADB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	int AADKJDGOLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	int DAMMFFLKPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool APKALFPGMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int BAPDJMFHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	void FDMFKLKCANG(FDOJONGBPAO BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
	void OCHPFFNIHDJ(bool PMAHLFBNFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "8")]
	bool MMAHCGMEBED(PGNMDKGFDBN BJBHFAMODGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
	void FIKNOOIGCJE(object MGDBGDNLMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
	void OEOALLFEAML(object MGDBGDNLMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HHANMHNMNFK(Action<object> GIIINKAMCAG);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LIJANNNAOPH(Action<object> GIIINKAMCAG);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
	void LDHDOHGILLE(NativeArray<ViewId> CFMEDNONLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "14")]
	void DMGGHPEFMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "15")]
	void LDOEPECEEIG(EEEPFGDDBAA HHCAOFMCNLG, ReadOnlySpan<byte> HPGIDELCODH, PGNMDKGFDBN BJBIEGLAMFB, bool NBOPLHFMBBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "16")]
	void LDOEPECEEIG(EEEPFGDDBAA HHCAOFMCNLG, ReadOnlySpan<byte> IADHGEAPNGO, bool NBOPLHFMBBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "17")]
	void LDOEPECEEIG(EEEPFGDDBAA HHCAOFMCNLG, ReadOnlySpan<byte> IADHGEAPNGO, ReadOnlySpan<byte> MIGAIIOMHMD, bool NBOPLHFMBBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "18")]
	void MKMJOJMDAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "19")]
	void EDJLCKGNKNF(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
	void BENIHLGKMFO(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
	void KHMOCIBIMIC(Dictionary<object, object> PGHKEKNHCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "22")]
	void DENAPAMLLHE(NativeList<ADLHINHFEDA> GDCJGNNOOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "24")]
	void KHDJMLNCEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "25")]
	void JLLDDLJJMNC(List<object> GKEBBNCFKMF, int OBKGKEGIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "26")]
	void JFJJPDFFGCJ(int BLEDCECONDJ, object JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "27")]
	void JBPNKDNJAGI(PGNMDKGFDBN BJBHFAMODGO, Dictionary<object, object> COGBEMJPNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "28")]
	void KJDHDFALAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "29")]
	void JKIFIIAPLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HLHBKIMEKCM
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D9E0", Offset = "0x7F1C3E0", VA = "0x187F1D9E0")]
	public static GJCICCGCOEE IJMIGJKPLEN(this IBJABKDMFFE MKNDHMJOBPH, object BECBHDDLOHA)
	{
		return default(GJCICCGCOEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GJCICCGCOEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IBJABKDMFFE MKNDHMJOBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private object BECBHDDLOHA;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CDF0", Offset = "0x7F1B7F0", VA = "0x187F1CDF0")]
	public GJCICCGCOEE(IBJABKDMFFE MKNDHMJOBPH, object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CDA0", Offset = "0x7F1B7A0", VA = "0x187F1CDA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JPICIJANLHK
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void EIDECOBNHBL(ViewId POHODHGBPHP, KFGKIGCKOGK DCPMLFOLFAK, int GAMOJFHOMGC);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "0")]
	void BAHJOODPIJB(EIDECOBNHBL JODNDIFCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "1")]
	void OIJAGJPJJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "2")]
	void AKFJOBGJKDP(AAPOELEAAKP IPADIJEFNLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ServiceLifetime(Lifetime.Application)]
public interface CDEGNKGLOIO
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[ServiceLifetime(Lifetime.Application)]
public interface DAGFKANJMPF
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct GJHHHGKAHLD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DAGFKANJMPF KKIMNOIOIGD;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CEE0", Offset = "0x7F1B8E0", VA = "0x187F1CEE0")]
		public GJHHHGKAHLD(DAGFKANJMPF KKIMNOIOIGD, string EEOCHCICMNA, string PHACEJNOOBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CE80", Offset = "0x7F1B880", VA = "0x187F1CE80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct FKIJKDOKODG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DAGFKANJMPF KKIMNOIOIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Task HAAEKADIBMM;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BE20", Offset = "0x7F1A820", VA = "0x187F1BE20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "0")]
	void PBODCNGEIIC(string IJOJGNJMCGP, float IDDLOIFGNLI = 5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "1")]
	void POBFHMKPFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBPNPAGAEFK(bool CNPJJBMCDGK, string EEOCHCICMNA, string PHACEJNOOBL);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "3")]
	void BALKFLFHHBE(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MPPCKLPBIDN
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7F259A0", Offset = "0x7F243A0", VA = "0x187F259A0")]
	public static DAGFKANJMPF.GJHHHGKAHLD DGEKHJMLINF(this DAGFKANJMPF MKNDHMJOBPH, string EEOCHCICMNA, string PHACEJNOOBL)
	{
		return default(DAGFKANJMPF.GJHHHGKAHLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ServiceLifetime(Lifetime.Application)]
public interface AILPPJDICMC
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LOCMDDCJIHJ(GameObject HNGFDIJGINB);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNNGDFENIIM(GameObject HNGFDIJGINB);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OBBODIDAFFA(int BJBHFAMODGO);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "3")]
	object PADIAJNPFOH(ENAPEPFMDAJ MBIJJAIIOHD, GameObject HNGFDIJGINB, Action<ENAPEPFMDAJ, int> DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPCPNKENFLM(GameObject HNGFDIJGINB, object EPKMNGDFMDE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BKGHJGGCGAB
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAIJIKFNFAA(IAIEGNHMFLD BNJDCEAGAEP, INJPECNJBDL JPCKBPIBNCM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ServiceLifetime(Lifetime.Application)]
public interface BHMANKCPLHB
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGPOMLMDCHO(object OJDHMKOBKLD, NativeList<byte> HPGIDELCODH);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object PGEPBAPICDN(NativeArray<byte> HPGIDELCODH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ServiceLifetime(Lifetime.Application)]
public interface PDPIGHCHLLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool EIMMFILPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Delegate PGEKFGECHJJ(AOOENPIJLCF OJFNLDNLKOA, Action<AOOENPIJLCF> DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPPCNPEFPNP(AOOENPIJLCF OJFNLDNLKOA, Delegate DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Delegate GEFJOOLGFGK(AOOENPIJLCF OJFNLDNLKOA, Action<AOOENPIJLCF> DDPCNGDKDMB);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOLCFFEMNBN(AOOENPIJLCF OJFNLDNLKOA, Delegate DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEOAIADIFDD(AOOENPIJLCF OJFNLDNLKOA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AOOENPIJLCF KICKCICAKJL(GameObject HNGFDIJGINB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ServiceLifetime(Lifetime.Application)]
public interface LEJMMEABIMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int DMOBKAPLNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	int KNNPDJPHNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool EMENNBANOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	bool OEMEJEBELCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENAPEPFMDAJ MMDGKIIAFFE(int BJBHFAMODGO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLEEIAEPFKF(GameObject OEKFPAOFCGC, JobHandle OKLHGAFKBPC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface GOBDJDKJDPM
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAIJIKFNFAA(int NIHHJEGJCCB, INJPECNJBDL LDDOPCFAHOI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ServiceLifetime(Lifetime.Application)]
public interface NFKCIFDJFPA
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool BBLNDNGBOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[ServiceLifetime(Lifetime.Application)]
public interface HNJPGNIHIMB
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	JHOAFMOCPOK PIBBBEBOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	KCOGCHBFLDF KDILAENBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool DHGLGENLKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCBJADEMOLF(Transform MNINMACDPEC);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNJJEPAEJAE(Transform MNINMACDPEC, EJEKANEOHGI FCPIHEGFGCD);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBFNKJKDDIN(Transform MNINMACDPEC, LBAACCFPEFG LKIOAPBFPML);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[ServiceLifetime(Lifetime.Application)]
public interface DNEFPAIGNAM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DIOBBNGHNGD;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ServiceLifetime(Lifetime.Application)]
public interface BHNGBJMGJCI
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDJDFNOMLDK();
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ServiceLifetime(Lifetime.Application)]
public interface JNLDJBMDLHC
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECGOPMPIKOF(GameObject HNGFDIJGINB, KFCPMNIEOEG KPOJPIIMBGB, BILGONJLGPF JIPKMDCEKJC);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKINBDCKMHN(ENAPEPFMDAJ MBIJJAIIOHD, bool CMECNPHHPOJ, float3 FNDKGGFEEOB, quaternion LBLAGFIFNJD);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JBCEGGMLCGB(KAGMCHPMLPA ABDCKDFOLDC);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGDAADOEFJA(DLOAIPKFGBA BBAFJLLBENK, DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCOHMJDEDJB(DLOAIPKFGBA BBAFJLLBENK, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JKMJCOMPAIL(KAGMCHPMLPA EJIHLDAGBON);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHMNIKFLAJG(NEGEMEPEKGJ OHPIKMOJFMF, ReadOnlySpan<Guid> KMFAAODDJHF, ReadOnlySpan<int> LLHGOJPMNDK, HDGDEEMNBFK<GameObject> GAGFBCPAJJP);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AEMHOIHGMMG(EAIPDLDMFMI INMLGCAAFGI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct CEAHBEHONBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NativeArray<byte> HPGIDELCODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GCHandle GCKDJGKENJL;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7F161D0", Offset = "0x7F14BD0", VA = "0x187F161D0")]
	public CEAHBEHONBN(ReadOnlyMemory<byte> IKIGJPENHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7F16190", Offset = "0x7F14B90", VA = "0x187F16190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum DKKLPEMLJAG
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
public struct NEGEMEPEKGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public ByteString INLLKFMJMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public object PGIHFCECNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object EKPEKAFBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IEnumerable<string> DDJLGGALEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool DCKHJMPAKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public BICFCNHMLON.FJDHJHJHPDN? IHCMOBNGAFK;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7F25AC0", Offset = "0x7F244C0", VA = "0x187F25AC0")]
	public NEGEMEPEKGJ(ByteString INLLKFMJMLP, [Optional] object PGIHFCECNAE, [Optional] object EKPEKAFBAKK, [Optional] IEnumerable<string> DDJLGGALEFF, bool DCKHJMPAKDO = true, [Optional] BICFCNHMLON.FJDHJHJHPDN? IHCMOBNGAFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LHKDMDJANOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public object EDMANCBPIBF;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LJIPKCOBJPE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Flags]
	public enum GMHLIJPILHF
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
	public RRObjectPrefabData FCBPEDFENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Guid OIEHHJHKJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Guid BMGAMKLFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid GHIJFIKPFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Guid KIOILFALLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public GMHLIJPILHF FIKPCOCNDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Color32 IMHJGEDBILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public int NOFDABFMOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BKCPJCIBBJI HCMDPCHIAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NEJFLHOMOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int DCLMFNAIOAI;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid CCELMGLMMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5269040", Offset = "0x5267A40", VA = "0x185269040")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool KNGADJOMCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7F24300", Offset = "0x7F22D00", VA = "0x187F24300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool MHFLPAOCBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7F24320", Offset = "0x7F22D20", VA = "0x187F24320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool OBFAEBCGHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F24310", Offset = "0x7F22D10", VA = "0x187F24310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool PCCOGCGOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F242F0", Offset = "0x7F22CF0", VA = "0x187F242F0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct OPDDAGNBFFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly CJGGHAMLOJJ HKECPJKDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal readonly CJGGHAMLOJJ EMHKONLCKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal readonly uint HBCEPJGCHMO;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7F26F20", Offset = "0x7F25920", VA = "0x187F26F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GGLACDGFCOL
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal readonly OPDDAGNBFFP KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CC40", Offset = "0x7F1B640", VA = "0x187F1CC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct IPNFMNLDNLM
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal readonly OPDDAGNBFFP KPGBPPBMJJK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CC40", Offset = "0x7F1B640", VA = "0x187F1CC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct JLGLBLPNIEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	internal readonly uint HBCEPJGCHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly bool HOOMEACAKNJ;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD40", Offset = "0x7F1E740", VA = "0x187F1FD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CJGGHAMLOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal int BACDJHJBLPL;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7F175B0", Offset = "0x7F15FB0", VA = "0x187F175B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[ServiceLifetime(Lifetime.Application)]
public interface ILHIONKOFDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	BLBBLNDHFIH PIGEBFNHIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface GNCFPGHIKOL
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface FOPJKAPDCKM
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BHCAHHBALAO
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x37F20D0", Offset = "0x37F0AD0", VA = "0x1837F20D0")]
	public static DLOAIPKFGBA DOOIFCLFNNH<T>(this T MBIJJAIIOHD) where T : GNCFPGHIKOL
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F13DD0", Offset = "0x7F127D0", VA = "0x187F13DD0")]
	public static MonoBehaviour DOOHJEMKDDD(this GNCFPGHIKOL MBIJJAIIOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7F13E50", Offset = "0x7F12850", VA = "0x187F13E50")]
	public static GameObject MIGFNEFDENP(this GNCFPGHIKOL MBIJJAIIOHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DILEOGCGOMK : GNCFPGHIKOL
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Initialize(ENAPEPFMDAJ PIIGBAMEEMF);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface PNKGGOIEHAN : GNCFPGHIKOL
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BBNOKEJNIAP
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate void KCCBPCFBPIL(NKHGNBHNPNC BDOLIEHPIAC);

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KCCBPCFBPIL INEFMFLJJAG;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface CCONCGCPKBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface IAEAJGLODKC
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FDACPNNNIIL
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Transform GetTransform();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Collider GetCollider();

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MoveToObject(ENAPEPFMDAJ JMOBGNEKNJG);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NotifyIsUniform(bool LKGMAFGHFBB);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DestroyCollider();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHEBBMFCLGF(ENAPEPFMDAJ JNMDJGFBNHD);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface HLCMEOOKFNA
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(LEOFMIOLMNC KBIGANGGGME);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface LEOFMIOLMNC
{
	[Cpp2IlInjected.Token(Token = "0x17000089")]
	GameObject HNGFDIJGINB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	Transform MNINMACDPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CKPEEOMOJJI OCLJKMHJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool IJDOOGJJFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIJCCJOMFMM(CKPEEOMOJJI LALBBHEFJAE);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GCMIBKGIHPB GetData();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KNFKPBMHCGM
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7F23400", Offset = "0x7F21E00", VA = "0x187F23400")]
	public static void HGHOOMFPNJH(this LEOFMIOLMNC OGMEFONHICP, OKBMAOLKCPM GJIMIGJJJKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface CKPEEOMOJJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Rigidbody NJDIIBKCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	LEOFMIOLMNC BAGOMHEIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	GameObject MIGFNEFDENP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Transform OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	CKPEEOMOJJI IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	CKPEEOMOJJI PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int FDCEHJBFHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	bool FPFHCIFNHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool BEOAIADIFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool DHDBIEJCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	FJBHJEKKKOJ ALHFICIODDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	MMGNDNMMIBP MMLKKGELJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	float MJKJLPBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "36")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Vector3 JBHKLEPEGOB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "38")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Vector3 IALNOMAHNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	Vector3 JPBKJMJLHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	Vector3 DLGDIJHCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool JLDPCDKAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool ONKMJCCBADM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	bool JCLDBNACAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	bool LNCPBHDEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Vector3 BJMHMKHBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Vector3 CILPBKBJNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Vector3 CBMDODIHBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "52")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 GNEAMFDMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	float ABAPMFBJMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	float LMMEKHANDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Vector3 MMDHKNKKPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Quaternion HECHIIJBGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	float DPMLBPCNACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	float LOFGGINBDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool GCOGCFPFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	BJFKEGNANDB DNEPNLLILDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool OOFIBNOFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Transform IAACOHLGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Vector3 EOGIJAHENMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "71")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	float AOIEPNMLFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "72")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "73")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	float KJAMDDODCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "74")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "75")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Quaternion CCFEOIPMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "76")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "77")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Vector3 PLJHMEAKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "79")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Quaternion EIPFKNEOAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "80")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "81")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	RigidbodyConstraints NDAJLCONCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "82")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "83")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	bool GMGDAJFJIKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "84")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "85")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	CollisionDetectionMode OPPKJLMOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "86")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "87")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	bool CICIBBPAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "88")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KANEOGHNJFB HEDEIKCGPFF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KANEOGHNJFB OFIKEGHAAJA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event KANEOGHNJFB AIFDABJDFDJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event KANEOGHNJFB KPEPBJELKCA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event KANEOGHNJFB NCDNCOALOHG;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event KANEOGHNJFB OIIABNPPGHG;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event KANEOGHNJFB NHDMNCBOADE;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event FMMFANILCNM HJNHKBJIAMO;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AMDCJLIPDMO, AMDCJLIPDMO> OOAPNHDFBKM;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CKPEEOMOJJI HBBGKOKBEPF(int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void KDFIPNDDFHG((Quaternion rot, Vector3 moments) HMJIJMLCIDN);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DEKCPONMMBI();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OHPCGLJDAHC();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void LKDJELHONKA();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void KBIKDALDOIA();

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void ODCKPPKNECL(CKPEEOMOJJI PCDAHJCDHHF, bool MPNHLGBIEGE = false);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void DDMBMLMAOKE(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void EIHKKIIHKIM(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 KKDMCMANIMD(Vector3 BIDFFEOGLBL);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 JPBKBCBBAEN(Vector3 CMGKIHAHNKG);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void EDHPIKJPNMN();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void NGDEHOOAGPF();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void LBDAHKDHKHC();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void CEOJMJCIADC(Vector3 KLLLEBHFHNI, Vector3 KKAICPOLEBD);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void IEJPNHPPLAB(Vector3 GOGJNILJNEN, Vector3 KMMDBEFLDJJ);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void DHPIKNNCCHL(Vector3 MBFMENKJIAM);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void DMLJDHOMMFJ(PHFBBBOEHHE EOIBMOKJMCC, Vector3 GNPPKKBDPBJ, float CGEKJMEOLJJ, float GEEMEDNHPAN = 8f, float NAFGNOICJFA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JABLPCALLAE(BFLBDPBGGCC IFGLFJKEHHO, Vector3 FDPNNHOKDDC, float HNEJJEILEPA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KGDNPIGJGLI(BFLBDPBGGCC IFGLFJKEHHO, Vector3 NGPACIMGGNA, float BIKCCBHNJCE = 7f, float NNAMGLPMFOG = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "108")]
	Vector3 EEBFPFCGOCD(Vector3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "109")]
	Vector3 ENPFPDOJAGF(Vector3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void AHJOIIJCHIM();

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "111")]
	void AHFJHFHBMOF(CKPEEOMOJJI JJHMEOPMAEJ, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PGJGNIMLBNG(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void ICFMKMGKFPN();

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void MINPMAPDKEN();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "115")]
	void OEFGFHILMEM();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "116")]
	bool PMHMCBPHCIC();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HHPGCIJHADF();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FPDDDLNGNCI(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void LDDOMOEOJNM(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DJIMFIKFOJP(object BECBHDDLOHA, bool PLIDCHGGBAD);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void AEMNKMKJHEE(Vector3 AKALCNGHLHF, Quaternion GKIBONHCOLJ);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void ENCHELFBAHD(Vector3 NIIDLMFIKHH, Quaternion HBPPPKIDAOE);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool GNDEKIGLJOM(float EMHHPNBMOLH);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void EONFLKLMHBH(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OPJKAHIKPBE(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void NGENBHLPLCE(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DCFIAPPHDDC(object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void GNDHMCFEFFI(Vector3 BOOINJJDCOC, ForceMode OBFDKNANAGO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void FFLEEFDDKDM(Vector3 BOOINJJDCOC, Vector3 JFMEMBGKAOB, ForceMode OBFDKNANAGO);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void PEDLDKMBEOD(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void GCJDDPBLICH(Vector3 CMHJLKLDGIM, ForceMode OBFDKNANAGO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "132")]
	bool HEOJEJIIFPB(Vector3 HPCBBMBEKNN, [Out] RaycastHit KGJLOFPICLA, float LCMAOMAPNJJ);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void KEAMPKLDOJP();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface MMGNDNMMIBP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class BOGJOJIHLEN : MMGNDNMMIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BOGJOJIHLEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "0")]
	void FMLIIKLNAJO(Vector3 LPLLONEMFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "1")]
	void GLJFGDOGFCK(Vector3 DGGOMONDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "2")]
	void JCPFDDNIPKD(Vector3 LPLLONEMFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "3")]
	void NEODEEIKGBK(Vector3 DGGOMONDOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FJBHJEKKKOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NPLJEAOEEHF();

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JBDIHPPALPD();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IAEMNJIGKMH(float MELLPFGFAIF, float FDNGHHLDFDM);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void KANEOGHNJFB(LEOFMIOLMNC OFJNIONBCLC);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum NHLGDOKGFBJ
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
public enum PHFBBBOEHHE
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
public delegate void FMMFANILCNM(LEOFMIOLMNC OFJNIONBCLC, bool MPNHLGBIEGE = false);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum BFLBDPBGGCC
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct GCMIBKGIHPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Rigidbody DBPDLPLAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public object GNNAFAGJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3 BCOJONMDENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector3 JFDJDOPNINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public DLKLAKEEKHP GOMCGOABOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool PMDMIPDCDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool LOFHEINIGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool PBMBMFMPPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool GNNFBMIIEAB;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct DLOAIPKFGBA : IEquatable<DLOAIPKFGBA>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly DLOAIPKFGBA DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public GameObject HNGFDIJGINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7F186E0", Offset = "0x7F170E0", VA = "0x187F186E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public ADLHINHFEDA LHCDLGAONDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7F189A0", Offset = "0x7F173A0", VA = "0x187F189A0")]
		get
		{
			return default(ADLHINHFEDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public AHFPEAMOHOD AIDJGMPIFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7F17DD0", Offset = "0x7F167D0", VA = "0x187F17DD0")]
		get
		{
			return default(AHFPEAMOHOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public RRObjectPrefabData GLEKPLHAFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7F18250", Offset = "0x7F16C50", VA = "0x187F18250")]
		get
		{
			return default(RRObjectPrefabData);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LDCFHNKBGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F188C0", Offset = "0x7F172C0", VA = "0x187F188C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool MAMPNNKICFP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7F17EE0", Offset = "0x7F168E0", VA = "0x187F17EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool OLDNCFLAHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F185A0", Offset = "0x7F16FA0", VA = "0x187F185A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool AFEGODAMEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7F186C0", Offset = "0x7F170C0", VA = "0x187F186C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool COKHCCJDIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7F18870", Offset = "0x7F17270", VA = "0x187F18870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool ADOLBJLDMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7F17E70", Offset = "0x7F16870", VA = "0x187F17E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool AFENNGOLMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7F18680", Offset = "0x7F17080", VA = "0x187F18680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool EPCDMJKKMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7F18080", Offset = "0x7F16A80", VA = "0x187F18080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool AJCJGDBEDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7F17CA0", Offset = "0x7F166A0", VA = "0x187F17CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool NOIINKDFGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7F18920", Offset = "0x7F17320", VA = "0x187F18920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool OMOJMBNFCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7F17EA0", Offset = "0x7F168A0", VA = "0x187F17EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool BEPOOILCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7F18150", Offset = "0x7F16B50", VA = "0x187F18150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool AMHFCANEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7F18600", Offset = "0x7F17000", VA = "0x187F18600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JIGBJDFCFEB JOAFKEGMOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(JIGBJDFCFEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public ILALMPCMBDF LBOLMDLOGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ILALMPCMBDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public CEBGGDHGMPC ABBOMCKDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(CEBGGDHGMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public JFBHFIOCJEK LGPKPCAAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(JFBHFIOCJEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public ABOKGKNNDEA FDEADPNDGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ABOKGKNNDEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public ENAPPFLAKDJ FBMGIBOFKDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPPFLAKDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public MBLHFGMBHKA PDEBLNIGAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(MBLHFGMBHKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public HBKMPIEPFDJ NOGEFGNMOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(HBKMPIEPFDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JDAIHPGPLEF DLFFJCGDOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(JDAIHPGPLEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public JNMIIKOJPFE CJHLLNMPNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(JNMIIKOJPFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MCHKKJLCBCL KELLEACCMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(MCHKKJLCBCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public CGKLKPDBCAI CGAFEJNEHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(CGKLKPDBCAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public EKPPLACHCCP AGCFDHCMHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(EKPPLACHCCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IKPOLDPBDOJ LFADKAFKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(IKPOLDPBDOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool NFMIKDFGADC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7F184B0", Offset = "0x7F16EB0", VA = "0x187F184B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool FGPKLLBPEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7F185C0", Offset = "0x7F16FC0", VA = "0x187F185C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool IAADOMNGOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7F18190", Offset = "0x7F16B90", VA = "0x187F18190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool IAKPEOGICJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7F188E0", Offset = "0x7F172E0", VA = "0x187F188E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool ECPEKOOOCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7F18640", Offset = "0x7F17040", VA = "0x187F18640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool JENEGHFCNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7F18040", Offset = "0x7F16A40", VA = "0x187F18040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool HGAMEJJOMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7F18960", Offset = "0x7F17360", VA = "0x187F18960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BCJOEIPPFIP OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(BCJOEIPPFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public OCGNHGKBLML HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(OCGNHGKBLML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7F120D0", Offset = "0x7F10AD0", VA = "0x187F120D0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static DLOAIPKFGBA HNONLACFBHP(ENAPEPFMDAJ PIIGBAMEEMF)
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7F181D0", Offset = "0x7F16BD0", VA = "0x187F181D0")]
	public CCGHEDPJKKI FHIKGFGHAAN()
	{
		return default(CCGHEDPJKKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7F18890", Offset = "0x7F17290", VA = "0x187F18890")]
	public LLJIFFLLAKA NLLLNPKKCJJ()
	{
		return default(LLJIFFLLAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7F17CE0", Offset = "0x7F166E0", VA = "0x187F17CE0")]
	public CDJDJONIPHI ADFGPIACFGO()
	{
		return default(CDJDJONIPHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7F188F0", Offset = "0x7F172F0", VA = "0x187F188F0")]
	public CAJABNBCAHN PGJLMKHAIKB()
	{
		return default(CAJABNBCAHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7F17F50", Offset = "0x7F16950", VA = "0x187F17F50")]
	public FOJBGEBHMBF DGJFCAONKKM()
	{
		return default(FOJBGEBHMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7F17F00", Offset = "0x7F16900", VA = "0x187F17F00")]
	public KBNDIAPHIBG DBCKDJFKAKJ()
	{
		return default(KBNDIAPHIBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7F183B0", Offset = "0x7F16DB0", VA = "0x187F183B0")]
	public void JIMLDNAJIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7F17FA0", Offset = "0x7F169A0", VA = "0x187F17FA0")]
	public void EFCPNMLOGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7F17D30", Offset = "0x7F16730", VA = "0x187F17D30")]
	public bool AOBBKCEFJPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x7F18A40", Offset = "0x7F17440", VA = "0x187F18A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public DLOAIPKFGBA(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(DLOAIPKFGBA PCDAHJCDHHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static ENAPEPFMDAJ HNONLACFBHP(DLOAIPKFGBA PCDAHJCDHHF)
	{
		return default(ENAPEPFMDAJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x7F18380", Offset = "0x7F16D80", VA = "0x187F18380")]
	public static bool IDFALDDOLDN(DLOAIPKFGBA MJGADEGDMOP, DLOAIPKFGBA LJDEEJKPAEN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7F18390", Offset = "0x7F16D90", VA = "0x187F18390")]
	public static bool JAIBCELPAPH(DLOAIPKFGBA MJGADEGDMOP, DLOAIPKFGBA LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7F180C0", Offset = "0x7F16AC0", VA = "0x187F180C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(DLOAIPKFGBA NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct EKPPLACHCCP : IEquatable<EKPPLACHCCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private KKAHPLHELKO KGHLMBPPPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7F19320", Offset = "0x7F17D20", VA = "0x187F19320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7F19920", Offset = "0x7F18320", VA = "0x187F19920")]
	public void LOGHNKFOGAC(uint KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7F19780", Offset = "0x7F18180", VA = "0x187F19780")]
	public bool IOGGLDGJMCH([Out] uint KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7F19500", Offset = "0x7F17F00", VA = "0x187F19500")]
	public bool FBLPAOCMLOL([Out] uint KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7F19380", Offset = "0x7F17D80", VA = "0x187F19380")]
	public void EOOFGDBJPPP(string KHNIMGKFPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7F19A30", Offset = "0x7F18430", VA = "0x187F19A30")]
	[CanBeNull]
	public string NGMIEFHKIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7F19600", Offset = "0x7F18000", VA = "0x187F19600")]
	public bool IEFNBHLCFID([Out] string NOJPHICPLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7F19880", Offset = "0x7F18280", VA = "0x187F19880")]
	public void LGBPDMPHKFH(string NOJPHICPLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public EKPPLACHCCP(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19470", Offset = "0x7F17E70", VA = "0x187F19470", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(EKPPLACHCCP NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct JIGBJDFCFEB : IEquatable<JIGBJDFCFEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private AENANBBBHCL IKONEFPFONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FB30", Offset = "0x7F1E530", VA = "0x187F1FB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private KKAHPLHELKO ILCLMICCPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FB90", Offset = "0x7F1E590", VA = "0x187F1FB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool DJEMIOHBBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FBF0", Offset = "0x7F1E5F0", VA = "0x187F1FBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool EPEBCBKAHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F210", Offset = "0x7F1DC10", VA = "0x187F1F210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public bool NKJFBBCEAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F5A0", Offset = "0x7F1DFA0", VA = "0x187F1F5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Guid PPLKGPDJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F3F0", Offset = "0x7F1DDF0", VA = "0x187F1F3F0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Guid DHLFLMGHBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F250", Offset = "0x7F1DC50", VA = "0x187F1F250")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Guid CDABBJILDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F760", Offset = "0x7F1E160", VA = "0x187F1F760")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public OCGNHGKBLML HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(OCGNHGKBLML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F970", Offset = "0x7F1E370", VA = "0x187F1F970")]
	public bool LMBNOENLEIP([Out] Guid MNODKBPNLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F500", Offset = "0x7F1DF00", VA = "0x187F1F500")]
	public bool FBFLDEEFBID([Out] Guid MKAMFGFDAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F2D0", Offset = "0x7F1DCD0", VA = "0x187F1F2D0")]
	public void CJMGDPJGGIA(Guid KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F660", Offset = "0x7F1E060", VA = "0x187F1F660")]
	public void JLGOGCIFHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FA10", Offset = "0x7F1E410", VA = "0x187F1FA10")]
	public Guid MDCMFFJBHGC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public JIGBJDFCFEB(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F470", Offset = "0x7F1DE70", VA = "0x187F1F470", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(JIGBJDFCFEB NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct CDJDJONIPHI : IEquatable<CDJDJONIPHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private CIKMOHIBDEH GGPPGJJIFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7F16130", Offset = "0x7F14B30", VA = "0x187F16130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 KOILBODCGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7F15E10", Offset = "0x7F14810", VA = "0x187F15E10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Quaternion PFDOBPBNPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7F15FF0", Offset = "0x7F149F0", VA = "0x187F15FF0")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public DLOAIPKFGBA EHMEKGPLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7F15F60", Offset = "0x7F14960", VA = "0x187F15F60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7F157F0", Offset = "0x7F141F0", VA = "0x187F157F0")]
	public KAGMCHPMLPA CACHLDHMAPK(Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7F15950", Offset = "0x7F14350", VA = "0x187F15950")]
	public bool FKIBIHHLAHG(DLOAIPKFGBA EAGGHBKHKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7F159F0", Offset = "0x7F143F0", VA = "0x187F159F0")]
	public void FMMLIMMDJFF(Vector3 JFMEMBGKAOB, Quaternion NGPACIMGGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7F15D00", Offset = "0x7F14700", VA = "0x187F15D00")]
	public void HHLPKLPLJAO(float JAHHKOMJJAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7F15B40", Offset = "0x7F14540", VA = "0x187F15B40")]
	public void HCAHPBGBICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public CDJDJONIPHI(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(CDJDJONIPHI PCDAHJCDHHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static ENAPEPFMDAJ HNONLACFBHP(CDJDJONIPHI PCDAHJCDHHF)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7F158C0", Offset = "0x7F142C0", VA = "0x187F158C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(CDJDJONIPHI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct CCGHEDPJKKI : IEquatable<CCGHEDPJKKI>
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CCGHEDPJKKI DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private MPJMMKIMNOF AKIFAJKIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7F15250", Offset = "0x7F13C50", VA = "0x187F15250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
	public Span<DLOAIPKFGBA> JKFFEFAGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7F150C0", Offset = "0x7F13AC0", VA = "0x187F150C0")]
		get
		{
			return default(Span<DLOAIPKFGBA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7F15040", Offset = "0x7F13A40", VA = "0x187F15040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7F15770", Offset = "0x7F14170", VA = "0x187F15770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public BCJOEIPPFIP OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(BCJOEIPPFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OCGNHGKBLML HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(OCGNHGKBLML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x7F152D0", Offset = "0x7F13CD0", VA = "0x187F152D0")]
	public void MNNHGAMGEFM(CCGHEDPJKKI NDNHELJMDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public CCGHEDPJKKI(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(CCGHEDPJKKI PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7F151C0", Offset = "0x7F13BC0", VA = "0x187F151C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(CCGHEDPJKKI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static DLOAIPKFGBA HNONLACFBHP(CCGHEDPJKKI NMEFAPBBOCD)
	{
		return default(DLOAIPKFGBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DefaultMember("Item")]
public struct LAHIEFNNKJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Dictionary<int, object> ICFOMKCGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private LPALHDAMDFN ONBBJIKEFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool AIJOGNDOIOI;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		[CompilerGenerated]
		readonly get
		{
			return default(DLOAIPKFGBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IAKIIFIBOKL OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7F23E70", Offset = "0x7F22870", VA = "0x187F23E70")]
		readonly set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7F24180", Offset = "0x7F22B80", VA = "0x187F24180")]
	internal LAHIEFNNKJK(DLOAIPKFGBA OJDHMKOBKLD, bool AIJOGNDOIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7F24050", Offset = "0x7F22A50", VA = "0x187F24050", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x3B16180", Offset = "0x3B14B80", VA = "0x183B16180")]
	public void FFFHEDIGKIF<T>(IAKIIFIBOKL KJNEHANBOBO, T PCDAHJCDHHF, [Optional] T ALKDPGOIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7F23FA0", Offset = "0x7F229A0", VA = "0x187F23FA0")]
	public void DAAFLACHELB(IAKIIFIBOKL KJNEHANBOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xA85B50", Offset = "0xA84550", VA = "0x180A85B50")]
	public Dictionary<int, object> COKOADCGEJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7F23F30", Offset = "0x7F22930", VA = "0x187F23F30")]
	private readonly void CIMELLGNNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class JJELODNPACF
{
	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FC80", Offset = "0x7F1E680", VA = "0x187F1FC80")]
	public static LAHIEFNNKJK OOMMHAHGDKJ(this DLOAIPKFGBA OJDHMKOBKLD)
	{
		return default(LAHIEFNNKJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct IKPOLDPBDOJ : IEquatable<IKPOLDPBDOJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly IKPOLDPBDOJ DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private bool OMOJMBNFCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DD40", Offset = "0x7F1C740", VA = "0x187F1DD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 EGCOBEBIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DD80", Offset = "0x7F1C780", VA = "0x187F1DD80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DFC0", Offset = "0x7F1C9C0", VA = "0x187F1DFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DF40", Offset = "0x7F1C940", VA = "0x187F1DF40")]
	public Vector3 JFBIGFLDALG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DEC0", Offset = "0x7F1C8C0", VA = "0x187F1DEC0")]
	public void HLMEPNPLJEO([In] Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DCC0", Offset = "0x7F1C6C0", VA = "0x187F1DCC0")]
	public void AJMAMAFOCKD([In] Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E020", Offset = "0x7F1CA20", VA = "0x187F1E020")]
	public bool PBMBBKPHLBM([In] Vector3 PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public IKPOLDPBDOJ(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DE30", Offset = "0x7F1C830", VA = "0x187F1DE30", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(IKPOLDPBDOJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E0D0", Offset = "0x7F1CAD0", VA = "0x187F1E0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct PCGDLOGKDFO : IEquatable<PCGDLOGKDFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F274F0", Offset = "0x7F25EF0", VA = "0x187F274F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(PCGDLOGKDFO NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct OCGNHGKBLML : IEquatable<OCGNHGKBLML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private MPJMMKIMNOF AKIFAJKIAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F262E0", Offset = "0x7F24CE0", VA = "0x187F262E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public ENAPEPFMDAJ AJKGFEBLENH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F26A10", Offset = "0x7F25410", VA = "0x187F26A10")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public DLOAIPKFGBA IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F267E0", Offset = "0x7F251E0", VA = "0x187F267E0")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public DLOAIPKFGBA PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F26250", Offset = "0x7F24C50", VA = "0x187F26250")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F26910", Offset = "0x7F25310", VA = "0x187F26910")]
	public Span<DLOAIPKFGBA> NIAADNKFEFC()
	{
		return default(Span<DLOAIPKFGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F264D0", Offset = "0x7F24ED0", VA = "0x187F264D0")]
	public Span<DLOAIPKFGBA> IEKHLKAMMKD()
	{
		return default(Span<DLOAIPKFGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F265D0", Offset = "0x7F24FD0", VA = "0x187F265D0")]
	public Span<DLOAIPKFGBA> JEPNNIFIHIK()
	{
		return default(Span<DLOAIPKFGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F260C0", Offset = "0x7F24AC0", VA = "0x187F260C0")]
	public Span<DLOAIPKFGBA> BBKONDLGHJE()
	{
		return default(Span<DLOAIPKFGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F263D0", Offset = "0x7F24DD0", VA = "0x187F263D0")]
	public Span<DLOAIPKFGBA> ICPLIIPGNEC()
	{
		return default(Span<DLOAIPKFGBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F26AA0", Offset = "0x7F254A0", VA = "0x187F26AA0")]
	public bool ODCKPPKNECL(DLOAIPKFGBA EAGGHBKHKHF, bool FFLKINLBHIE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F26870", Offset = "0x7F25270", VA = "0x187F26870")]
	public bool NEGGGDNIIHO(DLOAIPKFGBA AHFPKINDEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F266D0", Offset = "0x7F250D0", VA = "0x187F266D0")]
	public DLOAIPKFGBA KIGCHLNOGBL(uint CJHEGLKIIFN)
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F26340", Offset = "0x7F24D40", VA = "0x187F26340")]
	public CCGHEDPJKKI GKHBIKAHCEP()
	{
		return default(CCGHEDPJKKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public OCGNHGKBLML(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(OCGNHGKBLML PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F261C0", Offset = "0x7F24BC0", VA = "0x187F261C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(OCGNHGKBLML NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public readonly struct ILALMPCMBDF : IEquatable<ILALMPCMBDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public string PLIMLAHDBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E4E0", Offset = "0x7F1CEE0", VA = "0x187F1E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public string IBBKNMCHLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E630", Offset = "0x7F1D030", VA = "0x187F1E630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public string HHINJEGAJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E6A0", Offset = "0x7F1D0A0", VA = "0x187F1E6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public string MHDAOFIOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E1B0", Offset = "0x7F1CBB0", VA = "0x187F1E1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E570", Offset = "0x7F1CF70", VA = "0x187F1E570")]
	public bool IEFNBHLCFID([Out] string NOJPHICPLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public ILALMPCMBDF(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E450", Offset = "0x7F1CE50", VA = "0x187F1E450", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(ILALMPCMBDF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct FOJBGEBHMBF : IEquatable<FOJBGEBHMBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private KMJPJKPGPLG JGPICCBPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C270", Offset = "0x7F1AC70", VA = "0x187F1C270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public HIHPIEHKPPJ OCECDEDBHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C7E0", Offset = "0x7F1B1E0", VA = "0x187F1C7E0")]
		get
		{
			return default(HIHPIEHKPPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C040", Offset = "0x7F1AA40", VA = "0x187F1C040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool BPLCECJOPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BE70", Offset = "0x7F1A870", VA = "0x187F1BE70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BFA0", Offset = "0x7F1A9A0", VA = "0x187F1BFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public HDGDEEMNBFK<string> CBLHMDMPNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C480", Offset = "0x7F1AE80", VA = "0x187F1C480")]
		get
		{
			return default(HDGDEEMNBFK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CB20", Offset = "0x7F1B520", VA = "0x187F1CB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public HDGDEEMNBFK<string> KFOAIDILMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C6C0", Offset = "0x7F1B0C0", VA = "0x187F1C6C0")]
		get
		{
			return default(HDGDEEMNBFK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C150", Offset = "0x7F1AB50", VA = "0x187F1C150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public HDGDEEMNBFK<string> PNLEFJAGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C2D0", Offset = "0x7F1ACD0", VA = "0x187F1C2D0")]
		get
		{
			return default(HDGDEEMNBFK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CA00", Offset = "0x7F1B400", VA = "0x187F1CA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public HDGDEEMNBFK<string> KKFGOEOECEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C8E0", Offset = "0x7F1B2E0", VA = "0x187F1C8E0")]
		get
		{
			return default(HDGDEEMNBFK<string>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1C5A0", Offset = "0x7F1AFA0", VA = "0x187F1C5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BF00", Offset = "0x7F1A900", VA = "0x187F1BF00")]
	public bool CKJGAKAJEIM(ENAPEPFMDAJ KPIDJKLDGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public FOJBGEBHMBF(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static ENAPEPFMDAJ HNONLACFBHP(FOJBGEBHMBF PCDAHJCDHHF)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C3F0", Offset = "0x7F1ADF0", VA = "0x187F1C3F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(FOJBGEBHMBF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct OCPBCGCOJBL : IEquatable<OCPBCGCOJBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F26BD0", Offset = "0x7F255D0", VA = "0x187F26BD0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(OCPBCGCOJBL NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public readonly struct KAPBDANECMG : IEquatable<KAPBDANECMG>
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[Flags]
	public enum IJIODNPCGGL
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		SUCCESS = 0,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		ANCHOR_A_INVALID = 1,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		ANCHOR_B_INVALID = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		ANCHOR_A_CANNOT_CONNECT = 0,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ANCHOR_B_CANNOT_CONNECT = 0
	}

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KAPBDANECMG DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F120D0", Offset = "0x7F10AD0", VA = "0x187F120D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F215C0", Offset = "0x7F1FFC0", VA = "0x187F215C0")]
	public static IJIODNPCGGL CKPLLPDKPDP(KAPBDANECMG MJGADEGDMOP, KAPBDANECMG LJDEEJKPAEN)
	{
		return default(IJIODNPCGGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F21A40", Offset = "0x7F20440", VA = "0x187F21A40")]
	public bool NHGCHOKOIOA([Out] GameObject EAGGHBKHKHF, [Out] DLOAIPKFGBA KKHNMJOPFHF, [Out] DLOAIPKFGBA DMNPLDCEHDF, [Out] Vector3 JFMEMBGKAOB, [Out] Vector3 APKCAHNFJPG, [Out] Vector3 NNIHDDCLGCG, [Out] DLOAIPKFGBA BHNPLIHINFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F21860", Offset = "0x7F20260", VA = "0x187F21860")]
	public bool FHLOOELHNGL([Out] GameObject EAGGHBKHKHF, [Out] DLOAIPKFGBA KKHNMJOPFHF, [Out] DLOAIPKFGBA DMNPLDCEHDF, [Out] Vector3 JFMEMBGKAOB, [Out] Vector3 APKCAHNFJPG, [Out] Vector3 NNIHDDCLGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F21F40", Offset = "0x7F20940", VA = "0x187F21F40")]
	private void OFJEPJMNLDK(Entity FCFDGFFMMDF, EntityManager KCCKIPGFMEE, MagneticAnchorData HJAEPPOBLAM, [Out] GameObject EAGGHBKHKHF, [Out] DLOAIPKFGBA KKHNMJOPFHF, [Out] DLOAIPKFGBA DMNPLDCEHDF, [Out] Vector3 JFMEMBGKAOB, [Out] Vector3 APKCAHNFJPG, [Out] Vector3 NNIHDDCLGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public KAPBDANECMG(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F217D0", Offset = "0x7F201D0", VA = "0x187F217D0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(KAPBDANECMG NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F22290", Offset = "0x7F20C90", VA = "0x187F22290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public readonly struct NCCMPKBKJNG : IEquatable<NCCMPKBKJNG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F25A30", Offset = "0x7F24430", VA = "0x187F25A30", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(NCCMPKBKJNG NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct CEBGGDHGMPC : IEquatable<CEBGGDHGMPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly ComponentTypes LGJBGHKHFFP;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly CEBGGDHGMPC DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Collider MJEJKEEHILH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B20", Offset = "0x7F15520", VA = "0x187F16B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public IEMCFPCKHGN DPJILMMGDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7F17080", Offset = "0x7F15A80", VA = "0x187F17080")]
		get
		{
			return default(IEMCFPCKHGN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F16A00", Offset = "0x7F15400", VA = "0x187F16A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public HHLLLLGMKPE LBPNMDMNBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F17120", Offset = "0x7F15B20", VA = "0x187F17120")]
		get
		{
			return default(HHLLLLGMKPE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F166A0", Offset = "0x7F150A0", VA = "0x187F166A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public DCGEINBBHPK IAICAJHEOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x7F16410", Offset = "0x7F14E10", VA = "0x187F16410")]
		get
		{
			return default(DCGEINBBHPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7F16FB0", Offset = "0x7F159B0", VA = "0x187F16FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float ALJIMIPKIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7F16AE0", Offset = "0x7F154E0", VA = "0x187F16AE0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x7F169B0", Offset = "0x7F153B0", VA = "0x187F169B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public bool GBNJOMJPEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x7F16300", Offset = "0x7F14D00", VA = "0x187F16300")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x7F16E70", Offset = "0x7F15870", VA = "0x187F16E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public bool LAHOIHHGFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x7F17000", Offset = "0x7F15A00", VA = "0x187F17000")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x7F16F10", Offset = "0x7F15910", VA = "0x187F16F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public bool GCHGEEIGDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7F16280", Offset = "0x7F14C80", VA = "0x187F16280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F16C70", Offset = "0x7F15670", VA = "0x187F16C70")]
	public static bool JEAKDOBCBLA(DLOAIPKFGBA LLIFAAAPPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F16770", Offset = "0x7F15170", VA = "0x187F16770")]
	public static bool EFEDHOLKNME(DLOAIPKFGBA LLIFAAAPPGE, [Out] CEBGGDHGMPC GAKNKBOGJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F16540", Offset = "0x7F14F40", VA = "0x187F16540")]
	public bool CMFENHLEJHD([Out] FDACPNNNIIL PPLEGFHNHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F16450", Offset = "0x7F14E50", VA = "0x187F16450")]
	public bool CJAPKEEOJGF([Out] ENAPEPFMDAJ ALPBGLGCPNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7F170C0", Offset = "0x7F15AC0", VA = "0x187F170C0")]
	public bool PGLGNPEOCHH(JEMODOMIDJB KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7F166F0", Offset = "0x7F150F0", VA = "0x187F166F0")]
	public void DJOIBIGDFDJ(JEMODOMIDJB KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7F16370", Offset = "0x7F14D70", VA = "0x187F16370")]
	public void CBBNHBNMCDM(JEMODOMIDJB KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public CEBGGDHGMPC(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7F16A50", Offset = "0x7F15450", VA = "0x187F16A50", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(CEBGGDHGMPC NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7F17160", Offset = "0x7F15B60", VA = "0x187F17160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public readonly struct CAJABNBCAHN : IEquatable<CAJABNBCAHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool LHGMJELKBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7F14F60", Offset = "0x7F13960", VA = "0x187F14F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public CAJABNBCAHN(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x7F14FB0", Offset = "0x7F139B0", VA = "0x187F14FB0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(CAJABNBCAHN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public readonly struct JFBHFIOCJEK : IEquatable<JFBHFIOCJEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private FDLHNDAJCDN MOGLNGIBNHN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F1B0", Offset = "0x7F1DBB0", VA = "0x187F1F1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F110", Offset = "0x7F1DB10", VA = "0x187F1F110")]
	public void LBDMJOFMHPB(bool BGJFPFLLNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public JFBHFIOCJEK(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F080", Offset = "0x7F1DA80", VA = "0x187F1F080", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(JFBHFIOCJEK NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct ABOKGKNNDEA : IEquatable<ABOKGKNNDEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool NDPLIOKDMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7F116A0", Offset = "0x7F100A0", VA = "0x187F116A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool KNMHDIGKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7F11B30", Offset = "0x7F10530", VA = "0x187F11B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool NEGMPGKAHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7F112D0", Offset = "0x7F0FCD0", VA = "0x187F112D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7F11B80", Offset = "0x7F10580", VA = "0x187F11B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool FAICHLMDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x7F11A50", Offset = "0x7F10450", VA = "0x187F11A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool OBAPKPIMABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x7F113B0", Offset = "0x7F0FDB0", VA = "0x187F113B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool DLDALACBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7F11540", Offset = "0x7F0FF40", VA = "0x187F11540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool NKPLOGAOCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x7F114F0", Offset = "0x7F0FEF0", VA = "0x187F114F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool NKNIEFOLEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7F11830", Offset = "0x7F10230", VA = "0x187F11830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public bool NDLLCHNIBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7F111C0", Offset = "0x7F0FBC0", VA = "0x187F111C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool NDCKKJJHIHP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x7F11920", Offset = "0x7F10320", VA = "0x187F11920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool MELGJAECEOO
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x7F118D0", Offset = "0x7F102D0", VA = "0x187F118D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public bool KKIKKDJCLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x7F114A0", Offset = "0x7F0FEA0", VA = "0x187F114A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public bool OGGGNEJPGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x7F11620", Offset = "0x7F10020", VA = "0x187F11620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public bool DGAKBIIJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x7F11A10", Offset = "0x7F10410", VA = "0x187F11A10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7F119B0", Offset = "0x7F103B0", VA = "0x187F119B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public DNNBJCBPMAN GCJLLPMEBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7F11970", Offset = "0x7F10370", VA = "0x187F11970")]
		get
		{
			return default(DNNBJCBPMAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7F11130", Offset = "0x7F0FB30", VA = "0x187F11130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool OCGOCANAHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7F11010", Offset = "0x7F0FA10", VA = "0x187F11010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public BILGONJLGPF NEKCJJPDMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7F11AA0", Offset = "0x7F104A0", VA = "0x187F11AA0")]
		get
		{
			return default(BILGONJLGPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7F11880", Offset = "0x7F10280", VA = "0x187F11880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool HAGILGEPDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7F11210", Offset = "0x7F0FC10", VA = "0x187F11210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public Vector3 HJOBIGDEGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7F11250", Offset = "0x7F0FC50", VA = "0x187F11250")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 LNBHGJDKCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7F10F90", Offset = "0x7F0F990", VA = "0x187F10F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool AIAAJNMHPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7F11730", Offset = "0x7F10130", VA = "0x187F11730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7F10F30", Offset = "0x7F0F930", VA = "0x187F10F30")]
	public bool ALFKBGDABPK(JMIMLCMOIPN KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7F11320", Offset = "0x7F0FD20", VA = "0x187F11320")]
	public void EGKKBHFAHEB(JMIMLCMOIPN KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11AE0", Offset = "0x7F104E0", VA = "0x187F11AE0")]
	public bool OCOFHDCOGFA(KFCPMNIEOEG KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7F11590", Offset = "0x7F0FF90", VA = "0x187F11590")]
	public void FNDAPEGCIBJ(KFCPMNIEOEG KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7F11180", Offset = "0x7F0FB80", VA = "0x187F11180")]
	public KFCPMNIEOEG CCBHHKKMBNI()
	{
		return default(KFCPMNIEOEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7F116E0", Offset = "0x7F100E0", VA = "0x187F116E0")]
	public bool IKKLFIJDCFE(KFCPMNIEOEG PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public ABOKGKNNDEA(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7F11400", Offset = "0x7F0FE00", VA = "0x187F11400", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(ABOKGKNNDEA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct ENAPPFLAKDJ : IEquatable<ENAPPFLAKDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private OEKDNANFKLA NGMHLHIMLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1A7F0", Offset = "0x7F191F0", VA = "0x187F1A7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AE30", Offset = "0x7F19830", VA = "0x187F1AE30")]
	public bool ONPGKOOKOAE(HCMBDPHADFA GGGOHEOOHCH, List<DLOAIPKFGBA> NONPLOKGMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A650", Offset = "0x7F19050", VA = "0x187F1A650")]
	public int DCJCHGAAFNP(HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A410", Offset = "0x7F18E10", VA = "0x187F1A410")]
	public void AEDLLFPDPOB(List<DLOAIPKFGBA> NONPLOKGMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA10", Offset = "0x7F19410", VA = "0x187F1AA10")]
	public int HHIDBDHOLJB(DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AD00", Offset = "0x7F19700", VA = "0x187F1AD00")]
	public DLOAIPKFGBA MBCMOKPCCDF(int MNFHMLCLFEB, HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A520", Offset = "0x7F18F20", VA = "0x187F1A520")]
	public void AGNFIPNEMII(DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AB40", Offset = "0x7F19540", VA = "0x187F1AB40")]
	public bool HJKPFHANAII(DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A900", Offset = "0x7F19300", VA = "0x187F1A900")]
	public void GBMKLOEHFGK(HCMBDPHADFA GGGOHEOOHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A850", Offset = "0x7F19250", VA = "0x187F1A850")]
	public bool FMDOMGNIFEH(DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7F1ABF0", Offset = "0x7F195F0", VA = "0x187F1ABF0")]
	public bool LMEKIDGECLN(HCMBDPHADFA GGGOHEOOHCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public ENAPPFLAKDJ(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A760", Offset = "0x7F19160", VA = "0x187F1A760", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(ENAPPFLAKDJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct MBLHFGMBHKA : IEquatable<MBLHFGMBHKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7F24D40", Offset = "0x7F23740", VA = "0x187F24D40")]
	public void JFBPIDDEHBE(bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7F24C20", Offset = "0x7F23620", VA = "0x187F24C20")]
	public void EFJJNGDNNEL(bool PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3B39370", Offset = "0x3B37D70", VA = "0x183B39370")]
	public T JBOPMMPJDDN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public MBLHFGMBHKA(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7F24CB0", Offset = "0x7F236B0", VA = "0x187F24CB0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(MBLHFGMBHKA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct HBKMPIEPFDJ : IEquatable<HBKMPIEPFDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool GPAAPPIGAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D9A0", Offset = "0x7F1C3A0", VA = "0x187F1D9A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D880", Offset = "0x7F1C280", VA = "0x187F1D880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool BCEJNIOCOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D800", Offset = "0x7F1C200", VA = "0x187F1D800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public int LCHLPEMKODB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D8D0", Offset = "0x7F1C2D0", VA = "0x187F1D8D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D910", Offset = "0x7F1C310", VA = "0x187F1D910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public HBKMPIEPFDJ(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D770", Offset = "0x7F1C170", VA = "0x187F1D770", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(HBKMPIEPFDJ NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct JDAIHPGPLEF : IEquatable<JDAIHPGPLEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public int IBKJDHKBPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E9C0", Offset = "0x7F1D3C0", VA = "0x187F1E9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EA50", Offset = "0x7F1D450", VA = "0x187F1EA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public int EGGBLPJAFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E860", Offset = "0x7F1D260", VA = "0x187F1E860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EA00", Offset = "0x7F1D400", VA = "0x187F1EA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public uint HOMJDGCIDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E980", Offset = "0x7F1D380", VA = "0x187F1E980")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E8A0", Offset = "0x7F1D2A0", VA = "0x187F1E8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public JDAIHPGPLEF(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E8F0", Offset = "0x7F1D2F0", VA = "0x187F1E8F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(JDAIHPGPLEF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct JNMIIKOJPFE : IEquatable<JNMIIKOJPFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EHDKEPKIAIB LKDHJHAMPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7F20490", Offset = "0x7F1EE90", VA = "0x187F20490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private EINGLJOFPPL OLEOJNIDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7F20030", Offset = "0x7F1EA30", VA = "0x187F20030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool CKMHAIKGFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FDE0", Offset = "0x7F1E7E0", VA = "0x187F1FDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public bool EOOPBOBAMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FF90", Offset = "0x7F1E990", VA = "0x187F1FF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public bool IKFFOIPMNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7F208D0", Offset = "0x7F1F2D0", VA = "0x187F208D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public bool LHICGDDKIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7F206F0", Offset = "0x7F1F0F0", VA = "0x187F206F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool FMPHPKCHADA
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7F20900", Offset = "0x7F1F300", VA = "0x187F20900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public bool DFIOBGFGAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7F20660", Offset = "0x7F1F060", VA = "0x187F20660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public bool AHGBBJBCKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7F20090", Offset = "0x7F1EA90", VA = "0x187F20090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool MLLDPBNEPED
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F204F0", Offset = "0x7F1EEF0", VA = "0x187F204F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public bool PKIAJEJFGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7F202C0", Offset = "0x7F1ECC0", VA = "0x187F202C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FF20", Offset = "0x7F1E920", VA = "0x187F1FF20")]
	public bool CIOLFGDGFNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x7F203F0", Offset = "0x7F1EDF0", VA = "0x187F203F0")]
	public DLOAIPKFGBA IKKGGDGAEBO(DLOAIPKFGBA DKLAGICAOGN)
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x7F207C0", Offset = "0x7F1F1C0", VA = "0x187F207C0")]
	public ENAPEPFMDAJ MOLAGKBHLPA()
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FE70", Offset = "0x7F1E870", VA = "0x187F1FE70")]
	public bool CECGHECAGPF(ENAPEPFMDAJ DKLAGICAOGN, [Out] ENAPEPFMDAJ DGOIDDKDCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public JNMIIKOJPFE(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(JNMIIKOJPFE PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7F20230", Offset = "0x7F1EC30", VA = "0x187F20230", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(JNMIIKOJPFE NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct LLJIFFLLAKA : IEquatable<LLJIFFLLAKA>
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public static readonly LLJIFFLLAKA DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public DMOLGJAGICF LKPMPLALMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7F24650", Offset = "0x7F23050", VA = "0x187F24650")]
		get
		{
			return default(DMOLGJAGICF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public EALCMIHKJHP BMCDLJBPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7F24420", Offset = "0x7F22E20", VA = "0x187F24420")]
		get
		{
			return default(EALCMIHKJHP);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7F24710", Offset = "0x7F23110", VA = "0x187F24710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public CFDCEGNMEPB BOKLPDEMDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7F24330", Offset = "0x7F22D30", VA = "0x187F24330")]
		get
		{
			return default(CFDCEGNMEPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F243D0", Offset = "0x7F22DD0", VA = "0x187F243D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public float EEKEKAAKHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F246D0", Offset = "0x7F230D0", VA = "0x187F246D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F24830", Offset = "0x7F23230", VA = "0x187F24830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Vector3 OOJCFLCIOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F248D0", Offset = "0x7F232D0", VA = "0x187F248D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F24760", Offset = "0x7F23160", VA = "0x187F24760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public float PFGKDPJHOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F245B0", Offset = "0x7F22FB0", VA = "0x187F245B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public JBJNHLKNCIO ANLJNGGGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F244E0", Offset = "0x7F22EE0", VA = "0x187F244E0")]
		get
		{
			return default(JBJNHLKNCIO);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F24880", Offset = "0x7F23280", VA = "0x187F24880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public bool FLBPKEFKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F24690", Offset = "0x7F23090", VA = "0x187F24690")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F24370", Offset = "0x7F22D70", VA = "0x187F24370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public BCJOEIPPFIP OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(BCJOEIPPFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public OCGNHGKBLML HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(OCGNHGKBLML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7F24950", Offset = "0x7F23350", VA = "0x187F24950")]
	public GIMICFKEMIN OPBPCDEFOLN()
	{
		return default(GIMICFKEMIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7F247E0", Offset = "0x7F231E0", VA = "0x187F247E0")]
	public EOJIGNLPGOF KMEENEOMBGN()
	{
		return default(EOJIGNLPGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F24600", Offset = "0x7F23000", VA = "0x187F24600")]
	private bool FMBNHKMAKMG(JBJNHLKNCIO KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F24460", Offset = "0x7F22E60", VA = "0x187F24460")]
	public void DMDCPHHLLEO(JBJNHLKNCIO KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public LLJIFFLLAKA(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(LLJIFFLLAKA PCDAHJCDHHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F18390", Offset = "0x7F16D90", VA = "0x187F18390")]
	public static bool JAIBCELPAPH(LLJIFFLLAKA MJGADEGDMOP, LLJIFFLLAKA LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F24520", Offset = "0x7F22F20", VA = "0x187F24520", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(LLJIFFLLAKA NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct GIMICFKEMIN : IEquatable<GIMICFKEMIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public LLJIFFLLAKA CJODDKOEDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(LLJIFFLLAKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public AMKAGOPDJAP OLGMGEHPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1CCD0", Offset = "0x7F1B6D0", VA = "0x187F1CCD0")]
		get
		{
			return default(AMKAGOPDJAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public GIMICFKEMIN(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(GIMICFKEMIN PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CD10", Offset = "0x7F1B710", VA = "0x187F1CD10", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(GIMICFKEMIN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[DefaultMember("Item")]
public readonly struct EOJIGNLPGOF : IEquatable<EOJIGNLPGOF>
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static readonly EOJIGNLPGOF DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	private CBHGEONKCKO PDFLOKLECOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B5C0", Offset = "0x7F19FC0", VA = "0x187F1B5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public LLJIFFLLAKA CJODDKOEDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(LLJIFFLLAKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public KIMDEAGCPNF HOEOPJDLNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B2F0", Offset = "0x7F19CF0", VA = "0x187F1B2F0")]
		get
		{
			return default(KIMDEAGCPNF);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B410", Offset = "0x7F19E10", VA = "0x187F1B410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public IEnumerable<PFFPLMOBLJN> APKBJLNAFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B100", Offset = "0x7F19B00", VA = "0x187F1B100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public PFFPLMOBLJN OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AFF0", Offset = "0x7F199F0", VA = "0x187F1AFF0")]
		get
		{
			return default(PFFPLMOBLJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF60", Offset = "0x7F19960", VA = "0x187F1AF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public BCJOEIPPFIP OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(BCJOEIPPFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B6C0", Offset = "0x7F1A0C0", VA = "0x187F1B6C0")]
	public PFFPLMOBLJN MIPLJCFCNGM(float3? JFMEMBGKAOB, [Optional] quaternion? NGPACIMGGNA, [Optional] Vector3? JAHHKOMJJAE)
	{
		return default(PFFPLMOBLJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B970", Offset = "0x7F1A370", VA = "0x187F1B970")]
	public PFFPLMOBLJN NLEEAEJAGIN(int MNFHMLCLFEB, float3? JFMEMBGKAOB, [Optional] quaternion? NGPACIMGGNA, [Optional] Vector3? JAHHKOMJJAE)
	{
		return default(PFFPLMOBLJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B620", Offset = "0x7F1A020", VA = "0x187F1B620")]
	public void GLDJLNODHCI(int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B8E0", Offset = "0x7F1A2E0", VA = "0x187F1B8E0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public EOJIGNLPGOF(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F152B0", Offset = "0x7F13CB0", VA = "0x187F152B0")]
	public static bool HNONLACFBHP(EOJIGNLPGOF PCDAHJCDHHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F18380", Offset = "0x7F16D80", VA = "0x187F18380")]
	public static bool IDFALDDOLDN(EOJIGNLPGOF MJGADEGDMOP, EOJIGNLPGOF LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B530", Offset = "0x7F19F30", VA = "0x187F1B530", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(EOJIGNLPGOF NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct PFFPLMOBLJN : IEquatable<PFFPLMOBLJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public EOJIGNLPGOF EKMFHHECCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F27730", Offset = "0x7F26130", VA = "0x187F27730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public float3 PLJHMEAKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F279B0", Offset = "0x7F263B0", VA = "0x187F279B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F278C0", Offset = "0x7F262C0", VA = "0x187F278C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public quaternion EIPFKNEOAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F277C0", Offset = "0x7F261C0", VA = "0x187F277C0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F27810", Offset = "0x7F26210", VA = "0x187F27810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000185")]
	public float3 BOGMPKBDLED
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F27A60", Offset = "0x7F26460", VA = "0x187F27A60")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F27860", Offset = "0x7F26260", VA = "0x187F27860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000186")]
	public GOIIOPJIELK CEEMMOGOGOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F27A10", Offset = "0x7F26410", VA = "0x187F27A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000187")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000188")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F277B0", Offset = "0x7F261B0", VA = "0x187F277B0")]
	public void ALFDADAHNKC(EOJIGNLPGOF PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public PFFPLMOBLJN(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F27920", Offset = "0x7F26320", VA = "0x187F27920", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(PFFPLMOBLJN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public readonly struct KBNDIAPHIBG : IEquatable<KBNDIAPHIBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000189")]
	public bool FPHBFNBCOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F22410", Offset = "0x7F20E10", VA = "0x187F22410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018A")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public KBNDIAPHIBG(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F22380", Offset = "0x7F20D80", VA = "0x187F22380", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(KBNDIAPHIBG NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct MCHKKJLCBCL : IEquatable<MCHKKJLCBCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700018B")]
	private EEBNLPONHJM AOFDNMGDIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F25090", Offset = "0x7F23A90", VA = "0x187F25090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018C")]
	public bool KPAHICLCFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F24E60", Offset = "0x7F23860", VA = "0x187F24E60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F257F0", Offset = "0x7F241F0", VA = "0x187F257F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018D")]
	public bool PKFCDICLJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F253F0", Offset = "0x7F23DF0", VA = "0x187F253F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F258A0", Offset = "0x7F242A0", VA = "0x187F258A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public float MMFMEMJKMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F257B0", Offset = "0x7F241B0", VA = "0x187F257B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F25760", Offset = "0x7F24160", VA = "0x187F25760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public bool MCDAHBMKMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F25850", Offset = "0x7F24250", VA = "0x187F25850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F25900", Offset = "0x7F24300", VA = "0x187F25900")]
	public void PNBCAMIAAKM(int BBAFJLLBENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F24EB0", Offset = "0x7F238B0", VA = "0x187F24EB0")]
	public bool BKHGHMNAFHM([Out] int BBAFJLLBENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F25440", Offset = "0x7F23E40", VA = "0x187F25440")]
	public void JBFEOBAABPN(bool LBKNIIHKLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F25040", Offset = "0x7F23A40", VA = "0x187F25040")]
	public bool CEJKGIKALON(JHEADEDJLCG KCPPNOGKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F24FC0", Offset = "0x7F239C0", VA = "0x187F24FC0")]
	public void BKOBFBMDEKM(JHEADEDJLCG KCPPNOGKMII, bool NDMOBAIGJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F250F0", Offset = "0x7F23AF0", VA = "0x187F250F0")]
	public void ENECKDFNFLL(float HGGKDFKHCFL, float CJEOHFLKFLD, float NEDLOMLGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F25610", Offset = "0x7F24010", VA = "0x187F25610")]
	public void KNPCNGCKAIP(float3 ACHLCABDILJ, quaternion EBHMDABPHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7F252C0", Offset = "0x7F23CC0", VA = "0x187F252C0")]
	public bool GAIGCLEJKLB([Out] float3 ACHLCABDILJ, [Out] quaternion EBHMDABPHLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7F254E0", Offset = "0x7F23EE0", VA = "0x187F254E0")]
	public bool JLCCCEIDPHM([Out] float LBNPHJBPBID, [Out] float ICCMHHHLIIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7F24DD0", Offset = "0x7F237D0", VA = "0x187F24DD0")]
	public void AAMFJFBIPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public MCHKKJLCBCL(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x7F25230", Offset = "0x7F23C30", VA = "0x187F25230", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(MCHKKJLCBCL NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct BCJOEIPPFIP : IEquatable<BCJOEIPPFIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	private CAADPBPBGFN GGGLHIOBFDC
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7F12F70", Offset = "0x7F11970", VA = "0x187F12F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public Vector3 PLJHMEAKAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7F126C0", Offset = "0x7F110C0", VA = "0x187F126C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7F12200", Offset = "0x7F10C00", VA = "0x187F12200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public Quaternion EIPFKNEOAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E30", Offset = "0x7F10830", VA = "0x187F11E30")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7F12130", Offset = "0x7F10B30", VA = "0x187F12130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public Vector3 EOGIJAHENMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7F12E80", Offset = "0x7F11880", VA = "0x187F12E80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7F127B0", Offset = "0x7F111B0", VA = "0x187F127B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public Quaternion CCFEOIPMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7F122D0", Offset = "0x7F10CD0", VA = "0x187F122D0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7F13D00", Offset = "0x7F12700", VA = "0x187F13D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public float AOIEPNMLFAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7F13030", Offset = "0x7F11A30", VA = "0x187F13030")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7F12B50", Offset = "0x7F11550", VA = "0x187F12B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public float KJAMDDODCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7F11F80", Offset = "0x7F10980", VA = "0x187F11F80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public Matrix4x4 INDCMHJNHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x7F13420", Offset = "0x7F11E20", VA = "0x187F13420")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public OCGNHGKBLML HJKHAHECDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(OCGNHGKBLML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private LIEJCDBGGEG NFJGMOBDHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x7F120D0", Offset = "0x7F10AD0", VA = "0x187F120D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x7F124F0", Offset = "0x7F10EF0", VA = "0x187F124F0")]
	public KAOEODPJKHN ENIHNOCBGNP()
	{
		return default(KAOEODPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x7F13500", Offset = "0x7F11F00", VA = "0x187F13500")]
	public void LIAOHMEIEGB([Out] Matrix4x4 CGPCBMKHHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7F13620", Offset = "0x7F12020", VA = "0x187F13620")]
	public void NBKCIBMEKPH([In] Vector3 ANDPKFCEGDK, [In] Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x7F13720", Offset = "0x7F12120", VA = "0x187F13720")]
	public void NBKCIBMEKPH([In] RigidTransform EJCOCDOBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x7F12020", Offset = "0x7F10A20", VA = "0x187F12020")]
	public void CCEAIDFOOOF([Out] RigidTransform EJCOCDOBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x7F137E0", Offset = "0x7F121E0", VA = "0x187F137E0")]
	public void NMJBKCMKELM([In] Vector3 NOJEDFNGOOF, [In] Quaternion EOHNFCEAMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7F138E0", Offset = "0x7F122E0", VA = "0x187F138E0")]
	public void NMJBKCMKELM([In] RigidTransform MCMAFBKNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x7F12C00", Offset = "0x7F11600", VA = "0x187F12C00")]
	public void GPAPNKOLGND([Out] Vector3 NOJEDFNGOOF, [Out] Quaternion EOHNFCEAMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x7F12CE0", Offset = "0x7F116E0", VA = "0x187F12CE0")]
	public void GPAPNKOLGND([Out] RigidTransform EJCOCDOBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x7F13240", Offset = "0x7F11C40", VA = "0x187F13240")]
	public UniformTRS JOILMADJKLA()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x7F13270", Offset = "0x7F11C70", VA = "0x187F13270")]
	public void JOILMADJKLA([Out] UniformTRS MCMAFBKNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7F12690", Offset = "0x7F11090", VA = "0x187F12690")]
	public UniformTRS FBKLGMCHAJB()
	{
		return default(UniformTRS);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7F125D0", Offset = "0x7F10FD0", VA = "0x187F125D0")]
	public void FBKLGMCHAJB([Out] UniformTRS EJCOCDOBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7F12D90", Offset = "0x7F11790", VA = "0x187F12D90")]
	public Vector3 HBBKEBFANAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7F139A0", Offset = "0x7F123A0", VA = "0x187F139A0")]
	public void OIHPCFOKBCM([In] Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7F13330", Offset = "0x7F11D30", VA = "0x187F13330")]
	public Vector3 JPIENEAKBJM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7F12A80", Offset = "0x7F11480", VA = "0x187F12A80")]
	public void GGCNFNAHPAH([In] Vector3 PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x7F12930", Offset = "0x7F11330", VA = "0x187F12930")]
	public Quaternion GBOJMCDAMJE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7F12420", Offset = "0x7F10E20", VA = "0x187F12420")]
	public void EMMMNHOPKAL([In] Quaternion PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x7F13A70", Offset = "0x7F12470", VA = "0x187F13A70")]
	public Quaternion OPHIFKIOLKC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x7F13170", Offset = "0x7F11B70", VA = "0x187F13170")]
	public void JMOLMDANLHF([In] Quaternion PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x7F130D0", Offset = "0x7F11AD0", VA = "0x187F130D0")]
	public float JKOFBNOMEEO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7F13C50", Offset = "0x7F12650", VA = "0x187F13C50")]
	public void PEPIENENHHC(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x7F13460", Offset = "0x7F11E60", VA = "0x187F13460")]
	public float LENMPAKDLOP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x7F12880", Offset = "0x7F11280", VA = "0x187F12880")]
	public void FHIAPMOPEMC(float PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x7F13BC0", Offset = "0x7F125C0", VA = "0x187F13BC0")]
	public Vector3 PABHNBBAOFC([In] Vector3 HPCBBMBEKNN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public BCJOEIPPFIP(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7F12540", Offset = "0x7F10F40", VA = "0x187F12540", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(BCJOEIPPFIP NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public readonly struct CGKLKPDBCAI : IEquatable<CGKLKPDBCAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	private PCFEOOONLAD JHCPKLMIINI
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7F17550", Offset = "0x7F15F50", VA = "0x187F17550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public DLOAIPKFGBA PCJJLOCHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(DLOAIPKFGBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	private EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x7F11610", Offset = "0x7F10010", VA = "0x187F11610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7F17380", Offset = "0x7F15D80", VA = "0x187F17380")]
	public void DMHHJDOHCII(string GBJOGAJJMBI, KCFNBNEHMGB CFOOPMPGJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public CGKLKPDBCAI(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7F174C0", Offset = "0x7F15EC0", VA = "0x187F174C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(CGKLKPDBCAI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BA0", Offset = "0x7F105A0", VA = "0x187F11BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct FILMIOPCKHB : IEquatable<FILMIOPCKHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public IAIEGNHMFLD PFLNEDINOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BD30", Offset = "0x7F1A730", VA = "0x187F1BD30")]
		get
		{
			return default(IAIEGNHMFLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public FILMIOPCKHB(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BCA0", Offset = "0x7F1A6A0", VA = "0x187F1BCA0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(FILMIOPCKHB NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct KOGNIPCKIAK : IEquatable<KOGNIPCKIAK>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct HPOMHMHODIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private ENAPEPFMDAJ MBIJJAIIOHD;

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DC20", Offset = "0x7F1C620", VA = "0x187F1DC20")]
		public HPOMHMHODIM(ENAPEPFMDAJ MBIJJAIIOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DB90", Offset = "0x7F1C590", VA = "0x187F1DB90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x7F23B30", Offset = "0x7F22530", VA = "0x187F23B30")]
	public HPOMHMHODIM LBBLOBADELI()
	{
		return default(HPOMHMHODIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7F23840", Offset = "0x7F22240", VA = "0x187F23840")]
	public FIEDPDCDGBB CLLBKJBCKBJ(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(FIEDPDCDGBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7F23C80", Offset = "0x7F22680", VA = "0x187F23C80")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> NDHJHLGMJCL(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7F239C0", Offset = "0x7F223C0", VA = "0x187F239C0")]
	public NativeArray<ADLHINHFEDA> GGIDKENOECN(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(NativeArray<ADLHINHFEDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7F23790", Offset = "0x7F22190", VA = "0x187F23790")]
	public NativeArray<ADLHINHFEDA> BCLIJKHOKGI(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(NativeArray<ADLHINHFEDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7F23A70", Offset = "0x7F22470", VA = "0x187F23A70")]
	public KAGMCHPMLPA HFICFNDFPNB(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7F23DB0", Offset = "0x7F227B0", VA = "0x187F23DB0")]
	public KAGMCHPMLPA NEELCLAKMNO(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7F23BC0", Offset = "0x7F225C0", VA = "0x187F23BC0")]
	public KAGMCHPMLPA LNDHKCGJPGN(Allocator NDKMELBEFLH = Allocator.Temp)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public KOGNIPCKIAK(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7F23930", Offset = "0x7F22330", VA = "0x187F23930", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(KOGNIPCKIAK NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D090", Offset = "0x7F1BA90", VA = "0x187F1D090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct DEDPJPKCBHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int BICIBICPBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NJLIPJGBANG;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct PBDEMOHAMJE : IEquatable<PBDEMOHAMJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public KOGNIPCKIAK DKLPIDLFHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(KOGNIPCKIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public GMBBGJKGCAE JONELKFDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(GMBBGJKGCAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public FILMIOPCKHB MMBPJDFHCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(FILMIOPCKHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7F27450", Offset = "0x7F25E50", VA = "0x187F27450")]
	public bool HOOCFCLFFNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7F272D0", Offset = "0x7F25CD0", VA = "0x187F272D0")]
	public bool GJGKFLHCAGC([Out] Exception AJLHKIHCGAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public PBDEMOHAMJE(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static ENAPEPFMDAJ HNONLACFBHP(PBDEMOHAMJE PCDAHJCDHHF)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7F27240", Offset = "0x7F25C40", VA = "0x187F27240", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(PBDEMOHAMJE NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D090", Offset = "0x7F1BA90", VA = "0x187F1D090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct DNGBAIAGHGB : IDisposable, IEquatable<DNGBAIAGHGB>
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public static readonly DNGBAIAGHGB DGDKNKEGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public PBDEMOHAMJE PKCFNJINFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(PBDEMOHAMJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public KOGNIPCKIAK DKLPIDLFHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(KOGNIPCKIAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7F18C70", Offset = "0x7F17670", VA = "0x187F18C70")]
	public void BHDHOBJCJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x7F18CF0", Offset = "0x7F176F0", VA = "0x187F18CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public DNGBAIAGHGB(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7F18DC0", Offset = "0x7F177C0", VA = "0x187F18DC0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "5")]
	public bool Equals(DNGBAIAGHGB NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x7F18E50", Offset = "0x7F17850", VA = "0x187F18E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct GMBBGJKGCAE : IEquatable<GMBBGJKGCAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly ENAPEPFMDAJ PIIGBAMEEMF;

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public bool BJNMAJLJEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D000", Offset = "0x7F1BA00", VA = "0x187F1D000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	public GMBBGJKGCAE(ENAPEPFMDAJ MBIJJAIIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x7F11670", Offset = "0x7F10070", VA = "0x187F11670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7F1CF70", Offset = "0x7F1B970", VA = "0x187F1CF70", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x7F11490", Offset = "0x7F0FE90", VA = "0x187F11490", Slot = "4")]
	public bool Equals(GMBBGJKGCAE NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D090", Offset = "0x7F1BA90", VA = "0x187F1D090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DNCKGIEGOHA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private struct MEKMLPEGMNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Guid FNKCCICOAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public OOCLFELFEAJ MPCBGNFIJEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private struct OOCLFELFEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int PCDAHJCDHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int MIIHDODFGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int KOHAJFPELFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int HHJEMILAEKH;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x7F26C60", Offset = "0x7F25660", VA = "0x187F26C60")]
		public bool PJGGCEDKGFK([Out] ADLHINHFEDA ABAEHPFNLLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x7F26D00", Offset = "0x7F25700", VA = "0x187F26D00")]
		public OOCLFELFEAJ(ADLHINHFEDA ABAEHPFNLLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7F18BB0", Offset = "0x7F175B0", VA = "0x187F18BB0")]
	public static Guid DGFPCOOOMMF(this ADLHINHFEDA ABAEHPFNLLE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7F18C50", Offset = "0x7F17650", VA = "0x187F18C50")]
	public static bool LAMKLLFGEEN(this Guid FNKCCICOAII, [Out] ADLHINHFEDA ABAEHPFNLLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class DPNANBLJNIM
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x7F18FD0", Offset = "0x7F179D0", VA = "0x187F18FD0")]
	public static EODLPAIPBLC FGEPPNHGGNK(this ENAPEPFMDAJ KHNIMGKFPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7F19170", Offset = "0x7F17B70", VA = "0x187F19170")]
	public static EGLJCDJPPKL OJJAAPMGEHK(this ENAPEPFMDAJ KHNIMGKFPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x7F18F40", Offset = "0x7F17940", VA = "0x187F18F40")]
	public static EntityManager EPPMAGJCIHI(this ENAPEPFMDAJ KHNIMGKFPOO)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x38DA8F0", Offset = "0x38D92F0", VA = "0x1838DA8F0")]
	internal static bool BLBHOKAJODN<T>(this ENAPEPFMDAJ KHNIMGKFPOO, bool NDMOBAIGJOM) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x7F19060", Offset = "0x7F17A60", VA = "0x187F19060")]
	public static bool FOOPCLJHKGC(this ENAPEPFMDAJ KHNIMGKFPOO, CODIAJPBCGJ MLCOAPMDJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x38DC570", Offset = "0x38DAF70", VA = "0x1838DC570")]
	public static bool KOEOHNAAHLJ<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x38DCE30", Offset = "0x38DB830", VA = "0x1838DCE30")]
	public static bool LKKFLKFBGCB<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : struct, IBufferElementData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x38DABE0", Offset = "0x38D95E0", VA = "0x1838DABE0")]
	[JIEAOHANLHP]
	public static T HBDOAIEKALC<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x38D7EB0", Offset = "0x38D68B0", VA = "0x1838D7EB0")]
	[JIEAOHANLHP]
	public static T AFGDDNEKBPL<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x38DC450", Offset = "0x38DAE50", VA = "0x1838DC450")]
	public static bool HECHNHKEOCD<T>(this ENAPEPFMDAJ KHNIMGKFPOO, [Out] T PCDAHJCDHHF) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x38DAB30", Offset = "0x38D9530", VA = "0x1838DAB30")]
	public static T DMLLFDCDGOH<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x38DAAB0", Offset = "0x38D94B0", VA = "0x1838DAAB0")]
	public static T CPMLDDKLAKA<T>(this ENAPEPFMDAJ KHNIMGKFPOO) where T : class, IComponentData
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal static class AMKLEALLDHN
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public struct FIEDPDCDGBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private KAGMCHPMLPA AJHCLHGHINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> BELPOEEIAFH;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB450", Offset = "0x5CE9E50", VA = "0x185CEB450")]
	public FIEDPDCDGBB(KAGMCHPMLPA AJHCLHGHINB, NativeArray<EntityRemapUtility.EntityRemapInfo> BELPOEEIAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BC10", Offset = "0x7F1A610", VA = "0x187F1BC10")]
	public LocalId LENIEODPCKJ(LocalId OJDHMKOBKLD)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BC50", Offset = "0x7F1A650", VA = "0x187F1BC50")]
	public LocalId LENIEODPCKJ(int MNFHMLCLFEB)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BBA0", Offset = "0x7F1A5A0", VA = "0x187F1BBA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HNBCNFOFDHD
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKFNKBOCFCP(World HAGIBPOACDD, NativeParallelHashSet<FixedString64Bytes> JGHGJDAGCKC);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KKAHPLHELKO
{
	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBLPAOCMLOL(ENAPEPFMDAJ JNMDJGFBNHD, [Out] uint KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IOGGLDGJMCH(ENAPEPFMDAJ JNMDJGFBNHD, [Out] uint KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOGHNKFOGAC(ENAPEPFMDAJ JNMDJGFBNHD, uint KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGOMNJAPOAC(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NGMIEFHKIJI(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EOOFGDBJPPP(ENAPEPFMDAJ JNMDJGFBNHD, string KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IEFNBHLCFID(ENAPEPFMDAJ JNMDJGFBNHD, [Out] string NOJPHICPLME);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGBPDMPHKFH(ENAPEPFMDAJ JNMDJGFBNHD, string NOJPHICPLME);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AENANBBBHCL
{
	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	Guid KDPIFEDMNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	Guid LPFNKFPGMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DJEMIOHBBMB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task DIHILAHDILG(DLOAIPKFGBA OJDHMKOBKLD);

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Guid MDCMFFJBHGC(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJMGDPJGGIA(ENAPEPFMDAJ MBIJJAIIOHD, Guid MKAMFGFDAIG);

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLGOGCIFHOK(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ANDBJIJOLOH(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ EAGGHBKHKHF);

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCBKONEKNPD(ENAPEPFMDAJ MBIJJAIIOHD, ADLHINHFEDA ELDLGGCLIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FBGJLHCHBOA
{
	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	Guid KDPIFEDMNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKEGEIAJKLK(NativeList<Guid> EKJENELNAFI, NativeList<Guid> BOJPAHCEHJJ, NativeList<FixedString64Bytes> FCDCLJKPLLP);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KMIJOPLDOIJ
{
	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KAGMCHPMLPA JOLBFKHBIKJ(Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KAGMCHPMLPA GOGEPMMBKOH(Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKGFDEPMDPD(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCEJNIOCOEK(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KKLDOJBJIKG(ENAPEPFMDAJ JNMDJGFBNHD, [Out] ENAPEPFMDAJ NABIABJHPGD);

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GPAAPPIGAGH(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCAFDLNBBHG(ENAPEPFMDAJ JNMDJGFBNHD, int NIHHJEGJCCB);

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENAPEPFMDAJ DMOEIDIJPMM(ENAPEPFMDAJ NABIABJHPGD);

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNBCMHEPPOA(KAGMCHPMLPA KBAPNJGAALD, bool OLGOMDBOIEC);

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BJKAMJNIPHM(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKGLKGOMLAO(ENAPEPFMDAJ JNMDJGFBNHD, bool PAOMLPBEPBE);

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DJBCKGKFHOO();

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BPABFHPMKMP(ENAPEPFMDAJ MBIJJAIIOHD);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CIKMOHIBDEH
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<ENAPEPFMDAJ, ENAPEPFMDAJ> EHCMIKKCIDM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<ENAPEPFMDAJ, ENAPEPFMDAJ> JNPHJHFNNGG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<ENAPEPFMDAJ, ENAPEPFMDAJ, ENAPEPFMDAJ> JLBOKLADPHJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ENAPEPFMDAJ> LMJGHEKNEDP;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FKIBIHHLAHG(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ IGPJAGNJGBE);

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ENAPEPFMDAJ ANKOJGDDHNP(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KAGMCHPMLPA CACHLDHMAPK(ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ENAPEPFMDAJ KJAHBPNMIJP(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FMMLIMMDJFF(ENAPEPFMDAJ MBIJJAIIOHD, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HHLPKLPLJAO(ENAPEPFMDAJ MBIJJAIIOHD, float MHEMELNGBHJ);

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NAEOMADPDLD(ENAPEPFMDAJ MBIJJAIIOHD, [Out] ENAPEPFMDAJ EAGGHBKHKHF);

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BIIAKCIENGH(ENAPEPFMDAJ MBIJJAIIOHD, [Out] RigidTransform JKGMEODBJNH);

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 KNBPEHJMLEA(CDJDJONIPHI CGJBEMKJPKN);

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion KKHMKOIJJIF(CDJDJONIPHI CGJBEMKJPKN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class AFBPHPBGPEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ABKJDDLGCGM
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	object OIODALOOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIIBDIKPEII
{
	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHKPFLBGOIN(ENAPEPFMDAJ OJDHMKOBKLD, EAIPDLDMFMI INMLGCAAFGI);

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOCFAGHFNEC(EAIPDLDMFMI INMLGCAAFGI);

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGOECGCOEPB(ENAPEPFMDAJ MBIJJAIIOHD, [Out] EAIPDLDMFMI EPNMAJAPLLD);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[Flags]
public enum OONEEIPNNJI
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	IncludeSelf = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	IncludeChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	IncludeDescendants = 6,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	IncludeMask = 7,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Disembodied = 8,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Embodied = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	IgnoreEmbodiment = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	EmbodimentMask = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Runtime = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Authored = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	AuthoredAndRuntime = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	HierarchyMask = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	HintInputsAreDisjoint = 0x80
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public readonly struct KJCBGHLBJDG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly string GBCFHNGPBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly T ALKDPGOIFPD;

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x51C5EA0", Offset = "0x51C48A0", VA = "0x1851C5EA0")]
	public KJCBGHLBJDG(T ALKDPGOIFPD, [Optional][CallerMemberName] string GBCFHNGPBLM)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly KJCBGHLBJDG<int> EDHHGIBAFLB;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public static readonly KJCBGHLBJDG<int> DEPEAHCPDML;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public static readonly KJCBGHLBJDG<int> MCPAMOHELFG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public enum KBPCLJBNAOH
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class MPFDIEDLDII
{
	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x137BA70", Offset = "0x137A470", VA = "0x18137BA70")]
	public static bool CHDKMONBLHL(this KBPCLJBNAOH LOPOEJHIPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x177FA80", Offset = "0x177E480", VA = "0x18177FA80")]
	public static bool LHJCNNJHEEG(this KBPCLJBNAOH LOPOEJHIPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F97000", Offset = "0x2F95A00", VA = "0x182F97000")]
	public static bool CPPMIPLPOBK(this KBPCLJBNAOH LOPOEJHIPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x137BA60", Offset = "0x137A460", VA = "0x18137BA60")]
	public static bool GIJOHBIBAGE(this KBPCLJBNAOH LOPOEJHIPKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BICFCNHMLON
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public enum OOANCIPONCE
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Unloaded,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Loading,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Loaded,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public enum FJDHJHJHPDN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		NeverEditReady,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		AlwaysEditReady
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	OOANCIPONCE LLLFLNPIFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	bool PKAJELCINII
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	bool BAJLDGBKKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	FJDHJHJHPDN PHNAJPOMKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[ServiceLifetime(Lifetime.Application)]
public interface KHAPJGKJHDD
{
	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	KBPCLJBNAOH MPBLDGHJNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	KBPCLJBNAOH FDFMDNPNFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	KBPCLJBNAOH NACECPJKHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	KBPCLJBNAOH LKOOONLLMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	KBPCLJBNAOH FAKIFAGNOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	KBPCLJBNAOH GLLEOPBLEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	KBPCLJBNAOH NDEPKJACAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	KBPCLJBNAOH MLOKHHIAGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	KBPCLJBNAOH HDLNBFDKAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	KBPCLJBNAOH ABBOMCKDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	KBPCLJBNAOH EKBIMLPBFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	KBPCLJBNAOH LOCOIPIKNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	KBPCLJBNAOH MBACMJLAOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	KBPCLJBNAOH IKLBFDNHEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	KBPCLJBNAOH MNMOOHMAMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	KBPCLJBNAOH ENMCDPBLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	KBPCLJBNAOH KJMPMMHIKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	KBPCLJBNAOH IFPHFPEFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	KBPCLJBNAOH PJHFFALFBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	KBPCLJBNAOH INBBKDHLLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IBPMNADNGOO(KJCBGHLBJDG<int> DHADAJLMNNE);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MPJMMKIMNOF
{
	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event BBNOKEJNIAP.KCCBPCFBPIL INEFMFLJJAG;

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENAPEPFMDAJ BDJDOBJNAFH(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KAGMCHPMLPA NPJLADDPDJN(Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GOIIOPJIELK FFOGCAPLIEP(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GJCNAIGPIGO(IEnumerable<ENAPEPFMDAJ> CAACILOHNEF);

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOIIOPJIELK DJBHKLNCJOM(ENAPEPFMDAJ EAGGHBKHKHF, ENAPEPFMDAJ AJHCLHGHINB, bool PNFGCFOAGGB, ENAPEPFMDAJ DKLAGICAOGN);

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENAPEPFMDAJ IGONPOBPOPB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ODCKPPKNECL(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ EAGGHBKHKHF, bool FFLKINLBHIE = false);

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BBHGBCKOHIA(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ EAGGHBKHKHF);

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool INCIPKCPKGJ(ENAPEPFMDAJ IPMCNOAMGMB, ENAPEPFMDAJ LMPELBHCDBC);

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[Obsolete("Use IHierarchyService.GetChildren() instead")]
	KAGMCHPMLPA OFPBIDPFBDM(ENAPEPFMDAJ PIIGBAMEEMF);

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool APKAEMDJPKE(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ BOIFGGDKBDB);

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KAGMCHPMLPA BBKONDLGHJE(KAGMCHPMLPA GADNMOBPPDC, OONEEIPNNJI FIKPCOCNDHE, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool NEGGGDNIIHO(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ AHFPKINDEMG);

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ENAPEPFMDAJ MALAIGFGBBG(ENAPEPFMDAJ DKLAGICAOGN, ENAPEPFMDAJ CKEAALPOFNA);

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool GMOCKMBDCPE(ENAPEPFMDAJ DKLAGICAOGN, ENAPEPFMDAJ CKEAALPOFNA, [Out] ENAPEPFMDAJ JJNPFIKIPBO);

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ENAPEPFMDAJ GKJOKNBDODK(ENAPEPFMDAJ[] KBAPNJGAALD);

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ENAPEPFMDAJ KIGCHLNOGBL(ENAPEPFMDAJ MBIJJAIIOHD, uint CJHEGLKIIFN);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class JDOENLOGPKN
{
	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EED0", Offset = "0x7F1D8D0", VA = "0x187F1EED0")]
	public static bool FPFHCIFNHJK(this MPJMMKIMNOF HFNJMFEEMLC, ENAPEPFMDAJ MBIJJAIIOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EAE0", Offset = "0x7F1D4E0", VA = "0x187F1EAE0")]
	public static KAGMCHPMLPA BBKONDLGHJE(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, OONEEIPNNJI FIKPCOCNDHE, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EF80", Offset = "0x7F1D980", VA = "0x187F1EF80")]
	public static KAGMCHPMLPA IEKHLKAMMKD(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EF40", Offset = "0x7F1D940", VA = "0x187F1EF40")]
	public static KAGMCHPMLPA ICPLIIPGNEC(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F000", Offset = "0x7F1DA00", VA = "0x187F1F000")]
	public static KAGMCHPMLPA NEOBGIFCFBC(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EFC0", Offset = "0x7F1D9C0", VA = "0x187F1EFC0")]
	public static KAGMCHPMLPA JEPNNIFIHIK(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F1F040", Offset = "0x7F1DA40", VA = "0x187F1F040")]
	public static KAGMCHPMLPA NIAADNKFEFC(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EAA0", Offset = "0x7F1D4A0", VA = "0x187F1EAA0")]
	public static KAGMCHPMLPA BBKONDLGHJE(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1ED70", Offset = "0x7F1D770", VA = "0x187F1ED70")]
	public static KAGMCHPMLPA EAMLANDDMME(this MPJMMKIMNOF BNMCGGOFKAO, ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EDB0", Offset = "0x7F1D7B0", VA = "0x187F1EDB0")]
	public static KAGMCHPMLPA EAMLANDDMME(this MPJMMKIMNOF BNMCGGOFKAO, KAGMCHPMLPA MBIJJAIIOHD, Allocator NDKMELBEFLH)
	{
		return default(KAGMCHPMLPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KMJPJKPGPLG
{
	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIHPIEHKPPJ LPNJPEPHCGP(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HODMJGLFNOB(ENAPEPFMDAJ JNMDJGFBNHD, HIHPIEHKPPJ CINLHBCEEIL);

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JENGBFIAOCN(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPFEBEINLID(ENAPEPFMDAJ JNMDJGFBNHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDGDEEMNBFK<string> IMFGFALBFLL(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBHEPMPEOOC(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HDGDEEMNBFK<string> PHDGHNGLMJG(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHMMCHAHNHL(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HDGDEEMNBFK<string> MPPKKENAOLO(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCANMBIHKLL(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HDGDEEMNBFK<string> NKENKKNNLIA(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AMFCNIMKONG(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CKJGAKAJEIM(ENAPEPFMDAJ JNMDJGFBNHD, ENAPEPFMDAJ KPIDJKLDGJJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DIOBDIFFCMA
{
	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x7F17A00", Offset = "0x7F16400", VA = "0x187F17A00", Slot = "0")]
	Task<PBDEMOHAMJE> KKOGPLABNBE(NEGEMEPEKGJ OHPIKMOJFMF, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "1")]
	void EIHIAHGDMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface PMOEPKGMOEK
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BBNOKEJNIAP.KCCBPCFBPIL INEFMFLJJAG;

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENAPEPFMDAJ IGONPOBPOPB(ENAPEPFMDAJ GBGDJHDAECJ);

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ReadOnlySpan<ENAPEPFMDAJ> BJHHPAFGOPP();

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ReadOnlySpan<ENAPEPFMDAJ> FMKEHKNKAJB(ENAPEPFMDAJ EAGGHBKHKHF);

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GCOINNNFCHL(ENAPEPFMDAJ GHLGGANCABA, ENAPEPFMDAJ GFKGBLILCLI, [Out] GOIIOPJIELK PIAFDGBOJIP);

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CJHCKOPJPMF(ENAPEPFMDAJ GHLGGANCABA, ENAPEPFMDAJ BIKNADICMMH, [Out] GOIIOPJIELK PIAFDGBOJIP);

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JEEEDGNKHIJ(ENAPEPFMDAJ GHLGGANCABA);

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BBHGBCKOHIA(ENAPEPFMDAJ NIPAGEHBHFE, ENAPEPFMDAJ FEIPCFECKLD);

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GOIIOPJIELK NCGBDNANLAF(ENAPEPFMDAJ MBIJJAIIOHD);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CCIJNJHLGOE
{
	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	bool ENDKDOCHMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	bool PEOJHBDJACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	bool DMGOAAFGPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface GOBPEHMLLGC
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LOHJJKGNFLO
{
	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPBCFPHFFGC(ENAPEPFMDAJ MBIJJAIIOHD, CODIAJPBCGJ MLCOAPMDJJE);

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBDJPOJNAFO(ENAPEPFMDAJ MBIJJAIIOHD, CODIAJPBCGJ MLCOAPMDJJE);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMOEIDEIGJH
{
	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBIEDCDMCNP([In] float3 CHGCFNILDNG, [In] float3 HPCBBMBEKNN, float LCMAOMAPNJJ, [Out] NDPGHHPEPLH ILPECMLIINC, [Out] ENAPEPFMDAJ DOOGFLKEMBP);

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PFNEELIAMBF([In] float3 CHGCFNILDNG, float BGJJMJPDNJC, List<ENAPEPFMDAJ> KBAPNJGAALD);

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NBKDPALPFIO(Plane[] LMDGHGMKIDG, float3 CHGCFNILDNG, float3 IOPHBPCPMJL, quaternion NGPACIMGGNA, List<ENAPEPFMDAJ> KBAPNJGAALD);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OAADBODFAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBIEDCDMCNP([In] NativeArray<Entity> OBKJONELPMG, [In] float3 CHGCFNILDNG, [In] float3 HPCBBMBEKNN, [In] NativeArray<NDPGHHPEPLH> MDFNACABIBM);

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NativeList<Entity> PFNEELIAMBF([In] NativeArray<Entity> OBKJONELPMG, [In] float3 CHGCFNILDNG, float BGJJMJPDNJC);

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NativeList<Entity> NBKDPALPFIO([In] NativeArray<Entity> OBKJONELPMG, [In] NativeArray<float4> EKFLKAIOANM);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LILFAAHMPPN : MCDNNIEBNOJ, IEquatable<LILFAAHMPPN>
{
	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public int FOIACCDFCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public int EHHACNLGFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x7F24250", Offset = "0x7F22C50", VA = "0x187F24250", Slot = "8")]
	public bool Equals(LILFAAHMPPN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x7F242A0", Offset = "0x7F22CA0", VA = "0x187F242A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct NDPGHHPEPLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float NJGJECBFPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public float3 ODJALHAEEDH;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EJNHONPAFIK
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LIEJCDBGGEG
{
	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	EODLPAIPBLC FGEPPNHGGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	BLMPLBHICCL LOFOMIOAGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KAGMCHPMLPA, NativeArray<RRObjectPrefabData>> DPBAPFEMLHI;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KAGMCHPMLPA> CKFEBLGHGFJ;

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KAGMCHPMLPA GMMKHEINHCF();

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AHFPEAMOHOD ELIBIKDENEL(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "8")]
	RRObjectPrefabData CBPJNONIDJE(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BAEBJICNGAD(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DLOAIPKFGBA JIMLDNAJIJB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool NFMIKDFGADC(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FGPMIMDDHJD(ENAPEPFMDAJ MBIJJAIIOHD, [Out] Transform MNINMACDPEC);

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ENAPEPFMDAJ DJKLHMDONLD(ADLHINHFEDA ABAEHPFNLLE);

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GIHOGKFEGLO(ADLHINHFEDA ABAEHPFNLLE, [Out] ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ADLHINHFEDA KHIDFLKOANA(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KAGMCHPMLPA DJKLHMDONLD(NativeArray<ADLHINHFEDA> ABAEHPFNLLE, Allocator NDKMELBEFLH, bool GHOMFEPCBNM = true);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JNONFNNPNDE(NativeArray<KMIJPBAIKGJ> IAEHMNICOJM, NativeArray<ADLHINHFEDA> MMKOIILHDKH, NativeArray<Entity> NNCPEMNAOJL, HDGDEEMNBFK<LPALHDAMDFN> IHICEKLNMMK);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DLOAIPKFGBA NPFCKCFNLKD();

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	DLOAIPKFGBA LGHKECOEALP(RRObjectPrefabData JKDPGJIAJNJ, [Optional] HFLODILPGJG ADMDDIMPGOI);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CCGHEDPJKKI JIFCFFCPNLC();

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	EOJIGNLPGOF CIJHMNKKKKN();

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GIMICFKEMIN LHFPFEAOFBB(AMKAGOPDJAP LJDEBIMELGO);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PNICNJBPHAG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool AOBBKCEFJPH(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KAGMCHPMLPA AEHPGLCLAPI(KAGMCHPMLPA LKAJLCGLGLO, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IAKPEOGICJH(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FPMOELGGBJJ(ENAPEPFMDAJ MBIJJAIIOHD, ComponentTypes FHAMDHINANC);

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ENAPEPFMDAJ CIAMANMHIHE(Transform MNINMACDPEC);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class PJIFPABFCDP
{
	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x7F27F50", Offset = "0x7F26950", VA = "0x187F27F50")]
	internal static ENAPEPFMDAJ LIOAHMKNNIA(this Entity FCFDGFFMMDF, LIEJCDBGGEG CFOOPMPGJIK)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x7F27AC0", Offset = "0x7F264C0", VA = "0x187F27AC0")]
	public static DLOAIPKFGBA AIHJEDDJMMP(this LIEJCDBGGEG CFOOPMPGJIK, LocalId MBIJJAIIOHD)
	{
		return default(DLOAIPKFGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x7F27AD0", Offset = "0x7F264D0", VA = "0x187F27AD0")]
	public static ENAPEPFMDAJ DJKLHMDONLD(this LIEJCDBGGEG CFOOPMPGJIK, LocalId MBIJJAIIOHD)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x7F27EE0", Offset = "0x7F268E0", VA = "0x187F27EE0")]
	public static ADLHINHFEDA KHIDFLKOANA(this LIEJCDBGGEG CFOOPMPGJIK, LocalId MBIJJAIIOHD)
	{
		return default(ADLHINHFEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x7F27D30", Offset = "0x7F26730", VA = "0x187F27D30")]
	public static CCGHEDPJKKI HCIJFABKPPN(this LIEJCDBGGEG CFOOPMPGJIK, RigidTransform MCMAFBKNOBH)
	{
		return default(CCGHEDPJKKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x7F27B80", Offset = "0x7F26580", VA = "0x187F27B80")]
	public static GIMICFKEMIN FMMNDFFKPIB(this LIEJCDBGGEG CFOOPMPGJIK, AMKAGOPDJAP FNPPAEMKOHH, RigidTransform MCMAFBKNOBH)
	{
		return default(GIMICFKEMIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x7F28000", Offset = "0x7F26A00", VA = "0x187F28000")]
	public static EOJIGNLPGOF NJFAIGBAEFK(this LIEJCDBGGEG CFOOPMPGJIK, RigidTransform MCMAFBKNOBH)
	{
		return default(EOJIGNLPGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x7F281B0", Offset = "0x7F26BB0", VA = "0x187F281B0")]
	private static void PICNACBLMBE(DLOAIPKFGBA LLIFAAAPPGE, RigidTransform MCMAFBKNOBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal interface JHINFODNCAE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHDKEPKIAIB
{
	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	bool OCBCILAJHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	ENAPEPFMDAJ CNJDILDFBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	DLOAIPKFGBA GAGJNJOGADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DFPJPOPFBEN CBFGHJPEOHE;

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENAPEPFMDAJ MALAIGFGBBG(ENAPEPFMDAJ DKLAGICAOGN, ENAPEPFMDAJ CKEAALPOFNA);

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GMOCKMBDCPE(ENAPEPFMDAJ DKLAGICAOGN, ENAPEPFMDAJ CKEAALPOFNA, [Out] ENAPEPFMDAJ JJNPFIKIPBO);

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GMEIOJLCKME();

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKEAIDNKPFF();

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CKMHAIKGFCP(ENAPEPFMDAJ DKLAGICAOGN);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DFIOBGFGAKJ(ENAPEPFMDAJ DKLAGICAOGN);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public delegate void DFPJPOPFBEN(DLOAIPKFGBA EHCBPFOIGNO, DLOAIPKFGBA BPMMAHGCHEJ);
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class PEGFDANHEOO
{
	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x7F276E0", Offset = "0x7F260E0", VA = "0x187F276E0")]
	public static bool OLPPEFKMFFA(this EHDKEPKIAIB JKBDOKDHEFH, DLOAIPKFGBA DKLAGICAOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x7F27580", Offset = "0x7F25F80", VA = "0x187F27580")]
	public static bool GBEOPCECBOK(this EHDKEPKIAIB JKBDOKDHEFH, ENAPEPFMDAJ DKLAGICAOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x7F27660", Offset = "0x7F26060", VA = "0x187F27660")]
	public static bool LHICGDDKIEF(this EHDKEPKIAIB JKBDOKDHEFH, ENAPEPFMDAJ DKLAGICAOGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JHJFCJGIDMB
{
	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEEPGFFMOKC(NativeList<RRObjectPrefabData> HAEBAGDOBKH);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface OEKDNANFKLA
{
	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONPGKOOKOAE(DLOAIPKFGBA LLIFAAAPPGE, HCMBDPHADFA GGGOHEOOHCH, List<DLOAIPKFGBA> NONPLOKGMEC);

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DCJCHGAAFNP(DLOAIPKFGBA LLIFAAAPPGE, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEDLLFPDPOB(DLOAIPKFGBA LLIFAAAPPGE, List<DLOAIPKFGBA> NONPLOKGMEC);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HHIDBDHOLJB(DLOAIPKFGBA BBAFJLLBENK, DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DLOAIPKFGBA MBCMOKPCCDF(DLOAIPKFGBA BBAFJLLBENK, int MNFHMLCLFEB, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGNFIPNEMII(DLOAIPKFGBA BBAFJLLBENK, DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HJKPFHANAII(DLOAIPKFGBA BBAFJLLBENK, DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GBMKLOEHFGK(DLOAIPKFGBA BBAFJLLBENK, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FMDOMGNIFEH(DLOAIPKFGBA BBAFJLLBENK, DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JNCKKONNLGK(Entity BBAFJLLBENK, Entity DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IJLKNDDOBLN(Entity BBAFJLLBENK, HCMBDPHADFA GGGOHEOOHCH);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LMEKIDGECLN(DLOAIPKFGBA DKLAGICAOGN, HCMBDPHADFA GGGOHEOOHCH);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EHKDKFHMKPF
{
	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	FILMIOPCKHB JEJENDHICOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IAIEGNHMFLD GGBBOHPCFGI(FILMIOPCKHB JGPHIOPNBKA);

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FILMIOPCKHB NFDNIHLKFCE();

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FILMIOPCKHB MAPBIFOOOHD();
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EINGLJOFPPL
{
	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CECGHECAGPF(ENAPEPFMDAJ DKLAGICAOGN, [Out] ENAPEPFMDAJ DNIMBEIENAL);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface DJAFIONDJDC
{
	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFBPIDDEHBE(ENAPEPFMDAJ PIIGBAMEEMF, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFJJNGDNNEL(ENAPEPFMDAJ PIIGBAMEEMF, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPNIGLIHMHB(ENAPEPFMDAJ PIIGBAMEEMF, int PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CBHGEONKCKO
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ENAPEPFMDAJ> EOBDNMPNLNO(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENAPEPFMDAJ NDLCIIHDEKD(ENAPEPFMDAJ MBIJJAIIOHD, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OJEDKDHMGND(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIMDEAGCPNF FEGODFHLGFC(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOLJCNIBIPK(ENAPEPFMDAJ MBIJJAIIOHD, KIMDEAGCPNF JKGCHKOAIPN);

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENAPEPFMDAJ DGLJJFONOAA(ENAPEPFMDAJ MBIJJAIIOHD, [Optional] float3? JFMEMBGKAOB, [Optional] quaternion? NGPACIMGGNA, [Optional] float3? JAHHKOMJJAE);

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ENAPEPFMDAJ CEEHENEBILM(ENAPEPFMDAJ MBIJJAIIOHD, int MNFHMLCLFEB, [Optional] float3? JFMEMBGKAOB, [Optional] quaternion? NGPACIMGGNA, [Optional] float3? JAHHKOMJJAE);

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBOLPFAHFEG(ENAPEPFMDAJ MBIJJAIIOHD, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCLDOMPDBHH(ENAPEPFMDAJ MBIJJAIIOHD);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AAGOKGKIEAD
{
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PMJLOCGKOBI
{
	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	bool BHBCGOLOLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLGNGNCEFNA();

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKAGEJPDBEO();

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOBPILLMFCN();

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KPDIAOKAPCE();

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNIIDFBLPCC();

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECEBEBHKIMA();

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LADDDGMOCJB();

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PDLEKEKBOMA();

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DHJIILMIGFC();

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CNABEANCJHL();

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IOAPDJEMJEF();

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOEBIGGENMA();
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EEBNLPONHJM
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKHGHMNAFHM(ENAPEPFMDAJ DKLAGICAOGN, [Out] int BBAFJLLBENK);

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNBCAMIAAKM(ENAPEPFMDAJ DKLAGICAOGN, int BBAFJLLBENK);

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBFEOBAABPN(ENAPEPFMDAJ DKLAGICAOGN, bool LBKNIIHKLNM);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ENECKDFNFLL(ENAPEPFMDAJ DKLAGICAOGN, float HGGKDFKHCFL, float CJEOHFLKFLD, float NEDLOMLGMAI);

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JLCCCEIDPHM(ENAPEPFMDAJ MBIJJAIIOHD, [Out] float CJEOHFLKFLD, [Out] float NEDLOMLGMAI);

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNPCNGCKAIP(ENAPEPFMDAJ DKLAGICAOGN, float3 JFMEMBGKAOB, quaternion NGPACIMGGNA);

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GAIGCLEJKLB(ENAPEPFMDAJ DKLAGICAOGN, [Out] float3 JFMEMBGKAOB, [Out] quaternion NGPACIMGGNA);

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AAMFJFBIPJN(ENAPEPFMDAJ DKLAGICAOGN);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CAADPBPBGFN
{
	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIHPCFOKBCM(Entity FCFDGFFMMDF, [In] float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float3 HBBKEBFANAO(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMMMNHOPKAL(Entity FCFDGFFMMDF, [In] quaternion PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "3")]
	quaternion GBOJMCDAMJE(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBKCIBMEKPH(Entity FCFDGFFMMDF, [In] float3 JFMEMBGKAOB, [In] quaternion NGPACIMGGNA);

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCEAIDFOOOF(Entity FCFDGFFMMDF, [Out] RigidTransform JNGKMPEJDBM);

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMJBKCMKELM(Entity FCFDGFFMMDF, [In] float3 JFMEMBGKAOB, [In] quaternion NGPACIMGGNA);

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPAPNKOLGND(Entity FCFDGFFMMDF, [Out] float3 JFMEMBGKAOB, [Out] quaternion NGPACIMGGNA);

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GPAPNKOLGND(Entity FCFDGFFMMDF, [Out] RigidTransform JNGKMPEJDBM);

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PEPIENENHHC(Entity FCFDGFFMMDF, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float JKOFBNOMEEO(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GGCNFNAHPAH(Entity FCFDGFFMMDF, [In] float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float3 JPIENEAKBJM(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JMOLMDANLHF(Entity FCFDGFFMMDF, [In] quaternion PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	quaternion OPHIFKIOLKC(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHIAPMOPEMC(Entity FCFDGFFMMDF, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float LENMPAKDLOP(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AJAFFHEEOJD(Entity FCFDGFFMMDF, [Out] float4x4 CGPCBMKHHCJ);

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void BGBMFAHKEON(Entity FCFDGFFMMDF, [In] float4x4 CGPCBMKHHCJ);

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HCFAAFELPNN(Entity FCFDGFFMMDF);

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BOENMHLEOPA(Entity FCFDGFFMMDF, Entity OGLNHOKFGHC, Entity FEIPCFECKLD);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class JCFEPIPAEHA
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface JNOJKPGFFIB
{
	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNOBGPCFJOB(bool NKJLCDEGCON);
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface PCFEOOONLAD
{
	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPADCIHGCGL(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJPFAFECLHE(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJJANBIHBGF(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIPFNOHMGCG(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACKMMKJLHHM(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JBGIMIJBLHA(ENAPEPFMDAJ JNMDJGFBNHD, HDGDEEMNBFK<string> FHMNFJFMOMK);

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MPBMGHALCBE(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int IEHBFEJPFJI(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int HMPNGCEJOIM(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BBKFGDIALBG<string> OCJNODGNJCB(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BCLBINHBFEP(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BBKFGDIALBG<string> NDIJKKMEGLA(ENAPEPFMDAJ JNMDJGFBNHD);

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool AACDFGKMPJI(ENAPEPFMDAJ JNMDJGFBNHD, string GBJOGAJJMBI);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LGDBCKGCIMK(string GBJOGAJJMBI, KCFNBNEHMGB IAMKOJBNFJG);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ENAPEPFMDAJ AIJINCKFCAB(string GBJOGAJJMBI);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEACHLACCAC(string GBJOGAJJMBI, KCFNBNEHMGB IAMKOJBNFJG);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DMHHJDOHCII(ENAPEPFMDAJ CICHLNMEJJN, string GBJOGAJJMBI, KCFNBNEHMGB IAMKOJBNFJG);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BBKFGDIALBG<string> IKNIMKDONGL();
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class AEAGNNIGMCD
{
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LMPFCIAFLON
{
	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LOHCINCCMGB(string FLPHOFDJIDP = "Main");

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World JIOLNNJHPCD(string FLPHOFDJIDP = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World CKFHNAAMPBA(string FLPHOFDJIDP = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World PNNCJPIPIPB(string FLPHOFDJIDP = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface EGLJCDJPPKL
{
	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	World HKPAMNHEFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	World FBAEBGABNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	EntityManager EPPMAGJCIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001D8")]
	bool ANNFNILDKLH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase HCLCEHCENBJ(Type HHCAOFMCNLG);
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class ACFAPOJFAOK
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F11BC0", Offset = "0x7F105C0", VA = "0x187F11BC0")]
	public static ComponentSystemBase EOGHHDGAIDL(this World HAGIBPOACDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x3000390", Offset = "0x2FFED90", VA = "0x183000390")]
	public static T HCLCEHCENBJ<T>(this EGLJCDJPPKL LEHAFKMGCIN) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BHLGJNPNLEA
{
	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALGIODLIFHE(NativeListAsync<Entity> DLNGBICJMOF);

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEHHDGOKHCC(FFBAEFODIMO GHCHJCJMKLI);

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLLJHCCILOA(NativeListAsync<Entity> BGMKCLIONHI, bool DHGNECFLCMJ);

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCCIIFGIOJK();

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAAHCLGKPJG(Entity ALPBGLGCPNB);
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface HJHPEHKJOGC
{
	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APFNEEALMKD(Collider PPLEGFHNHEE, [Out] AAJIJBMDHCM HMABEADDPPB);
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IOIBNFLPGLE
{
	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Collider PELKEHEHOBK(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PHPNBGLIBLN(ENAPEPFMDAJ FAPJNOHNEDC, GameObject ANGPMLNFAIK, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLOOGACPKAM(GameObject PPLEGFHNHEE);

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider FILMEHAACAE<TCollider>(GameObject NNAKLCKBBKJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNHCLIEGIPD(Collider PPLEGFHNHEE);

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HJDAKKFDGBF<TCollider>(string GBCFHNGPBLM) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FDACPNNNIIL KFEJOKMJNLK(ENAPEPFMDAJ FBDJDJAEHKE, ENAPEPFMDAJ KAPKPBOANEB, AMKAGOPDJAP HCLCHKKNFJP, float3 NOGMMOFPBBJ, quaternion FPHCCCBFNEI, float3 NJFGCDBKBKO);

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CMFENHLEJHD(ENAPEPFMDAJ MBIJJAIIOHD, [Out] FDACPNNNIIL PPLEGFHNHEE);

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GEEFDNKLDNK(ENAPEPFMDAJ MBIJJAIIOHD, [Out] ENAPEPFMDAJ ALPBGLGCPNB);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum CPJFBNKBKKP
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Sphere,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Box,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Mesh,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	CapsuleX,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	CapsuleY,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	CapsuleZ,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CKHGENHBJMF
{
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public struct NNIFMIIAGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int HCLCHKKNFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public GameObject ANGPMLNFAIK;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIKIDMNOPKO(ENAPEPFMDAJ MBIJJAIIOHD, IEMCFPCKHGN ELFIGBBFNMF, bool AMHBGJMDOEI, JEMODOMIDJB LLPGFGDEBOF);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHNHDONNEPB(ENAPEPFMDAJ MBIJJAIIOHD, IEMCFPCKHGN ELFIGBBFNMF, bool AMHBGJMDOEI, bool JGFLOAJCNPB, bool GMDIEMDHBPD);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KMILEGDAIEA JNMBDACFHPA(ENAPEPFMDAJ ALPBGLGCPNB, List<ENAPEPFMDAJ> NHPCIJMIJLE);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDACPNNNIIL FDNDGANHMNG(GameObject MNFBAKADMKC, GameObject JGGHACAEOIB);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POJLIIJGBME(GameObject MNFBAKADMKC, List<GameObject> BFFCDCDCBOJ);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEOOIGEBNCH(GameObject JGGHACAEOIB);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FILMEHAACAE<T>(GameObject NNAKLCKBBKJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNHCLIEGIPD(Collider PPLEGFHNHEE);

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GameObject OPKIKKNJMID<T>(string GBCFHNGPBLM) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GCJHICEFJFI(Collider PPLEGFHNHEE, [Out] ENAPEPFMDAJ BBAFJLLBENK);

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NHBDCMDJBMK(ENAPEPFMDAJ MBIJJAIIOHD, [Out] AAJIJBMDHCM HMABEADDPPB);

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<CPJFBNKBKKP> PPLNLDPOJCG(Allocator NDKMELBEFLH = Allocator.TempJob);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Mesh[] AOPHADGECGP();
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface CBIIKHEMLIG
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLEAELBHIOH(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECOBBKCDHHK(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KMPGHHAFECC(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ENAPEPFMDAJ HBBGKOKBEPF(ENAPEPFMDAJ MBIJJAIIOHD, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KAGMCHPMLPA JHOHEMDCNJK(ENAPEPFMDAJ MBIJJAIIOHD, Allocator NDKMELBEFLH = Allocator.Temp);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPPOPFOAGDN(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA, ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCKEKIMKMAF(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MJCJHGNGKJG(ENAPEPFMDAJ MBIJJAIIOHD, [Out] ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGKBDNGEMFE(ENAPEPFMDAJ MBIJJAIIOHD, float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IIALPKDKNPH(ENAPEPFMDAJ MBIJJAIIOHD, [Out] float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MPHCHGFJOEG(ENAPEPFMDAJ MBIJJAIIOHD, float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ADJDNNDOJHH(ENAPEPFMDAJ MBIJJAIIOHD, [Out] float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPEMPFCEPBP(ENAPEPFMDAJ MBIJJAIIOHD, (Quaternion rot, Vector3 moments) HMJIJMLCIDN);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NMOJNOAJNNH(ENAPEPFMDAJ MBIJJAIIOHD, [Out] quaternion NOEMAMNIFJJ, [Out] float3 PMGNHMOILNI);

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LBOFACIPJCI(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 KOAFBBHJLFL(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 NNKEACDEOLM(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CIIBODFHBFJ(ENAPEPFMDAJ MBIJJAIIOHD, float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PFKLFFGPINK(ENAPEPFMDAJ MBIJJAIIOHD, float3 PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float LBDOIJHMPJF(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float JCMNMGMJNMG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NIAKDAJMLOI(ENAPEPFMDAJ MBIJJAIIOHD, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BBLILPPIGBB(ENAPEPFMDAJ MBIJJAIIOHD, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CollisionDetectionMode AAADGJBFBME(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DCBFLNBDLLG(ENAPEPFMDAJ MBIJJAIIOHD, CollisionDetectionMode PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BJFKEGNANDB ICPCBKEEFGL(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JIKALDBNHCD(ENAPEPFMDAJ MBIJJAIIOHD, BJFKEGNANDB PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PGNEBOKDHKL(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KEPCLMBKABC(ENAPEPFMDAJ MBIJJAIIOHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(Slot = "29")]
	ENAPEPFMDAJ BDJDOBJNAFH(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BGAPNNNLHDI(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(Slot = "31")]
	ENAPEPFMDAJ IGONPOBPOPB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ODCKPPKNECL(ENAPEPFMDAJ MBIJJAIIOHD, ENAPEPFMDAJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(Slot = "33")]
	DLKLAKEEKHP NHPBPGMHGGG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NPJJDIKLJBD(ENAPEPFMDAJ MBIJJAIIOHD, DLKLAKEEKHP GOMCGOABOEM);

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EHOCFKDNELA(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void APJBBHHDHOG(ENAPEPFMDAJ MBIJJAIIOHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool CCIILCNBKGG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LNNNMLKEPAI(ENAPEPFMDAJ MBIJJAIIOHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	RigidbodyConstraints PLEEFKMNFMJ(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void IFHCCDPFKAE(ENAPEPFMDAJ MBIJJAIIOHD, RigidbodyConstraints PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	float BNGDJLGAEOH(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LABCMGJODFN(ENAPEPFMDAJ MBIJJAIIOHD, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	float EGFALJCJEOK(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GCMGMLJFGPD(ENAPEPFMDAJ MBIJJAIIOHD, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool EKKLMPHGKCB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void FGPCODLPHKD(ENAPEPFMDAJ MBIJJAIIOHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(Slot = "47")]
	bool JFMBEHAFGLI(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void ICJCPLHDLKA(ENAPEPFMDAJ MBIJJAIIOHD, bool PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LGJIAFHHOHB(ENAPEPFMDAJ MBIJJAIIOHD, int PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(Slot = "50")]
	FJBHJEKKKOJ JDLKHGIDCPE(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void BPHHPFFFDAH(ENAPEPFMDAJ MBIJJAIIOHD, FJBHJEKKKOJ PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(Slot = "52")]
	MMGNDNMMIBP JDBNPMPMFNK(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void EAKOEACLDHL(ENAPEPFMDAJ MBIJJAIIOHD, MMGNDNMMIBP PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "54")]
	float OAMKAMHEOPF(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	void PHCMNJICAAG(ENAPEPFMDAJ MBIJJAIIOHD, float PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GMDLNFDIMOK(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void FNHGGKJFNCN(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	bool LCDPHGAPHHG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	void MHGMMEIEFFP(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void FGLJGOJBAPF(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(Slot = "61")]
	bool CDPGJBOKAFG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(Slot = "62")]
	bool MBJOEGHBNEA(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Rigidbody FDJPOFDKCCA(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void NPFNFGKMNFM(ENAPEPFMDAJ MBIJJAIIOHD, Rigidbody FADODMKCMLG);

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void NGENBHLPLCE(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void DCFIAPPHDDC(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BJHABCMEBMM(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FBNNCEHFOMG(ENAPEPFMDAJ MBIJJAIIOHD, float3 CGGOJBPICAG);

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MPIFCJDAELA(ENAPEPFMDAJ MBIJJAIIOHD, float3 DGGOMONDOHM);

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool MOHIKAOCFCG(ENAPEPFMDAJ MBIJJAIIOHD, [Out] float3 CGGOJBPICAG);

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool JGNNKECHMMK(ENAPEPFMDAJ MBIJJAIIOHD, [Out] float3 DGGOMONDOHM);

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool OOFIBNOFLPB(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void NJOOMDMBOMH(ENAPEPFMDAJ MBIJJAIIOHD, object BECBHDDLOHA, bool PLIDCHGGBAD);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void COGAOJPIBBA(ENAPEPFMDAJ MBIJJAIIOHD, bool JHGFAMKONOJ);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void ILBHNBOBDLG(ENAPEPFMDAJ MBIJJAIIOHD);

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool IJNNEMBGPEC(ENAPEPFMDAJ MBIJJAIIOHD);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INKBJOIFKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNHFNAMJKKK(Entity EBCDKMKOJDD);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKAKENLBFFB(Entity EBCDKMKOJDD);

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBOJFEBDBMJ(Entity EBCDKMKOJDD);
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FDLHNDAJCDN
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOGECEHCKHH(ENAPEPFMDAJ DKLAGICAOGN, bool BGJFPFLLNLP);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public delegate void FKLKHKBMFBB(IODLJFMHOBH FCOKJIGPPNB);
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public readonly ref struct IODLJFMHOBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly KAGMCHPMLPA EJIHLDAGBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly NativeArray<byte> NGEPLLLPPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly NativeArray<byte> KCNPBOEBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly CODIAJPBCGJ MLCOAPMDJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int FPLMLNBDHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Type NOKPPDOGAKH;

	[Cpp2IlInjected.Token(Token = "0x170001D9")]
	public KAGMCHPMLPA BDNMMIDGDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x4C86A50", Offset = "0x4C85450", VA = "0x184C86A50")]
		get
		{
			return default(KAGMCHPMLPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DA")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E750", Offset = "0x7F1D150", VA = "0x187F1E750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001DB")]
	public CODIAJPBCGJ GAGMDOKLKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
		get
		{
			return default(CODIAJPBCGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E7A0", Offset = "0x7F1D1A0", VA = "0x187F1E7A0")]
	public IODLJFMHOBH(KAGMCHPMLPA EJIHLDAGBON, NativeArray<byte> NGEPLLLPPCI, NativeArray<byte> KCNPBOEBOJC, CODIAJPBCGJ MLCOAPMDJJE, int FPLMLNBDHDP, Type NOKPPDOGAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9D40", Offset = "0x3AA8740", VA = "0x183AA9D40")]
	public NativeArray<T> PBKCPFGDGJM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9C10", Offset = "0x3AA8610", VA = "0x183AA9C10")]
	public NativeArray<T> ALKMGKKDOGN<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA9C50", Offset = "0x3AA8650", VA = "0x183AA9C50")]
	public (KAGMCHPMLPA, NativeArray<T>, NativeArray<T>) IBPMNADNGOO<T>() where T : struct
	{
		return default((KAGMCHPMLPA, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E770", Offset = "0x7F1D170", VA = "0x187F1E770")]
	public NKHGNBHNPNC DHNJAIFNAIO()
	{
		return default(NKHGNBHNPNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public interface CLLBKCAPOKF
{
	[Cpp2IlInjected.Token(Token = "0x170001DC")]
	string DEANMCONMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DD")]
	CLLBKCAPOKF EFGELPDECOF
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001DE")]
	IEnumerable<CLLBKCAPOKF> GIMKACOBAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface BCLIOHNNKAE
{
	[Cpp2IlInjected.Token(Token = "0x170001DF")]
	CLLBKCAPOKF HGHGLMCHNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E0")]
	NativeArray<CODIAJPBCGJ> FAKLNCEIALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JOLJKHPCPMD(CODIAJPBCGJ MLCOAPMDJJE, [Out] CLLBKCAPOKF AJEELMNCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPIAMCEAEFP(CODIAJPBCGJ MLCOAPMDJJE, FKLKHKBMFBB JMPFPCJHIID);

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAJHDKMEFKB(CODIAJPBCGJ MLCOAPMDJJE, FKLKHKBMFBB JMPFPCJHIID);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ONILDMOJOJL
{
	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EPIAMCEAEFP(CODIAJPBCGJ MLCOAPMDJJE, FKLKHKBMFBB JMPFPCJHIID);

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAJHDKMEFKB(CODIAJPBCGJ MLCOAPMDJJE, FKLKHKBMFBB JMPFPCJHIID);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class HFEHLLACNMO
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface HLOEAOGKPNF
{
	[Cpp2IlInjected.Token(Token = "0x170001E1")]
	bool NLELDMIPPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E2")]
	DLJHLLCGILG GDLAOIICLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEEPNGKDKLG(IAIEGNHMFLD ABAEHPFNLLE, bool DIMNOGHDAIO);

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CGAHMGMNKHP(ADLHINHFEDA ABAEHPFNLLE, CODIAJPBCGJ MLCOAPMDJJE);

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMCMOEFOEMD(NativeArray<ADLHINHFEDA> KBDICFEMPEA);
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class FBNBBMDEJGC
{
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public readonly ref struct NKHGNBHNPNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly IODLJFMHOBH HPGIDELCODH;

	[Cpp2IlInjected.Token(Token = "0x170001E3")]
	public KAGMCHPMLPA BDNMMIDGDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x4C86A50", Offset = "0x4C85450", VA = "0x184C86A50")]
		get
		{
			return default(KAGMCHPMLPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x7F26090", Offset = "0x7F24A90", VA = "0x187F26090")]
	public NKHGNBHNPNC(IODLJFMHOBH HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x7F25F60", Offset = "0x7F24960", VA = "0x187F25F60")]
	public KAGMCHPMLPA PBKCPFGDGJM()
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x7F25B40", Offset = "0x7F24540", VA = "0x187F25B40")]
	public KAGMCHPMLPA ALKMGKKDOGN()
	{
		return default(KAGMCHPMLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x7F25C70", Offset = "0x7F24670", VA = "0x187F25C70")]
	public (KAGMCHPMLPA, KAGMCHPMLPA, KAGMCHPMLPA) IBPMNADNGOO()
	{
		return default((KAGMCHPMLPA, KAGMCHPMLPA, KAGMCHPMLPA));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public static class MICLMHCAOPH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public readonly struct DLJHLLCGILG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly NativeBitArray DDHBCPNOIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly NativeParallelHashMap<ADLHINHFEDA, int> MNMOGOIEHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly NativeParallelHashSet<IAIEGNHMFLD> NMAEKIGNPKD;

	[Cpp2IlInjected.Token(Token = "0x170001E4")]
	public bool GKKJOEIBDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7F17A60", Offset = "0x7F16460", VA = "0x187F17A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001E5")]
	public bool NLELDMIPPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7F17A80", Offset = "0x7F16480", VA = "0x187F17A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x5D41340", Offset = "0x5D3FD40", VA = "0x185D41340")]
	public DLJHLLCGILG(NativeBitArray DDHBCPNOIBD, NativeParallelHashMap<ADLHINHFEDA, int> MNMOGOIEHGK, NativeParallelHashSet<IAIEGNHMFLD> NMAEKIGNPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x7F17AB0", Offset = "0x7F164B0", VA = "0x187F17AB0")]
	public bool CGAHMGMNKHP(ADLHINHFEDA ABAEHPFNLLE, CODIAJPBCGJ MLCOAPMDJJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FLAPFPGLJHE
{
	[Cpp2IlInjected.Token(Token = "0x170001E6")]
	LBAACCFPEFG LNFMLOJGGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[ServiceLifetime(Lifetime.LoadInstance)]
public interface MGLBOPBHLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFOPOLEGLJG(ENAPEPFMDAJ MBIJJAIIOHD, DMLEMIIKCOM PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LFLLENECNAF AMDCFBDOBIN();
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NEOCGKLJABG
{
	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIOPPGJHEIG(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMIJAPBBBMH(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ComponentSystemBase GABCIFCMFGO(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIIBPMGABGN(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAOJPCEGPBD(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OHFKBFNNLCB(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FMNMHHLIPKG(World HAGIBPOACDD);

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeParallelHashSet<ComponentTypeIndex> BMMEDGBMNGC();
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FCHEOJAONPM
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HALFIAFGNOF(ENAPEPFMDAJ PIIGBAMEEMF, bool PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct ILFNPJLIKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly IEnumerable<HNJMEJAJGPE> CONHHEBAINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly IReadOnlyList<GameObject> DFKBNDHBEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly IReadOnlyList<int> FKMDLHEOOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly IReadOnlyList<(ADLHINHFEDA, ADLHINHFEDA)> OBMEMNCEECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly int JKECHIHBPIL;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct POCDHHDKHPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public InventionIdData KHNIMGKFPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public InventionInstanceIdData KALBDAKMCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public bool EKJAIFMNDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x7F282A0", Offset = "0x7F26CA0", VA = "0x187F282A0")]
	public POCDHHDKHPN(long KHNIMGKFPOO, Guid KALBDAKMCAH, bool EKJAIFMNDOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[ServiceLifetime(Lifetime.Application)]
public interface AGPJEJLJAFN
{
	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBDEMOHAMJE LIOOMJEMBAO(NEGEMEPEKGJ NJPILGECKNH, int BDGHELFBPFO = 0, bool IEAOCPKLMGK = false);

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DNGBAIAGHGB NAGPIHCKCBH(NEGEMEPEKGJ NJPILGECKNH, ENAPEPFMDAJ EAGGHBKHKHF, [In] UniformTRS JJACJNEFCMH, OGNBHGBADFO LBCMLAJPILP, [Optional] POCDHHDKHPN FAJMKIKIDHO, bool PKHBEDGBEOK = true, bool BMFBIEHHPID = false, bool IEAOCPKLMGK = false, bool JHKKEHLHBKG = false);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMPPJBENADP GODALIODJBD();

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMPPJBENADP DBNBGIODOKO(KAGMCHPMLPA KBAPNJGAALD, [In] UniformTRS HKPEGCGEMBL, [Optional] OGNBHGBADFO GMCKGIPBBFD);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HOOCFCLFFNL(ENAPEPFMDAJ NAMJMGOLGGM);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GJGKFLHCAGC(ENAPEPFMDAJ NAMJMGOLGGM, [Out] Exception EMKLCNOEBAG);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeArray<ADLHINHFEDA> GGIDKENOECN(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NativeArray<ADLHINHFEDA> BCLIJKHOKGI(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KAGMCHPMLPA HFICFNDFPNB(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KAGMCHPMLPA NEELCLAKMNO(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KAGMCHPMLPA BAKEKHFJKJE(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NDHJHLGMJCL(ENAPEPFMDAJ NAMJMGOLGGM, Allocator NDKMELBEFLH);

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LFHLOPFOFMF(ENAPEPFMDAJ NAMJMGOLGGM);

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int HMHKDEMOKBA(ENAPEPFMDAJ NAMJMGOLGGM, int IMCIONKBBCL);
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[ServiceLifetime(Lifetime.Application)]
public interface NCCLKBNONFG
{
	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0xE8AF10", Offset = "0xE89910", VA = "0x180E8AF10", Slot = "0")]
	bool DKBEFMGKPNM(object JEMDJIEKJFA, AAPOELEAAKP NOKPKAJJDFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class LNFLMNKLAII
{
	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x7F249A0", Offset = "0x7F233A0", VA = "0x187F249A0")]
	public static bool DKBEFMGKPNM(this NCCLKBNONFG BNMCGGOFKAO, object JEMDJIEKJFA, [Out] AAPOELEAAKP NOKPKAJJDFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public enum AAECDNIMHJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	MaxPlayers = byte.MaxValue,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	IsVisible = 254,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	IsOpen = 253,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	PlayerCount = 252,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Removed = 251,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	PropsListedInLobby = 250,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	CleanupCacheOnLeave = 249,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	MasterClientId = 248,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	ExpectedUsers = 247,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	PlayerTtl = 246,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	EmptyRoomTtl = 245,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HasDedicatedMaster = 87
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface AAPOELEAAKP
{
	[Cpp2IlInjected.Token(Token = "0x170001E7")]
	NIBEEHLDBHF GLEDFKBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E8")]
	PGNMDKGFDBN DIKGDMMMELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001E9")]
	bool LKACNAFBHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EA")]
	bool KKJGDCKAOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object DOBBPAKLENC();

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0xFDAED0", Offset = "0xFD98D0", VA = "0x180FDAED0", Slot = "5")]
	(PGNMDKGFDBN, Dictionary<object, object>) NNGHEMMNHEO()
	{
		return default((PGNMDKGFDBN, Dictionary<object, object>));
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
	(ADLHINHFEDA, PGNMDKGFDBN) HODFONKLGAG()
	{
		return default((ADLHINHFEDA, PGNMDKGFDBN));
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "7")]
	BPJILBPJJPI<(ADLHINHFEDA, PGNMDKGFDBN)> GDJNKNKFFKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xFDAED0", Offset = "0xFD98D0", VA = "0x180FDAED0", Slot = "8")]
	(EEEPFGDDBAA, byte[]) IODCLCOEEOE()
	{
		return default((EEEPFGDDBAA, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0xFDAED0", Offset = "0xFD98D0", VA = "0x180FDAED0", Slot = "9")]
	(KDALJMPLLKK, byte[]) NLDIMEMKJNG()
	{
		return default((KDALJMPLLKK, byte[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0xFDAED0", Offset = "0xFD98D0", VA = "0x180FDAED0", Slot = "10")]
	T GBAFHMCEBDK<T>()
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class DAIKFFLOKIC
{
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x7F178C0", Offset = "0x7F162C0", VA = "0x187F178C0")]
	public static bool HINCOHCKNIO(this AAPOELEAAKP IPADIJEFNLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public interface GNONBMFALJL : BPJILBPJJPI<KFGKIGCKOGK>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[DefaultMember("Item")]
public interface BPJILBPJJPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x170001EB")]
	T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001EC")]
	int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public enum NIBEEHLDBHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	BulkInstantiate = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	BulkDestroy = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	OMSendPacket = 4,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_OutOfBandMessage = 5,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_FastForwardMarker = 6,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_SelfJoinMarker = 7,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_DebugOp = 10,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_CachedEvent = 11,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RRRoomRequestEvent = 20,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RRRoomRequestFailedResponseEvent = 21,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RRBufferedRoomEvent = 22,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RRClearBufferedRoomEvent = 23,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_CreationOp = 24,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_CreationOpResponse = 25,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_CreationOp_Unchecked = 26,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_MasterLockBlockComplete = 27,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_NetworkSynchronization = 28,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_NetworkInstantiate = 29,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_BulkInstantiate = 31,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_Destroy = 32,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_BulkDestroy = 33,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_TransferOwnership = 34,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_OwnershipUpdate = 35,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_RPC = 36,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_JoinRequest = 100,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_JoinResponse = 101,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_RoomUpdate = 102,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_PlayerUpdate = 103,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_RemotePlayerJoined = 104,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_RemotePlayerLeft = 105,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RR_Leave = 106,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RPC = 200,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	SendSerialize = 201,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	Instantiation = 202,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	CloseConnection = 203,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Destroy = 204,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RemoveCachedRPCs = 205,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	SendSerializeReliable = 206,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	DestroyPlayer = 207,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	OwnershipRequest = 209,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	OwnershipTransfer = 210,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	VacantViewIds = 211,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	OwnershipUpdate = 212,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	AuthEvent = 223,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LobbyStats = 224,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	AppStats = 226,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Match = 227,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	QueueState = 228,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	GameListUpdate = 229,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	GameList = 230,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	CacheSliceChanged = 250,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	ErrorInfo = 251,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	PropertiesChanged = 253,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Leave = 254,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Join = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public enum EEEPFGDDBAA : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	None = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	NetworkTransformInitializationData = 1314146628u,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	RestoreCreationData = 1380140064u,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	OldestCachedPacketId = 1329811529u,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	SnapshotPublished = 1397773634u,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	SnapshotPayload = 1397771332u,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	SnapshotClear = 1129337683u
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class GMHOEPDHCGB
{
	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D5F0", Offset = "0x7F1BFF0", VA = "0x187F1D5F0")]
	public static ADLHINHFEDA PDDNGKBCLMK(this ECAMLCIDMLN HPGIDELCODH)
	{
		return default(ADLHINHFEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D340", Offset = "0x7F1BD40", VA = "0x187F1D340")]
	public static ADLHINHFEDA KOBJJNJNLNI([In] this ECAMLCIDMLN HPGIDELCODH)
	{
		return default(ADLHINHFEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0E40", Offset = "0x7E9F840", VA = "0x187EA0E40")]
	public static ADLHINHFEDA LAGLKOPJELI(this ECAMLCIDMLN HPGIDELCODH)
	{
		return default(ADLHINHFEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x7EA0E40", Offset = "0x7E9F840", VA = "0x187EA0E40")]
	public static ViewId HOPHOKJOFLG(this ECAMLCIDMLN HPGIDELCODH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D420", Offset = "0x7F1BE20", VA = "0x187F1D420")]
	public static FixedString64Bytes MDCKFLNGKAH(this IAIEGNHMFLD KHNIMGKFPOO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D0B0", Offset = "0x7F1BAB0", VA = "0x187F1D0B0")]
	public static FixedString64Bytes KKGNPKGOJMA(this ADLHINHFEDA KHNIMGKFPOO)
	{
		return default(FixedString64Bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D390", Offset = "0x7F1BD90", VA = "0x187F1D390")]
	public static FixedString32Bytes MDCKFLNGKAH(this Entity FCFDGFFMMDF)
	{
		return default(FixedString32Bytes);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KPNDKPOBPKN : FDOJONGBPAO
{
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public enum KOAEBDGIIGK
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface LFCAEFGMNDM
{
	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<object> AGCGHJFCGGB;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "2")]
	void AMAMBBJDHDI(object JEMDJIEKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "3")]
	void BEKIOMGBOIM(KDALJMPLLKK CHCCOOMJKLJ, ReadOnlySpan<byte> MGDBGDNLMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	void BAHHMHNBKHD(EEEPFGDDBAA HHCAOFMCNLG, ReadOnlySpan<byte> MGDBGDNLMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface KALBBIDNDHP
{
	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDALJMPLLKK HBJEIDAKFAD(ReadOnlySpan<byte> MGDBGDNLMCM);
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface IDFJAADELKH
{
	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIKNOOIGCJE(KDALJMPLLKK KJNEHANBOBO, ReadOnlySpan<byte> MGDBGDNLMCM);

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFHEGCFLEGG(ReadOnlySpan<KDALJMPLLKK> JFJBPEOFIJL);
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public struct DFHHEEKPHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public KDALJMPLLKK CHCCOOMJKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public ReadOnlyMemory<byte> MGDBGDNLMCM;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public struct KDALJMPLLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public static KDALJMPLLKK LNDEDBIEIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public IAIEGNHMFLD BNJDCEAGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public int GPLBGDNONHG;

	[Cpp2IlInjected.Token(Token = "0x170001ED")]
	public static IAIEGNHMFLD GIODNLAOMOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x7F23080", Offset = "0x7F21A80", VA = "0x187F23080")]
		get
		{
			return default(IAIEGNHMFLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x52685E0", Offset = "0x5266FE0", VA = "0x1852685E0")]
	public KDALJMPLLKK(IAIEGNHMFLD BNJDCEAGAEP, int GPLBGDNONHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x7F23240", Offset = "0x7F21C40", VA = "0x187F23240")]
	public static bool IDFALDDOLDN([In] KDALJMPLLKK LCMCGCNDGLJ, [In] KDALJMPLLKK JAOCPECLJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x7F230D0", Offset = "0x7F21AD0", VA = "0x187F230D0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x7F231E0", Offset = "0x7F21BE0", VA = "0x187F231E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x7F232D0", Offset = "0x7F21CD0", VA = "0x187F232D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x7F23070", Offset = "0x7F21A70", VA = "0x187F23070")]
	public void AJIECABKDHF([Out] IAIEGNHMFLD KKNDHFCJJOK, [Out] int GPLBGDNONHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class MEBOOBEIFJD
{
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public struct HNJMEJAJGPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Guid FNKCCICOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public string DBLNPCOHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector3 JFMEMBGKAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Quaternion NGPACIMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Vector3 JAHHKOMJJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public int IOHMCBLGCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public HFLODILPGJG JKGCHKOAIPN;

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DA70", Offset = "0x7F1C470", VA = "0x187F1DA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public enum JOKLEOFMOAB
{
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	Scene,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	SubgraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	SubgraphRestore,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	RestoreCreationData,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	InventionPreview
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class PJPOHKDMNDE
{
	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x7F281E0", Offset = "0x7F26BE0", VA = "0x187F281E0")]
	public static bool FNLDHLHAGLH(this JOKLEOFMOAB HHCAOFMCNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x7F28210", Offset = "0x7F26C10", VA = "0x187F28210")]
	public static bool NODOGHPIDLD(this JOKLEOFMOAB HHCAOFMCNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x7F28200", Offset = "0x7F26C00", VA = "0x187F28200")]
	public static bool KBBJIKGIDIA(this JOKLEOFMOAB HHCAOFMCNLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[Flags]
public enum IMHNCGPMEBC
{
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	WorldPhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	AdditivePhases = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	RestoreCreationData = 0x2B
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface OGNBHGBADFO
{
	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APFDCBHHFNG([In] Guid AJHCLHGHINB, [Out] Guid GMGNNFDOICN);
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[Flags]
public enum DNKDEDINDEK
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface AMPPJBENADP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170001EE")]
	INIMHOEKCBK FJCCPBANJAF
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString LECCFPDJDFJ();
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum JMHACJLNPND
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
public struct PKGCACCDEGH : ISystemStateComponentData, IComponentData, IEquatable<PKGCACCDEGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public float3 HIJNILBHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public float3 LPFPODMBBOH;

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F28220", Offset = "0x7F26C20", VA = "0x187F28220", Slot = "4")]
	public bool Equals(PKGCACCDEGH NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MJOKOEOMDCJ
{
	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJBMKCADEDP(long DINAHPFAGDC);

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGBPIOBMJON(NativeParallelHashSet<long> PAIFJDDEEJK);

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJGBDGLPPLN(World HAGIBPOACDD, NativeParallelHashMap<Guid, long> DKPEINKAPEC);

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHDHFJEPEFA(ADLHINHFEDA ABAEHPFNLLE);

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CIENFDNDABM(ADLHINHFEDA ABAEHPFNLLE, [Out] Guid HGMKFOENLKG, [Out] long DINAHPFAGDC);

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDPFNFONBAO(ADLHINHFEDA ABAEHPFNLLE, Guid HGMKFOENLKG, long DINAHPFAGDC);

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NBJFMMKNANM(Guid HGMKFOENLKG);

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GOABDKHJPHO(Guid HGMKFOENLKG, [Out] int JDBOGLFONHH, [Out] int CNJMPLLEGFK);

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FOBHCKDGBKL(Guid HGMKFOENLKG, int JDBOGLFONHH, int CNJMPLLEGFK);

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCAAFDHMJHI(Guid HGMKFOENLKG);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public class IBFGABBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IBFGABBDLJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
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
