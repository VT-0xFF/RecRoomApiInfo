using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Attributes;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Service;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel.Interop;
using RecRoom.ObjectModel.Serialization;
using RecRoom.ObjectModel.Systems;
using RecRoom.ObjectModel.Transmission;
using RecRoom.RendererV1;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGWPJOUYUE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
	public SVGWPJOUYUE()
	{
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x844ECE0", Offset = "0x844E0E0", VA = "0x18844ECE0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class AWQOPLEHVPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844CBE0", Offset = "0x844BFE0", VA = "0x18844CBE0")]
		public static void ZIMVGYRUBNI(this Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844CAB0", Offset = "0x844BEB0", VA = "0x18844CAB0")]
		public static void ZIMVGYRUBNI(this Rigidbody a, Vector3 b, Quaternion c, Vector3 d)
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NativeObjectLocalIdArray : IReadOnlyList<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IReadOnlyCollection<ObjectLocalId>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly LNGQTCAXYFX objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x844E3A0", Offset = "0x844D7A0", VA = "0x18844E3A0", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x844E200", Offset = "0x844D600", VA = "0x18844E200", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x50520F0", Offset = "0x50514F0", VA = "0x1850520F0")]
			public Enumerator(LNGQTCAXYFX objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x844E010", Offset = "0x844D410", VA = "0x18844E010", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x844E120", Offset = "0x844D520", VA = "0x18844E120", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x844E290", Offset = "0x844D690", VA = "0x18844E290", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ObjectServiceHandle handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private NativeArray<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x844FAF0", Offset = "0x844EEF0", VA = "0x18844FAF0", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x844FB70", Offset = "0x844EF70", VA = "0x18844FB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int MZPPUDLFUON
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x844F320", Offset = "0x844E720", VA = "0x18844F320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool SBDFDLHCDRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x844F4D0", Offset = "0x844E8D0", VA = "0x18844F4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<LocalId> WHHVJKCIMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2A78BB0", Offset = "0x2A77FB0", VA = "0x182A78BB0")]
			get
			{
				return default(NativeArray<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal NativeArray<Entity> HFCGFMRVHSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x844F5D0", Offset = "0x844E9D0", VA = "0x18844F5D0")]
			get
			{
				return default(NativeArray<Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844F760", Offset = "0x844EB60", VA = "0x18844F760")]
		public NativeObjectLocalIdArray(int capacity, LNGQTCAXYFX objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844FA30", Offset = "0x844EE30", VA = "0x18844FA30")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x844F9C0", Offset = "0x844EDC0", VA = "0x18844F9C0")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<Entity> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844F8C0", Offset = "0x844ECC0", VA = "0x18844F8C0")]
		internal NativeObjectLocalIdArray(LNGQTCAXYFX objects, NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x844F950", Offset = "0x844ED50", VA = "0x18844F950")]
		internal NativeObjectLocalIdArray(LNGQTCAXYFX objects, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x844FA40", Offset = "0x844EE40", VA = "0x18844FA40")]
		public NativeObjectLocalIdArray(LNGQTCAXYFX objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x844F810", Offset = "0x844EC10", VA = "0x18844F810")]
		public NativeObjectLocalIdArray(NativeObjectLocalIdArray existing, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x844F060", Offset = "0x844E460", VA = "0x18844F060")]
		public void CopyTo(List<ObjectLocalId> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x844F580", Offset = "0x844E980", VA = "0x18844F580")]
		public void UAMGCFBLODC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x844EFC0", Offset = "0x844E3C0", VA = "0x18844EFC0")]
		public NativeObjectLocalIdArray Clone(Allocator allocator)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x844F630", Offset = "0x844EA30", VA = "0x18844F630")]
		public Span<ObjectLocalId> ZJMBNJKFXPA()
		{
			return default(Span<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x844F430", Offset = "0x844E830", VA = "0x18844F430")]
		public NativeObjectLocalIdArray OKNVULZUHXT(int a, int b)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x844F2E0", Offset = "0x844E6E0", VA = "0x18844F2E0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x844F370", Offset = "0x844E770", VA = "0x18844F370")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x844F510", Offset = "0x844E910", VA = "0x18844F510", Slot = "6")]
		private IEnumerator<ObjectLocalId> QSOABUHEOWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x844EF50", Offset = "0x844E350", VA = "0x18844EF50", Slot = "7")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class RZPIUINSPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A2CB60", Offset = "0x3A2BF60", VA = "0x183A2CB60")]
		public static RentedArray<a> YTNHWCSMHGW<a>(this NativeObjectLocalIdArray a) where a : UnityEngine.Component
		{
			return default(RentedArray<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NativeObjectLocalIdList : IList<ObjectLocalId>, ICollection<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly LNGQTCAXYFX objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x844E2D0", Offset = "0x844D6D0", VA = "0x18844E2D0", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x844E1B0", Offset = "0x844D5B0", VA = "0x18844E1B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x50520F0", Offset = "0x50514F0", VA = "0x1850520F0")]
			public Enumerator(LNGQTCAXYFX objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x844E050", Offset = "0x844D450", VA = "0x18844E050", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x844E090", Offset = "0x844D490", VA = "0x18844E090", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x844E250", Offset = "0x844D650", VA = "0x18844E250", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly LNGQTCAXYFX objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NativeList<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8450640", Offset = "0x844FA40", VA = "0x188450640", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8450750", Offset = "0x844FB50", VA = "0x188450750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x84502F0", Offset = "0x844F6F0", VA = "0x1884502F0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x84502F0", Offset = "0x844F6F0", VA = "0x1884502F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NativeList<LocalId> WHHVJKCIMON
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
			get
			{
				return default(NativeList<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84505C0", Offset = "0x844F9C0", VA = "0x1884505C0")]
		public NativeObjectLocalIdList(LNGQTCAXYFX objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8450530", Offset = "0x844F930", VA = "0x188450530")]
		public NativeObjectLocalIdList(LNGQTCAXYFX objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x844FC50", Offset = "0x844F050", VA = "0x18844FC50")]
		public NativeObjectLocalIdArray BFCZZPZBIML()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x844FE30", Offset = "0x844F230", VA = "0x18844FE30", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x844FE70", Offset = "0x844F270", VA = "0x18844FE70", Slot = "13")]
		public bool Contains(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x844FEF0", Offset = "0x844F2F0", VA = "0x18844FEF0", Slot = "14")]
		public void CopyTo(ObjectLocalId[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x844FBD0", Offset = "0x844EFD0", VA = "0x18844FBD0", Slot = "11")]
		public void Add(ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8450220", Offset = "0x844F620", VA = "0x188450220", Slot = "7")]
		public void Insert(int index, ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8450470", Offset = "0x844F870", VA = "0x188450470", Slot = "15")]
		public bool Remove(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84501A0", Offset = "0x844F5A0", VA = "0x1884501A0", Slot = "6")]
		public int IndexOf(ObjectLocalId item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8450420", Offset = "0x844F820", VA = "0x188450420", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84500D0", Offset = "0x844F4D0", VA = "0x1884500D0", Slot = "18")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8450110", Offset = "0x844F510", VA = "0x188450110")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8450340", Offset = "0x844F740", VA = "0x188450340", Slot = "16")]
		private IEnumerator<ObjectLocalId> QSOABUHEOWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x844FD50", Offset = "0x844F150", VA = "0x18844FD50", Slot = "17")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface PIZSXRPSMYA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ObjectLocalId GIHNQFFXBSD(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface TYMPXLKYSRN : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TGANNJJYHFZ : NTIQFDTHHUR, CVPPYAMBGRC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		XFAXRWZYYDX FUAPKEZRLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		ObjectServiceHandle OPKUEZDEOEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface CVPPYAMBGRC
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool AFDDQPQJFSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JFFMJQDLAWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TYJRYOEPRYH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface SIZMJEXGOQQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool MGQTVBCAECS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool ACALCZXWBPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool FFKWYGNTHPK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool BVSWQUBVXPV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool DPMPSMVRZAY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ONZQHQFWBXV(ByteString a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void VODCVORXYIQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GOMKIGGGEKL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		SAMXOKXXSFT FUAPKEZRLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		WWAUIXBAGZF WBAXDAZKXYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ZERWNOTTOVS LKKUHZDSDNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TGANNJJYHFZ VOSGMAOKRIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		RKFUIJSWYLU VCUQPJSZFWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		SIZMJEXGOQQ ZPXTDEGHNUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		MPMUIZRKMRK BMHHPXUSFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		PPOJYMYMBDY KBXRPYYCOUV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		PWUPVFQBAGE HIINVYAVMUF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		GYGFXJBKLMH KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		KSDPPWMWOYZ YJOOHTDJDLY
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		LSQSDFJISSL BXHBDXAOVGK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		ZDFDFJCUSTD RMLTWACOSBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		LOCSQWGPZIX EVHFTAVGGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		KDKEUALAXZV GBYBXFQOIVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		UKAHPGQWKTI GXWHYMIQEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		TGMRTUQFOJR ZNDAXODIMVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		ZSFTDSWKISY PVCKHWIYOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		YTULLSVUPOS BHRBTHZTNZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		GQERUNFMZGW RQTTCUCVWSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		HYBBZABLQFR UNMKCCYYROR
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		MFCMLTFJRWM XGTIZAVXOYY
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		FPSLQYSQYMA QCGTJPZFYFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		LKIUSZVOLVR FNXMWDPLFBG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		OELRROPTMWT PKHUGXHYWVB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		EGEDLXCDTXG BXLLFFUFSRN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		GFLRQANDFVQ GKRWRCUWZGP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		GAMMXNOZWXY NPGYJCADMFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		OPCHQLYRCDD PXJLCYUMQZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		HYXBHRXVTRO OFYSNHJVWYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		LGFWOCXQZYC WPFNJXTJEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		KYVDUWZOVKY YMQFLCZNWGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		LQPODEPWEIZ BGHYZPKXLFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		NYHEUDSDETG LKBPBXNRNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		BCPOFSWQQOV JMLUKLAXIUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		OAMPTGKUKZW ZQAGANWJMQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		YUPBBDTSNSP GLNZVRYNOMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		RIJCQQICXBM FVRPJSDEZIV
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		OGNQEMRTGWZ CDWNZPCJGCO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DebuggerTypeProxy(typeof(UOGLUPVJYKV))]
	[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
	public readonly struct ObjectLocalId : IComparable<ObjectLocalId>, IEquatable<ObjectLocalId>
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly ObjectLocalId Invalid;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int ObjectHandleBits = 8;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int ObjectHandleOffset = 24;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int ObjectHandleMask = -16777216;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const int VersionMask = 16777215;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly LocalId localId;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8451560", Offset = "0x8450960", VA = "0x188451560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TGANNJJYHFZ VOSGMAOKRIO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8451880", Offset = "0x8450C80", VA = "0x188451880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public LocalId OMIHZQJGQLC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x84515F0", Offset = "0x84509F0", VA = "0x1884515F0")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal ObjectServiceHandle OPKUEZDEOEY
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8451930", Offset = "0x8450D30", VA = "0x188451930")]
			get
			{
				return default(ObjectServiceHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool RXVKYWZTPWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8451630", Offset = "0x8450A30", VA = "0x188451630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool MEYSCNDYWCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x84518E0", Offset = "0x8450CE0", VA = "0x1884518E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8451A80", Offset = "0x8450E80", VA = "0x188451A80")]
		public ObjectLocalId(LNGQTCAXYFX objectSystem, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8451B40", Offset = "0x8450F40", VA = "0x188451B40")]
		public ObjectLocalId(ObjectServiceHandle handle, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
		public RRObject SAYSTVCJCYR()
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8451BD0", Offset = "0x8450FD0", VA = "0x188451BD0")]
		public static implicit operator LocalId(ObjectLocalId objId)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8451C10", Offset = "0x8451010", VA = "0x188451C10")]
		public static implicit operator Entity(ObjectLocalId objId)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8451960", Offset = "0x8450D60", VA = "0x188451960")]
		public static bool ZWISVWGZSLY(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8451940", Offset = "0x8450D40", VA = "0x188451940")]
		public static bool ZPGHGHNXRJT(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8451750", Offset = "0x8450B50", VA = "0x188451750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84513D0", Offset = "0x84507D0", VA = "0x1884513D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84512D0", Offset = "0x84506D0", VA = "0x1884512D0", Slot = "4")]
		public int CompareTo(ObjectLocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "5")]
		public bool Equals(ObjectLocalId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class XKWHLTWHAUT
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8466250", Offset = "0x8465650", VA = "0x188466250")]
		public static ObjectNetworkId PYVEBZUXNIZ(this ObjectLocalId a)
		{
			return default(ObjectNetworkId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class UOGLUPVJYKV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct ObjectServiceHandle : IEquatable<ObjectServiceHandle>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly byte handle;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static byte[] handles;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static LNGQTCAXYFX defaultObjectService;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static TGANNJJYHFZ defaultObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static LNGQTCAXYFX[] objectServices;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static TGANNJJYHFZ[] objectModels;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static Stack<byte> freeHandles;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public TGANNJJYHFZ VOSGMAOKRIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8452460", Offset = "0x8451860", VA = "0x188452460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public LNGQTCAXYFX QZGQNZDVVLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8451E30", Offset = "0x8451230", VA = "0x188451E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8452A90", Offset = "0x8451E90", VA = "0x188452A90")]
		static ObjectServiceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2AC7A40", Offset = "0x2AC6E40", VA = "0x182AC7A40")]
		internal ObjectServiceHandle(byte value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72C4D40", Offset = "0x72C4140", VA = "0x1872C4D40", Slot = "4")]
		public bool Equals(ObjectServiceHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8451CF0", Offset = "0x84510F0", VA = "0x188451CF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xDAF5E0", Offset = "0xDAE9E0", VA = "0x180DAF5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84523B0", Offset = "0x84517B0", VA = "0x1884523B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8452070", Offset = "0x8451470", VA = "0x188452070")]
		private static LNGQTCAXYFX QNVFILJQIXK(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8451C50", Offset = "0x8451050", VA = "0x188451C50")]
		private static TGANNJJYHFZ BWWMHUHPMHI(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8451F10", Offset = "0x8451310", VA = "0x188451F10")]
		private static object NIRYCXGYBEY(byte a, object[] b, object c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8451E20", Offset = "0x8451220", VA = "0x188451E20")]
		private static int MBCXYFGRZEC(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8451E10", Offset = "0x8451210", VA = "0x188451E10")]
		private static int KLGACHUARFY(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8451D90", Offset = "0x8451190", VA = "0x188451D90")]
		private static (int, int) KDWJSDPKUEM(byte a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8452A80", Offset = "0x8451E80", VA = "0x188452A80")]
		private static byte YJFCFSZBEZT(int a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8452110", Offset = "0x8451510", VA = "0x188452110")]
		internal static ObjectServiceHandle SHWXSEAJSCT(TGANNJJYHFZ a, LNGQTCAXYFX b)
		{
			return default(ObjectServiceHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8452540", Offset = "0x8451940", VA = "0x188452540")]
		internal static void WUGNLHLOTAM(ObjectServiceHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8452730", Offset = "0x8451B30", VA = "0x188452730")]
		private static void YBAYZAYANXO(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum LoadType
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SubGraph,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		SceneMainInitial,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SceneMainJoining,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		SceneAdditive
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface BNRFLSBIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool VUSFVQWSQCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool ZLPJQWFCKRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool LYBCQUTALFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool GZDPOEGOWPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool NDZJOVBJDAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface XIARYWSIZGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SRLGFTAZMBP(UHLKWOJOMTO a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FFATGAIALAU(UHLKWOJOMTO a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KMNGBLNPZRT(ZHIEIBQGXOU a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface CWRSZMKRJCX : UHLKWOJOMTO, BNRFLSBIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		int VYYPFRYCRTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AVKWJHITIWT(KHEHKJYIUTK a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface UHLKWOJOMTO : BNRFLSBIDLH
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum PhysicsMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Environment = 0,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Decoration = 1,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Physical_Sticky = 2,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Physical = 4
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool BFDKXFRXYIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool SDGPHIYBGIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool TPPURVVIVWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface KHEHKJYIUTK
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool XLCDACWGVEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		PrimitiveShapeType OWTUQSPIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		DBAUGONVEBA HOLBAIOCPET
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		float3 UFCVMLCAYHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		quaternion GYPOFJPFDYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		float3 UATJXLHWCDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		RenderableMaterial UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RenderableColor BBHCWBJOSMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		float EKHQRFFSRUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		float3 TTFAGNXCRSS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		float LJSREPGEVAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ShapeConfigFlags DTVUNCVEUXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface JVGYHGFBMRC
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		float3 UJNTDLPNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		float3 YQVISJLTEUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		quaternion QVHOWIPVPVN(float3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface DBAUGONVEBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool EANEFJMKNWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool UHNAMKBCMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool XNTUQAFWQVE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		float LAGVNPNOJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		int EDDXXOUUNTX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		int JPQHAUYQHML
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HZVYVUVKYEU(JVGYHGFBMRC a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public class HMVJFTTNPDY
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public HMVJFTTNPDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VOBCPCIWZFJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Guid BGIPDSVJTLX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task HEBNXFOJBWD(Guid a, Guid b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task NQWPMUCYUMA(Guid a, Guid[] b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid HOXWPNUSVAD(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task QJGRTHMCGVV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RZKGVOLFZQG(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JYGFKUKAXJI(GXAZSOSBKTW a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ACDRMIXCDLB(Guid a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RRKGIAWPPHY(Guid a, ObjectNetworkId b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LERAJBCEGLK(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RKQWWGINCTY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JZARGVCAEZK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BEYMRAMYRXW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "0")]
		void HMMPMMIUZAF(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WWAUIXBAGZF
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		BEYMRAMYRXW ZGWSBTNQKQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		VNRREVWPPGH DCCBIURSKZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		VNHJALYGBZM NWTWXUSSHEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		RSXDWLLMJWU OYDAMVSVEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		RUOFXNRWHDG RWYMDCIZKLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		BGTKYRLSDUP AYVZGFTQKUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		YOAZKJMMLTP FZAYWZSPZGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		SMEIIDMRXNQ PHYQSUFGHKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VNRREVWPPGH
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		string AGSMLJSDODA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QGOPZDBPRQE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NPEPJXVLVEU(Action a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NTEFWRRIVCJ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int TWSMHBFUZCL(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DZQJKEBQRXX([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BKCHHRWMKDK([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LZUVZQWJMXW([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZPZPPLBPAPB([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VNHJALYGBZM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "0")]
		void EZFYCAYPHJZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RSXDWLLMJWU
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		protected static readonly Guid CSQJXLGWEED;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		static readonly Guid UVFNGIQIZVU;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		static readonly Guid TJUKSHNFCBY;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		static readonly Guid ZUALRRVPMQW;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		bool HQAWLXJNKSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool EYTIUNROYUT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		bool TRJISYKRLNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool OYMNNAIGUFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8465150", Offset = "0x8464550", VA = "0x188465150", Slot = "4")]
		string[] MNCEXQWRJZW(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XKFBKQBEFOW();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x84651F0", Offset = "0x84645F0", VA = "0x1884651F0", Slot = "6")]
		Guid SDLNCRIMIDJ(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int EVEMMFWRSJB(SerializedDataWrapper a);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SYBNPDTOCET(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int CBLMSXPZNZL(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PPWDKCSDYCO(string a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		string SOWVLOIUYCX(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool QEFIYPUINHS(RRObjectPrefabData a, [Out] LocalId b);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RentedArray<byte[]> PNFQBIBINDH(NativeArray<ViewDescriptor> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YKPQEWQMPAS(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GameObject RFQXBKNUMBO(string a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void KXXDEELJHFT(Transform a, RRObjectPrefabData b, MRSPDLXDOCP c);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool FQGUMAEVKAG(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ZCXEAQVWKZS(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "19")]
		void PFQXQBIJHBF(SerializedDataWrapper a, NativeArray<int> b, PATPBQUPMIT<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void GWELIKKNPTH();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "21")]
		void EHVQMXZUSHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "22")]
		void UAMVYVOEJXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "23")]
		bool RSMUPLMNGKQ(SerializedDataWrapper a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "24")]
		XIARYWSIZGM IQFPYFSRZIQ(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "25")]
		void OSJGOHEPQDE(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "26")]
		bool JLRJXVHBWIC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8465220", Offset = "0x8464620", VA = "0x188465220")]
		static RSXDWLLMJWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ALJRLASKYHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		long BUNLBGPYXQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		long RWBCWODYTBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "1")]
			get
			{
				return default(long);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RUOFXNRWHDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool ZZIASLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		int ISIEBJWXULE
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		int BMLDBTQEMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		int BGTIJWDZDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		bool PJSNFYLDWON
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		int YRRIJSHTVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		void IKZXSUMTVSP(HDUADJJBHEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		void DXTLQZULZMH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "8")]
		bool FQUTPFAVFJB(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
		void UGYUGOVCWIR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "10")]
		void RIADYDXZKVA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void RWFENJJZUCV(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void UFBNPXJMNYS(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "13")]
		void CLKTUBRHXCE(NativeArray<ViewId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "14")]
		void UOTQARQWPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "15")]
		void JCJYTUOQYIK(OutOfBandMessageType a, ReadOnlySpan<byte> b, PlayerId c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "16")]
		void JCJYTUOQYIK(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "17")]
		void JCJYTUOQYIK(OutOfBandMessageType a, ReadOnlySpan<byte> b, ReadOnlySpan<byte> c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "18")]
		void ETIQSRANSOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "19")]
		void YEAAFNPMANA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "20")]
		void QHPBLBBKQTB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "21")]
		void YYEDYFHKIMK(Dictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "22")]
		void SMCTXYMENYN(NativeList<ObjectNetworkId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "24")]
		void NYKGBRJTWBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "25")]
		void VEVYLWJEIPI(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "26")]
		void BZXONOCAKBA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "27")]
		void AMCPPCNPMSH(PlayerId a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "28")]
		void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "29")]
		void NWINLDNKCAN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class TCMENOAZMGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84657C0", Offset = "0x8464BC0", VA = "0x1884657C0")]
		public static NetworkPauseScope JNGPUMXSNWK(this RUOFXNRWHDG a, object b)
		{
			return default(NetworkPauseScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct NetworkPauseScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RUOFXNRWHDG dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object token;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8450850", Offset = "0x844FC50", VA = "0x188450850")]
		public NetworkPauseScope(RUOFXNRWHDG dependencies, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8450800", Offset = "0x844FC00", VA = "0x188450800", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NMZRZQMVPTV
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate void ApplyNetworkTransform(ViewId viewId, NetworkTransformSyncData syncData, int sender);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "0")]
		void Pause(ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "1")]
		void HFNANUUUTWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "2")]
		void IYGUJCWTARK(WYHSPCAVTMD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DHJSATYTUNM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface IZVFEARWWXC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GJIKWLOQOUG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BGTKYRLSDUP
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct LoadScreenScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private BGTKYRLSDUP notifications;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x844EBD0", Offset = "0x844DFD0", VA = "0x18844EBD0")]
			public LoadScreenScope(BGTKYRLSDUP notifications, string title, string subtitle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x844EB70", Offset = "0x844DF70", VA = "0x18844EB70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct FadeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private BGTKYRLSDUP notifications;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Task task;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x844E470", Offset = "0x844D870", VA = "0x18844E470", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "0")]
		void ZUVXPDFINUD(string a, float b = 5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "1")]
		void HBMFUWKFFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FMFNPDPDEPO(bool a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "3")]
		void SAKQSTHRICL(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class GMYPYXZWJRX
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x844E4C0", Offset = "0x844D8C0", VA = "0x18844E4C0")]
		public static BGTKYRLSDUP.LoadScreenScope OCXHVLFQLGO(this BGTKYRLSDUP a, string b, string c)
		{
			return default(BGTKYRLSDUP.LoadScreenScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ServiceLifetime(Lifetime.Application)]
	public interface AUMKRHSSHTR
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int SWAHLSGCKCJ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XYROOKVGDJY(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KIUHWJBOFDR(int a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		object VGRZRIOFFWB(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DZDNQITAYNS(GameObject a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QVAWRRKZJGO
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		HPKCKZYQHUV LHEKLMKECYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SLQKGPCLNXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BYPGDRMALMN(NetworkCreatorId a, RolePermission b);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EEDZMGBOAYT(PlayerId a, AccountRoleTypeNetworked b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PPJZBONXMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CQVTSUWTJSM(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object Deserialize(NativeArray<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BMHTOHARKWT
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool ATOWQOXXJUU
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Delegate PPQYYXOXXDW(VITLXRLATFK a, Action<VITLXRLATFK> b);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DBBEZLWXLVH(VITLXRLATFK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Delegate QXYFVLBPZFX(VITLXRLATFK a, Action<VITLXRLATFK> b);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DZGEXOVWTYJ(VITLXRLATFK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KGYJMXFIELE(VITLXRLATFK a);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		VITLXRLATFK AMDKNLJLAWQ(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BGVXMUJRESR
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		int TOJXJOPNKPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		int TVZKWIROTQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool TLORZRNCMKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool HJBSWTSEJXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId ZPQWDYEUPZT(int a);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PUIAFGDNAKB(GameObject a, JobHandle b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface HPKCKZYQHUV
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZTUOGOFHYPL(AccountRoleTypeNetworked a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YOAZKJMMLTP
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool MGQTVBCAECS
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface OHDUGSVEQRB
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		PDKFUQTKNFO VYOUMBVVRLB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		IHTOZJMDENQ VZPWNSLVLBP
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool XPRURPIGPPV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XHKLUGOWSCF(Transform a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VFIRVWGRSIR(Transform a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LTSRTABVXAV(Transform a, OutlineEffectType b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SMEIIDMRXNQ
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ESJZFBXGWXI;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MCRIPSHRHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OBNCRJIOHRK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WHCLBEQEYOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AKEXQAPFRLT(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DGJMGJPTUXK(ObjectLocalId a, bool b, float3 c, quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GOVWNUNUADD(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GBKYTVSTUBV(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BSASGTCIQLV(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JBCTQWCWFTW(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PVTJGHIHHUB(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LVERHDGGHVZ(PJZRIAFFLPE a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LADAFBUSOXC(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UJBIEBILJKB(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void FZLYLAOPAUN(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct NativeArrayPinnedMemory : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly NativeArray<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly GCHandle handle;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x844EEA0", Offset = "0x844E2A0", VA = "0x18844EEA0")]
		public NativeArrayPinnedMemory(ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x844EE70", Offset = "0x844E270", VA = "0x18844EE70", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum SerializedAssetVersion
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		V0PreObjectModel = 0,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		V1ObjectModelHierarchy = 1,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		V2ObjectModelHierarchy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		V3Entities050 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		V4Entities050Compressed = 4,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		V5BumpObjectModelVersionMay2024 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		V6Entities100 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		OldestCompatibleVersion = 3,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LatestVersion = 6
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct SerializedDataWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ByteString serializedOMData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public object persistenceViewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public object connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IEnumerable<string> legacyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public bool isLatestDeprecatedVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public FENBCGLKXBE.EditReadyPreference? loadEditReadyPreference;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8465740", Offset = "0x8464B40", VA = "0x188465740")]
		public SerializedDataWrapper(ByteString serializedOMData, [Optional] object persistenceViewData, [Optional] object connectableGraphData, [Optional] IEnumerable<string> legacyTags, bool isLatestDeprecatedVersion = true, [Optional] FENBCGLKXBE.EditReadyPreference? loadEditReadyPreference)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct SerializedObjectModelData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public object objectModelData;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct ViewDescriptor
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[Flags]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			IsInvalid = 1,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			IsStudioPrefab = 2,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			IsBetaOnly = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			IsDevOnly = 8,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			IsR1Only = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			IsR1Upgrade = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			IsAllowedDevOnly = 0x40
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public RRObjectPrefabData prefabData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Guid persistenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid costumeKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid objectBoardGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid circuitParentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Flags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Color32 colorOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int spawnableToolType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GameTeam teamOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int entityIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int transformIndex;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Guid HLVCHUZMEYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x52EDEC0", Offset = "0x52ED2C0", VA = "0x1852EDEC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool OQTMVXSOCRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8466230", Offset = "0x8465630", VA = "0x188466230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool THTLFSJZMAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8466220", Offset = "0x8465620", VA = "0x188466220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool EZRSGIZVSIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8466210", Offset = "0x8465610", VA = "0x188466210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool HWFXRIJZLZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8466240", Offset = "0x8465640", VA = "0x188466240")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public readonly struct HistoryAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal readonly HistoryMarker start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal readonly HistoryMarker end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x844E750", Offset = "0x844DB50", VA = "0x18844E750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8465340", Offset = "0x8464740", VA = "0x188465340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8465340", Offset = "0x8464740", VA = "0x188465340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct GotoMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		internal readonly bool isAtStart;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x844E690", Offset = "0x844DA90", VA = "0x18844E690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct HistoryMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal int offset;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x844E9A0", Offset = "0x844DDA0", VA = "0x18844E9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GAQATEAEXQA
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		MQAJXTMNVHT KJPPRXDQMSO
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface GXAZSOSBKTW
	{
		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface LMZWGGRXMXI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class DFLJAORQSWK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x35001F0", Offset = "0x34FF5F0", VA = "0x1835001F0")]
		public static RRObject SAYSTVCJCYR<a>(this a a) where a : GXAZSOSBKTW
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x844D910", Offset = "0x844CD10", VA = "0x18844D910")]
		public static MonoBehaviour VLMPHAFJHLW(this GXAZSOSBKTW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x844D850", Offset = "0x844CC50", VA = "0x18844D850")]
		public static GameObject GameObject(this GXAZSOSBKTW localId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface DWAVBKAXUDH : GXAZSOSBKTW
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectLocalId objectId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface EKGOFHFTDPT : GXAZSOSBKTW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface HRYRTUYFKQN
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ParentsChangedCallback(ObjectIdBulkPropertyChangeData changeData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event ParentsChangedCallback COCRUOZESBT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface RQHGQUEDODL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface GWTKCITJUUU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface BOQSKSJCOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Transform GetTransform();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Collider GetCollider();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MoveToObject(ObjectLocalId newObject);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NotifyIsUniform(bool isUniform);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DestroyCollider();

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FGMCEMJHGHK(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface LAXRYYYHDDO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRootRBEXChanged(JHZEISLHDPT newRootWithUnityRigidbody);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface JHZEISLHDPT
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		GameObject GKSYCCOGFTR
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		Transform WJCWXTHIKWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		MWIJDBIDZDF QIOEUPCARMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool HNEGECRYVAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ONRBYKLEUCI(MWIJDBIDZDF a);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RigidbodyExData GetData();
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class OIGVKICHQWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84508E0", Offset = "0x844FCE0", VA = "0x1884508E0")]
		public static void OZFKVEOCDXU(this JHZEISLHDPT a, MRSPDLXDOCP b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface MWIJDBIDZDF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		Rigidbody QNEZXRYKHXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		JHZEISLHDPT UONFEXDYHIU
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		GameObject QYWBNTWUNOD
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		Transform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		MWIJDBIDZDF YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		MWIJDBIDZDF JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		int INVHDCFVKSP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		bool WPVPLREWLPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		VDZYKGMLTUT LRBGTFZTHLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		HBNPYSELDYW DCDYMVMWUSH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		float LTQZYTALBDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "36")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		Vector3 CKYWBPNGQUK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "38")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Vector3 XZFWVRVTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		Vector3 GJPNWNLMIRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "42")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		Vector3 DAIFPKLWRXR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "44")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		bool EHODYOLUUXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool XEUKYMICXNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "46")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool KMTALXYSSXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool PCFNUGIDUMT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		Vector3 DJBEWVCRZBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		Vector3 IGAFVSWPCWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Vector3 JVLPJAUZBDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Vector3 TFTMCTTECYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		float LTXYVPLQEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		float NEBHKMAZSPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "56")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		Vector3 CUBUQBRLKCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		Quaternion FYCJLHUPUKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		float JGTAUWLZKXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "61")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		float TOZQNNTDPRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "63")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool DSJHKGQLUHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "65")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		TransformTrackRate CGDXYLOQKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "67")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		bool EJXMOZGYWKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		Transform JWILKKTGZHX
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		Vector3 FBGWFBKYUIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(Slot = "71")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		float JFNFNHALNOT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "73")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		float BCICBUXIYNK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "74")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "75")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		Quaternion HMGAGMHXMLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "77")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		Vector3 UJNTDLPNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "79")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Quaternion ILSUHOUFHJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "81")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		RigidbodyConstraints UXRQCXKMIBY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "83")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		bool QQWMQEWJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "85")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		CollisionDetectionMode BUQBOMKWSUW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(Slot = "87")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool BPNQFULQQVO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RbexAction UFVABTNCHJA;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RbexAction YQSIFTORTNS;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RbexAction HKMLKUBCHGJ;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RbexAction IFTUUWQQREU;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RbexAction ZUXTCXUQVIJ;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RbexAction TANAEAFQUZO;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event RbexAction MGDQBBFJNPN;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexParentChangeAction SPYZLHERCQK;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UpdateLOD, UpdateLOD> LDZEKXBNUKW;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		MWIJDBIDZDF HNEJLTSOARG(int a);

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void YCRIHYGOZAF((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "89")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "90")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "91")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void OnDestroy();

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void SetParent(MWIJDBIDZDF value, bool isPhysicallyDetachedOnly = false);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void ZGJQLXZMOVN(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void ITULSOQBLLE(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "97")]
		Vector3 LRMLHJIINQB(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "98")]
		Vector3 CIFCKWXAXST(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void BWEFLGWTBXW();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void WLDDRETZDIV();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void PJOXMHGLFQY();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void GDHMYKPNYFK(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "103")]
		void NZKWHSCZSZD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "104")]
		void XGBEWNLQOLC(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "105")]
		void WEPRVJNKZCW(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "106")]
		void LNZOYVKXZHZ(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "107")]
		void ZKWBPDUCICU(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "108")]
		Vector3 CNBKTKVKPYZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "109")]
		Vector3 APWNQULCBXF(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "110")]
		void PJXPHYOMJLG();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "111")]
		void VYVVXZRESCG(MWIJDBIDZDF a, object b);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "112")]
		void VYBHMIWWNMX(object a);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "113")]
		void WZAGCFBATJV();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "114")]
		void XTSXEAXJHCY();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "115")]
		void YCMGNIZKGPX();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "116")]
		bool OSBUHOXNNLB();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "117")]
		void PHZGPXDVXYP();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "118")]
		void CRCHUBDAKHQ(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "119")]
		void ELXGXTJKQMP(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "120")]
		void HOSPLPTERRN(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "121")]
		void ULPNALVLYND(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "122")]
		void MKOKGCUYAUJ(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "123")]
		bool WQBQWIFTSHK(float a);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "124")]
		void DVMWDVAGVIJ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "125")]
		void AMKMFYSJONU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "126")]
		void LBTTOIQEHMV(object a);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "127")]
		void UQNEFILOZIE(object a);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "128")]
		void OJHCZMNXWZS(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "129")]
		void MFHPWYYEDLU(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "130")]
		void QONTKXGZROT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "131")]
		void IUILABLYMAT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "132")]
		bool GODKAIEGKGG(Vector3 a, [Out] RaycastHit b, float c);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "133")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface HBNPYSELDYW
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class YKDRBFNYZEF : HBNPYSELDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YKDRBFNYZEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "0")]
		void VENPBXHZRGT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "1")]
		void VSCRGWTSTSW(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "2")]
		void ZSDDIWCBJWK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "3")]
		void ZZPFWKRZNCR(Vector3 a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface VDZYKGMLTUT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 IFNKZXAPWLB();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 KJDVCHEIFHQ();

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DNXMWLUWZHX(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void RbexAction(JHZEISLHDPT thisRigidbodyEx);
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum RbexCallbackType
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ChildAdded,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ChildRemoved,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ParentChanged,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		HierarchyMassUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		SleepChanged,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		DistanceBandChanged,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		IsKinematicChanged,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Discontinuity,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Destroyed,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum RbexImpulseType
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Reflective,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		FullOverride
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void RbexParentChangeAction(JHZEISLHDPT thisRigidbodyEx, bool isPhysicallyDetachedOnly = false);
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum RbexRotationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Reflective
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct RigidbodyExData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public object photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Vector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool hasPrecomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool hasCustomCenterOfMass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct RRObject : IEquatable<RRObject>
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly RRObject Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public GameObject GKSYCCOGFTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x8463200", Offset = "0x8462600", VA = "0x188463200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ObjectNetworkId ZALRNYYMMJX
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x84637F0", Offset = "0x8462BF0", VA = "0x1884637F0")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public ObjectType QCKBAQUQRYB
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x8463D10", Offset = "0x8463110", VA = "0x188463D10")]
			get
			{
				return default(ObjectType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public RRObjectPrefabData JZJNTNVKONC
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x84630D0", Offset = "0x84624D0", VA = "0x1884630D0")]
			get
			{
				return default(RRObjectPrefabData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool SBAMZMZPFRV
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x8463F30", Offset = "0x8463330", VA = "0x188463F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool MKJRKOGADOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x8463DB0", Offset = "0x84631B0", VA = "0x188463DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool XLCDACWGVEX
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8463A50", Offset = "0x8462E50", VA = "0x188463A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool LWZSMSIQIWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x8464180", Offset = "0x8463580", VA = "0x188464180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool SHGNEPXFCKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8464160", Offset = "0x8463560", VA = "0x188464160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool WFTDEEFPLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x84639F0", Offset = "0x8462DF0", VA = "0x1884639F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool NLHKCTMFYQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8463EF0", Offset = "0x84632F0", VA = "0x188463EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool NRJNYYYTNZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8463A70", Offset = "0x8462E70", VA = "0x188463A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool FEZRAIFCEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x8463B00", Offset = "0x8462F00", VA = "0x188463B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool WDDKNNLVZKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x8463CD0", Offset = "0x84630D0", VA = "0x188463CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool GKATJCOVXEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x8463E10", Offset = "0x8463210", VA = "0x188463E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool CXWNQADOXPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x8463C40", Offset = "0x8463040", VA = "0x188463C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool XQBCLZQXRFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x84637B0", Offset = "0x8462BB0", VA = "0x1884637B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool MXDXXVQLATS
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x84639B0", Offset = "0x8462DB0", VA = "0x1884639B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool TOSNSEXWGLU
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x8463C00", Offset = "0x8463000", VA = "0x188463C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool BFMXAKZLGQT
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8463DD0", Offset = "0x84631D0", VA = "0x188463DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool JKMHGYIWWAG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x8463BC0", Offset = "0x8462FC0", VA = "0x188463BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public RRObjectCircuitBoard OEBKMFOBZXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectCircuitBoard);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public RRObjectIdentity CVYDPLSSLYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectIdentity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RRObjectPhysics RMLTWACOSBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectPhysics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public RRObjectPlayerInteraction IOJZTTRZLEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectPlayerInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RRObjectPolicy THRHACLMJRS
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectPolicy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public RRObjectReferenceGroup XKVULJMFVRM
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectReferenceGroup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public RRObjectRenderEffects BYXJSWDCIAE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectRenderEffects);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public RRObjectReplicatedObject QAZMODHSXTK
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectReplicatedObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public RRObjectReplicator FRFIWXJDKDN
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectReplicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public RRObjectScope EVHFTAVGGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectScope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public RRObjectToolCleanup YEWVMYPVAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectToolCleanup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public RRObjectUserTags BHBGGPRIAUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectUserTags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public RRObjectAIMetadata FNZZYJUFOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectAIMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RRObjectDeformable FSPXCSSOIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectDeformable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public RRObjectObjectInteractionFilter DRQTLIVUBQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectObjectInteractionFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool AUJINBPXPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x84636C0", Offset = "0x8462AC0", VA = "0x1884636C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool MJEYXZHHPIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x8463890", Offset = "0x8462C90", VA = "0x188463890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool LFMEDZPJNXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x84638D0", Offset = "0x8462CD0", VA = "0x1884638D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool RXVKYWZTPWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8463F50", Offset = "0x8463350", VA = "0x188463F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool RTGIHQNCSAS
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x84633D0", Offset = "0x84627D0", VA = "0x1884633D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool TIDIZJAVGMT
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8464120", Offset = "0x8463520", VA = "0x188464120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool UIJNLPEBEEK
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8463390", Offset = "0x8462790", VA = "0x188463390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public RRObjectTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RRObjectHierarchy KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x8451560", Offset = "0x8450960", VA = "0x188451560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator RRObject(ObjectLocalId objectId)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8463540", Offset = "0x8462940", VA = "0x188463540")]
		public RRObjectContainer FAMEECNTPKB()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8463A20", Offset = "0x8462E20", VA = "0x188463A20")]
		public RRObjectShape HZDXBWOKWUH()
		{
			return default(RRObjectShape);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8463EA0", Offset = "0x84632A0", VA = "0x188463EA0")]
		public RRObjectConnectable SFOLZKVTDKY()
		{
			return default(RRObjectConnectable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8463B90", Offset = "0x8462F90", VA = "0x188463B90")]
		public RRObjectPlayer MODEXZOTBAX()
		{
			return default(RRObjectPlayer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8463B40", Offset = "0x8462F40", VA = "0x188463B40")]
		public RRObjectPlayerInteractionFilter LTEEOETMRNO()
		{
			return default(RRObjectPlayerInteractionFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84640D0", Offset = "0x84634D0", VA = "0x1884640D0")]
		public RRObjectStudioObject WNNZUJNTNTV()
		{
			return default(RRObjectStudioObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8463E50", Offset = "0x8463250", VA = "0x188463E50")]
		public RRObjectElementSnapPoint QTXPLINNRNC()
		{
			return default(RRObjectElementSnapPoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8463AB0", Offset = "0x8462EB0", VA = "0x188463AB0")]
		public RRObjectElement JXSDQDQGUYC()
		{
			return default(RRObjectElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8463C80", Offset = "0x8463080", VA = "0x188463C80")]
		public RRObjectTerrain OMSFLLBEHPZ()
		{
			return default(RRObjectTerrain);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x84635C0", Offset = "0x84629C0", VA = "0x1884635C0")]
		public void FAYQYGDGJEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8463410", Offset = "0x8462810", VA = "0x188463410")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x84641A0", Offset = "0x84635A0", VA = "0x1884641A0")]
		public void ZYOGEARWKUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8463910", Offset = "0x8462D10", VA = "0x188463910")]
		public bool HFXYUQNFGFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8463F60", Offset = "0x8463360", VA = "0x188463F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObject value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ObjectLocalId(RRObject value)
		{
			return default(ObjectLocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8456000", Offset = "0x8455400", VA = "0x188456000")]
		public static bool ZWISVWGZSLY(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8451940", Offset = "0x8450D40", VA = "0x188451940")]
		public static bool ZPGHGHNXRJT(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x84634B0", Offset = "0x84628B0", VA = "0x1884634B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObject other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct RRObjectAIMetadata : IEquatable<RRObjectAIMetadata>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private LQPODEPWEIZ QZKMNWCVINF
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x8453360", Offset = "0x8452760", VA = "0x188453360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x84534C0", Offset = "0x84528C0", VA = "0x1884534C0")]
		public void PQWQXZQSOAT(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8453050", Offset = "0x8452450", VA = "0x188453050")]
		public bool DNJLGROEMQW([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x84533C0", Offset = "0x84527C0", VA = "0x1884533C0")]
		public bool OTSMZCAANWU([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8452EB0", Offset = "0x84522B0", VA = "0x188452EB0")]
		public void AAECQRAPBUW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x84535F0", Offset = "0x84529F0", VA = "0x1884535F0")]
		[CanBeNull]
		public string UKBHYNMJXXU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x84531E0", Offset = "0x84525E0", VA = "0x1884531E0")]
		public bool HYIXFKFOJFL([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8452FA0", Offset = "0x84523A0", VA = "0x188452FA0")]
		public void APXUTQRUTYS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectAIMetadata(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8453150", Offset = "0x8452550", VA = "0x188453150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectAIMetadata other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct RRObjectCircuitBoard : IEquatable<RRObjectCircuitBoard>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		private MPMUIZRKMRK XKPSHPHNWHX
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x8453E90", Offset = "0x8453290", VA = "0x188453E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		private LQPODEPWEIZ BGHYZPKXLFS
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8453EF0", Offset = "0x84532F0", VA = "0x188453EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool BSNKUWQPCLF
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8453E00", Offset = "0x8453200", VA = "0x188453E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool NSDBLPIQIDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8453A40", Offset = "0x8452E40", VA = "0x188453A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public bool UIJOQBCQOOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8453A80", Offset = "0x8452E80", VA = "0x188453A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Guid QNCEKCBFNEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8453F50", Offset = "0x8453350", VA = "0x188453F50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Guid GDEBWNCDUBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x84540F0", Offset = "0x84534F0", VA = "0x1884540F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Guid MZXKBECDUXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8453700", Offset = "0x8452B00", VA = "0x188453700")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public RRObjectHierarchy KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8453B40", Offset = "0x8452F40", VA = "0x188453B40")]
		public bool PNFAHJUDQOA([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8453910", Offset = "0x8452D10", VA = "0x188453910")]
		public bool CUHZEJJNEPO([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8453BE0", Offset = "0x8452FE0", VA = "0x188453BE0")]
		public void PNIAAXSWRWP(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8453D00", Offset = "0x8453100", VA = "0x188453D00")]
		public void QEXKPNWLPHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8453FD0", Offset = "0x84533D0", VA = "0x188453FD0")]
		public Guid WWWVQMPOGWE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectCircuitBoard(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x84539B0", Offset = "0x8452DB0", VA = "0x1884539B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectCircuitBoard other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public readonly struct RRObjectConnectable : IEquatable<RRObjectConnectable>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		private PWUPVFQBAGE GITDKIZZWZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8454350", Offset = "0x8453750", VA = "0x188454350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public Vector3 VEYZKIKNYWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8454170", Offset = "0x8453570", VA = "0x188454170")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public Quaternion WWGKHPVXSFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x84548C0", Offset = "0x8453CC0", VA = "0x1884548C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public RRObject FJXOTASNXBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x84543B0", Offset = "0x84537B0", VA = "0x1884543B0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x84546A0", Offset = "0x8453AA0", VA = "0x1884546A0")]
		public NativeObjectLocalIdArray TPOPGKKQDIH(Allocator a)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8454440", Offset = "0x8453840", VA = "0x188454440")]
		public bool PIVNJWDHTWI(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8454770", Offset = "0x8453B70", VA = "0x188454770")]
		public void URVFHXPWKUS(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8454A00", Offset = "0x8453E00", VA = "0x188454A00")]
		public void WCOYCDRELUF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x84544E0", Offset = "0x84538E0", VA = "0x1884544E0")]
		public void SPHTJEJFLSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectConnectable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectConnectable value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ObjectLocalId(RRObjectConnectable value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x84542C0", Offset = "0x84536C0", VA = "0x1884542C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectConnectable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public readonly struct RRObjectContainer : IEquatable<RRObjectContainer>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly RRObjectContainer Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private GYGFXJBKLMH RHMGXLJDPIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8454BB0", Offset = "0x8453FB0", VA = "0x188454BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
		public Span<RRObject> BBQMLARKSHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8454C10", Offset = "0x8454010", VA = "0x188454C10")]
			get
			{
				return default(Span<RRObject>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x8454B30", Offset = "0x8453F30", VA = "0x188454B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x8454DA0", Offset = "0x84541A0", VA = "0x188454DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public RRObjectTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public RRObjectHierarchy KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8454E20", Offset = "0x8454220", VA = "0x188454E20")]
		public void UTMDTUQMRTU(RRObjectContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectContainer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectContainer value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8454D10", Offset = "0x8454110", VA = "0x188454D10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectContainer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator RRObject(RRObjectContainer self)
		{
			return default(RRObject);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct RRObjectCreationParameters : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<int, object> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private CJOKLWFVVZO wrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool isReadOnly;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public RRObject Object
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			[CompilerGenerated]
			readonly get
			{
				return default(RRObject);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		public CreationInstantiationKey this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x84555E0", Offset = "0x84549E0", VA = "0x1884555E0")]
			readonly set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8455510", Offset = "0x8454910", VA = "0x188455510")]
		internal RRObjectCreationParameters(RRObject obj, bool isReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x84552C0", Offset = "0x84546C0", VA = "0x1884552C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A27400", Offset = "0x3A26800", VA = "0x183A27400")]
		public void HMUFOCRYDRV<a>(CreationInstantiationKey a, a b, [Optional] a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8455460", Offset = "0x8454860", VA = "0x188455460")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xC1E140", Offset = "0xC1D540", VA = "0x180C1E140")]
		public Dictionary<int, object> YBCWKJXDAUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x84553F0", Offset = "0x84547F0", VA = "0x1884553F0")]
		private readonly void JRNNHWMBBCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class DBAMFBSFBQN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x844D790", Offset = "0x844CB90", VA = "0x18844D790")]
		public static RRObjectCreationParameters IJDGWDZGUYA(this RRObject a)
		{
			return default(RRObjectCreationParameters);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct RRObjectDeformable : IEquatable<RRObjectDeformable>
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly RRObjectDeformable Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private bool GKATJCOVXEX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8455890", Offset = "0x8454C90", VA = "0x188455890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public Vector3 JFZVTAHLWWU
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8455A60", Offset = "0x8454E60", VA = "0x188455A60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x84556A0", Offset = "0x8454AA0", VA = "0x1884556A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8455700", Offset = "0x8454B00", VA = "0x188455700")]
		public Vector3 CRKCPAZBQAE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8455810", Offset = "0x8454C10", VA = "0x188455810")]
		public void LFSHJDWIOSM([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8455980", Offset = "0x8454D80", VA = "0x188455980")]
		public void TNBUUFMRFNA([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x84558D0", Offset = "0x8454CD0", VA = "0x1884558D0")]
		public bool RLTVOARULAP([In] Vector3 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectDeformable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8455780", Offset = "0x8454B80", VA = "0x188455780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectDeformable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8455A00", Offset = "0x8454E00", VA = "0x188455A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct RRObjectDesync : IEquatable<RRObjectDesync>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8455B90", Offset = "0x8454F90", VA = "0x188455B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectDesync other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct RRObjectElement : IEquatable<RRObjectElement>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		private OAMPTGKUKZW ZQAGANWJMQH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x84564C0", Offset = "0x84558C0", VA = "0x1884564C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public bool BLEMUECGDLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x8456520", Offset = "0x8455920", VA = "0x188456520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public bool QXXHEJSEMVW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x8456260", Offset = "0x8455660", VA = "0x188456260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public ElementGroupStatusData OBORNMTUHPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x8456390", Offset = "0x8455790", VA = "0x188456390")]
			get
			{
				return default(ElementGroupStatusData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public bool EAPVREVBJKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x8456820", Offset = "0x8455C20", VA = "0x188456820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public bool GZDWBNPKIYA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x84566F0", Offset = "0x8455AF0", VA = "0x1884566F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public bool PPQVYYYKQHC
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8456860", Offset = "0x8455C60", VA = "0x188456860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8456780", Offset = "0x8455B80", VA = "0x188456780")]
		public bool YEVVRRVXCXZ(RRObjectElement a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8456650", Offset = "0x8455A50", VA = "0x188456650")]
		public bool UBKYUWQPVMQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x84561C0", Offset = "0x84555C0", VA = "0x1884561C0")]
		public bool OTYSQVKSDTD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x84560A0", Offset = "0x84554A0", VA = "0x1884560A0")]
		public ReadOnlySpan<ObjectLocalId> FWKGDMAEGLS()
		{
			return default(ReadOnlySpan<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectElement(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8456000", Offset = "0x8455400", VA = "0x188456000")]
		public static bool ZWISVWGZSLY(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8451940", Offset = "0x8450D40", VA = "0x188451940")]
		public static bool ZPGHGHNXRJT(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8456010", Offset = "0x8455410", VA = "0x188456010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectElement other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public readonly struct RRObjectElementSnapPoint : IEquatable<RRObjectElementSnapPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly RRObjectElementSnapPoint Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		private OAMPTGKUKZW PKNGRYXVNMR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8455D80", Offset = "0x8455180", VA = "0x188455D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public bool VKHZGSUSVII
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x8455D20", Offset = "0x8455120", VA = "0x188455D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public RRObjectTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8455F60", Offset = "0x8455360", VA = "0x188455F60")]
		public bool YEVVRRVXCXZ(RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8455EC0", Offset = "0x84552C0", VA = "0x188455EC0")]
		public bool XWLMANISSIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8455DE0", Offset = "0x84551E0", VA = "0x188455DE0")]
		public bool WQWYDNNALTR([Out] RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8455C20", Offset = "0x8455020", VA = "0x188455C20")]
		public void APJDLBZPYJW(ElementSnapPointRuntimeFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectElementSnapPoint(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8456000", Offset = "0x8455400", VA = "0x188456000")]
		public static bool ZWISVWGZSLY(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8451940", Offset = "0x8450D40", VA = "0x188451940")]
		public static bool ZPGHGHNXRJT(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8455C90", Offset = "0x8455090", VA = "0x188455C90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectElementSnapPoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public readonly struct RRObjectHierarchy : IEquatable<RRObjectHierarchy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private GYGFXJBKLMH RHMGXLJDPIM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8456B00", Offset = "0x8455F00", VA = "0x188456B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public ObjectLocalId GAZFCLMPONR
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8456F40", Offset = "0x8456340", VA = "0x188456F40")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public RRObject YSZAMEVATVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x8456C90", Offset = "0x8456090", VA = "0x188456C90")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public RRObject JNBRJWHHBWC
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8456DB0", Offset = "0x84561B0", VA = "0x188456DB0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x84568F0", Offset = "0x8455CF0", VA = "0x1884568F0")]
		public Span<RRObject> BTUEASBEOAN()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8456E40", Offset = "0x8456240", VA = "0x188456E40")]
		public Span<RRObject> RZLCTGXHGGO()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8457100", Offset = "0x8456500", VA = "0x188457100")]
		public Span<RRObject> TWFNXDGNSTN()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8457200", Offset = "0x8456600", VA = "0x188457200")]
		public Span<RRObject> ZVGONNRYUPB()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8456FD0", Offset = "0x84563D0", VA = "0x188456FD0")]
		public bool SetParent(RRObject parent, bool worldPositionStays = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8456BF0", Offset = "0x8455FF0", VA = "0x188456BF0")]
		public bool GGXRLINRNGD(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x84569F0", Offset = "0x8455DF0", VA = "0x1884569F0")]
		public RRObject CNBZFGGAIRR(uint a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8456D20", Offset = "0x8456120", VA = "0x188456D20")]
		public RRObjectContainer HDGMBJSPWZX()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectHierarchy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectHierarchy value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8456B60", Offset = "0x8455F60", VA = "0x188456B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectHierarchy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct RRObjectIdentity : IEquatable<RRObjectIdentity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public string AMXDXJEJKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8457450", Offset = "0x8456850", VA = "0x188457450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public string EEONWHHJNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8457830", Offset = "0x8456C30", VA = "0x188457830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string HKONMBQIMCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x84574E0", Offset = "0x84568E0", VA = "0x1884574E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string CZXKSWEDZFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8457590", Offset = "0x8456990", VA = "0x188457590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8457390", Offset = "0x8456790", VA = "0x188457390")]
		public bool HYIXFKFOJFL([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectIdentity(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8457300", Offset = "0x8456700", VA = "0x188457300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectIdentity other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public readonly struct RRObjectInternal : IEquatable<RRObjectInternal>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8457870", Offset = "0x8456C70", VA = "0x188457870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectInternal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct RRObjectMagneticAnchor : IEquatable<RRObjectMagneticAnchor>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[Flags]
		public enum ConnectResult
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			SUCCESS = 0,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			ANCHOR_A_INVALID = 1,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			ANCHOR_B_INVALID = 2,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			ANCHOR_A_ALREADY_CONNECTED = 4,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ANCHOR_B_ALREADY_CONNECTED = 8
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static Log log;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly RRObjectMagneticAnchor Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		private LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8451560", Offset = "0x8450960", VA = "0x188451560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager CCPMMFHJJYI
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x84585D0", Offset = "0x84579D0", VA = "0x1884585D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8458580", Offset = "0x8457980", VA = "0x188458580")]
		public float MLJFHXACHJI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x84588E0", Offset = "0x8457CE0", VA = "0x1884588E0")]
		public void ZLLYKYOCJHY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8458600", Offset = "0x8457A00", VA = "0x188458600")]
		public static ConnectResult TFZIZYXXDQJ(RRObjectMagneticAnchor a, RRObjectMagneticAnchor b)
		{
			return default(ConnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8457D50", Offset = "0x8457150", VA = "0x188457D50")]
		public bool FUXAPCIGGWO([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g, [Out] RRObject h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8458310", Offset = "0x8457710", VA = "0x188458310")]
		public bool LACJSNANQTI([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8457990", Offset = "0x8456D90", VA = "0x188457990")]
		private void FLZRBMOORIZ(Entity a, EntityManager b, MagneticAnchorData c, [Out] GameObject d, [Out] GameObject e, [Out] RRObject f, [Out] RRObject g, [Out] Vector3 h, [Out] Vector3 i, [Out] Vector3 j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectMagneticAnchor(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8457900", Offset = "0x8456D00", VA = "0x188457900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectMagneticAnchor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8458880", Offset = "0x8457C80", VA = "0x188458880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct RRObjectNetworkComponents : IEquatable<RRObjectNetworkComponents>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8458B30", Offset = "0x8457F30", VA = "0x188458B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectNetworkComponents other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct RRObjectObjectInteractionFilter : IEquatable<RRObjectObjectInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		private YUPBBDTSNSP PKNGRYXVNMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8458EE0", Offset = "0x84582E0", VA = "0x188458EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public InteractionFilterMode BALPIKTSLUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x8459050", Offset = "0x8458450", VA = "0x188459050")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x8458BC0", Offset = "0x8457FC0", VA = "0x188458BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public RentedArray<string> FRFJGXBATYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8458F40", Offset = "0x8458340", VA = "0x188458F40")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8458DC0", Offset = "0x84581C0", VA = "0x188458DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public RentedArray<string> VZIBXIRQDWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x8459090", Offset = "0x8458490", VA = "0x188459090")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8458CA0", Offset = "0x84580A0", VA = "0x188458CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectObjectInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8458C10", Offset = "0x8458010", VA = "0x188458C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectObjectInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public readonly struct RRObjectPhysics : IEquatable<RRObjectPhysics>
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ComponentTypeSet RequiredComponents;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly RRObjectPhysics Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public Collider DBBRKPEDULH
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x8459BC0", Offset = "0x8458FC0", VA = "0x188459BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public CollisionLayerEnum IVZRBQBXLXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x84592C0", Offset = "0x84586C0", VA = "0x1884592C0")]
			get
			{
				return default(CollisionLayerEnum);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x84591B0", Offset = "0x84585B0", VA = "0x1884591B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public CollisionMode QMCSFOMNMQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8459200", Offset = "0x8458600", VA = "0x188459200")]
			get
			{
				return default(CollisionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x84593E0", Offset = "0x84587E0", VA = "0x1884593E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public GrabbableMode ZHPBUZPNNJH
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8459B80", Offset = "0x8458F80", VA = "0x188459B80")]
			get
			{
				return default(GrabbableMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8459D10", Offset = "0x8459110", VA = "0x188459D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public float TVNCWBPERBY
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x845A0B0", Offset = "0x84594B0", VA = "0x18845A0B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8459300", Offset = "0x8458700", VA = "0x188459300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public bool BFDKXFRXYIH
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x845A040", Offset = "0x8459440", VA = "0x18845A040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x8459AE0", Offset = "0x8458EE0", VA = "0x188459AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public bool FPKBOZGASDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x8459A60", Offset = "0x8458E60", VA = "0x188459A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8459960", Offset = "0x8458D60", VA = "0x188459960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public bool YYGZBTIDHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x8459240", Offset = "0x8458640", VA = "0x188459240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8459D60", Offset = "0x8459160", VA = "0x188459D60")]
		public static bool RUOVQJLWIMN(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8459720", Offset = "0x8458B20", VA = "0x188459720")]
		public static bool ICFBJHCLOJX(RRObject a, [Out] RRObjectPhysics b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x84595C0", Offset = "0x84589C0", VA = "0x1884595C0")]
		public bool GYMQFZPXFYO([Out] BOQSKSJCOID a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8459430", Offset = "0x8458830", VA = "0x188459430")]
		public bool FUEKBUORYIH([Out] ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8459A00", Offset = "0x8458E00", VA = "0x188459A00")]
		public bool LKNDGDVYLAS(PhysicsModelEnumFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8459F60", Offset = "0x8459360", VA = "0x188459F60")]
		public void TZAVYURIVAC(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8459520", Offset = "0x8458920", VA = "0x188459520")]
		public void GUKTMSBNLDX(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectPhysics(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8459350", Offset = "0x8458750", VA = "0x188459350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectPhysics other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8459FE0", Offset = "0x84593E0", VA = "0x188459FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public readonly struct RRObjectPlayer : IEquatable<RRObjectPlayer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public bool FVPJJKBDKHY
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x845B310", Offset = "0x845A710", VA = "0x18845B310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectPlayer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x845B280", Offset = "0x845A680", VA = "0x18845B280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectPlayer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public readonly struct RRObjectPlayerInteraction : IEquatable<RRObjectPlayerInteraction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		private KDKEUALAXZV GBYBXFQOIVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x845B220", Offset = "0x845A620", VA = "0x18845B220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x845B0A0", Offset = "0x845A4A0", VA = "0x18845B0A0")]
		public void CQQCQJFOLIJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectPlayerInteraction(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x845B190", Offset = "0x845A590", VA = "0x18845B190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteraction other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public readonly struct RRObjectPlayerInteractionFilter : IEquatable<RRObjectPlayerInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private KSDPPWMWOYZ YJOOHTDJDLY
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x845AF20", Offset = "0x845A320", VA = "0x18845AF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public InteractionFilterMode WZKXQGGZYQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x845A7E0", Offset = "0x8459BE0", VA = "0x18845A7E0")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x845AB40", Offset = "0x8459F40", VA = "0x18845AB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public bool WERTBWVUPPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x845AD70", Offset = "0x845A170", VA = "0x18845AD70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x845AAA0", Offset = "0x8459EA0", VA = "0x18845AAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public RentedArray<string> UAYPLCZUGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x845AF80", Offset = "0x845A380", VA = "0x18845AF80")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x845AE00", Offset = "0x845A200", VA = "0x18845AE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public RentedArray<string> JBZJDBGWKZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x845A980", Offset = "0x8459D80", VA = "0x18845A980")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x845A3F0", Offset = "0x84597F0", VA = "0x18845A3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public RentedArray<string> NVDPYYVYEYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x845A5A0", Offset = "0x84599A0", VA = "0x18845A5A0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x845A2D0", Offset = "0x84596D0", VA = "0x18845A2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public RentedArray<string> BKPOCFKTKTN
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x845AC50", Offset = "0x845A050", VA = "0x18845AC50")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x845A6C0", Offset = "0x8459AC0", VA = "0x18845A6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x845A8E0", Offset = "0x8459CE0", VA = "0x18845A8E0")]
		public bool KIQQXLLJPIT(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectPlayerInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ObjectLocalId(RRObjectPlayerInteractionFilter value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x845A510", Offset = "0x8459910", VA = "0x18845A510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public readonly struct RRObjectPolicy : IEquatable<RRObjectPolicy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public bool PVTDNPTOFDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x845B3E0", Offset = "0x845A7E0", VA = "0x18845B3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public bool EKJPMZXYTEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x845BF80", Offset = "0x845B380", VA = "0x18845BF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool JCQMZFDKHSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x845BA00", Offset = "0x845AE00", VA = "0x18845BA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x845B8F0", Offset = "0x845ACF0", VA = "0x18845B8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool LKLVICJIGWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x845B680", Offset = "0x845AA80", VA = "0x18845B680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public bool WMSOPETXYNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x845B8A0", Offset = "0x845ACA0", VA = "0x18845B8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool MVDZKUDWCDS
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x845C210", Offset = "0x845B610", VA = "0x18845C210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool AFGJTPONWIW
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x845B910", Offset = "0x845AD10", VA = "0x18845B910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool UWLMXZDTEZA
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x845BA50", Offset = "0x845AE50", VA = "0x18845BA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool JMCDJSTKBUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x845C0E0", Offset = "0x845B4E0", VA = "0x18845C0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool RVFYQYWZRFY
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x845B6D0", Offset = "0x845AAD0", VA = "0x18845B6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool FKLCXUQYHAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x845B9B0", Offset = "0x845ADB0", VA = "0x18845B9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool TEBTUWBLSCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x845C130", Offset = "0x845B530", VA = "0x18845C130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public bool ZLPJQWFCKRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x845B580", Offset = "0x845A980", VA = "0x18845B580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public bool LYBCQUTALFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x845C050", Offset = "0x845B450", VA = "0x18845C050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x845B720", Offset = "0x845AB20", VA = "0x18845B720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool VZNPJARXOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x845C090", Offset = "0x845B490", VA = "0x18845C090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public NavMeshGenerationMode QLJITUVMLAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x845B470", Offset = "0x845A870", VA = "0x18845B470")]
			get
			{
				return default(NavMeshGenerationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x845B960", Offset = "0x845AD60", VA = "0x18845B960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public bool DFTWKJQOWSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x845B780", Offset = "0x845AB80", VA = "0x18845B780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public CircuitsTransformBehavior ESODEHSOSIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x845BAF0", Offset = "0x845AEF0", VA = "0x18845BAF0")]
			get
			{
				return default(CircuitsTransformBehavior);
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x845B420", Offset = "0x845A820", VA = "0x18845B420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public bool STCDNQSARVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x845C260", Offset = "0x845B660", VA = "0x18845C260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public Vector3 MPBLQYJIBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x845B360", Offset = "0x845A760", VA = "0x18845B360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public Vector3 OOKICTJXPXT
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x845BFD0", Offset = "0x845B3D0", VA = "0x18845BFD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public bool BICUDKMELIC
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x845BB30", Offset = "0x845AF30", VA = "0x18845BB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public bool ZTRDJNCNSEO
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x845BE00", Offset = "0x845B200", VA = "0x18845BE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		private EntityManager CCPMMFHJJYI
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x84585D0", Offset = "0x84579D0", VA = "0x1884585D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x845B620", Offset = "0x845AA20", VA = "0x18845B620")]
		public bool HLLCPVGXGXQ(ObjectPolicyEnum a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x845C180", Offset = "0x845B580", VA = "0x18845C180")]
		public void YWQCASWORUO(ObjectPolicyEnum a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x845B5D0", Offset = "0x845A9D0", VA = "0x18845B5D0")]
		public bool HCMRPWIINVC(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x845BF00", Offset = "0x845B300", VA = "0x18845BF00")]
		public void TWRHAHEAQRK(ObjectPolicyUserConfigurableFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x845B4B0", Offset = "0x845A8B0", VA = "0x18845B4B0")]
		public ObjectPolicyUserConfigurableFlags EEPROHZZDBT()
		{
			return default(ObjectPolicyUserConfigurableFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x845BAA0", Offset = "0x845AEA0", VA = "0x18845BAA0")]
		public bool QVNFRDLGFXL(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectPolicy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x845B4F0", Offset = "0x845A8F0", VA = "0x18845B4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectPolicy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public readonly struct RRObjectReferenceGroup : IEquatable<RRObjectReferenceGroup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		private ZSFTDSWKISY PVCKHWIYOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x845C970", Offset = "0x845BD70", VA = "0x18845C970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x845CAE0", Offset = "0x845BEE0", VA = "0x18845CAE0")]
		public bool SGLJLGSELAZ(ReferenceGroupKind a, List<RRObject> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x845C860", Offset = "0x845BC60", VA = "0x18845C860")]
		public int QCEAWGWOPFO(ReferenceGroupKind a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x845C510", Offset = "0x845B910", VA = "0x18845C510")]
		public void NIJCOXRWSOU(List<RRObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x845CC10", Offset = "0x845C010", VA = "0x18845CC10")]
		public int SNBKMDXQDXR(RRObject a, ReferenceGroupKind b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x845C730", Offset = "0x845BB30", VA = "0x18845C730")]
		public RRObject OUDDTPBUIJG(int a, ReferenceGroupKind b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x845C330", Offset = "0x845B730", VA = "0x18845C330")]
		public void HQZDSJUAASL(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x845C460", Offset = "0x845B860", VA = "0x18845C460")]
		public bool MKXCDLEBAUB(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x845C620", Offset = "0x845BA20", VA = "0x18845C620")]
		public void NJZXERBIQWW(ReferenceGroupKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x845CD40", Offset = "0x845C140", VA = "0x18845CD40")]
		public bool UJMDMNIYLSA(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x845C9D0", Offset = "0x845BDD0", VA = "0x18845C9D0")]
		public bool ROOTAPCVGFO(ReferenceGroupKind a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectReferenceGroup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x845C2A0", Offset = "0x845B6A0", VA = "0x18845C2A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectReferenceGroup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public readonly struct RRObjectRenderEffects : IEquatable<RRObjectRenderEffects>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x845CE80", Offset = "0x845C280", VA = "0x18845CE80")]
		public void FEIOGEZSDQT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x845CF10", Offset = "0x845C310", VA = "0x18845CF10")]
		public void WKOOUJLKRSR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A27C20", Offset = "0x3A27020", VA = "0x183A27C20")]
		public a WAVJDPVVLBR<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectRenderEffects(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x845CDF0", Offset = "0x845C1F0", VA = "0x18845CDF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectRenderEffects other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public readonly struct RRObjectReplicatedObject : IEquatable<RRObjectReplicatedObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public bool JGGKNWRBMCA
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x845CFA0", Offset = "0x845C3A0", VA = "0x18845CFA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x845D070", Offset = "0x845C470", VA = "0x18845D070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool MHSLWGTWTRD
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x845D150", Offset = "0x845C550", VA = "0x18845D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public int OPTQLJXMWOS
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x845D1D0", Offset = "0x845C5D0", VA = "0x18845D1D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x845D0C0", Offset = "0x845C4C0", VA = "0x18845D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectReplicatedObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x845CFE0", Offset = "0x845C3E0", VA = "0x18845CFE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectReplicatedObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public readonly struct RRObjectReplicator : IEquatable<RRObjectReplicator>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public int TUQTQZMZKTT
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x845D3C0", Offset = "0x845C7C0", VA = "0x18845D3C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x845D370", Offset = "0x845C770", VA = "0x18845D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public int YHHYDGSBKIB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x845D210", Offset = "0x845C610", VA = "0x18845D210")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x845D2E0", Offset = "0x845C6E0", VA = "0x18845D2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public uint ALLKZKCLRHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x845D330", Offset = "0x845C730", VA = "0x18845D330")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x845D400", Offset = "0x845C800", VA = "0x18845D400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectReplicator(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x845D250", Offset = "0x845C650", VA = "0x18845D250", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectReplicator other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public readonly struct RRObjectScope : IEquatable<RRObjectScope>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		private LOCSQWGPZIX CCNVVBWBESV
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x845DC00", Offset = "0x845D000", VA = "0x18845DC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		private HYBBZABLQFR UNMKCCYYROR
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x845DF10", Offset = "0x845D310", VA = "0x18845DF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool HENDZNKZVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x845D700", Offset = "0x845CB00", VA = "0x18845D700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool EVQLRLBLZTY
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x845DA90", Offset = "0x845CE90", VA = "0x18845DA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public bool VOVSBIKRPXF
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x845DBD0", Offset = "0x845CFD0", VA = "0x18845DBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public bool GGQBPZVBPJN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x845DE40", Offset = "0x845D240", VA = "0x18845DE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool KHMMYHTVJXT
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x845DF70", Offset = "0x845D370", VA = "0x18845DF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public bool SIJSHXIWPJU
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x845DA00", Offset = "0x845CE00", VA = "0x18845DA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public bool RINASAJMAFG
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x845D450", Offset = "0x845C850", VA = "0x18845D450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public bool UWKQVHHJBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x845DC60", Offset = "0x845D060", VA = "0x18845DC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public bool PGCNQZNAADK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x845D820", Offset = "0x845CC20", VA = "0x18845D820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x845DDD0", Offset = "0x845D1D0", VA = "0x18845DDD0")]
		public bool NBGEPSELVHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x845DB30", Offset = "0x845CF30", VA = "0x18845DB30")]
		public RRObject IHBPTBEASVL(RRObject a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x845D5F0", Offset = "0x845C9F0", VA = "0x18845D5F0")]
		public ObjectLocalId DVGPFDEPOID()
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x845D950", Offset = "0x845CD50", VA = "0x18845D950")]
		public bool FDPHDYBYSLB(ObjectLocalId a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectScope(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectScope value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x845D790", Offset = "0x845CB90", VA = "0x18845D790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectScope other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct RRObjectShape : IEquatable<RRObjectShape>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly RRObjectShape Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public EShapeType OWTUQSPIGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x845F1C0", Offset = "0x845E5C0", VA = "0x18845F1C0")]
			get
			{
				return default(EShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public RenderableColor BBHCWBJOSMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x845EFD0", Offset = "0x845E3D0", VA = "0x18845EFD0")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x845EF80", Offset = "0x845E380", VA = "0x18845EF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public RenderableMaterial UIIQDVLKWCX
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x845EEF0", Offset = "0x845E2F0", VA = "0x18845EEF0")]
			get
			{
				return default(RenderableMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x845F200", Offset = "0x845E600", VA = "0x18845F200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public float QOKNBLRLPAN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x845F250", Offset = "0x845E650", VA = "0x18845F250")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x845EEA0", Offset = "0x845E2A0", VA = "0x18845EEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public Vector3 DHVXJVNSKIS
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x845EDD0", Offset = "0x845E1D0", VA = "0x18845EDD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x845F140", Offset = "0x845E540", VA = "0x18845F140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public float LJSREPGEVAG
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x845F290", Offset = "0x845E690", VA = "0x18845F290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public ShapeConfigFlags DTVUNCVEUXF
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x845F2E0", Offset = "0x845E6E0", VA = "0x18845F2E0")]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x845EF30", Offset = "0x845E330", VA = "0x18845EF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public bool JFRGFDGGPCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x845ED00", Offset = "0x845E100", VA = "0x18845ED00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x845F060", Offset = "0x845E460", VA = "0x18845F060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public RRObjectTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public RRObjectHierarchy KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x845ECB0", Offset = "0x845E0B0", VA = "0x18845ECB0")]
		public RRObjectShapePrimitive BHJEPUJRGLZ()
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x845F010", Offset = "0x845E410", VA = "0x18845F010")]
		public RRObjectShapeSpline KWVGKFSLTKT()
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x845EE50", Offset = "0x845E250", VA = "0x18845EE50")]
		private bool GFNXKUCLHNN(ShapeConfigFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x845F0C0", Offset = "0x845E4C0", VA = "0x18845F0C0")]
		public void NNABQKHAPOI(ShapeConfigFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectShape(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectShape value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8451940", Offset = "0x8450D40", VA = "0x188451940")]
		public static bool ZPGHGHNXRJT(RRObjectShape a, RRObjectShape b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x845ED40", Offset = "0x845E140", VA = "0x18845ED40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectShape other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct RRObjectShapePrimitive : IEquatable<RRObjectShapePrimitive>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public RRObjectShape JNGIBUAPTOL
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public PrimitiveShapeType YYOBJSIMLJF
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x845E030", Offset = "0x845D430", VA = "0x18845E030")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectShapePrimitive(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectShapePrimitive value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x845DFA0", Offset = "0x845D3A0", VA = "0x18845DFA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectShapePrimitive other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct RRObjectShapeSpline : IEquatable<RRObjectShapeSpline>
	{
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly RRObjectShapeSpline Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		private LKIUSZVOLVR FNXMWDPLFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x845EA20", Offset = "0x845DE20", VA = "0x18845EA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public RRObjectShape JNGIBUAPTOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public SplineParameters ZXJTOGTDPXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x845EA80", Offset = "0x845DE80", VA = "0x18845EA80")]
			get
			{
				return default(SplineParameters);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x845E2F0", Offset = "0x845D6F0", VA = "0x18845E2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public IEnumerable<RRObjectSplinePoint> WFIGYVEFSEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x845E070", Offset = "0x845D470", VA = "0x18845E070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public RRObjectSplinePoint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x845EBA0", Offset = "0x845DFA0", VA = "0x18845EBA0")]
			get
			{
				return default(RRObjectSplinePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x845E410", Offset = "0x845D810", VA = "0x18845E410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public RRObjectTransform SFEPHHTYQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x845E800", Offset = "0x845DC00", VA = "0x18845E800")]
		public RRObjectSplinePoint KFJONBROKIC(float3? a, [Optional] quaternion? b, [Optional] Vector3? c)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x845E5D0", Offset = "0x845D9D0", VA = "0x18845E5D0")]
		public RRObjectSplinePoint Insert(int index, float3? position, [Optional] quaternion? rotation, [Optional] Vector3? scale)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x845E4A0", Offset = "0x845D8A0", VA = "0x18845E4A0")]
		public void EPVQTLCLKWT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x845E260", Offset = "0x845D660", VA = "0x18845E260")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectShapeSpline(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8454B10", Offset = "0x8453F10", VA = "0x188454B10")]
		public static implicit operator bool(RRObjectShapeSpline value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8456000", Offset = "0x8455400", VA = "0x188456000")]
		public static bool ZWISVWGZSLY(RRObjectShapeSpline a, RRObjectShapeSpline b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x845E540", Offset = "0x845D940", VA = "0x18845E540", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectShapeSpline other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct RRObjectSplinePoint : IEquatable<RRObjectSplinePoint>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public RRObjectShapeSpline HOLBAIOCPET
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x845F4C0", Offset = "0x845E8C0", VA = "0x18845F4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public float3 UJNTDLPNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x845F5E0", Offset = "0x845E9E0", VA = "0x18845F5E0")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x845F410", Offset = "0x845E810", VA = "0x18845F410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public quaternion ILSUHOUFHJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x845F590", Offset = "0x845E990", VA = "0x18845F590")]
			get
			{
				return default(quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x845F470", Offset = "0x845E870", VA = "0x18845F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public float3 YQVISJLTEUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x845F320", Offset = "0x845E720", VA = "0x18845F320")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x845F640", Offset = "0x845EA40", VA = "0x18845F640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public FractionalIndex ORFDZXMBXNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x845F540", Offset = "0x845E940", VA = "0x18845F540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x845F6A0", Offset = "0x845EAA0", VA = "0x18845F6A0")]
		public void YFSQHTETQCT(RRObjectShapeSpline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectSplinePoint(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x845F380", Offset = "0x845E780", VA = "0x18845F380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectSplinePoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public readonly struct RRObjectStudioObject : IEquatable<RRObjectStudioObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public bool RVUFHMYEOTR
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x845F6B0", Offset = "0x845EAB0", VA = "0x18845F6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectStudioObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x845F720", Offset = "0x845EB20", VA = "0x18845F720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectStudioObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public readonly struct RRObjectTerrain : IEquatable<RRObjectTerrain>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly RRObjectTerrain Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		private OGNQEMRTGWZ CDWNZPCJGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x845FA90", Offset = "0x845EE90", VA = "0x18845FA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public uint KTCAPHASVBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x845FAF0", Offset = "0x845EEF0", VA = "0x18845FAF0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x845FD90", Offset = "0x845F190", VA = "0x18845FD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public TerrainLayerRoughness YVFYWBIXJNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x845F800", Offset = "0x845EC00", VA = "0x18845F800")]
			get
			{
				return default(TerrainLayerRoughness);
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x845F9F0", Offset = "0x845EDF0", VA = "0x18845F9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public float XCSJXNKSNGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x845FEF0", Offset = "0x845F2F0", VA = "0x18845FEF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x8460040", Offset = "0x845F440", VA = "0x188460040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public float CKBBEOGYKWL
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x845FC40", Offset = "0x845F040", VA = "0x18845FC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x845F7B0", Offset = "0x845EBB0", VA = "0x18845F7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TerrainPlayAreaShape GVGVQIVJLKS
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x845FB80", Offset = "0x845EF80", VA = "0x18845FB80")]
			get
			{
				return default(TerrainPlayAreaShape);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x84601F0", Offset = "0x845F5F0", VA = "0x1884601F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public float SNKCVBAMVXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x845FE30", Offset = "0x845F230", VA = "0x18845FE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x845FB30", Offset = "0x845EF30", VA = "0x18845FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public float XMNLWNDWHFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x845FD40", Offset = "0x845F140", VA = "0x18845FD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public float VTLHPKJUPER
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x845FEB0", Offset = "0x845F2B0", VA = "0x18845FEB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public float WEVKZKHHCAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x845FBC0", Offset = "0x845EFC0", VA = "0x18845FBC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8460160", Offset = "0x845F560", VA = "0x188460160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public RenderableColor LJLOVVYKELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x845FE70", Offset = "0x845F270", VA = "0x18845FE70")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x845FDE0", Offset = "0x845F1E0", VA = "0x18845FDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public RenderableColor KPPEDRRJMAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x8460090", Offset = "0x845F490", VA = "0x188460090")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x845FF30", Offset = "0x845F330", VA = "0x18845FF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public float JLTOCMYREZR
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x84601B0", Offset = "0x845F5B0", VA = "0x1884601B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x8460110", Offset = "0x845F510", VA = "0x188460110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public TerrainWaterMaterial CRIKFRZDBVW
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x845FC00", Offset = "0x845F000", VA = "0x18845FC00")]
			get
			{
				return default(TerrainWaterMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x845FA40", Offset = "0x845EE40", VA = "0x18845FA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public WaterOverrides PBIXVPYHJWG
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x84600D0", Offset = "0x845F4D0", VA = "0x1884600D0")]
			get
			{
				return default(WaterOverrides);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x8460350", Offset = "0x845F750", VA = "0x188460350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public ReadOnlySpan<TerrainGenerationLayer> JXPGNWSFFRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x845FF80", Offset = "0x845F380", VA = "0x18845FF80")]
			get
			{
				return default(ReadOnlySpan<TerrainGenerationLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x8460240", Offset = "0x845F640", VA = "0x188460240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public ReadOnlySpan<TerrainCustomMaterialLayer> FWSKCGOSXEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x845FC80", Offset = "0x845F080", VA = "0x18845FC80")]
			get
			{
				return default(ReadOnlySpan<TerrainCustomMaterialLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x845F840", Offset = "0x845EC40", VA = "0x18845F840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectTerrain(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ObjectLocalId(RRObjectTerrain value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x845F960", Offset = "0x845ED60", VA = "0x18845F960", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectTerrain other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public readonly struct RRObjectToolCleanup : IEquatable<RRObjectToolCleanup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		private EGEDLXCDTXG PLKQCCOTUXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x8460F10", Offset = "0x8460310", VA = "0x188460F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public bool WTWTTSYZXKC
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8460E20", Offset = "0x8460220", VA = "0x188460E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x8460D40", Offset = "0x8460140", VA = "0x188460D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public bool NFFSTWERSQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x8460B70", Offset = "0x845FF70", VA = "0x188460B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x8460480", Offset = "0x845F880", VA = "0x188460480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public float FEFIMEULGIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x8460BC0", Offset = "0x845FFC0", VA = "0x188460BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x8460430", Offset = "0x845F830", VA = "0x188460430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public bool UIEBWKOHMEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x8460B20", Offset = "0x845FF20", VA = "0x188460B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8460E70", Offset = "0x8460270", VA = "0x188460E70")]
		public void WOEURSWMIYJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8460790", Offset = "0x845FB90", VA = "0x188460790")]
		public bool HMNHURORSNW([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x84606F0", Offset = "0x845FAF0", VA = "0x1884606F0")]
		public void ForceCleanup(bool forceImmediate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x84606A0", Offset = "0x845FAA0", VA = "0x1884606A0")]
		public bool FWBWQDHPUIW(ToolCleanupFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8460DA0", Offset = "0x84601A0", VA = "0x188460DA0")]
		public void VMPVDYOLDBF(ToolCleanupFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8460C00", Offset = "0x8460000", VA = "0x188460C00")]
		public void SYEQBSYDMXO(float a, float b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x84609D0", Offset = "0x845FDD0", VA = "0x1884609D0")]
		public void JEZXKZVCXJV(float3 a, quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x84608A0", Offset = "0x845FCA0", VA = "0x1884608A0")]
		public bool ISASCTZRXPM([Out] float3 a, [Out] quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8460570", Offset = "0x845F970", VA = "0x188460570")]
		public bool FSSQGPWCISM([Out] float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x84603A0", Offset = "0x845F7A0", VA = "0x1884603A0")]
		public void AFCJWTLZXVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectToolCleanup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x84604E0", Offset = "0x845F8E0", VA = "0x1884604E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectToolCleanup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct RRObjectTransform : IEquatable<RRObjectTransform>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		private GFLRQANDFVQ GBKHQOSSKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x8460F70", Offset = "0x8460370", VA = "0x188460F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Vector3 UJNTDLPNGHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x8462B30", Offset = "0x8461F30", VA = "0x188462B30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x8461480", Offset = "0x8460880", VA = "0x188461480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Quaternion ILSUHOUFHJR
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x84628F0", Offset = "0x8461CF0", VA = "0x1884628F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x8461BB0", Offset = "0x8460FB0", VA = "0x188461BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Vector3 FBGWFBKYUIN
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x8461C80", Offset = "0x8461080", VA = "0x188461C80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x8461FE0", Offset = "0x84613E0", VA = "0x188461FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Quaternion HMGAGMHXMLK
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x8461030", Offset = "0x8460430", VA = "0x188461030")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x8462C20", Offset = "0x8462020", VA = "0x188462C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public float JFNFNHALNOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x84611D0", Offset = "0x84605D0", VA = "0x1884611D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x8462A40", Offset = "0x8461E40", VA = "0x188462A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public float BCICBUXIYNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x8462470", Offset = "0x8461870", VA = "0x188462470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Matrix4x4 JUMRGBGOSTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x8462AF0", Offset = "0x8461EF0", VA = "0x188462AF0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public RRObjectHierarchy KWUYBNVJDUF
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		private LNGQTCAXYFX AATZZAXDLVU
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x8451560", Offset = "0x8450960", VA = "0x188451560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8461180", Offset = "0x8460580", VA = "0x188461180")]
		public RRTransform CCFDCLNEWEG()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8462D90", Offset = "0x8462190", VA = "0x188462D90")]
		public void ZWOZPJAPUQI([Out] Matrix4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8461D70", Offset = "0x8461170", VA = "0x188461D70")]
		public void OEKDKFNQBGM([In] Vector3 localPosition, [In] Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8461E70", Offset = "0x8461270", VA = "0x188461E70")]
		public void OEKDKFNQBGM([In] RigidTransform parentFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x84623C0", Offset = "0x84617C0", VA = "0x1884623C0")]
		public void SCBTAQKGIMI([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x84622C0", Offset = "0x84616C0", VA = "0x1884622C0")]
		public void QZNFNCFHPYL([In] Vector3 worldPosition, [In] Quaternion worldRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x8462200", Offset = "0x8461600", VA = "0x188462200")]
		public void QZNFNCFHPYL([In] RigidTransform worldFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x84618F0", Offset = "0x8460CF0", VA = "0x1884618F0")]
		public void LORXQQAMGSP([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x8461840", Offset = "0x8460C40", VA = "0x188461840")]
		public void LORXQQAMGSP([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8461330", Offset = "0x8460730", VA = "0x188461330")]
		public UniformTRS EIKGCIANLIZ()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x8461270", Offset = "0x8460670", VA = "0x188461270")]
		public void EIKGCIANLIZ([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x84619D0", Offset = "0x8460DD0", VA = "0x1884619D0")]
		public UniformTRS MBOMZOVUEYM()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8461A00", Offset = "0x8460E00", VA = "0x188461A00")]
		public void MBOMZOVUEYM([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8461750", Offset = "0x8460B50", VA = "0x188461750")]
		public Vector3 JDKOLPLNCAG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x8462510", Offset = "0x8461910", VA = "0x188462510")]
		public void SetLocalPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8461AC0", Offset = "0x8460EC0", VA = "0x188461AC0")]
		public Vector3 MWQWDZHFOEJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x84626B0", Offset = "0x8461AB0", VA = "0x1884626B0")]
		public void SetWorldPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x84620B0", Offset = "0x84614B0", VA = "0x1884620B0")]
		public Quaternion QVHOWIPVPVN()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x84625E0", Offset = "0x84619E0", VA = "0x1884625E0")]
		public void SetLocalRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8461600", Offset = "0x8460A00", VA = "0x188461600")]
		public Quaternion GQPLNCUBENS()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8462780", Offset = "0x8461B80", VA = "0x188462780")]
		public void SetWorldRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8462850", Offset = "0x8461C50", VA = "0x188462850")]
		public float TNHBWMILJEL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x8461F30", Offset = "0x8461330", VA = "0x188461F30")]
		public void PYARRQNWCET(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x8462CF0", Offset = "0x84620F0", VA = "0x188462CF0")]
		public float ZVQKIXGIOFO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8461550", Offset = "0x8460950", VA = "0x188461550")]
		public void GPKRALGBHIA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x8461360", Offset = "0x8460760", VA = "0x188461360")]
		public Vector3 EYLVNVFZWDN([In] Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectTransform(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x84613F0", Offset = "0x84607F0", VA = "0x1884613F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public readonly struct RRObjectUserTags : IEquatable<RRObjectUserTags>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		private OPCHQLYRCDD PXJLCYUMQZA
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x8462F40", Offset = "0x8462340", VA = "0x188462F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public RRObject ADSRXIMGFER
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x8453040", Offset = "0x8452440", VA = "0x188453040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8462FA0", Offset = "0x84623A0", VA = "0x188462FA0")]
		public void PFBCRDMTCEZ(string a, NativeObjectLocalIdList b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRObjectUserTags(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8462EB0", Offset = "0x84622B0", VA = "0x188462EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRObjectUserTags other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x84535D0", Offset = "0x84529D0", VA = "0x1884535D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public readonly struct RRScene : IEquatable<RRScene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public NetworkCreatorId DNOSMOIILUT
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8465060", Offset = "0x8464460", VA = "0x188465060")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRScene(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8464FD0", Offset = "0x84643D0", VA = "0x188464FD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRScene other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct RRSceneEntityRemap : IEquatable<RRSceneEntityRemap>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct RetainScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private ObjectLocalId localId;

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x84656A0", Offset = "0x8464AA0", VA = "0x1884656A0")]
			public RetainScope(ObjectLocalId localId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x8465610", Offset = "0x8464A10", VA = "0x188465610", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x8464390", Offset = "0x8463790", VA = "0x188464390")]
		public RetainScope HCSMZEYOCLN()
		{
			return default(RetainScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8464420", Offset = "0x8463820", VA = "0x188464420")]
		public EntityRemapArray HTNCYPSCFQQ(Allocator a = Allocator.Temp)
		{
			return default(EntityRemapArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8464680", Offset = "0x8463A80", VA = "0x188464680")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LMKMZQKZBAQ(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x84647B0", Offset = "0x8463BB0", VA = "0x1884647B0")]
		public NativeArray<ObjectNetworkId> OXSJELZDXXJ(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8464510", Offset = "0x8463910", VA = "0x188464510")]
		public NativeArray<ObjectNetworkId> KVZZPAXUVEW(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x8464240", Offset = "0x8463640", VA = "0x188464240")]
		public NativeObjectLocalIdArray CHDXHWDFLTW(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8464860", Offset = "0x8463C60", VA = "0x188464860")]
		public NativeObjectLocalIdArray TAQCHMBUUOJ(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x84645C0", Offset = "0x84639C0", VA = "0x1884645C0")]
		public NativeObjectLocalIdArray LGRGNAUMVVD(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRSceneEntityRemap(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8464300", Offset = "0x8463700", VA = "0x188464300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRSceneEntityRemap other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8464920", Offset = "0x8463D20", VA = "0x188464920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct SceneLoadResultMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int objectCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int removeCount;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public readonly struct RRSceneLoadOperation : IEquatable<RRSceneLoadOperation>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public RRSceneEntityRemap QTWNQMTXPJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public RRSceneLoadResult PKTGOURPEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRSceneLoadResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public RRScene DHMJPDMDRJY
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRScene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8464CA0", Offset = "0x84640A0", VA = "0x188464CA0")]
		public bool KALXIRBNVJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8464D40", Offset = "0x8464140", VA = "0x188464D40")]
		public bool RLUEGWILOMZ([Out] Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRSceneLoadOperation(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xD01B00", Offset = "0xD00F00", VA = "0x180D01B00")]
		public static implicit operator ObjectLocalId(RRSceneLoadOperation value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8464C10", Offset = "0x8464010", VA = "0x188464C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRSceneLoadOperation other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8464920", Offset = "0x8463D20", VA = "0x188464920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public readonly struct RRSceneLoadOperationSubgraph : IDisposable, IEquatable<RRSceneLoadOperationSubgraph>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly RRSceneLoadOperationSubgraph Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public RRSceneLoadOperation NXNEEQBUZMH
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRSceneLoadOperation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public RRSceneEntityRemap QTWNQMTXPJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8464A10", Offset = "0x8463E10", VA = "0x188464A10")]
		public void EWFXCKBZFYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8464940", Offset = "0x8463D40", VA = "0x188464940", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRSceneLoadOperationSubgraph(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8464A90", Offset = "0x8463E90", VA = "0x188464A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "5")]
		public bool Equals(RRSceneLoadOperationSubgraph other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8464B20", Offset = "0x8463F20", VA = "0x188464B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public readonly struct RRSceneLoadResult : IEquatable<RRSceneLoadResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public bool VNEOXAMCWXS
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x8464F40", Offset = "0x8464340", VA = "0x188464F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ObjectLocalId NEWSTJSXLIU
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x10D9ED0", Offset = "0x10D92D0", VA = "0x1810D9ED0")]
		public RRSceneLoadResult(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x84515C0", Offset = "0x84509C0", VA = "0x1884515C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8464EB0", Offset = "0x84642B0", VA = "0x188464EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x84513C0", Offset = "0x84507C0", VA = "0x1884513C0", Slot = "4")]
		public bool Equals(RRSceneLoadResult other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8464920", Offset = "0x8463D20", VA = "0x188464920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class ZVPINNZFTOE
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private struct EntityGuidInterop
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Guid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public ObjectGuid objectGuid;
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct ObjectGuid
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int creator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int magic;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int reserved;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x8450C70", Offset = "0x8450070", VA = "0x188450C70")]
			public bool IVYCRKJIFST([Out] ObjectNetworkId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x8450D10", Offset = "0x8450110", VA = "0x188450D10")]
			public ObjectGuid(ObjectNetworkId networkId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8466360", Offset = "0x8465760", VA = "0x188466360")]
		public static Guid IPPJRVHONCO(this ObjectNetworkId a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8466400", Offset = "0x8465800", VA = "0x188466400")]
		public static bool MFNQPRLBHBO(this Guid a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class ASYFOOHRRMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x844C9C0", Offset = "0x844BDC0", VA = "0x18844C9C0")]
		public static GOMKIGGGEKL IAFKJHOAUDG(this ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x844CA50", Offset = "0x844BE50", VA = "0x18844CA50")]
		public static LGFWOCXQZYC World(this ObjectLocalId id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x844C770", Offset = "0x844BB70", VA = "0x18844C770")]
		public static EntityManager CCPMMFHJJYI(this ObjectLocalId a)
		{
			return default(EntityManager);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x3026990", Offset = "0x3025D90", VA = "0x183026990")]
		internal static bool NVTHEGTZUJE<a>(this ObjectLocalId a, bool b) where a : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x844C880", Offset = "0x844BC80", VA = "0x18844C880")]
		public static bool EPGDYWFQADN(this ObjectLocalId a, NetworkProperty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x3026690", Offset = "0x3025A90", VA = "0x183026690")]
		public static bool ITOKGJIBKDA<b>(this ObjectLocalId a) where b : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x3026450", Offset = "0x3025850", VA = "0x183026450")]
		public static bool EYNPHUVBRSY<c>(this ObjectLocalId a) where c : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3027250", Offset = "0x3026650", VA = "0x183027250")]
		[MustUseRefValueWithoutStoring]
		internal static NativeArray<T> UHVRFEGNHEN<T>(this ObjectLocalId a, Allocator b) where T : struct, IBufferElementData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3026170", Offset = "0x3025570", VA = "0x183026170")]
		[MustUseRefValueWithoutStoring]
		public static T BZQMDXDVDQR<T>(this ObjectLocalId a) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3025D60", Offset = "0x3025160", VA = "0x183025D60")]
		[MustUseRefValueWithoutStoring]
		public static d BYAIZVAQGDX<d>(this ObjectLocalId a) where d : struct, IComponentData
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3026C30", Offset = "0x3026030", VA = "0x183026C30")]
		public static bool QDEJMHMXRCR<e>(this ObjectLocalId a, [Out] e b) where e : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3026FB0", Offset = "0x30263B0", VA = "0x183026FB0")]
		public static f RIFUZQASROQ<f>(this ObjectLocalId a) where f : struct, IComponentData
		{
			return (f)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3026B90", Offset = "0x3025F90", VA = "0x183026B90")]
		public static g NVYILRRXFWN<g>(this ObjectLocalId a) where g : class, IComponentData
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class MMCCEFLZVDV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[DefaultMember("Item")]
	public struct EntityRemapArray : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NativeObjectLocalIdArray src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x630D8F0", Offset = "0x630CCF0", VA = "0x18630D8F0")]
		public EntityRemapArray(NativeObjectLocalIdArray src, NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x844DF60", Offset = "0x844D360", VA = "0x18844DF60")]
		public LocalId GIHNQFFXBSD(LocalId a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x844DFA0", Offset = "0x844D3A0", VA = "0x18844DFA0")]
		public LocalId GIHNQFFXBSD(int a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x844DEF0", Offset = "0x844D2F0", VA = "0x18844DEF0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LQPODEPWEIZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OTSMZCAANWU(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DNJLGROEMQW(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PQWQXZQSOAT(ObjectLocalId a, uint b);

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KVWKGDGIQRE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string UKBHYNMJXXU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AAECQRAPBUW(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HYIXFKFOJFL(ObjectLocalId a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void APXUTQRUTYS(ObjectLocalId a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MPMUIZRKMRK
	{
		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		Guid BGIPDSVJTLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		Guid FBASZMZLCUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BSNKUWQPCLF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task KHQYJRRBGPX(RRObject a);

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Guid WWWVQMPOGWE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PNIAAXSWRWP(ObjectLocalId a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QEXKPNWLPHV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task ZFCYPZLYZYS(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TIVLKSTUFTH(ObjectLocalId a, ObjectNetworkId b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KYVNZPJAVDO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		Guid BGIPDSVJTLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MRIEGCJHQTI(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YTULLSVUPOS
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeObjectLocalIdArray ESIXIJNABMB(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeObjectLocalIdArray PCLSULKRGWU(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EHEZIHIHMFF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MHSLWGTWTRD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BRTWIOQTCGJ(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JGGKNWRBMCA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MDLGMWNJHXU(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId UIUCZJPQSAZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MNTKIVESTNT(NativeObjectLocalIdArray a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DCNAQCECGEK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ZTCIUZDQZBI(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int GUHCLFDTZZZ();

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void STAOFBUBAKO(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PWUPVFQBAGE
	{
		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ObjectLocalId, ObjectLocalId> QSXLWTRVPKA;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ObjectLocalId, ObjectLocalId> JESUTPSVDXE;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<ObjectLocalId, ObjectLocalId, ObjectLocalId> BHAKKCNTLUY;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ObjectLocalId> KYSWFTUYCFV;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PIVNJWDHTWI(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ObjectLocalId SWGLSFKFMVS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray TPOPGKKQDIH(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ObjectLocalId DAKGZFAQSSY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void URVFHXPWKUS(ObjectLocalId a, Vector3 b, Quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void WCOYCDRELUF(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool SMUFUWTILDJ(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool ROJAXVGZJFR(ObjectLocalId a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 TILNDNNDXFR(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "17")]
		quaternion BOAUDHSEYQC(RRObjectConnectable a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class LWRJZESPXOS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DZDRTWBPGRG
	{
		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		object JINIOFGWLPE
		{
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PPOJYMYMBDY
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BDKZRBXIPLW(ObjectLocalId a, PJZRIAFFLPE b);

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WSVVKNYQUQF(PJZRIAFFLPE a);

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BDHTLVVUSHV(ObjectLocalId a, [Out] PJZRIAFFLPE b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface RIJCQQICXBM
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CNHPCZZJHIZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeArray<ObjectLocalId> PCLFYNYZCOF();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Flags]
	public enum DescendantFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		IncludeSelf = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IncludeChildren = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		IncludeDescendants = 6,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		IncludeMask = 7,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Disembodied = 8,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Embodied = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IgnoreEmbodiment = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		EmbodimentMask = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Runtime = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Authored = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		AuthoredAndRuntime = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		HierarchyMask = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		HintInputsAreDisjoint = 0x80
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface OAMPTGKUKZW
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public ref struct SnapPointPreviewInformation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public ReadOnlySpan<ObjectLocalId> MyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ReadOnlySpan<ObjectLocalId> NearbyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public ObjectLocalId ProposedSnapPointSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ObjectLocalId ProposedSnapPointOther;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IEYPHWPGEOR(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HVPAZETXQUR(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UNCLWDGZLJV(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OECKEOAGANO(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PPQVYYYKQHC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GZDWBNPKIYA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId JHPOUYLFXMS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ReadOnlySpan<ObjectLocalId> DHDORGUHKHK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ReadOnlySpan<ObjectLocalId> GHXVGAGHMQN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SnapPointPreviewInformation VSMTECPNTJJ(ObjectLocalId a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FXMORYVIUVR(ObjectLocalId a, [Out] ElementGroupStatusData b);

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VHBTJDRPJJH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MCZFDMKUYDO(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public readonly struct GameConfig<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDF8C0", Offset = "0x4EDECC0", VA = "0x184EDF8C0")]
		public GameConfig(T defaultValue, [Optional][CallerMemberName] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Obfuscation(ApplyToMembers = false)]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GameConfig<int> UGKZSCZMKRW;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GameConfig<int> BXAZQBTQYDG;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GameConfig<int> UTVZURALQJE;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum GameConfigState
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Enabled,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Indeterminate
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class OLUTSCKJLQV
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1227D50", Offset = "0x1227150", VA = "0x181227D50")]
		public static bool IsEnabled(this GameConfigState state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x163D270", Offset = "0x163C670", VA = "0x18163D270")]
		public static bool YCDSEDRZLAG(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2F6C460", Offset = "0x2F6B860", VA = "0x182F6C460")]
		public static bool PXNBMMKMYAB(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1227D60", Offset = "0x1227160", VA = "0x181227D60")]
		public static bool SLPGJMGGGWO(this GameConfigState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FENBCGLKXBE
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Unloaded,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Loading,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			Loaded,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public enum EditReadyPreference
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			NeverEditReady,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			AlwaysEditReady
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		State GJZGMYSWVHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		bool QFDTENETOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool KYLWYHZGZVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		EditReadyPreference TCIXKSODPFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZERWNOTTOVS
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		GameConfigState PJNLFBJJUWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		GameConfigState TYMKZKXVUEL
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		GameConfigState EUAZPTZHGUE
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		GameConfigState FTEAEFKGRLB
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		GameConfigState RSOKTGXHMHI
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		GameConfigState BGHHYJCVNGW
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		GameConfigState QCEACCTJVTG
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		GameConfigState YLMAUWFEMEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		GameConfigState HCBUGOQNVLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		GameConfigState RMLTWACOSBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		GameConfigState TIKVYNFJAVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		GameConfigState RVYREUNOOTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		GameConfigState CIIMRFKZCXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		GameConfigState JMMVODTHOMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		GameConfigState BKONWPMCYLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		GameConfigState VQMTPVVNWME
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		GameConfigState XPWYITHFLBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		GameConfigState TYSTUMNVVXP
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		GameConfigState NUQGMKNOBGG
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		GameConfigState GLGVWATVAGY
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Get(GameConfig<int> config);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GYGFXJBKLMH
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event HRYRTUYFKQN.ParentsChangedCallback COCRUOZESBT;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId WONVXSFBTXE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NativeObjectLocalIdArray OBXFINBGPDN(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FractionalIndex JLUKGWNBEHW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LAZEBICOLUP(IEnumerable<ObjectLocalId> a);

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FractionalIndex Move(ObjectLocalId parent, ObjectLocalId src, bool isBefore, ObjectLocalId target);

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId QZSTEMVIJIO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SetParent(ObjectLocalId localId, ObjectLocalId parent, bool worldPositionStays = false);

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KBDINHJWCCY(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CELMBTOVBGD(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[Obsolete("Use IHierarchyService.GetChildren() instead")]
		NativeObjectLocalIdArray RZOFBDZFVPM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool BXNMANKLBGF(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NativeObjectLocalIdArray LJUAZMDESXI(NativeObjectLocalIdArray a, DescendantFlags b, Allocator c);

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool GGXRLINRNGD(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ObjectLocalId WMIMHUMWBUY(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool WYTPNOUYECP(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ObjectLocalId TYGSBECHLVU(ObjectLocalId[] a);

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId CNBZFGGAIRR(ObjectLocalId a, uint b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class BCMUFIZUJRM
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x844D510", Offset = "0x844C910", VA = "0x18844D510")]
		public static bool WPVPLREWLPM(this GYGFXJBKLMH a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x844D1C0", Offset = "0x844C5C0", VA = "0x18844D1C0")]
		public static NativeObjectLocalIdArray LJUAZMDESXI(this GYGFXJBKLMH a, ObjectLocalId b, DescendantFlags c, Allocator d)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x844D490", Offset = "0x844C890", VA = "0x18844D490")]
		public static NativeObjectLocalIdArray RZLCTGXHGGO(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x844D580", Offset = "0x844C980", VA = "0x18844D580")]
		public static NativeObjectLocalIdArray ZVGONNRYUPB(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x844D450", Offset = "0x844C850", VA = "0x18844D450")]
		public static NativeObjectLocalIdArray NLAUYNIULXQ(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x844D4D0", Offset = "0x844C8D0", VA = "0x18844D4D0")]
		public static NativeObjectLocalIdArray TWFNXDGNSTN(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x844D020", Offset = "0x844C420", VA = "0x18844D020")]
		public static NativeObjectLocalIdArray BTUEASBEOAN(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x844D180", Offset = "0x844C580", VA = "0x18844D180")]
		public static NativeObjectLocalIdArray BZGRHPWTRIL(this GYGFXJBKLMH a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x844D060", Offset = "0x844C460", VA = "0x18844D060")]
		public static NativeObjectLocalIdArray BZGRHPWTRIL(this GYGFXJBKLMH a, NativeObjectLocalIdArray b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZVJVNZNPIPZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x8466300", Offset = "0x8465700", VA = "0x188466300", Slot = "0")]
		Task<RRSceneLoadOperation> LoadMain(SerializedDataWrapper serializedDataWrapper, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "1")]
		void CWFETDVXQFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface NYHEUDSDETG
	{
		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event HRYRTUYFKQN.ParentsChangedCallback COCRUOZESBT;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId QZSTEMVIJIO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ReadOnlySpan<ObjectLocalId> TYLNHBVKJYI();

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ReadOnlySpan<ObjectLocalId> FQKVCRWELJP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YPWKCBRYAFU(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MAYEUSUFXLP(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TCTYPUJYYDD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KBDINHJWCCY(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FractionalIndex PFEUAPYXAVO(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LZYDIMTSOON
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		bool QVDGCLFXSPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		bool OIKBHKUVHMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ZFPNEXUNIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GMLYNBGGYXZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BPQDCBJGDLZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BRJISPBLPXG(ObjectLocalId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KHXUYGZPKCL(ObjectLocalId a, NetworkProperty b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface YUPBBDTSNSP
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RentedArray<string> IJERGXLEHYG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RentedArray<string> DIYSUSTTIZZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EOVKAIWQELZ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MVEPBTLZTWG(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool XUXDFLUVQCD(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KSDPPWMWOYZ
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		InteractionFilterMode BEUQPTAYGWT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AIHSKULSSED(ObjectLocalId a, InteractionFilterMode b);

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VYTQBUFABDD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LAMLQJVNSQB(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RentedArray<string> WCJWOQQPHKN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YCANGKWUBUV(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RentedArray<string> CIAXKBYXHEL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OVETYCHYDEX(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RentedArray<string> AEDBGPVOAIJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WGXTZIDBMPH(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RentedArray<string> OPZREDAWBUT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void UGGDNQAIITF(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool KIQQXLLJPIT(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FPSLQYSQYMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast([In] float3 origin, [In] float3 direction, float maxDistance, [Out] RayIntersection intersection, [Out] ObjectLocalId spline);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OverlapSphere([In] float3 origin, float radius, List<ObjectLocalId> localIds);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KGYXKEBTQNX(Plane[] a, float3 b, float3 c, quaternion d, List<ObjectLocalId> e);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FIUHVVEHUMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Raycast([In] NativeArray<Entity> entities, [In] float3 origin, [In] float3 direction, [In] NativeArray<RayIntersection> outRayIntersections);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeList<Entity> OverlapSphere([In] NativeArray<Entity> entities, [In] float3 origin, float radius);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NativeList<Entity> KGYXKEBTQNX([In] NativeArray<Entity> entities, [In] NativeArray<float4> frustumPlanes);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public struct PhysicsSceneColliderHandle : XWGLIIDUFIP, IEquatable<PhysicsSceneColliderHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC240", Offset = "0x2DAB640", VA = "0x182DAC240", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x2DAC250", Offset = "0x2DAB650", VA = "0x182DAC250", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x8452E10", Offset = "0x8452210", VA = "0x188452E10", Slot = "8")]
		public bool Equals(PhysicsSceneColliderHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8452E60", Offset = "0x8452260", VA = "0x188452E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct RayIntersection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float3 normal;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OJJNCTNFPBT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LNGQTCAXYFX
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		GOMKIGGGEKL IAFKJHOAUDG
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		ObjectServiceHandle OPKUEZDEOEY
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		int MFOOFOKUONS
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		int NVIFRZONTDL
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		int SPINUMUEFWB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		int AREWAZFCIGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		int YRNWKYSDWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<NativeObjectLocalIdArray, NativeArray<RRObjectPrefabData>> ZDMYGEGUCNU;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<NativeObjectLocalIdArray> MRAYUVCBQVM;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray KBDNPVEASPR();

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ObjectType LCYZWNOAZAF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RRObjectPrefabData AFVPFZAZTMU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TBARCMIQLLO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "15")]
		RRObject Embody(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool AUJINBPXPEJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool VTVXKUOCPBR(ObjectLocalId a, [Out] Transform b);

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId KVABRUWIHOM(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool UZPHSSMLZPH(ObjectNetworkId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "20")]
		ObjectNetworkId PYVEBZUXNIZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		NativeObjectLocalIdArray KVABRUWIHOM(NativeArray<ObjectNetworkId> a, Allocator b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool TFQJIRHGPZL(NativeArray<ObjectCreationData> a, NativeArray<ObjectNetworkId> b, NativeArray<Entity> c, RentedArray<CJOKLWFVVZO> d);

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "23")]
		RRObject DAFCFLNRMKQ();

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RRObject CreateObject(RRObjectPrefabData prefabType, [Optional] CreationInstantiationParameters instantiationParameters);

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RRObjectContainer ZZFDUUGWGIR();

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RRObjectShapeSpline WSMOKYBYQZB();

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RRObjectShapePrimitive TQNDTBAMUSD(PrimitiveShapeType a);

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void AGMZAPCLNKF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void ZYOGEARWKUI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool HFXYUQNFGFY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		NativeObjectLocalIdArray QJHURVGNMRE(NativeObjectLocalIdArray a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool Exists(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool ZFJZNLDIICW(ObjectLocalId a, ComponentTypeSet b);

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ObjectLocalId XYYMEFWJUAP(Transform a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class VUUMEXYMSLQ
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8466030", Offset = "0x8465430", VA = "0x188466030")]
		internal static ObjectLocalId KNGMWDSPCHJ(this Entity a, LNGQTCAXYFX b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8466190", Offset = "0x8465590", VA = "0x188466190")]
		public static RRObject OEAFQRSQJIN(this LNGQTCAXYFX a, LocalId b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x84660E0", Offset = "0x84654E0", VA = "0x1884660E0")]
		public static ObjectLocalId KVABRUWIHOM(this LNGQTCAXYFX a, LocalId b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x84661A0", Offset = "0x84655A0", VA = "0x1884661A0")]
		public static ObjectNetworkId PYVEBZUXNIZ(this LNGQTCAXYFX a, LocalId b)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8465CA0", Offset = "0x84650A0", VA = "0x188465CA0")]
		public static RRObjectContainer CDUOZJNMEIF(this LNGQTCAXYFX a, RigidTransform b)
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8465E80", Offset = "0x8465280", VA = "0x188465E80")]
		public static RRObjectShapePrimitive IWJBWONCBGL(this LNGQTCAXYFX a, PrimitiveShapeType b, RigidTransform c)
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8465AF0", Offset = "0x8464EF0", VA = "0x188465AF0")]
		public static RRObjectShapeSpline ABFRTTTLFGX(this LNGQTCAXYFX a, RigidTransform b)
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8465E50", Offset = "0x8465250", VA = "0x188465E50")]
		private static void DSCCNCOBRFX(RRObject a, RigidTransform b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal interface LFNCOETRNBO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LOCSQWGPZIX
	{
		[Cpp2IlInjected.Token(Token = "0x17000210")]
		bool DSGFPTKJIFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		ObjectLocalId WNZEGAKFSQU
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		RRObject XQAABNVVNBL
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event ScopeChangedEventHandler TJAJDRAEPLE;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId WMIMHUMWBUY(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool WYTPNOUYECP(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GAXSCBQSCJM();

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void TBTMJJANVGG();

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool HENDZNKZVJJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool SIJSHXIWPJU(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate void ScopeChangedEventHandler(RRObject oldScope, RRObject newScope);
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class AZQRMQBNSHR
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x844CEC0", Offset = "0x844C2C0", VA = "0x18844CEC0")]
		public static bool HDDEDDTFGYN(this LOCSQWGPZIX a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x844CD60", Offset = "0x844C160", VA = "0x18844CD60")]
		public static bool DGQRCSULKAK(this LOCSQWGPZIX a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x844CE40", Offset = "0x844C240", VA = "0x18844CE40")]
		public static bool GGQBPZVBPJN(this LOCSQWGPZIX a, ObjectLocalId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KYVDUWZOVKY
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZIUPTBTQLPY(NativeList<RRObjectPrefabData> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZSFTDSWKISY
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SGLJLGSELAZ(RRObject a, ReferenceGroupKind b, List<RRObject> c);

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int QCEAWGWOPFO(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NIJCOXRWSOU(RRObject a, List<RRObject> b);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int SNBKMDXQDXR(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRObject OUDDTPBUIJG(RRObject a, int b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HQZDSJUAASL(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MKXCDLEBAUB(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NJZXERBIQWW(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool UJMDMNIYLSA(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TRKWNOWOHIT(Entity a, Entity b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QAAALGKFAAT(Entity a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ROOTAPCVGFO(RRObject a, ReferenceGroupKind b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GQERUNFMZGW
	{
		[Cpp2IlInjected.Token(Token = "0x17000213")]
		RRScene GRZRWHIFQOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NetworkCreatorId SMGSYMKHFEX(RRScene a);

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRScene CDVZSWTVJSU();

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRScene UUKLEAMIZYE();
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HYBBZABLQFR
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FDPHDYBYSLB(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MFCMLTFJRWM
	{
		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<ObjectLocalId> GKIRIPGWSOD;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FEIOGEZSDQT(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WKOOUJLKRSR(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JQEVPPMPJCV(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LKIUSZVOLVR
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ObjectLocalId> HMBAZUAEVSL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ObjectLocalId SMLWHLGYORX(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MIYYMUPYZGT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SplineParameters EAUAYESZWUC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZNKVCJNRKNE(ObjectLocalId a, SplineParameters b);

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId HRXPEURUZII(ObjectLocalId a, [Optional] float3? b, [Optional] quaternion? c, [Optional] float3? d);

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId YBXGWOGKNOX(ObjectLocalId a, int b, [Optional] float3? c, [Optional] quaternion? d, [Optional] float3? e);

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YTPFUMSOUNH(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PKTKICBOXJE(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OPPBATKJUIO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface OGNQEMRTGWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VFZXEABMHJU(ObjectLocalId a, ReadOnlySpan<TerrainGenerationLayer> b);

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NQUSBSYENPL(ObjectLocalId a, ReadOnlySpan<TerrainCustomMaterialLayer> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OELRROPTMWT
	{
		[Cpp2IlInjected.Token(Token = "0x17000214")]
		bool XQPZYZZPRFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZSMHCMLEKQH();

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZEKLEULJNTG();

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JFDXZQZACLK();

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LDSEFJBJDVP();

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FBDZRMQBXQL();

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TEHIKXASXBU();

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UDVHBUDDHAI();

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GLORMNRQAQU();

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void FBAFJCTNKIQ();

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DBRKUGOISOC();

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void HNBQCGVTQHZ();

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MPEJKAKJBSY();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EGEDLXCDTXG
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HMNHURORSNW(ObjectLocalId a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WOEURSWMIYJ(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ForceCleanup(ObjectLocalId target, bool forceImmediate);

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SYEQBSYDMXO(ObjectLocalId a, float b, float c, float d);

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool FSSQGPWCISM(ObjectLocalId a, [Out] float b, [Out] float c);

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JEZXKZVCXJV(ObjectLocalId a, float3 b, quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ISASCTZRXPM(ObjectLocalId a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AFCJWTLZXVR(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GFLRQANDFVQ
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetLocalPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float3 JDKOLPLNCAG(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLocalRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "3")]
		quaternion QVHOWIPVPVN(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OEKDKFNQBGM(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SCBTAQKGIMI(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QZNFNCFHPYL(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LORXQQAMGSP(Entity a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LORXQQAMGSP(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PYARRQNWCET(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float TNHBWMILJEL(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SetWorldPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "12")]
		float3 MWQWDZHFOEJ(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void SetWorldRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		quaternion GQPLNCUBENS(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GPKRALGBHIA(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float ZVQKIXGIOFO(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void WISESQJGYWI(Entity a, [Out] float4x4 b);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void HFOLXDKLXNC(Entity a, [In] float4x4 localToWorld);

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void NotifyTransformParentChanged(Entity entity);

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void WJKLUPOWKPR(Entity a, Entity b, Entity c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class EPDVLFCHJVO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GAMMXNOZWXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QTMDEUEBHTE(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OPCHQLYRCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XXRIAOZEWPQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XKYWZMZCAFC(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NVOPHVMIVCM(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PFBKMCZGKHU(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VGFPHDRXUTX(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TRKHHSRGMGP(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int BSHMNRQIDUD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int FTVOXQWYLUG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int BBXEKGNUGWI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		PATPBQUPMIT<string> TGWDZXEIMLM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool MBIFQSZUQSU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		PATPBQUPMIT<string> ZIZFUPMVLTG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool GLLKODESDWP(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void MYXGTISTDDN(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectLocalId XKOTPPLLUES(string a);

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void LYRJOPRQPFK(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void PFBCRDMTCEZ(ObjectLocalId a, string b, NativeObjectLocalIdList c);

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		PATPBQUPMIT<string> IKIEUZTQRIT();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public static class COTDLTPDJVK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface TMSXUGQMWTT
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "0")]
		World SRHWKJOQGTT(string a = "Main");

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "1")]
		World OYXGXTQZJOW(string a = "Shadow");

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "2")]
		World IWYSGSNFXLT(string a = "Deserialization");

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "3")]
		World MBIDXHQCKZY(string a = "Serialization");
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LGFWOCXQZYC
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		World SFBZAYUJXOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		World KJUJHFFBXIO
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		EntityManager CCPMMFHJJYI
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		bool FTNBLRPOGMU
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ComponentSystemBase HYYPNRCJTSL(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public static class BEXTNJJOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x844D5C0", Offset = "0x844C9C0", VA = "0x18844D5C0")]
		public static ComponentSystemBase CDSXZOBJWQP(this World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x3361530", Offset = "0x3360930", VA = "0x183361530")]
		public static a HYYPNRCJTSL<a>(this LGFWOCXQZYC a) where a : ComponentSystemBase
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WIFIEZGGGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ATBOQMDKAAU(NativeListAsync<Entity> a);

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBAEVLWXYCX(CollisionIslandGeneratorState a);

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UMFLCCIEYEM(NativeListAsync<Entity> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UPRXUGRAHNY();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LJMFNTXQQRN(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface LSQSDFJISSL
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SPUKCAGPAGY(Collider a, [Out] ObjectLocomotionSettings b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZDFDFJCUSTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Collider QXKEXKALJDY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject ZPNWTMGGJET(ObjectLocalId a, GameObject b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RWVCWROWTCV(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "3")]
		a THMGPBWFMBP<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VUVEMQPWQSJ(Collider a);

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject AFYTRJTBLJP<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		BOQSKSJCOID TBCREXGHLMC(ObjectLocalId a, ObjectLocalId b, PrimitiveShapeType c, float3 d, quaternion e, float3 f);

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GYMQFZPXFYO(ObjectLocalId a, [Out] BOQSKSJCOID b);

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LYZWVUAMULY(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Sphere,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		CapsuleX,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		CapsuleY,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		CapsuleZ,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SBBKFEIPZJV
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		public struct ShapePrefab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int shapeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public GameObject prefab;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OFKRGMCKKOF(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d);

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CRPHIBIWPFH(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ETFGMCSJWEW GSDGYCJNEKT(ObjectLocalId a, List<ObjectLocalId> b);

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BOQSKSJCOID WCJCNQZNLWY(GameObject a, GameObject b);

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LZMLXWIDDCI(GameObject a, List<GameObject> b);

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FWSHHVPPTNE(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "6")]
		a THMGPBWFMBP<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VUVEMQPWQSJ(Collider a);

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GameObject PFGGTCQTQEH<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool QINVAWUTLZM(Collider a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IVREEFOEFBE(ObjectLocalId a, [Out] ObjectLocomotionSettings b);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<ColliderType> AWCDHBRAOQY(Allocator a = Allocator.TempJob);

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Mesh[] POMUNQBXUOC();
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface TGMRTUQFOJR
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JGRLELRKPON(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MVKDYJAGDFC(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int XATKRSZGMMX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ObjectLocalId HNEJLTSOARG(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NativeObjectLocalIdArray JXWIDCJMKRA(ObjectLocalId a, Allocator b = Allocator.Temp);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VCMBXKCDNLA(ObjectLocalId a, object b, ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MJDREXZBVFB(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NTQLNTHYEFV(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NPPXZSEZCWF(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool UHIIOLLYUXH(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DETLYDEQTFY(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool RIWCZOEPVCC(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void QBNBEOLCPAR(ObjectLocalId a, (Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool MCNLSJPZWJQ(ObjectLocalId a, [Out] quaternion b, [Out] float3 c);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YWHNWYEMBKB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
		float3 KYYUOUJPXBH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 AZEDZZUUBRU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void SFWGOUNYAJU(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void NPXIALXDAFF(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		float VBNLTWFQLXI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "20")]
		float XKUZQGYHUDP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void WBQPGMPOQLT(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void BINFJGPKMIS(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CollisionDetectionMode IRMSJVNYNBW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void BMXJTUQRBDO(ObjectLocalId a, CollisionDetectionMode b);

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "25")]
		TransformTrackRate FATQGMBUHON(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ZJCYIJWQWTL(ObjectLocalId a, TransformTrackRate b);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool MMYPKVGYRFX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void EVXLIFVHDTP(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "29")]
		ObjectLocalId WONVXSFBTXE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void TQBLWHMVRWK(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ObjectLocalId QZSTEMVIJIO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetParent(ObjectLocalId localId, ObjectLocalId value);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		RbexInterpolationMode YXKNKOFYKSY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void HLJKHYVWCRO(ObjectLocalId a, RbexInterpolationMode b);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool NQWYKIPJNZL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void APLBOLSDSMF(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool YERMAHMVCPC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void DUHZGVYOYIM(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		RigidbodyConstraints KGJSJEZVEKL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void SDXGCONPTMP(ObjectLocalId a, RigidbodyConstraints b);

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		float DCNIQPOQPRO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void LPIYALUGUHK(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		float RFLXJMLPMIK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void MYNJXUJVFHE(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool JIPDEXYHGIZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void NRUPVPKNELX(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool LCQTZOQLLCA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void SPGDUWRMAXO(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void VKVYENYYWVS(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		VDZYKGMLTUT TJXMDENXMIQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void KFPDEXWPDYY(ObjectLocalId a, VDZYKGMLTUT b);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		HBNPYSELDYW NVOSOYZVIYP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void ZYTRPJCFNTZ(ObjectLocalId a, HBNPYSELDYW b);

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		float LNQHBHJPGFX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void DQONUHVWQSR(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void UISGWQOHUVA(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void OKHEKKRVQPV(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		bool HJAGRQXZZJG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void VGATEUYFFXI(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void FTCATUBADCN(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		bool PATOOGLTBNQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		bool PXCKYBWNWJC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		Rigidbody IWUVKXBUNXH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void LANECBXCNWF(ObjectLocalId a, Rigidbody b);

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void LBTTOIQEHMV(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void UQNEFILOZIE(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "67")]
		bool KKJSIFDLLVX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void XRJNTQMYEJU(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void CVPYPSHZZDK(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool SPOFFEUFXOV(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool GUZKXUCJOHJ(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "72")]
		bool EJXMOZGYWKD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void CZWQQMYYAFK(ObjectLocalId a, object b, bool c);

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void GWMVKWDNHLS(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void OBGKYCNJHFI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "76")]
		bool RCZBGLSWAAV(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface UZBMEJNJUAV
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ETGZFRABPTF(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JRELSWHKIVT(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SFOYGOGQLBB(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KDKEUALAXZV
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CXKWRQUZPNI(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public delegate void BulkPropertyChangeCallback(BulkPropertyChangeData propertyChangeData);
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public readonly ref struct BulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly NativeObjectLocalIdArray objectIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly NativeArray<byte> prev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly NativeArray<byte> curr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly int propertySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Type propertyType;

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public NativeObjectLocalIdArray FUAMVJGXPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x412F330", Offset = "0x412E730", VA = "0x18412F330")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x844D730", Offset = "0x844CB30", VA = "0x18844D730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public NetworkProperty FPQWNIOTCZB
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4020", Offset = "0xAD3420", VA = "0x180AD4020")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x844D750", Offset = "0x844CB50", VA = "0x18844D750")]
		public BulkPropertyChangeData(NativeObjectLocalIdArray objectIds, NativeArray<byte> prev, NativeArray<byte> curr, NetworkProperty property, int propertySize, Type propertyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x3419DC0", Offset = "0x34191C0", VA = "0x183419DC0")]
		public NativeArray<a> WSZFOWOAEDB<a>() where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x3419CE0", Offset = "0x34190E0", VA = "0x183419CE0")]
		public NativeArray<b> LDWESRKFBHJ<b>() where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x3419AC0", Offset = "0x3418EC0", VA = "0x183419AC0")]
		public (NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>) Get<T>() where T : struct
		{
			return default((NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x47F39A0", Offset = "0x47F2DA0", VA = "0x1847F39A0")]
		public ObjectIdBulkPropertyChangeData OKIKPVOAOMZ()
		{
			return default(ObjectIdBulkPropertyChangeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface DMJRVFLDVIQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		string MSLIKGUUVSC
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		DMJRVFLDVIQ DXLUWXKGCUB
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		IEnumerable<DMJRVFLDVIQ> AVFDFAOBGVS
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface SSWQSTIQGVL
	{
		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		DMJRVFLDVIQ NBLZIRXPDIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		NativeArray<NetworkProperty> CNQLHFIUWMC
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BAVFYVSGEHS(NetworkProperty a, [Out] DMJRVFLDVIQ b);

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SHWXSEAJSCT(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WUGNLHLOTAM(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface UKAHPGQWKTI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SHWXSEAJSCT(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WUGNLHLOTAM(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class LFQCNOVXTII
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZBLNVVVSLGF
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		bool LVNPMASPSVF
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		ReplicationData SEDUSRHGJRC
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LOHAAHHHFIP(NetworkCreatorId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QFOAZHUVPWU(ObjectNetworkId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XGYNWAZJMZZ(NativeArray<ObjectNetworkId> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class RUUOLOYJSBZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public readonly ref struct ObjectIdBulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly BulkPropertyChangeData data;

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public NativeObjectLocalIdArray FUAMVJGXPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x412F330", Offset = "0x412E730", VA = "0x18412F330")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x84512A0", Offset = "0x84506A0", VA = "0x1884512A0")]
		public ObjectIdBulkPropertyChangeData(BulkPropertyChangeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8451170", Offset = "0x8450570", VA = "0x188451170")]
		public NativeObjectLocalIdArray WSZFOWOAEDB()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8451040", Offset = "0x8450440", VA = "0x188451040")]
		public NativeObjectLocalIdArray LDWESRKFBHJ()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8450D50", Offset = "0x8450150", VA = "0x188450D50")]
		public (NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray) Get()
		{
			return default((NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class DAAVWRGOVVL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public readonly struct ReplicationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly NativeBitArray bitArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly NativeParallelHashMap<ObjectNetworkId, int> bitOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly NativeParallelHashSet<NetworkCreatorId> denyCreatorIds;

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public bool JURDEVILHTU
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x84655D0", Offset = "0x84649D0", VA = "0x1884655D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public bool LVNPMASPSVF
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x84653D0", Offset = "0x84647D0", VA = "0x1884653D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x84655F0", Offset = "0x84649F0", VA = "0x1884655F0")]
		public ReplicationData(NativeBitArray bitArray, NativeParallelHashMap<ObjectNetworkId, int> bitOffsets, NativeParallelHashSet<NetworkCreatorId> denyCreatorIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8465400", Offset = "0x8464800", VA = "0x188465400")]
		public bool QFOAZHUVPWU(ObjectNetworkId a, NetworkProperty b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface RQXJVWCHGME
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		OutlineEffectType CUMSCZQTLEX
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface JWIZMKKQBVY
	{
		[Cpp2IlInjected.Token(Token = "0x17000227")]
		int VYYPFRYCRTI
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		int SNEXTAOYUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SGKZXTMJAQX(ObjectLocalId a, MutableRef b);

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle JTMFTVTWSDF();

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RootHandle DBZDTHSQCKW();
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PPSPAXFXRPV
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SXWGIVODGJX(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ENHODVILUVN(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ComponentSystemBase DHDVQTSXXTU(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QCGWRZGIDZQ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NDQALEMXWYJ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PPWGWRVMTQQ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VFASYRZLAGF(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeParallelHashSet<ComponentTypeIndex> HGCEYUYASWM();
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HYXBHRXVTRO
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XQYWSORHKNK(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public readonly struct BulkInstantiationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly IEnumerable<InstantiationRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly IReadOnlyList<GameObject> instantiations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly IReadOnlyList<int> requestIndexByInstantiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly IReadOnlyList<(ObjectNetworkId, ObjectNetworkId)> srcDstNetworkIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int rootCount;
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public struct InventionParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public InventionIdData id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public InventionInstanceIdData instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool overwriteIdData;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x844EB20", Offset = "0x844DF20", VA = "0x18844EB20")]
		public InventionParameters(long id, Guid instanceId, bool overwriteIdData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RKFUIJSWYLU
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RRSceneLoadOperation RDMJOJQOINA(SerializedDataWrapper a, int b = 0, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRSceneLoadOperationSubgraph PTWNEYXQOGA(SerializedDataWrapper a, ObjectLocalId b, [In] UniformTRS parentFromWorldTransform, ANIBKCUTPIF c, [Optional] InventionParameters d, bool e = true, bool f = false, bool g = false, bool h = false);

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DOMZLDOXQKA NXNOBRYZWXX();

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DOMZLDOXQKA WTFAOCUTQSF(NativeObjectLocalIdArray a, [In] UniformTRS serializedSceneFromCommonParentOfSerializedRoots, [Optional] ANIBKCUTPIF b);

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KALXIRBNVJJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RLUEGWILOMZ(ObjectLocalId a, [Out] Exception b);

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NativeArray<ObjectNetworkId> OXSJELZDXXJ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeArray<ObjectNetworkId> KVZZPAXUVEW(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(Slot = "8")]
		NativeObjectLocalIdArray CHDXHWDFLTW(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NativeObjectLocalIdArray TAQCHMBUUOJ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray MGGWBVISJKB(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<EntityRemapUtility.EntityRemapInfo> LMKMZQKZBAQ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool URPEZJYMNNI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int TVQKZEZZGMY(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HXMSWNWJIXV
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xC7AF10", Offset = "0xC7A310", VA = "0x180C7AF10", Slot = "0")]
		bool WNIWTQLPHSC(object a, WYHSPCAVTMD b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class BYHZALHIXIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x844D650", Offset = "0x844CA50", VA = "0x18844D650")]
		public static bool WNIWTQLPHSC(this HXMSWNWJIXV a, object b, [Out] WYHSPCAVTMD c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public enum GamePropertyKey : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		MaxPlayers = 255,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		IsVisible = 254,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		IsOpen = 253,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		PlayerCount = 252,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Removed = 251,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		PropsListedInLobby = 250,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		CleanupCacheOnLeave = 249,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		MasterClientId = 248,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		ExpectedUsers = 247,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		PlayerTtl = 246,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		EmptyRoomTtl = 245,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		HasDedicatedMaster = 87
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public interface WYHSPCAVTMD
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		NetworkEventType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		PlayerId GQNZJUUOZCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		bool BBANKANJADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		bool GDUFDCSHGND
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object VGYXWVDDEMS();

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OQKLXIJKRSY([Out] PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "6")]
		(PlayerId, object) GVOHCAUYGOU()
		{
			return default((PlayerId, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "7")]
		(ObjectNetworkId, PlayerId) HZSXJEERPMY()
		{
			return default((ObjectNetworkId, PlayerId));
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "8")]
		GOLWLRVZMXJ<(ObjectNetworkId, PlayerId)> DLMANOQPZJR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "9")]
		(OutOfBandMessageType, byte[]) SVIRYWTTEVN()
		{
			return default((OutOfBandMessageType, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "10")]
		(PacketSource, byte[]) AOWYSGZARHK()
		{
			return default((PacketSource, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0", Slot = "11")]
		a LNMLXVWBCMZ<a>()
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public static class TSGNVPRAHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x8465850", Offset = "0x8464C50", VA = "0x188465850")]
		public static bool PREWJTMDUUI(this WYHSPCAVTMD a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public interface PAORAJAOPEB : GOLWLRVZMXJ<NetworkTransformSyncData>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface GOLWLRVZMXJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		int WFHQKHTXLMO
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public enum NetworkEventType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		BulkInstantiate = 1,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		BulkDestroy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		OMSendPacket = 4,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		RR_OutOfBandMessage = 5,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		RR_FastForwardMarker = 6,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		RR_SelfJoinMarker = 7,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		RR_DebugOp = 10,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		RR_CachedEvent = 11,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RRRoomRequestEvent = 20,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RRRoomRequestFailedResponseEvent = 21,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		RRBufferedRoomEvent = 22,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		RRClearBufferedRoomEvent = 23,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RR_CreationOp = 24,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		RR_CreationOpResponse = 25,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		RR_CreationOp_Unchecked = 26,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		RR_MasterLockBlockComplete = 27,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		RR_NetworkSynchronization = 28,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		RR_NetworkInstantiate = 29,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		RR_BulkInstantiate = 31,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		RR_Destroy = 32,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		RR_BulkDestroy = 33,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RR_TransferOwnership = 34,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		RR_OwnershipUpdate = 35,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RR_RPC = 36,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		RR_JoinRequest = 100,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		RR_JoinResponse = 101,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RR_RoomUpdate = 102,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		RR_PlayerUpdate = 103,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RR_RemotePlayerJoined = 104,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		RR_RemotePlayerLeft = 105,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		RR_Leave = 106,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		RPC = 200,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		SendSerialize = 201,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Instantiation = 202,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		CloseConnection = 203,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Destroy = 204,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		RemoveCachedRPCs = 205,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		SendSerializeReliable = 206,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		DestroyPlayer = 207,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		OwnershipRequest = 209,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		OwnershipTransfer = 210,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		VacantViewIds = 211,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		OwnershipUpdate = 212,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		AuthEvent = 223,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		LobbyStats = 224,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		AppStats = 226,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Match = 227,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		QueueState = 228,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		GameListUpdate = 229,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		GameList = 230,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		CacheSliceChanged = 250,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		ErrorInfo = 251,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		PropertiesChanged = 253,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Leave = 254,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Join = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public enum OutOfBandMessageType : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None = 0u,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		NetworkTransformInitializationData = 1314146628u,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		RestoreCreationData = 1380140064u,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		OldestCachedPacketId = 1329811529u,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		SnapshotPublished = 1397773634u,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		SnapshotPayload = 1397771332u,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		SnapshotClear = 1129337683u,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		RequestNetworkTransformInitialization = 1380865097u
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public static class EWKMKIWUFZU
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x844DE80", Offset = "0x844D280", VA = "0x18844DE80")]
		public static ObjectNetworkId NCUAINSNCND(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x844DEB0", Offset = "0x844D2B0", VA = "0x18844DEB0")]
		public static ObjectNetworkId TELBKDIQHOP([In] this ObjectNetworkIdComponentData data)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x828A930", Offset = "0x8289D30", VA = "0x18828A930")]
		public static ObjectNetworkId ECTEJKTYHMC(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x828A930", Offset = "0x8289D30", VA = "0x18828A930")]
		public static ViewId CCLOPYLHELF(this ObjectNetworkIdComponentData a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x844DC20", Offset = "0x844D020", VA = "0x18844DC20")]
		public static FixedString64Bytes GCLKSZTMCCD(this NetworkCreatorId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x844D990", Offset = "0x844CD90", VA = "0x18844D990")]
		public static FixedString64Bytes FSIOKUCQWQC(this ObjectNetworkId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x844DDF0", Offset = "0x844D1F0", VA = "0x18844DDF0")]
		public static FixedString32Bytes GCLKSZTMCCD(this Entity a)
		{
			return default(FixedString32Bytes);
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IACOVWVSRWJ : HDUADJJBHEG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public enum OpCode
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		End,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Destroy,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		SetProp,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface APAKMFNBAVV
	{
		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<object> AJZEOLAZCDT;

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "2")]
		void HLOZWQRXUFP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "3")]
		void UTHUTPYIWWT(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		void WQPWHICUONR(OutOfBandMessageType a, ReadOnlySpan<byte> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GXZMXRJOKYB
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PacketSource WRGTCIJTRJC(ReadOnlySpan<byte> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NFLNVFYPGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UGYUGOVCWIR(PacketSource a, ReadOnlySpan<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XONETNVMYNB(ReadOnlySpan<PacketSource> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public struct Chunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PacketSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ReadOnlyMemory<byte> payload;
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public struct PacketSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static PacketSource SnapshotPacketSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public NetworkCreatorId creatorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int packetId;

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public static NetworkCreatorId EGMSHRMNTLS
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x8452C10", Offset = "0x8452010", VA = "0x188452C10")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x52ED5F0", Offset = "0x52EC9F0", VA = "0x1852ED5F0")]
		public PacketSource(NetworkCreatorId creatorId, int packetId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8452CF0", Offset = "0x84520F0", VA = "0x188452CF0")]
		public static bool ZWISVWGZSLY([In] PacketSource lhs, [In] PacketSource rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8452AA0", Offset = "0x8451EA0", VA = "0x188452AA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8452BA0", Offset = "0x8451FA0", VA = "0x188452BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8452C60", Offset = "0x8452060", VA = "0x188452C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8452C00", Offset = "0x8452000", VA = "0x188452C00")]
		public void HYZXLOOBRHM([Out] NetworkCreatorId a, [Out] int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class OUVDHCLPIPC
	{
	}
}
namespace RecRoom.ObjectModel.Interop
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public struct InstantiationRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector3 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int photonViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CreationInstantiationParameters parameters;

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x844EA00", Offset = "0x844DE00", VA = "0x18844EA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public enum DeserializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Scene,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		SubgraphAdditive,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		SubgraphRestore,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		RestoreCreationData,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		InventionPreview
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public static class HUOAXYIAOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x844E710", Offset = "0x844DB10", VA = "0x18844E710")]
		public static bool IDJMSAJROIU(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x844E740", Offset = "0x844DB40", VA = "0x18844E740")]
		public static bool ZECTBOABRVQ(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x844E730", Offset = "0x844DB30", VA = "0x18844E730")]
		public static bool KPQWLSOESQC(this DeserializationOperationType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[Flags]
	public enum DeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		ParseProtobuf = 1,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		PostInstantiate = 8,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		NotifyInstantiated = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		DisposeProtobuf = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NotifyCompleted = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		WorldPhasesClient = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		WorldPhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		AdditivePhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		RestoreCreationData = 0x2B
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public interface ANIBKCUTPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BDCPKCPVLJK([In] Guid src, [Out] Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Flags]
	public enum WorldDeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Parse = 1,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PostInstantiate = 0x18,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		LoadCompleted = 0x60,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		All = 0x7F
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public interface DOMZLDOXQKA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000230")]
		PIZSXRPSMYA QLDZKRETLYO
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ByteString NZZLBUFCANK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public enum SerializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		World,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Subgraph
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
	public struct LocalBoundsData : ICleanupComponentData, IComponentData, IEquatable<LocalBoundsData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public float3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float3 extents;

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x844EC60", Offset = "0x844E060", VA = "0x18844EC60", Slot = "4")]
		public bool Equals(LocalBoundsData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BCPOFSWQQOV
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ReadOnlySpan<ObjectLocalId> QTLBSLCQGJF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GMEGQBRLTSH(ObjectLocalId a, [Out] ObjectLocalId b);
	}
}
namespace RecRoom.ObjectModel.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface AGLWZXASSNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZBUDBDYMQJM(long a);

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ATGFGBDZPQC(NativeParallelHashSet<long> a);

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PKFRMIROHLS(World a, NativeParallelHashMap<Guid, long> b);

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CNZAKHJXBLN(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool SJSBDHCTUTS(ObjectNetworkId a, [Out] Guid b, [Out] long c);

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ALRXHNAICOL(ObjectNetworkId a, Guid b, long c);

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool VHLUXQMZGCC(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool YOCDGVWPEML(Guid a, [Out] int b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WXHWOMOJAKA(Guid a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void FVEBLPHSDZB(Guid a);
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
