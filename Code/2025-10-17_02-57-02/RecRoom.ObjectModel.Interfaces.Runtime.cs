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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class ZFXGPLLYWZU
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
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	public ZFXGPLLYWZU()
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
		[Cpp2IlInjected.Address(RVA = "0x86CF2B0", Offset = "0x86CD8B0", VA = "0x1886CF2B0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class OJXJWXFQLSF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86D1540", Offset = "0x86CFB40", VA = "0x1886D1540")]
		public static void GKLQYWCZBHS(this Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86D1410", Offset = "0x86CFA10", VA = "0x1886D1410")]
		public static void GKLQYWCZBHS(this Rigidbody a, Vector3 b, Quaternion c, Vector3 d)
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
			private readonly SAOUEARSLXZ objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x86CE840", Offset = "0x86CCE40", VA = "0x1886CE840", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x86CE580", Offset = "0x86CCB80", VA = "0x1886CE580", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x51F22E0", Offset = "0x51F08E0", VA = "0x1851F22E0")]
			public Enumerator(SAOUEARSLXZ objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x86CE4B0", Offset = "0x86CCAB0", VA = "0x1886CE4B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x86CE660", Offset = "0x86CCC60", VA = "0x1886CE660", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x86CE730", Offset = "0x86CCD30", VA = "0x1886CE730", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D0620", Offset = "0x86CEC20", VA = "0x1886D0620", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x86D06A0", Offset = "0x86CECA0", VA = "0x1886D06A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int KNORUAWIBJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x86D0240", Offset = "0x86CE840", VA = "0x1886D0240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JYNGXFGZZJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x86CFDA0", Offset = "0x86CE3A0", VA = "0x1886CFDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<LocalId> IRBMFWFNLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D072D0", Offset = "0x2D058D0", VA = "0x182D072D0")]
			get
			{
				return default(NativeArray<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal NativeArray<Entity> GQHEAGAPHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86D0060", Offset = "0x86CE660", VA = "0x1886D0060")]
			get
			{
				return default(NativeArray<Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86D04E0", Offset = "0x86CEAE0", VA = "0x1886D04E0")]
		public NativeObjectLocalIdArray(int capacity, SAOUEARSLXZ objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86D04D0", Offset = "0x86CEAD0", VA = "0x1886D04D0")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86D0460", Offset = "0x86CEA60", VA = "0x1886D0460")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<Entity> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86D0590", Offset = "0x86CEB90", VA = "0x1886D0590")]
		internal NativeObjectLocalIdArray(SAOUEARSLXZ objects, NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86D03F0", Offset = "0x86CE9F0", VA = "0x1886D03F0")]
		internal NativeObjectLocalIdArray(SAOUEARSLXZ objects, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86D0290", Offset = "0x86CE890", VA = "0x1886D0290")]
		public NativeObjectLocalIdArray(SAOUEARSLXZ objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86D0340", Offset = "0x86CE940", VA = "0x1886D0340")]
		public NativeObjectLocalIdArray(NativeObjectLocalIdArray existing, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86CFB20", Offset = "0x86CE120", VA = "0x1886CFB20")]
		public void CopyTo(List<ObjectLocalId> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86CFE20", Offset = "0x86CE420", VA = "0x1886CFE20")]
		public void EFTSJPBLYUG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86CFA80", Offset = "0x86CE080", VA = "0x1886CFA80")]
		public NativeObjectLocalIdArray Clone(Allocator allocator)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86CFF30", Offset = "0x86CE530", VA = "0x1886CFF30")]
		public Span<ObjectLocalId> IZEQZQFULOQ()
		{
			return default(Span<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86D00C0", Offset = "0x86CE6C0", VA = "0x1886D00C0")]
		public NativeObjectLocalIdArray JZROOLUQHCP(int a, int b)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86CFDE0", Offset = "0x86CE3E0", VA = "0x1886CFDE0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86CFE70", Offset = "0x86CE470", VA = "0x1886CFE70")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86D01D0", Offset = "0x86CE7D0", VA = "0x1886D01D0", Slot = "6")]
		private IEnumerator<ObjectLocalId> SOOARQVTPZU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86D0160", Offset = "0x86CE760", VA = "0x1886D0160", Slot = "7")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class BUGJOHXYQVK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3616410", Offset = "0x3614A10", VA = "0x183616410")]
		public static RentedArray<a> RZRBIQEXMUQ<a>(this NativeObjectLocalIdArray a) where a : UnityEngine.Component
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
			private readonly SAOUEARSLXZ objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x86CE770", Offset = "0x86CCD70", VA = "0x1886CE770", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x86CE530", Offset = "0x86CCB30", VA = "0x1886CE530", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x51F22E0", Offset = "0x51F08E0", VA = "0x1851F22E0")]
			public Enumerator(SAOUEARSLXZ objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x86CE4F0", Offset = "0x86CCAF0", VA = "0x1886CE4F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x86CE5D0", Offset = "0x86CCBD0", VA = "0x1886CE5D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x86CE6F0", Offset = "0x86CCCF0", VA = "0x1886CE6F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SAOUEARSLXZ objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NativeList<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x86D1170", Offset = "0x86CF770", VA = "0x1886D1170", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x86D1280", Offset = "0x86CF880", VA = "0x1886D1280", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x86D1010", Offset = "0x86CF610", VA = "0x1886D1010", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x86D1010", Offset = "0x86CF610", VA = "0x1886D1010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NativeList<LocalId> IRBMFWFNLHN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF80", Offset = "0xBBC580", VA = "0x180BBDF80")]
			get
			{
				return default(NativeList<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86D10F0", Offset = "0x86CF6F0", VA = "0x1886D10F0")]
		public NativeObjectLocalIdList(SAOUEARSLXZ objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86D1060", Offset = "0x86CF660", VA = "0x1886D1060")]
		public NativeObjectLocalIdList(SAOUEARSLXZ objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86D0C40", Offset = "0x86CF240", VA = "0x1886D0C40")]
		public NativeObjectLocalIdArray JGYONLDRSWJ()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86D0780", Offset = "0x86CED80", VA = "0x1886D0780", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86D07C0", Offset = "0x86CEDC0", VA = "0x1886D07C0", Slot = "13")]
		public bool Contains(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86D0840", Offset = "0x86CEE40", VA = "0x1886D0840", Slot = "14")]
		public void CopyTo(ObjectLocalId[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86D0700", Offset = "0x86CED00", VA = "0x1886D0700", Slot = "11")]
		public void Add(ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86D0B70", Offset = "0x86CF170", VA = "0x1886D0B70", Slot = "7")]
		public void Insert(int index, ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86D0E70", Offset = "0x86CF470", VA = "0x1886D0E70", Slot = "15")]
		public bool Remove(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86D0AF0", Offset = "0x86CF0F0", VA = "0x1886D0AF0", Slot = "6")]
		public int IndexOf(ObjectLocalId item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D0E20", Offset = "0x86CF420", VA = "0x1886D0E20", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86D0A20", Offset = "0x86CF020", VA = "0x1886D0A20", Slot = "18")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86D0A60", Offset = "0x86CF060", VA = "0x1886D0A60")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86D0F30", Offset = "0x86CF530", VA = "0x1886D0F30", Slot = "16")]
		private IEnumerator<ObjectLocalId> SOOARQVTPZU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86D0D40", Offset = "0x86CF340", VA = "0x1886D0D40", Slot = "17")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface APCWCRYRQHU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ObjectLocalId FNOZEFBECYF(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface GKUMXSSCKRX : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WFLSYEQGAHP : JIIFIJDFNCD, BTOFDOWGUHY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		EDAGNEPUCRN DGOKCCKYFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		ObjectServiceHandle UJMIGLONFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BTOFDOWGUHY
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool YGAJUXDHCKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ARJGSUANVQC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IAOUYUCGUQZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface RUDQJVPTEKO
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool BEMCMFULFEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool TGQZZKXMOPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool DFLMWSZBPZY
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool TOSJWYOJFPL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool OAYKFMJNBNU
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
		bool DKFXCZPECOF(ByteString a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NBZBOYTSOAW();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NHQJTNSTIUN
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		XRIYJCZWKCD DGOKCCKYFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		MDHRGUOMCBL CMLBPXWYNGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		NSSZUZNBGHA BVGIESSZQGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		WFLSYEQGAHP SQPRCLFLRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		YDHGDYYXAPO OZMFTIHEYRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		RUDQJVPTEKO EJRYKFDCRNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		KOGIUQPMNTM WLOROVRWZOY
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		GSNDGRFYNAE ZEQBTJSJEKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		JKRXTVWXZLM YBHMLEGXRNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		MMTRKLJTBTD FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		HZYGZOVMKQX ISDLVWBODSM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		UTDJJZEXMJH IKRXSTBPQXS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		VHASDORTCFJ XDZXJNOLBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		CRUWWEPXMPT XXDLBDNZGJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		IZKJXUTETSZ TAAGRKYSTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		IIJDQCNASRO IADCKUXGZZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		DOWDGXIAQIF FQVQRCDSMYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		BGQZNSSZVHM RGSJMQTIZED
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		XHOFCQVELXK BOBSCKIIEJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		WFPLTSWUEQQ NAKFOZYJPYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		CTTCFIGDGAR QQRHBMQZVQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		PFBVKPLATCK LCHJXIAVSSC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		OSCHYGYXUZY BFJXBBNQOFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		LWIGPBJZGAB JMMFYHHNLMS
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		MIMNXURAIYR CIJIACFQMYV
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		ZXYDVJEPOUG IMLTTRZKIUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		YCOHKLSVTYA NSUGERVXESZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		WCKDNWDWHWY YXTYMYHSHWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		CXNQWDQLUPV KPWBMMSKTRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		EFJKQEFKKXE GGDVUSRXAGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		EKUIPXDCQIY ILVSHMSPLCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		QZRXMKBROTY NDVTXPAYGYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		EICJLSRXAJZ FRFKONOTEWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		PKCVCCBDLWS QJOYSEPOXBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		GEEMCYTPPOH JGEVPJLPFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		ZGZDWFKXWGS HULJWJWQJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		EWYECPRGJGJ XNBXAHYMJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		FEJMQOCLGZK KNVPOENMXDN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		ZMWNPDHDBTV SRHMTKZMIWM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DebuggerTypeProxy(typeof(QKVQWSJNUYL))]
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
		public SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public WFLSYEQGAHP SQPRCLFLRYA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x86D2480", Offset = "0x86D0A80", VA = "0x1886D2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public LocalId XGZZUOQYMGC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x86D1D20", Offset = "0x86D0320", VA = "0x1886D1D20")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal ObjectServiceHandle UJMIGLONFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x86D2150", Offset = "0x86D0750", VA = "0x1886D2150")]
			get
			{
				return default(ObjectServiceHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool SAOTFGOFIJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x86D2160", Offset = "0x86D0760", VA = "0x1886D2160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool NGDUWBWCIWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x86D23B0", Offset = "0x86D09B0", VA = "0x1886D23B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86D2570", Offset = "0x86D0B70", VA = "0x1886D2570")]
		public ObjectLocalId(SAOUEARSLXZ objectSystem, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86D24E0", Offset = "0x86D0AE0", VA = "0x1886D24E0")]
		public ObjectLocalId(ObjectServiceHandle handle, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
		public RRObject UBJYMSZOVMT()
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86D2630", Offset = "0x86D0C30", VA = "0x1886D2630")]
		public static implicit operator LocalId(ObjectLocalId objId)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86D2670", Offset = "0x86D0C70", VA = "0x1886D2670")]
		public static implicit operator Entity(ObjectLocalId objId)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86D2030", Offset = "0x86D0630", VA = "0x1886D2030")]
		public static bool HCJGUXGANNO(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86D2400", Offset = "0x86D0A00", VA = "0x1886D2400")]
		public static bool VSCIXNKBWNJ(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86D2280", Offset = "0x86D0880", VA = "0x1886D2280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E60", Offset = "0x86D0460", VA = "0x1886D1E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86D1D60", Offset = "0x86D0360", VA = "0x1886D1D60", Slot = "4")]
		public int CompareTo(ObjectLocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "5")]
		public bool Equals(ObjectLocalId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class VUDGBKFTMUV
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86E6FA0", Offset = "0x86E55A0", VA = "0x1886E6FA0")]
		public static ObjectNetworkId PQWRQADVFBB(this ObjectLocalId a)
		{
			return default(ObjectNetworkId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class QKVQWSJNUYL
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
		private static SAOUEARSLXZ defaultObjectService;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static WFLSYEQGAHP defaultObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static SAOUEARSLXZ[] objectServices;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static WFLSYEQGAHP[] objectModels;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static Stack<byte> freeHandles;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public WFLSYEQGAHP SQPRCLFLRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x86D3370", Offset = "0x86D1970", VA = "0x1886D3370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public SAOUEARSLXZ ZEDTWTXCSHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x86D3290", Offset = "0x86D1890", VA = "0x1886D3290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86D34F0", Offset = "0x86D1AF0", VA = "0x1886D34F0")]
		static ObjectServiceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2D56040", Offset = "0x2D54640", VA = "0x182D56040")]
		internal ObjectServiceHandle(byte value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7572570", Offset = "0x7570B70", VA = "0x187572570", Slot = "4")]
		public bool Equals(ObjectServiceHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86D26C0", Offset = "0x86D0CC0", VA = "0x1886D26C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x110F250", Offset = "0x110D850", VA = "0x18110F250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86D2E80", Offset = "0x86D1480", VA = "0x1886D2E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86D2DE0", Offset = "0x86D13E0", VA = "0x1886D2DE0")]
		private static SAOUEARSLXZ PBEWFZEKCLQ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86D3450", Offset = "0x86D1A50", VA = "0x1886D3450")]
		private static WFLSYEQGAHP ZYEQTKXRJSQ(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86D3120", Offset = "0x86D1720", VA = "0x1886D3120")]
		private static object VWROVQGZXKK(byte a, object[] b, object c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86D26B0", Offset = "0x86D0CB0", VA = "0x1886D26B0")]
		private static int DVIWDFHMVFC(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86D2DD0", Offset = "0x86D13D0", VA = "0x1886D2DD0")]
		private static int MXWWWVJKWII(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86D2D50", Offset = "0x86D1350", VA = "0x1886D2D50")]
		private static (int, int) LIASUZMNRGG(byte a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86D3280", Offset = "0x86D1880", VA = "0x1886D3280")]
		private static byte WBAILBAFRCP(int a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86D2AB0", Offset = "0x86D10B0", VA = "0x1886D2AB0")]
		internal static ObjectServiceHandle KQPXXDZDTRT(WFLSYEQGAHP a, SAOUEARSLXZ b)
		{
			return default(ObjectServiceHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86D2F30", Offset = "0x86D1530", VA = "0x1886D2F30")]
		internal static void VJDYMFSHNXM(ObjectServiceHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86D2760", Offset = "0x86D0D60", VA = "0x1886D2760")]
		private static void FIFKEPDRVWK(int a)
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
	public interface PAFABALJKZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool CEYSJZWWJXT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool QATCOPOYNSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool MKGHAPKAUYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool DWMJADRBFEU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool ZKBKWLZIUKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface RJTVTVPRSXE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JWGJDNARNGL(PLMLAZBVVSK a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OLEPBUXVECS(PLMLAZBVVSK a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LZUDFFEYLQT(XXSWOYRBGLQ a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface OWKLXWVKWVX : PLMLAZBVVSK, PAFABALJKZR
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		int LLMWVAOHWEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FRPMHDXNIBX(VOVIQUBDVFU a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface PLMLAZBVVSK : PAFABALJKZR
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
		bool CFTBBNEWNLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool FWNZPGXZRAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool EUZSNEHZEVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface VOVIQUBDVFU
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool GYZWXGGGHRL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		PrimitiveShapeType LUEUYUIEGJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		RRTCZGNBILW PXUCFIEWHTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		float3 DSBMUQQWNYH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		quaternion VBLUIXJXMKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		float3 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		RenderableMaterial PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RenderableColor HHPEXJZUJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		float AZLZTQGKHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		float3 JKCYYQVJBGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		float GMIALSEFPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ShapeConfigFlags IYREEORWVFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface VZYYOMUWBPY
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		float3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		float3 RTMVMDHZWKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		quaternion MQHSIQNSUKN(float3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface RRTCZGNBILW
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool FXRBVFKMFOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool RWVOODLDRJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool LVBHKBNKMKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		float CWOZQLHMEND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		int FTJRLOHGVNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		int VGOEAVABCPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PXZYFRPRLSS(VZYYOMUWBPY a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public class ENJPVONXFKY
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ENJPVONXFKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RRDJTMUVVHD
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Guid YLKNFQNVNKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task UXYFCCZGXNL(Guid a, Guid b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task PKKYFVWSMZU(Guid a, Guid[] b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid GDFCMYOJAMN(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task HOKCXWVDDKZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QISNLUKAQQE(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HMZCCNDEQPS(HGNNCTYYPGW a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void EAONYMDVDON(Guid a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QMKEZFCOZCA(Guid a, ObjectNetworkId b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XBTTNKBURQG(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ZCZJLSXMUEU(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UVGKJNAZQHQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PQBOBCPSFSC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "0")]
		void IEOYFDJUBEX(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MDHRGUOMCBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		PQBOBCPSFSC KTBLWDJJYSS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		MNHFXHHAFMV VKCMRYKCTHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		VHXTHHIQODK AZELNYFNGCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		TLVYHOLCIGC QSJBBZZNVSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		QKAPHQYONNA LVGXDMTOVYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		YZETNVXBHEN AJMBHMFIEKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		PYMUMZEADNF NJNBTJGVRJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		EXMJULBPWUU GEGGSQBQPJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MNHFXHHAFMV
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		string MBJJHWUEUOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LFZNCJWMNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FETXHHVRRJE(Action a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MVULATBVEBB(string a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int NBKKJJNMVWN(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PMWGUQWBAZN([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TINFIQXYLPY([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RCCIEXDYTFI([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SKVWFTXGLEN([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VHXTHHIQODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "0")]
		void FDALKTVGBSV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TLVYHOLCIGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		protected static readonly Guid EYNGNWIETSR;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		static readonly Guid JXMQXXTHQVG;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		static readonly Guid PWVWQUWIDXS;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		static readonly Guid SVQICBRCSNG;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		bool VVRQBUAESSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool DONNGCPHTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		bool GRJQTMDDJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool TZHEUSVWEVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x86E6AD0", Offset = "0x86E50D0", VA = "0x1886E6AD0", Slot = "4")]
		string[] XHQTEHSXWBE(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NBLLBFWMTNW();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86E6AA0", Offset = "0x86E50A0", VA = "0x1886E6AA0", Slot = "6")]
		Guid ICUOICZOKDL(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int SXXBJHQRWLX(SerializedDataWrapper a);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BOBRITRSGAJ(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int DKHITWIKOXB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BWCCTPKLBPS(string a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		string RAUXRPIHYHH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool JGVZPRIZFJA(RRObjectPrefabData a, [Out] LocalId b);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RentedArray<byte[]> YQYSWBKDPHJ(NativeArray<ViewDescriptor> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void OQVYPDUEPCI(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GameObject EGCGJLGYSDA(string a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void XAZPRRFQTJZ(Transform a, RRObjectPrefabData b, RODATQHQXLX c);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool ZQNSPKVYBZO(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void DLYBUNELBNE(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "19")]
		void FWQZDAQUTQV(SerializedDataWrapper a, NativeArray<int> b, IMEKMSZAYDL<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MGGUPQUJVRN();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "21")]
		void NJPVVAYVXAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "22")]
		void XTHCKEVSCQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "23")]
		bool IDKVDHTISSS(SerializedDataWrapper a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "24")]
		RJTVTVPRSXE WUINUGUGJLY(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "25")]
		void NNUUTFGOERG(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "26")]
		bool MWHAUURAOPK(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x86E6B70", Offset = "0x86E5170", VA = "0x1886E6B70")]
		static TLVYHOLCIGC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LVJZCKCMYVG
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		long AQYUBIDLKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		long VNXBWVFEZTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "1")]
			get
			{
				return default(long);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QKAPHQYONNA
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		int XMXAXOCHKWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		int FSLGJJKUOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		int XAFLDETVPRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		bool UKVXOALQQRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		int EFRFNSNEUAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		void BOKPBJIPYEN(QKPLUTIPQBC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		void FRWICKNGKTH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "8")]
		bool MAUPZWFNKQV(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
		void YAYZNGADQSL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
		void SKGBALEJCDK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void AZBENTYXVQD(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void FZGJAJRZDBW(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
		void BMWGZODFCQS(NativeArray<ViewId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
		void JIVWPNKZNBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "15")]
		void RATUVEDAXEA(OutOfBandMessageType a, ReadOnlySpan<byte> b, PlayerId c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		void RATUVEDAXEA(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "17")]
		void RATUVEDAXEA(OutOfBandMessageType a, ReadOnlySpan<byte> b, ReadOnlySpan<byte> c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "18")]
		void KRSFYQXXAWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "19")]
		void QFZCQOHFJQM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "20")]
		void ROJYUOZQUQV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "21")]
		void HUDHRLDIVQA(Dictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "22")]
		void VEMLZIWJEYX(NativeList<ObjectNetworkId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "24")]
		void YSOTDJDUDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "25")]
		void JQQZCDDFVPK(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "26")]
		void HMXABJOURQA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "27")]
		void CFNECTYJAQJ(PlayerId a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "28")]
		void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "29")]
		void QAWGVRGTKHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class JJOAROJYPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86CF010", Offset = "0x86CD610", VA = "0x1886CF010")]
		public static NetworkPauseScope ZYCRGGQXUNS(this QKAPHQYONNA a, object b)
		{
			return default(NetworkPauseScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct NetworkPauseScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private QKAPHQYONNA dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object token;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86D1380", Offset = "0x86CF980", VA = "0x1886D1380")]
		public NetworkPauseScope(QKAPHQYONNA dependencies, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86D1330", Offset = "0x86CF930", VA = "0x1886D1330", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XNJLLINLFPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate void ApplyNetworkTransform(ViewId viewId, NetworkTransformSyncData syncData, int sender);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "0")]
		void Pause(ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "1")]
		void DTWORKFBIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "2")]
		void VNJCSOGXCKG(VMBFRJHVPND a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JPVJWLHREDC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface HLFEETEILQC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YPSCAHTUQQA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YZETNVXBHEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct LoadScreenScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private YZETNVXBHEN notifications;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x86CF1A0", Offset = "0x86CD7A0", VA = "0x1886CF1A0")]
			public LoadScreenScope(YZETNVXBHEN notifications, string title, string subtitle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x86CF0E0", Offset = "0x86CD6E0", VA = "0x1886CF0E0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct FadeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private YZETNVXBHEN notifications;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Task task;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x86CE910", Offset = "0x86CCF10", VA = "0x1886CE910", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "0")]
		void UJYNVHROWEZ(string a, float b = 5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "1")]
		void FHXXOBOVCYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TOBBBYZKDLI(bool a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "3")]
		void ADCDYFGPEJT(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class WTBROOLOBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86E7090", Offset = "0x86E5690", VA = "0x1886E7090")]
		public static YZETNVXBHEN.LoadScreenScope LWRFPZYJEYM(this YZETNVXBHEN a, string b, string c)
		{
			return default(YZETNVXBHEN.LoadScreenScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MALYIHATQAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LGJRRNQQYAT(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XBXHFXFIYOI(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool GVSMQDPNLER(int a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		object DAIMCGWOZLJ(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FLMDJIXQMQS(GameObject a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IXXFOLCMZMA
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		ESILARESUHZ RNHJKEQVNUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SZFUVYZIPQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UJFYTXUIXCX(NetworkCreatorId a, RolePermission b);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RZIDPXPROIZ(PlayerId a, AccountRoleTypeNetworked b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DPGXAJTZWEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KYZOGDONURM(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object Deserialize(NativeArray<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YRMJBOGBIJD
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool QTSGZHOKJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Delegate GXYUHRHFIUC(KXZTLOMYDMK a, Action<KXZTLOMYDMK> b);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OCDKCKLBHSL(KXZTLOMYDMK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Delegate NULJSVKZVPJ(KXZTLOMYDMK a, Action<KXZTLOMYDMK> b);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FAFHYIJZEXR(KXZTLOMYDMK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RYZUWNDXRMY(KXZTLOMYDMK a);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KXZTLOMYDMK QSPGUXOOTQG(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NXPBYZDUWHR
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		int FJAEXNJTZEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		int RVPGXIVMFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool QRBWESDINLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool VVVBWNHMCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId NBXKGBWUPGH(int a);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HRHFPCSESEH(GameObject a, JobHandle b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface ESILARESUHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool RNPDZOXGMQP(AccountRoleTypeNetworked a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PYMUMZEADNF
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool BEMCMFULFEY
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BUABRLVJUTT
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		VFTFGZTBLYG QCYBLHJHPGF
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		YAAJDYCRQCQ RXWYURKUPQX
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool ZUOVRZBACDT
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FWDZOMTWCVJ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DTGOIOBJGSP(Transform a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GIBKSWIRUYL(Transform a, OutlineEffectType b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EXMJULBPWUU
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FZWRXSRWKVC;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MMLUUHEVQFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DNLOVAHZLXY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VQFAJVFBIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JNNUXYZXHMH(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CZXNKMADEDY(ObjectLocalId a, bool b, float3 c, quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CIEATMDADZB(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EUKZZQFTEIV(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGHVMBKLKGB(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LQPTCWDCXHM(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VTJOBJUCPNN(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GGFKCREPDXD(QQYPBZHNRPK a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MBBAFGPBNFQ(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KVAPXHYWJLB(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HQVTMUXUOVN(ObjectLocalId a);
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
		[Cpp2IlInjected.Address(RVA = "0x86CF9D0", Offset = "0x86CDFD0", VA = "0x1886CF9D0")]
		public NativeArrayPinnedMemory(ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86CF9A0", Offset = "0x86CDFA0", VA = "0x1886CF9A0", Slot = "4")]
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
		public KPXFTPKFCPC.EditReadyPreference? loadEditReadyPreference;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A20", Offset = "0x86E5020", VA = "0x1886E6A20")]
		public SerializedDataWrapper(ByteString serializedOMData, [Optional] object persistenceViewData, [Optional] object connectableGraphData, [Optional] IEnumerable<string> legacyTags, bool isLatestDeprecatedVersion = true, [Optional] KPXFTPKFCPC.EditReadyPreference? loadEditReadyPreference)
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
		public Guid BHXVQGIEEYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5458290", Offset = "0x5456890", VA = "0x185458290")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool WDQJRVKSXEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x86E7080", Offset = "0x86E5680", VA = "0x1886E7080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool MZJEQSGBPDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x86E7070", Offset = "0x86E5670", VA = "0x1886E7070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool SOLSTZDAKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x86E7060", Offset = "0x86E5660", VA = "0x1886E7060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool KNJOSDZHQVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x86E7050", Offset = "0x86E5650", VA = "0x1886E7050")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CEBE0", Offset = "0x86CD1E0", VA = "0x1886CEBE0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E62A0", Offset = "0x86E48A0", VA = "0x1886E62A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E62A0", Offset = "0x86E48A0", VA = "0x1886E62A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CEB60", Offset = "0x86CD160", VA = "0x1886CEB60", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CEE40", Offset = "0x86CD440", VA = "0x1886CEE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WJIKZDNLNCK
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		SYDUYQNDTEP HYODHPLVJJW
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface HGNNCTYYPGW
	{
		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface DSJIEXIMQSE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class BFFXHGDTXXS
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x360ED70", Offset = "0x360D370", VA = "0x18360ED70")]
		public static RRObject UBJYMSZOVMT<a>(this a a) where a : HGNNCTYYPGW
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x86CD920", Offset = "0x86CBF20", VA = "0x1886CD920")]
		public static MonoBehaviour BYCRAZVVHOK(this HGNNCTYYPGW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86CD9A0", Offset = "0x86CBFA0", VA = "0x1886CD9A0")]
		public static GameObject GameObject(this HGNNCTYYPGW localId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface JJLTLBXLDBV : HGNNCTYYPGW
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectLocalId objectId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface BXWZVSLECNB : HGNNCTYYPGW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface SBMKBOGGRAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ParentsChangedCallback(ObjectIdBulkPropertyChangeData changeData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event ParentsChangedCallback TSTPLGAHHOP;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface DOCEXSZNLBR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface LTJLUSLDRAG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface GTKNBOMGRVX
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
		void OUNVIUEXTXM(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface CNVMLVLMNMG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRootRBEXChanged(RDQYEZMSIPZ newRootWithUnityRigidbody);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface RDQYEZMSIPZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		GameObject EAYEYPAFMJP
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		Transform FXOQWRPSRBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		RVJCLYOAPLX VUMSKOFRZNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool MACVPJFZWSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PYCXHFPABRM(RVJCLYOAPLX a);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RigidbodyExData GetData();
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class SNJSVHRKEXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86E66A0", Offset = "0x86E4CA0", VA = "0x1886E66A0")]
		public static void SREYNPBTOKE(this RDQYEZMSIPZ a, RODATQHQXLX b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface RVJCLYOAPLX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		Rigidbody VRSPXEIIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		RDQYEZMSIPZ WGZFOQFQUNM
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		GameObject OIIVGYXZJKR
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		Transform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		RVJCLYOAPLX VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		RVJCLYOAPLX KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		int HUHKTJRFZGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		bool NXIOQPKZSPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		GWZOVDSJQAJ ENBNSDCTZAO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		XTLAQFBHGWM NKUSKFWRICR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		float FPFKHWYFMQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "36")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		Vector3 GUXZBVKNDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "38")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Vector3 ZNYZYPOGLSI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		Vector3 MIZTDCUUJAT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "42")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		Vector3 NTQHGGLVDWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "44")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		bool KWFBGIOLEIB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool EHFCNEEPFCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "46")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool KUSDVIFWQSN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool DTONGYNCRVD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		Vector3 WVDERJFXLHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		Vector3 UUPZSHGJAQT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Vector3 JQMBINHTMOX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Vector3 ZNIPXSKVBVK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		float ZOGHTOAMTPW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		float NEVEOTWGTWL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "56")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		Vector3 KPNWERTDQVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		Quaternion BTMHZDZPTEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		float TFNROOJRIYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "61")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		float KRJDZBDSTUM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "63")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool UBADDGEUNTB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "65")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		TransformTrackRate LFJLPSMNURZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "67")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		bool XMOTNJSXNOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		Transform MYGXPCYGXQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		Vector3 IJHLHASXSDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(Slot = "71")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		float NDKFOHCPKUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "73")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		float LBPVVEIKGNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "74")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "75")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		Quaternion YLZSVHOHRDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "77")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		Vector3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "79")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Quaternion VZKKPJCUJMB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "81")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		RigidbodyConstraints UEXBILMUHCU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "83")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		bool OJIQCIDCODR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "85")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		CollisionDetectionMode IBRRXADKWGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(Slot = "87")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool DHOGBUZFGDA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RbexAction XBSNUORLFIY;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RbexAction JIJKHZKMUPE;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RbexAction LMQTYIKWJBV;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RbexAction LNDYYFCXCXA;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RbexAction MMRAAZNVBBN;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RbexAction REYSTJINLEW;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event RbexAction RLSMFOUTABP;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexParentChangeAction FZIHJZHWBZO;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UpdateLOD, UpdateLOD> JSASWVDUFKI;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RVJCLYOAPLX WGPJQHWBOJY(int a);

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void GIVGAKBJRFB((Quaternion rot, Vector3 moments) tensor);

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
		void SetParent(RVJCLYOAPLX value, bool isPhysicallyDetachedOnly = false);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void YSERHPILTAF(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void CLRHTBBQZTW(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "97")]
		Vector3 DNSNNGPNWBB(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "98")]
		Vector3 SPLSVTCBSAZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void TZTJZYFQYLU();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void IBMFXXKGQQT();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void FBWEYOMQCDY();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void EZGSSGBAMSW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "103")]
		void ZBUQCOEYNNB(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "104")]
		void QBLYPYRLXVE(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "105")]
		void KWVASTHJFQE(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "106")]
		void WIASDOLUIXD(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "107")]
		void FTIQBIMRMLI(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "108")]
		Vector3 GUDIQEGSVRZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "109")]
		Vector3 YXVODMJIFYF(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "110")]
		void ESINSQNCERM();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "111")]
		void LCIPSZVQGWY(RVJCLYOAPLX a, object b);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "112")]
		void AJWNTRARDIB(object a);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "113")]
		void VOLQCZQRAXX();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "114")]
		void ZYICHSWFPIK();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "115")]
		void UXEZXRLAETN();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "116")]
		bool GBLVPQIMCEV();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "117")]
		void WXNQIESLXQB();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "118")]
		void UQHHDEMYSNC(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "119")]
		void GNIPAXTFFRH(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "120")]
		void WDSUTKKKOXH(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "121")]
		void GCZLGOGFKEX(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "122")]
		void TRLKQMDOURJ(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "123")]
		bool WBTPNXYAYMW(float a);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "124")]
		void BPBHDMDYFJR(object a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "125")]
		void EKYPSVZFXZK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "126")]
		void XLEVRRHIHKP(object a);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "127")]
		void IWTOHCEWFXU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "128")]
		void ZHAAVPZLZNI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "129")]
		void UZTITFQJZGI(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "130")]
		void FUHXARLNTCR(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "131")]
		void UWZTPEUMPYV(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "132")]
		bool RHOKRHCVZQI(Vector3 a, [Out] RaycastHit b, float c);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "133")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface XTLAQFBHGWM
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class COKDHZKTBKX : XTLAQFBHGWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public COKDHZKTBKX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "0")]
		void XHRFUHMCTLT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "1")]
		void VTQEOLYPXRK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "2")]
		void NSAQYTOZGFG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "3")]
		void KAEZKZGXOEH(Vector3 a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface GWZOVDSJQAJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 QDEEGOZNVJD();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 OKEJMUWZDTS();

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IUSMPRUIDXJ(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void RbexAction(RDQYEZMSIPZ thisRigidbodyEx);
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
	public delegate void RbexParentChangeAction(RDQYEZMSIPZ thisRigidbodyEx, bool isPhysicallyDetachedOnly = false);
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
		public GameObject EAYEYPAFMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x86E4390", Offset = "0x86E2990", VA = "0x1886E4390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ObjectNetworkId FNLTWIMDPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x86E5110", Offset = "0x86E3710", VA = "0x1886E5110")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public ObjectType VRKNVOXXGVF
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x86E4F40", Offset = "0x86E3540", VA = "0x1886E4F40")]
			get
			{
				return default(ObjectType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public RRObjectPrefabData SPFOUOKQBOK
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x86E47F0", Offset = "0x86E2DF0", VA = "0x1886E47F0")]
			get
			{
				return default(RRObjectPrefabData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool XFUAWBPFTLT
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x86E4760", Offset = "0x86E2D60", VA = "0x1886E4760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool WAGCUVFBTNR
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x86E4680", Offset = "0x86E2C80", VA = "0x1886E4680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool GYZWXGGGHRL
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x86E4090", Offset = "0x86E2690", VA = "0x1886E4090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool WDEBDDLSYNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x86E4BD0", Offset = "0x86E31D0", VA = "0x1886E4BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool MLZRWWALHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x86E49F0", Offset = "0x86E2FF0", VA = "0x1886E49F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool USYBYHINCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x86E4A10", Offset = "0x86E3010", VA = "0x1886E4A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool MSWNUOULQFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x86E4190", Offset = "0x86E2790", VA = "0x1886E4190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool WEXBSHGXJHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x86E4640", Offset = "0x86E2C40", VA = "0x1886E4640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool FGWNKQGZVDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x86E4050", Offset = "0x86E2650", VA = "0x1886E4050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool FPCAAGXFFAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x86E40B0", Offset = "0x86E26B0", VA = "0x1886E40B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool SHRHWFRDEBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x86E4560", Offset = "0x86E2B60", VA = "0x1886E4560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool VMCZFZGCTSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x86E4A40", Offset = "0x86E3040", VA = "0x1886E4A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool OUJRFJPRUBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x86E4E80", Offset = "0x86E3480", VA = "0x1886E4E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool XGEGBOCVUIC
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x86E4780", Offset = "0x86E2D80", VA = "0x1886E4780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool VTJRXHVNWVW
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x86E4720", Offset = "0x86E2D20", VA = "0x1886E4720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool ERTVDMPUOFH
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x86E4B90", Offset = "0x86E3190", VA = "0x1886E4B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool JWQGCIETOUI
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x86E4520", Offset = "0x86E2B20", VA = "0x1886E4520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public RRObjectCircuitBoard MSCSSOLSFVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectCircuitBoard);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public RRObjectIdentity ILHYJJUUMFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectIdentity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RRObjectPhysics XDZXJNOLBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectPhysics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public RRObjectPlayerInteraction OMOHZKHWMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectPlayerInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RRObjectPolicy CZRZPFAJQXU
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectPolicy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public RRObjectReferenceGroup IWHQOOAXIAU
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectReferenceGroup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public RRObjectRenderEffects TEVJNVAFKZE
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectRenderEffects);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public RRObjectReplicatedObject IXGCFAJUFKW
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectReplicatedObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public RRObjectReplicator NKVSCVYEMQN
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectReplicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public RRObjectScope XXDLBDNZGJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectScope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public RRObjectToolCleanup OWWWGZCYLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectToolCleanup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public RRObjectUserTags EDUMUMYCZQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectUserTags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public RRObjectAIMetadata RITODPOFECX
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectAIMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RRObjectDeformable YDPNCJSZBTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectDeformable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public RRObjectObjectInteractionFilter KXNXSQQUYFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectObjectInteractionFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool TYZWNSNRPFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x86E42A0", Offset = "0x86E28A0", VA = "0x1886E42A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool YXDTULNDCQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x86E41D0", Offset = "0x86E27D0", VA = "0x1886E41D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool WFMEMATOOHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x86E4960", Offset = "0x86E2F60", VA = "0x1886E4960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool SAOTFGOFIJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x86E4A80", Offset = "0x86E3080", VA = "0x1886E4A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool UWIVBKWEJOU
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x86E4E40", Offset = "0x86E3440", VA = "0x1886E4E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool LMZYUPMLWHD
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x86E4DB0", Offset = "0x86E33B0", VA = "0x1886E4DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool KZUMEWQQMUM
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x86E4FE0", Offset = "0x86E35E0", VA = "0x1886E4FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public RRObjectTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RRObjectHierarchy FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator RRObject(ObjectLocalId objectId)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x86E4EC0", Offset = "0x86E34C0", VA = "0x1886E4EC0")]
		public RRObjectContainer XAKVVDQHSSL()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x86E46A0", Offset = "0x86E2CA0", VA = "0x1886E46A0")]
		public RRObjectShape LJCGVWKRJDD()
		{
			return default(RRObjectShape);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x86E4910", Offset = "0x86E2F10", VA = "0x1886E4910")]
		public RRObjectConnectable PSSBDIXLTHI()
		{
			return default(RRObjectConnectable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x86E47C0", Offset = "0x86E2DC0", VA = "0x1886E47C0")]
		public RRObjectPlayer OOBJGTQTRGF()
		{
			return default(RRObjectPlayer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x86E46D0", Offset = "0x86E2CD0", VA = "0x1886E46D0")]
		public RRObjectPlayerInteractionFilter MVSWBUPBDYO()
		{
			return default(RRObjectPlayerInteractionFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x86E4D60", Offset = "0x86E3360", VA = "0x1886E4D60")]
		public RRObjectStudioObject UGEALKMXKQN()
		{
			return default(RRObjectStudioObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x86E49A0", Offset = "0x86E2FA0", VA = "0x1886E49A0")]
		public RRObjectElementSnapPoint QQZRAXWCARY()
		{
			return default(RRObjectElementSnapPoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x86E5020", Offset = "0x86E3620", VA = "0x1886E5020")]
		public RRObjectElement XMRFYPREXHO()
		{
			return default(RRObjectElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x86E4DF0", Offset = "0x86E33F0", VA = "0x1886E4DF0")]
		public RRObjectTerrain UUMPDIHFUMJ()
		{
			return default(RRObjectTerrain);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x86E4A90", Offset = "0x86E3090", VA = "0x1886E4A90")]
		public void SIGHAZQNUWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x86E40F0", Offset = "0x86E26F0", VA = "0x1886E40F0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x86E5070", Offset = "0x86E3670", VA = "0x1886E5070")]
		public void XRWANGDZRCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x86E45A0", Offset = "0x86E2BA0", VA = "0x1886E45A0")]
		public bool GZBTXPRNIUQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x86E4BF0", Offset = "0x86E31F0", VA = "0x1886E4BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObject value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator ObjectLocalId(RRObject value)
		{
			return default(ObjectLocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x86D6B20", Offset = "0x86D5120", VA = "0x1886D6B20")]
		public static bool HCJGUXGANNO(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x86D2400", Offset = "0x86D0A00", VA = "0x1886D2400")]
		public static bool VSCIXNKBWNJ(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x86E4210", Offset = "0x86E2810", VA = "0x1886E4210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
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
		private EICJLSRXAJZ GWVTWFYQNIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x86D3F50", Offset = "0x86D2550", VA = "0x1886D3F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x86D3CC0", Offset = "0x86D22C0", VA = "0x1886D3CC0")]
		public void BDNPQFQZNZP(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x86D3DC0", Offset = "0x86D23C0", VA = "0x1886D3DC0")]
		public bool ERLFEZAXBMA([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x86D40D0", Offset = "0x86D26D0", VA = "0x1886D40D0")]
		public bool UYJHZIOMGYG([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x86D3FB0", Offset = "0x86D25B0", VA = "0x1886D3FB0")]
		public void TTGPXWMHJCY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x86D41D0", Offset = "0x86D27D0", VA = "0x1886D41D0")]
		[CanBeNull]
		public string VPCSFLUIVOU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x86D42E0", Offset = "0x86D28E0", VA = "0x1886D42E0")]
		public bool WORRTWCSBOT([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x86D4460", Offset = "0x86D2A60", VA = "0x1886D4460")]
		public void XHVOFZLBRLO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectAIMetadata(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x86D3EC0", Offset = "0x86D24C0", VA = "0x1886D3EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectAIMetadata other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private KOGIUQPMNTM SCFYNPFHRLR
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x86D4E80", Offset = "0x86D3480", VA = "0x1886D4E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		private EICJLSRXAJZ FRFKONOTEWC
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x86D4C40", Offset = "0x86D3240", VA = "0x1886D4C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool IHIGHRRFMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x86D4EE0", Offset = "0x86D34E0", VA = "0x1886D4EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool WZBLAAJMNVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x86D49C0", Offset = "0x86D2FC0", VA = "0x1886D49C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public bool YTBCTCZCEOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x86D4CA0", Offset = "0x86D32A0", VA = "0x1886D4CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Guid CECKUBPPUKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x86D48B0", Offset = "0x86D2EB0", VA = "0x1886D48B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Guid INANEINPBQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x86D4BC0", Offset = "0x86D31C0", VA = "0x1886D4BC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Guid DYWUQQHBMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x86D46A0", Offset = "0x86D2CA0", VA = "0x1886D46A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public RRObjectHierarchy FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x86D4600", Offset = "0x86D2C00", VA = "0x1886D4600")]
		public bool CCJOJYATCHM([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x86D4A00", Offset = "0x86D3000", VA = "0x1886D4A00")]
		public bool HRBKPZHRCYO([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x86D4D60", Offset = "0x86D3360", VA = "0x1886D4D60")]
		public void SBZBNMAQOLD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x86D4500", Offset = "0x86D2B00", VA = "0x1886D4500")]
		public void AREQYFZJFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x86D4AA0", Offset = "0x86D30A0", VA = "0x1886D4AA0")]
		public Guid KGOQICBZBKW()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectCircuitBoard(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x86D4930", Offset = "0x86D2F30", VA = "0x1886D4930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectCircuitBoard other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private JKRXTVWXZLM DRYXLSQCCSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x86D5420", Offset = "0x86D3A20", VA = "0x1886D5420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public Vector3 NVAMLUPWDZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x86D4F70", Offset = "0x86D3570", VA = "0x1886D4F70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public Quaternion XWZASDVWZFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x86D56F0", Offset = "0x86D3CF0", VA = "0x1886D56F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public RRObject JAYCKHOLHMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x86D5480", Offset = "0x86D3A80", VA = "0x1886D5480")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x86D5510", Offset = "0x86D3B10", VA = "0x1886D5510")]
		public NativeObjectLocalIdArray KOGQBYGRSXT(Allocator a)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x86D5650", Offset = "0x86D3C50", VA = "0x1886D5650")]
		public bool MCVPSETFJDY(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x86D5830", Offset = "0x86D3E30", VA = "0x1886D5830")]
		public void PFHQYSSMFSY(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x86D5280", Offset = "0x86D3880", VA = "0x1886D5280")]
		public void DKTVQURPEHR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x86D50C0", Offset = "0x86D36C0", VA = "0x1886D50C0")]
		public void DJIWBHCNNVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectConnectable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectConnectable value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator ObjectLocalId(RRObjectConnectable value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86D5390", Offset = "0x86D3990", VA = "0x1886D5390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectConnectable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private MMTRKLJTBTD LNJGINONLWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x86D59A0", Offset = "0x86D3FA0", VA = "0x1886D59A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
		public Span<RRObject> RMEPSDQKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x86D6030", Offset = "0x86D4630", VA = "0x1886D6030")]
			get
			{
				return default(Span<RRObject>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A00", Offset = "0x86D4000", VA = "0x1886D5A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x86D5FB0", Offset = "0x86D45B0", VA = "0x1886D5FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public RRObjectTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public RRObjectHierarchy FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x86D5B10", Offset = "0x86D4110", VA = "0x1886D5B10")]
		public void NSWPGGNTTUQ(RRObjectContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectContainer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectContainer value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A80", Offset = "0x86D4080", VA = "0x1886D5A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectContainer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
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
		private SBZBMFPSOBU wrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool isReadOnly;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public RRObject Object
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			[CompilerGenerated]
			readonly get
			{
				return default(RRObject);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		public CreationInstantiationKey this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x86D6450", Offset = "0x86D4A50", VA = "0x1886D6450")]
			readonly set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x86D6380", Offset = "0x86D4980", VA = "0x1886D6380")]
		internal RRObjectCreationParameters(RRObject obj, bool isReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x86D6130", Offset = "0x86D4730", VA = "0x1886D6130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA770", Offset = "0x3CE8D70", VA = "0x183CEA770")]
		public void RXTDGBHLSRT<a>(CreationInstantiationKey a, a b, [Optional] a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x86D6260", Offset = "0x86D4860", VA = "0x1886D6260")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xBBDF80", Offset = "0xBBC580", VA = "0x180BBDF80")]
		public Dictionary<int, object> FVGBBLGXTKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x86D6310", Offset = "0x86D4910", VA = "0x1886D6310")]
		private readonly void ULYJMMUHRVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class GFEOMVJUMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x86CE960", Offset = "0x86CCF60", VA = "0x1886CE960")]
		public static RRObjectCreationParameters NZGWKRVVOVI(this RRObject a)
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
		private bool SHRHWFRDEBX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x86D66B0", Offset = "0x86D4CB0", VA = "0x1886D66B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public Vector3 EPCCLKMULRI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x86D6770", Offset = "0x86D4D70", VA = "0x1886D6770")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x86D6650", Offset = "0x86D4C50", VA = "0x1886D6650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x86D6820", Offset = "0x86D4E20", VA = "0x1886D6820")]
		public Vector3 SKSDUDVDMYS()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x86D6900", Offset = "0x86D4F00", VA = "0x1886D6900")]
		public void XTPDJJHCCXQ([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x86D66F0", Offset = "0x86D4CF0", VA = "0x1886D66F0")]
		public void NTYLARWLMVC([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x86D6510", Offset = "0x86D4B10", VA = "0x1886D6510")]
		public bool CDPQKYWQTZD([In] Vector3 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectDeformable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x86D65C0", Offset = "0x86D4BC0", VA = "0x1886D65C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectDeformable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x86D68A0", Offset = "0x86D4EA0", VA = "0x1886D68A0", Slot = "3")]
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
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A00", Offset = "0x86D5000", VA = "0x1886D6A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectDesync other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private ZGZDWFKXWGS HULJWJWQJFD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x86D7470", Offset = "0x86D5A70", VA = "0x1886D7470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public bool SMLMBMPFZMM
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x86D70E0", Offset = "0x86D56E0", VA = "0x1886D70E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public bool QHYSZMJXSOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x86D72B0", Offset = "0x86D58B0", VA = "0x1886D72B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public ElementGroupStatusData DLIVMAQOGXR
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x86D6E80", Offset = "0x86D5480", VA = "0x1886D6E80")]
			get
			{
				return default(ElementGroupStatusData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public bool KNHDXNCHVPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x86D7720", Offset = "0x86D5D20", VA = "0x1886D7720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public bool QNWBWNIDTQW
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x86D7690", Offset = "0x86D5C90", VA = "0x1886D7690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public bool XDDTRIHQBQK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x86D73E0", Offset = "0x86D59E0", VA = "0x1886D73E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x86D74D0", Offset = "0x86D5AD0", VA = "0x1886D74D0")]
		public bool VMNQYMYVNKF(RRObjectElement a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x86D6FB0", Offset = "0x86D55B0", VA = "0x1886D6FB0")]
		public bool EYSJQOQKHKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x86D7210", Offset = "0x86D5810", VA = "0x1886D7210")]
		public bool GWDSQTDJCPF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x86D7570", Offset = "0x86D5B70", VA = "0x1886D7570")]
		public ReadOnlySpan<ObjectLocalId> VYVKEAINYEK()
		{
			return default(ReadOnlySpan<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectElement(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x86D6B20", Offset = "0x86D5120", VA = "0x1886D6B20")]
		public static bool HCJGUXGANNO(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x86D2400", Offset = "0x86D0A00", VA = "0x1886D2400")]
		public static bool VSCIXNKBWNJ(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x86D7050", Offset = "0x86D5650", VA = "0x1886D7050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectElement other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private ZGZDWFKXWGS PJOFSIWONPR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x86D6DB0", Offset = "0x86D53B0", VA = "0x1886D6DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public bool IBMOROWMOEC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x86D6BD0", Offset = "0x86D51D0", VA = "0x1886D6BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public RRObjectTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x86D6D10", Offset = "0x86D5310", VA = "0x1886D6D10")]
		public bool VMNQYMYVNKF(RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x86D6B30", Offset = "0x86D5130", VA = "0x1886D6B30")]
		public bool MVGLDHXZWBR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x86D6C30", Offset = "0x86D5230", VA = "0x1886D6C30")]
		public bool UWLEWMIZMOR([Out] RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D6E10", Offset = "0x86D5410", VA = "0x1886D6E10")]
		public void YDJENYLGMIK(ElementSnapPointRuntimeFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectElementSnapPoint(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x86D6B20", Offset = "0x86D5120", VA = "0x1886D6B20")]
		public static bool HCJGUXGANNO(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x86D2400", Offset = "0x86D0A00", VA = "0x1886D2400")]
		public static bool VSCIXNKBWNJ(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A90", Offset = "0x86D5090", VA = "0x1886D6A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectElementSnapPoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private MMTRKLJTBTD LNJGINONLWO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x86D7760", Offset = "0x86D5D60", VA = "0x1886D7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public ObjectLocalId PUBGXNRUUOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x86D7AE0", Offset = "0x86D60E0", VA = "0x1886D7AE0")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public RRObject VTVCVRULVZC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x86D77C0", Offset = "0x86D5DC0", VA = "0x1886D77C0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public RRObject KXNQQKPTVYU
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x86D7DA0", Offset = "0x86D63A0", VA = "0x1886D7DA0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x86D7CA0", Offset = "0x86D62A0", VA = "0x1886D7CA0")]
		public Span<RRObject> MVDSFXQXJQX()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x86D79E0", Offset = "0x86D5FE0", VA = "0x1886D79E0")]
		public Span<RRObject> JISBDBPHOUQ()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x86D7850", Offset = "0x86D5E50", VA = "0x1886D7850")]
		public Span<RRObject> CZIWIJMFRAR()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x86D7E30", Offset = "0x86D6430", VA = "0x1886D7E30")]
		public Span<RRObject> SEUJYBTPWJP()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x86D7F30", Offset = "0x86D6530", VA = "0x1886D7F30")]
		public bool SetParent(RRObject parent, bool worldPositionStays = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x86D7B70", Offset = "0x86D6170", VA = "0x1886D7B70")]
		public bool LDEIRIBNIUJ(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x86D8060", Offset = "0x86D6660", VA = "0x1886D8060")]
		public RRObject WSNCUOAOVMR(uint a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x86D7C10", Offset = "0x86D6210", VA = "0x1886D7C10")]
		public RRObjectContainer LPMLCKOOIJZ()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectHierarchy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectHierarchy value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x86D7950", Offset = "0x86D5F50", VA = "0x1886D7950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectHierarchy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public string YHRYJBCAKUU
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x86D8240", Offset = "0x86D6840", VA = "0x1886D8240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public string XMHVHQGKEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x86D8170", Offset = "0x86D6770", VA = "0x1886D8170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string ZTNDRGFDXKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x86D82D0", Offset = "0x86D68D0", VA = "0x1886D82D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string QMLANCJZCDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x86D8380", Offset = "0x86D6980", VA = "0x1886D8380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x86D8620", Offset = "0x86D6C20", VA = "0x1886D8620")]
		public bool WORRTWCSBOT([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectIdentity(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x86D81B0", Offset = "0x86D67B0", VA = "0x1886D81B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectIdentity other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x86D86E0", Offset = "0x86D6CE0", VA = "0x1886D86E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectInternal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		private SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager NHNVKRVBEPU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x86D8E80", Offset = "0x86D7480", VA = "0x1886D8E80")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x86D8BC0", Offset = "0x86D71C0", VA = "0x1886D8BC0")]
		public float IXQWAVFWFLW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x86D8EB0", Offset = "0x86D74B0", VA = "0x1886D8EB0")]
		public void RVYINZCTBTK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x86D9690", Offset = "0x86D7C90", VA = "0x1886D9690")]
		public static ConnectResult YXLAMJEOLPZ(RRObjectMagneticAnchor a, RRObjectMagneticAnchor b)
		{
			return default(ConnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x86D90D0", Offset = "0x86D76D0", VA = "0x1886D90D0")]
		public bool VFUMTSLHTBC([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g, [Out] RRObject h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x86D8C10", Offset = "0x86D7210", VA = "0x1886D8C10")]
		public bool JNLFSVLNMHK([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x86D8770", Offset = "0x86D6D70", VA = "0x1886D8770")]
		private void BUTUUMTLAIP(Entity a, EntityManager b, MagneticAnchorData c, [Out] GameObject d, [Out] GameObject e, [Out] RRObject f, [Out] RRObject g, [Out] Vector3 h, [Out] Vector3 i, [Out] Vector3 j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectMagneticAnchor(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x86D8B30", Offset = "0x86D7130", VA = "0x1886D8B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectMagneticAnchor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x86D9070", Offset = "0x86D7670", VA = "0x1886D9070", Slot = "3")]
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
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x86D99A0", Offset = "0x86D7FA0", VA = "0x1886D99A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectNetworkComponents other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private EWYECPRGJGJ PJOFSIWONPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x86D9FC0", Offset = "0x86D85C0", VA = "0x1886D9FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public InteractionFilterMode YEYCFIUEXSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x86D9C30", Offset = "0x86D8230", VA = "0x1886D9C30")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x86D9B50", Offset = "0x86D8150", VA = "0x1886D9B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public RentedArray<string> GFZTQALYZIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x86D9C70", Offset = "0x86D8270", VA = "0x1886D9C70")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x86D9A30", Offset = "0x86D8030", VA = "0x1886D9A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public RentedArray<string> GXIWJXKWQGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x86D9D80", Offset = "0x86D8380", VA = "0x1886D9D80")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x86D9EA0", Offset = "0x86D84A0", VA = "0x1886D9EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectObjectInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x86D9BA0", Offset = "0x86D81A0", VA = "0x1886D9BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectObjectInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public Collider KXVLHZNHRZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x86DA020", Offset = "0x86D8620", VA = "0x1886DA020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public CollisionLayerEnum VJOPETORNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x86DA260", Offset = "0x86D8860", VA = "0x1886DA260")]
			get
			{
				return default(CollisionLayerEnum);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x86DA830", Offset = "0x86D8E30", VA = "0x1886DA830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public CollisionMode BYXKKTNVJUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x86DA6B0", Offset = "0x86D8CB0", VA = "0x1886DA6B0")]
			get
			{
				return default(CollisionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x86DA660", Offset = "0x86D8C60", VA = "0x1886DA660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public GrabbableMode OPRDVQKLHQH
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x86DA6F0", Offset = "0x86D8CF0", VA = "0x1886DA6F0")]
			get
			{
				return default(GrabbableMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x86DAA50", Offset = "0x86D9050", VA = "0x1886DAA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public float IAKKGZDFJHG
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x86DA420", Offset = "0x86D8A20", VA = "0x1886DA420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x86DA3D0", Offset = "0x86D89D0", VA = "0x1886DA3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public bool CFTBBNEWNLD
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x86DA880", Offset = "0x86D8E80", VA = "0x1886DA880")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x86DA2A0", Offset = "0x86D88A0", VA = "0x1886DA2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public bool HGRXQLGWDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x86DA7B0", Offset = "0x86D8DB0", VA = "0x1886DA7B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x86DA8F0", Offset = "0x86D8EF0", VA = "0x1886DA8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public bool CRLKGZOSQUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x86DAEE0", Offset = "0x86D94E0", VA = "0x1886DAEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x86DAAA0", Offset = "0x86D90A0", VA = "0x1886DAAA0")]
		public static bool XMNCLBLNPLN(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x86DACA0", Offset = "0x86D92A0", VA = "0x1886DACA0")]
		public static bool XTYYQLAKLBN(RRObject a, [Out] RRObjectPhysics b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x86DA460", Offset = "0x86D8A60", VA = "0x1886DA460")]
		public bool IHXCMVXMQLK([Out] GTKNBOMGRVX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x86DA170", Offset = "0x86D8770", VA = "0x1886DA170")]
		public bool BTALUWMBRAJ([Out] ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x86DA990", Offset = "0x86D8F90", VA = "0x1886DA990")]
		public bool QXOYEXIRBPG(PhysicsModelEnumFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x86DA730", Offset = "0x86D8D30", VA = "0x1886DA730")]
		public void LLNNKWKZCNO(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x86DA5C0", Offset = "0x86D8BC0", VA = "0x1886DA5C0")]
		public void JWICKWOMBUP(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectPhysics(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x86DA340", Offset = "0x86D8940", VA = "0x1886DA340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectPhysics other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x86DA9F0", Offset = "0x86D8FF0", VA = "0x1886DA9F0", Slot = "3")]
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
		public bool DOWSCEIGIIM
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x86DC180", Offset = "0x86DA780", VA = "0x1886DC180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectPlayer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x86DC0F0", Offset = "0x86DA6F0", VA = "0x1886DC0F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectPlayer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private IZKJXUTETSZ TAAGRKYSTPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x86DC090", Offset = "0x86DA690", VA = "0x1886DC090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x86DBF10", Offset = "0x86DA510", VA = "0x1886DBF10")]
		public void ABSAIFBDSPB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectPlayerInteraction(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x86DC000", Offset = "0x86DA600", VA = "0x1886DC000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectPlayerInteraction other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private HZYGZOVMKQX ISDLVWBODSM
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x86DBEB0", Offset = "0x86DA4B0", VA = "0x1886DBEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public InteractionFilterMode MZKYGEDIRQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x86DB880", Offset = "0x86D9E80", VA = "0x1886DB880")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x86DB380", Offset = "0x86D9980", VA = "0x1886DB380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public bool NDSMVTPSPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x86DBAA0", Offset = "0x86DA0A0", VA = "0x1886DBAA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x86DBB30", Offset = "0x86DA130", VA = "0x1886DBB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public RentedArray<string> VGWTGGCOFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x86DB980", Offset = "0x86D9F80", VA = "0x1886DB980")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x86DB760", Offset = "0x86D9D60", VA = "0x1886DB760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public RentedArray<string> NFMTEDRNWTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x86DBC70", Offset = "0x86DA270", VA = "0x1886DBC70")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x86DB640", Offset = "0x86D9C40", VA = "0x1886DB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public RentedArray<string> UVTULXOFVCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x86DB260", Offset = "0x86D9860", VA = "0x1886DB260")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x86DBD90", Offset = "0x86DA390", VA = "0x1886DBD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public RentedArray<string> MTMBUWNGLXH
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x86DB490", Offset = "0x86D9A90", VA = "0x1886DB490")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x86DB140", Offset = "0x86D9740", VA = "0x1886DB140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x86DBBD0", Offset = "0x86DA1D0", VA = "0x1886DBBD0")]
		public bool VZJOKGLIRPX(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectPlayerInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator ObjectLocalId(RRObjectPlayerInteractionFilter value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x86DB5B0", Offset = "0x86D9BB0", VA = "0x1886DB5B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectPlayerInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public bool JMOLBUEKPOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x86DCC00", Offset = "0x86DB200", VA = "0x1886DCC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public bool KSDWFKBJCZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x86DC280", Offset = "0x86DA880", VA = "0x1886DC280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool HPGSIRNEDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x86DC700", Offset = "0x86DAD00", VA = "0x1886DC700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x86DC9C0", Offset = "0x86DAFC0", VA = "0x1886DC9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool BDFYXVADVLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x86DC590", Offset = "0x86DAB90", VA = "0x1886DC590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public bool GRDRYHUJEPT
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x86DC1D0", Offset = "0x86DA7D0", VA = "0x1886DC1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool IHDAWTNFLQW
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x86DCAE0", Offset = "0x86DB0E0", VA = "0x1886DCAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool EKSQVSNVONS
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x86DC5E0", Offset = "0x86DABE0", VA = "0x1886DC5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool XCTRRBIQRNS
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x86DCB70", Offset = "0x86DB170", VA = "0x1886DCB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool CGYPWECWOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x86DC6B0", Offset = "0x86DACB0", VA = "0x1886DC6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool VMHMRHCHPVK
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x86DCD00", Offset = "0x86DB300", VA = "0x1886DCD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool VRDDVKQWPVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x86DC400", Offset = "0x86DAA00", VA = "0x1886DC400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool DCZPOVCCMYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x86DC3B0", Offset = "0x86DA9B0", VA = "0x1886DC3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public bool QATCOPOYNSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x86DC540", Offset = "0x86DAB40", VA = "0x1886DC540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public bool MKGHAPKAUYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x86DC9E0", Offset = "0x86DAFE0", VA = "0x1886DC9E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x86DC4E0", Offset = "0x86DAAE0", VA = "0x1886DC4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool JPSLUAEOLCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x86DC2D0", Offset = "0x86DA8D0", VA = "0x1886DC2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public NavMeshGenerationMode RBPGHBUMIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x86DCB30", Offset = "0x86DB130", VA = "0x1886DCB30")]
			get
			{
				return default(NavMeshGenerationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x86DD070", Offset = "0x86DB670", VA = "0x1886DD070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public bool QHSGEMZALCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x86DC7A0", Offset = "0x86DADA0", VA = "0x1886DC7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public CircuitsTransformBehavior ZYISBZOMGRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x86DCC40", Offset = "0x86DB240", VA = "0x1886DCC40")]
			get
			{
				return default(CircuitsTransformBehavior);
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x86DD0C0", Offset = "0x86DB6C0", VA = "0x1886DD0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public bool VAYKDWLFALO
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x86DCAA0", Offset = "0x86DB0A0", VA = "0x1886DCAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public Vector3 RLOQVCYRWMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x86DC630", Offset = "0x86DAC30", VA = "0x1886DC630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public Vector3 DXXGBRMZAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x86DCA20", Offset = "0x86DB020", VA = "0x1886DCA20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public bool JGXFYJRBQMY
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x86DCD50", Offset = "0x86DB350", VA = "0x1886DCD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public bool XETUYTYBIQE
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x86DC8C0", Offset = "0x86DAEC0", VA = "0x1886DC8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		private EntityManager NHNVKRVBEPU
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x86D8E80", Offset = "0x86D7480", VA = "0x1886D8E80")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x86DC220", Offset = "0x86DA820", VA = "0x1886DC220")]
		public bool APHUHMCBMPC(ObjectPolicyEnum a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x86DC320", Offset = "0x86DA920", VA = "0x1886DC320")]
		public void DAWQBUGHRLS(ObjectPolicyEnum a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x86DC750", Offset = "0x86DAD50", VA = "0x1886DC750")]
		public bool LROHDZXTULQ(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x86DCC80", Offset = "0x86DB280", VA = "0x1886DCC80")]
		public void XBVIJXBVAHM(ObjectPolicyUserConfigurableFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x86DCBC0", Offset = "0x86DB1C0", VA = "0x1886DCBC0")]
		public ObjectPolicyUserConfigurableFlags VEQOGYCKGYX()
		{
			return default(ObjectPolicyUserConfigurableFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x86DD020", Offset = "0x86DB620", VA = "0x1886DD020")]
		public bool ZFGVXAFMMJB(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectPolicy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x86DC450", Offset = "0x86DAA50", VA = "0x1886DC450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectPolicy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private BGQZNSSZVHM RGSJMQTIZED
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x86DD110", Offset = "0x86DB710", VA = "0x1886DD110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x86DDA20", Offset = "0x86DC020", VA = "0x1886DDA20")]
		public bool VXUDHGXSZDV(ReferenceGroupKind a, List<RRObject> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x86DD800", Offset = "0x86DBE00", VA = "0x1886DD800")]
		public int SNVJXTAUTVQ(ReferenceGroupKind a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x86DD330", Offset = "0x86DB930", VA = "0x1886DD330")]
		public void FWDRIKPVQDI(List<RRObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x86DD170", Offset = "0x86DB770", VA = "0x1886DD170")]
		public int DAWBYAWITUB(RRObject a, ReferenceGroupKind b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x86DD620", Offset = "0x86DBC20", VA = "0x1886DD620")]
		public RRObject LVJBAXBYKJI(int a, ReferenceGroupKind b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x86DD440", Offset = "0x86DBA40", VA = "0x1886DD440")]
		public void JAIIZJKTRBT(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x86DD750", Offset = "0x86DBD50", VA = "0x1886DD750")]
		public bool RDJPIPKTLGD(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x86DDB50", Offset = "0x86DC150", VA = "0x1886DDB50")]
		public void ZBVCHSTUMUY(ReferenceGroupKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x86DD570", Offset = "0x86DBB70", VA = "0x1886DD570")]
		public bool JNOBDFIPIVE(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x86DD910", Offset = "0x86DBF10", VA = "0x1886DD910")]
		public bool VIKKHYQDNDQ(ReferenceGroupKind a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectReferenceGroup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x86DD2A0", Offset = "0x86DB8A0", VA = "0x1886DD2A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectReferenceGroup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x86DDCF0", Offset = "0x86DC2F0", VA = "0x1886DDCF0")]
		public void XOWSYPBXXOR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x86DDD80", Offset = "0x86DC380", VA = "0x1886DDD80")]
		public void XZTWNUENWHF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAF80", Offset = "0x3CE9580", VA = "0x183CEAF80")]
		public a IBCXIDTDAJH<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectRenderEffects(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x86DDC60", Offset = "0x86DC260", VA = "0x1886DDC60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectRenderEffects other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public bool TUJOQVZVQJU
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x86DDF20", Offset = "0x86DC520", VA = "0x1886DDF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x86DDF60", Offset = "0x86DC560", VA = "0x1886DDF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool ILQGDIDTPET
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x86DDEA0", Offset = "0x86DC4A0", VA = "0x1886DDEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public int HQWYIHTWEGY
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x86DDFB0", Offset = "0x86DC5B0", VA = "0x1886DDFB0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x86DDFF0", Offset = "0x86DC5F0", VA = "0x1886DDFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectReplicatedObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x86DDE10", Offset = "0x86DC410", VA = "0x1886DDE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectReplicatedObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public int HVNPXJJHIDF
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x86DE150", Offset = "0x86DC750", VA = "0x1886DE150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x86DE190", Offset = "0x86DC790", VA = "0x1886DE190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public int HRGKOSSKHEH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x86DE080", Offset = "0x86DC680", VA = "0x1886DE080")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x86DE1E0", Offset = "0x86DC7E0", VA = "0x1886DE1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public uint ETOWWNJUOOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x86DE230", Offset = "0x86DC830", VA = "0x1886DE230")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x86DE270", Offset = "0x86DC870", VA = "0x1886DE270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectReplicator(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x86DE0C0", Offset = "0x86DC6C0", VA = "0x1886DE0C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectReplicator other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private CRUWWEPXMPT PRTELJITSSL
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x86DE940", Offset = "0x86DCF40", VA = "0x1886DE940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		private CTTCFIGDGAR QQRHBMQZVQT
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x86DEBE0", Offset = "0x86DD1E0", VA = "0x1886DEBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool ZFYJFHADDSN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x86DE2C0", Offset = "0x86DC8C0", VA = "0x1886DE2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool ZUYBWXACWEE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x86DEB40", Offset = "0x86DD140", VA = "0x1886DEB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public bool RSVPYBHLPCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x86DE650", Offset = "0x86DCC50", VA = "0x1886DE650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public bool IPLGCTHFDDH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x86DE480", Offset = "0x86DCA80", VA = "0x1886DE480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool DZTWSRIRBOT
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x86DEDE0", Offset = "0x86DD3E0", VA = "0x1886DEDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public bool DVPNRFIVTWA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x86DED50", Offset = "0x86DD350", VA = "0x1886DED50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public bool SAHZKVEEJIO
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x86DE9A0", Offset = "0x86DCFA0", VA = "0x1886DE9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public bool JHEWQGUUQOR
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x86DE7D0", Offset = "0x86DCDD0", VA = "0x1886DE7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public bool TIRNLIUNSMS
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x86DE350", Offset = "0x86DC950", VA = "0x1886DE350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x86DE550", Offset = "0x86DCB50", VA = "0x1886DE550")]
		public bool ESCYQSRNYYL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x86DE730", Offset = "0x86DCD30", VA = "0x1886DE730")]
		public RRObject JPXAGUOJKRN(RRObject a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x86DEC40", Offset = "0x86DD240", VA = "0x1886DEC40")]
		public ObjectLocalId VUFPZDISLNL()
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x86DE680", Offset = "0x86DCC80", VA = "0x1886DE680")]
		public bool FPRAMRYLPRT(ObjectLocalId a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectScope(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectScope value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x86DE5C0", Offset = "0x86DCBC0", VA = "0x1886DE5C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectScope other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public EShapeType LUEUYUIEGJT
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x86E0050", Offset = "0x86DE650", VA = "0x1886E0050")]
			get
			{
				return default(EShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public RenderableColor HHPEXJZUJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x86DFCC0", Offset = "0x86DE2C0", VA = "0x1886DFCC0")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x86DFE70", Offset = "0x86DE470", VA = "0x1886DFE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public RenderableMaterial PRMMTXGXHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x86E00F0", Offset = "0x86DE6F0", VA = "0x1886E00F0")]
			get
			{
				return default(RenderableMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x86DFE20", Offset = "0x86DE420", VA = "0x1886DFE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public float CJHQTIMWDNN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x86DFD40", Offset = "0x86DE340", VA = "0x1886DFD40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x86DFD80", Offset = "0x86DE380", VA = "0x1886DFD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public Vector3 QNHAAIQWQOU
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x86DFEC0", Offset = "0x86DE4C0", VA = "0x1886DFEC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x86DFF40", Offset = "0x86DE540", VA = "0x1886DFF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public float GMIALSEFPAE
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x86DFB10", Offset = "0x86DE110", VA = "0x1886DFB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public ShapeConfigFlags IYREEORWVFL
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x86E0010", Offset = "0x86DE610", VA = "0x1886E0010")]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x86DFBE0", Offset = "0x86DE1E0", VA = "0x1886DFBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public bool ILFDNTRMCWP
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x86DFD00", Offset = "0x86DE300", VA = "0x1886DFD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x86E0090", Offset = "0x86DE690", VA = "0x1886E0090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public RRObjectTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public RRObjectHierarchy FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x86DFFC0", Offset = "0x86DE5C0", VA = "0x1886DFFC0")]
		public RRObjectShapePrimitive RYEAMXFYJTX()
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x86E0130", Offset = "0x86DE730", VA = "0x1886E0130")]
		public RRObjectShapeSpline ZWFTKGLZGDL()
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x86DFDD0", Offset = "0x86DE3D0", VA = "0x1886DFDD0")]
		private bool MLWBWEFJSGN(ShapeConfigFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x86DFB60", Offset = "0x86DE160", VA = "0x1886DFB60")]
		public void BVQWDSDMLJU(ShapeConfigFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectShape(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectShape value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x86D2400", Offset = "0x86D0A00", VA = "0x1886D2400")]
		public static bool VSCIXNKBWNJ(RRObjectShape a, RRObjectShape b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x86DFC30", Offset = "0x86DE230", VA = "0x1886DFC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectShape other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public RRObjectShape EDITPNQYEUF
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public PrimitiveShapeType JTFCKIJTXOB
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x86DEEA0", Offset = "0x86DD4A0", VA = "0x1886DEEA0")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectShapePrimitive(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectShapePrimitive value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x86DEE10", Offset = "0x86DD410", VA = "0x1886DEE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectShapePrimitive other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private LWIGPBJZGAB JMMFYHHNLMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x86DF600", Offset = "0x86DDC00", VA = "0x1886DF600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public RRObjectShape EDITPNQYEUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public SplineParameters KBTFAEMPRYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x86DF090", Offset = "0x86DD690", VA = "0x1886DF090")]
			get
			{
				return default(SplineParameters);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x86DF8E0", Offset = "0x86DDEE0", VA = "0x1886DF8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public IEnumerable<RRObjectSplinePoint> APPVIUFMYIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x86DF700", Offset = "0x86DDD00", VA = "0x1886DF700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public RRObjectSplinePoint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x86DFA00", Offset = "0x86DE000", VA = "0x1886DFA00")]
			get
			{
				return default(RRObjectSplinePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public int MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x86DEF70", Offset = "0x86DD570", VA = "0x1886DEF70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public RRObjectTransform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x86DF3E0", Offset = "0x86DD9E0", VA = "0x1886DF3E0")]
		public RRObjectSplinePoint MWSUSSABYVG(float3? a, [Optional] quaternion? b, [Optional] Vector3? c)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x86DF1B0", Offset = "0x86DD7B0", VA = "0x1886DF1B0")]
		public RRObjectSplinePoint Insert(int index, float3? position, [Optional] quaternion? rotation, [Optional] Vector3? scale)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x86DF660", Offset = "0x86DDC60", VA = "0x1886DF660")]
		public void RXWITETQETH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x86DEEE0", Offset = "0x86DD4E0", VA = "0x1886DEEE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectShapeSpline(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x86D5980", Offset = "0x86D3F80", VA = "0x1886D5980")]
		public static implicit operator bool(RRObjectShapeSpline value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x86D6B20", Offset = "0x86D5120", VA = "0x1886D6B20")]
		public static bool HCJGUXGANNO(RRObjectShapeSpline a, RRObjectShapeSpline b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x86DF000", Offset = "0x86DD600", VA = "0x1886DF000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectShapeSpline other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public RRObjectShapeSpline PXUCFIEWHTP
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x86E02D0", Offset = "0x86DE8D0", VA = "0x1886E02D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public float3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x86E04B0", Offset = "0x86DEAB0", VA = "0x1886E04B0")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x86E0350", Offset = "0x86DE950", VA = "0x1886E0350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public quaternion VZKKPJCUJMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x86E0410", Offset = "0x86DEA10", VA = "0x1886E0410")]
			get
			{
				return default(quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x86E0180", Offset = "0x86DE780", VA = "0x1886E0180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public float3 RTMVMDHZWKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x86E03B0", Offset = "0x86DE9B0", VA = "0x1886E03B0")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x86E0260", Offset = "0x86DE860", VA = "0x1886E0260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public FractionalIndex FASPCDLRUNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x86E0460", Offset = "0x86DEA60", VA = "0x1886E0460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x86E02C0", Offset = "0x86DE8C0", VA = "0x1886E02C0")]
		public void GNUCWDFVOPT(RRObjectShapeSpline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectSplinePoint(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x86E01D0", Offset = "0x86DE7D0", VA = "0x1886E01D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectSplinePoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public bool LUIRYGIOBKN
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x86E05A0", Offset = "0x86DEBA0", VA = "0x1886E05A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectStudioObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x86E0510", Offset = "0x86DEB10", VA = "0x1886E0510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectStudioObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private ZMWNPDHDBTV SRHMTKZMIWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x86E07B0", Offset = "0x86DEDB0", VA = "0x1886E07B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public uint CJWBONVVFMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x86E0AD0", Offset = "0x86DF0D0", VA = "0x1886E0AD0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x86E06D0", Offset = "0x86DECD0", VA = "0x1886E06D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public TerrainLayerRoughness IVHUERUWARK
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x86E0720", Offset = "0x86DED20", VA = "0x1886E0720")]
			get
			{
				return default(TerrainLayerRoughness);
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x86E0F60", Offset = "0x86DF560", VA = "0x1886E0F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public float XUDRYUMIWDU
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x86E0FF0", Offset = "0x86DF5F0", VA = "0x1886E0FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x86E0760", Offset = "0x86DED60", VA = "0x1886E0760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public float BDZCTAERNGV
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x86E11B0", Offset = "0x86DF7B0", VA = "0x1886E11B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x86E0970", Offset = "0x86DEF70", VA = "0x1886E0970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TerrainPlayAreaShape RTYXRYMAKYA
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x86E0810", Offset = "0x86DEE10", VA = "0x1886E0810")]
			get
			{
				return default(TerrainPlayAreaShape);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x86E0ED0", Offset = "0x86DF4D0", VA = "0x1886E0ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public float YVWZGCZBSPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x86E0C20", Offset = "0x86DF220", VA = "0x1886E0C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x86E1030", Offset = "0x86DF630", VA = "0x1886E1030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public float SUJCYWQCNUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x86E0890", Offset = "0x86DEE90", VA = "0x1886E0890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public float SQDRFRDVSAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x86E09C0", Offset = "0x86DEFC0", VA = "0x1886E09C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public float UMASWOVPSVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x86E0F20", Offset = "0x86DF520", VA = "0x1886E0F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x86E10C0", Offset = "0x86DF6C0", VA = "0x1886E10C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public RenderableColor GKHROZAGFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x86E0A00", Offset = "0x86DF000", VA = "0x1886E0A00")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x86E0A80", Offset = "0x86DF080", VA = "0x1886E0A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public RenderableColor ASGXNMUOEVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x86E0A40", Offset = "0x86DF040", VA = "0x1886E0A40")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x86E0E80", Offset = "0x86DF480", VA = "0x1886E0E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public float LXGIJLCSGUF
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x86E1080", Offset = "0x86DF680", VA = "0x1886E1080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x86E0B10", Offset = "0x86DF110", VA = "0x1886E0B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public TerrainWaterMaterial DDKMLIFLOXI
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x86E0FB0", Offset = "0x86DF5B0", VA = "0x1886E0FB0")]
			get
			{
				return default(TerrainWaterMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x86E1110", Offset = "0x86DF710", VA = "0x1886E1110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public WaterOverrides UXCZGHDMCDG
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x86E0850", Offset = "0x86DEE50", VA = "0x1886E0850")]
			get
			{
				return default(WaterOverrides);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x86E1160", Offset = "0x86DF760", VA = "0x1886E1160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public ReadOnlySpan<TerrainGenerationLayer> CHTTVGDWYAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x86E0610", Offset = "0x86DEC10", VA = "0x1886E0610")]
			get
			{
				return default(ReadOnlySpan<TerrainGenerationLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x86E0D70", Offset = "0x86DF370", VA = "0x1886E0D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public ReadOnlySpan<TerrainCustomMaterialLayer> EAFMCJOFQAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x86E0B60", Offset = "0x86DF160", VA = "0x1886E0B60")]
			get
			{
				return default(ReadOnlySpan<TerrainCustomMaterialLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x86E0C60", Offset = "0x86DF260", VA = "0x1886E0C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectTerrain(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator ObjectLocalId(RRObjectTerrain value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x86E08E0", Offset = "0x86DEEE0", VA = "0x1886E08E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectTerrain other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private ZXYDVJEPOUG BPBEGWPPDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x86E1930", Offset = "0x86DFF30", VA = "0x1886E1930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public bool GZUCDYCVPCI
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x86E17F0", Offset = "0x86DFDF0", VA = "0x1886E17F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x86E1320", Offset = "0x86DF920", VA = "0x1886E1320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public bool AIGZATTVUZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x86E17A0", Offset = "0x86DFDA0", VA = "0x1886E17A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x86E1740", Offset = "0x86DFD40", VA = "0x1886E1740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public float QPCMORXKUSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x86E1990", Offset = "0x86DFF90", VA = "0x1886E1990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x86E18E0", Offset = "0x86DFEE0", VA = "0x1886E18E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public bool YGNKBUXNCTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x86E1B10", Offset = "0x86E0110", VA = "0x1886E1B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x86E1840", Offset = "0x86DFE40", VA = "0x1886E1840")]
		public void LVLAQZIZZGX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x86E1540", Offset = "0x86DFB40", VA = "0x1886E1540")]
		public bool FUNUVBFJPOW([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x86E1650", Offset = "0x86DFC50", VA = "0x1886E1650")]
		public void ForceCleanup(bool forceImmediate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x86E16F0", Offset = "0x86DFCF0", VA = "0x1886E16F0")]
		public bool IJZMMTQYQDO(ToolCleanupFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x86E1B60", Offset = "0x86E0160", VA = "0x1886E1B60")]
		public void USLKBEDBOPT(ToolCleanupFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x86E19D0", Offset = "0x86DFFD0", VA = "0x1886E19D0")]
		public void TLVRGZSONRI(float a, float b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x86E1C70", Offset = "0x86E0270", VA = "0x1886E1C70")]
		public void YZIUPADAZKZ(float3 a, quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x86E1410", Offset = "0x86DFA10", VA = "0x1886E1410")]
		public bool FMQRPLVIOYE([Out] float3 a, [Out] quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x86E11F0", Offset = "0x86DF7F0", VA = "0x1886E11F0")]
		public bool BZXHDVHQANM([Out] float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x86E1BE0", Offset = "0x86E01E0", VA = "0x1886E1BE0")]
		public void YGNEACSGNJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectToolCleanup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x86E1380", Offset = "0x86DF980", VA = "0x1886E1380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectToolCleanup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private YCOHKLSVTYA JAPWYIFUNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x86E1E90", Offset = "0x86E0490", VA = "0x1886E1E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Vector3 RAMBHLEETFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x86E3130", Offset = "0x86E1730", VA = "0x1886E3130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x86E2F20", Offset = "0x86E1520", VA = "0x1886E2F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Quaternion VZKKPJCUJMB
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x86E2FF0", Offset = "0x86E15F0", VA = "0x1886E2FF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x86E1DC0", Offset = "0x86E03C0", VA = "0x1886E1DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Vector3 IJHLHASXSDR
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x86E21E0", Offset = "0x86E07E0", VA = "0x1886E21E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x86E2910", Offset = "0x86E0F10", VA = "0x1886E2910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Quaternion YLZSVHOHRDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x86E1F50", Offset = "0x86E0550", VA = "0x1886E1F50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x86E3D60", Offset = "0x86E2360", VA = "0x1886E3D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public float NDKFOHCPKUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x86E33C0", Offset = "0x86E19C0", VA = "0x1886E33C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x86E3960", Offset = "0x86E1F60", VA = "0x1886E3960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public float LBPVVEIKGNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x86E3CC0", Offset = "0x86E22C0", VA = "0x1886E3CC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Matrix4x4 BCGRMLMLIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x86E2830", Offset = "0x86E0E30", VA = "0x1886E2830")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public RRObjectHierarchy FSUFSPBZXFF
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		private SAOUEARSLXZ RDNZNGUBKGY
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x86D2420", Offset = "0x86D0A20", VA = "0x1886D2420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x86E2330", Offset = "0x86E0930", VA = "0x1886E2330")]
		public RRTransform CCBWDZNKMPK()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x86E3AC0", Offset = "0x86E20C0", VA = "0x1886E3AC0")]
		public void WCCGKBGSIIO([Out] Matrix4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x86E2AA0", Offset = "0x86E10A0", VA = "0x1886E2AA0")]
		public void MJGNXYQVBAW([In] Vector3 localPosition, [In] Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x86E29E0", Offset = "0x86E0FE0", VA = "0x1886E29E0")]
		public void MJGNXYQVBAW([In] RigidTransform parentFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x86E2780", Offset = "0x86E0D80", VA = "0x1886E2780")]
		public void KUGZQSKHYYG([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x86E3520", Offset = "0x86E1B20", VA = "0x1886E3520")]
		public void RTGKSMNXMTT([In] Vector3 worldPosition, [In] Quaternion worldRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x86E3460", Offset = "0x86E1A60", VA = "0x1886E3460")]
		public void RTGKSMNXMTT([In] RigidTransform worldFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x86E2BA0", Offset = "0x86E11A0", VA = "0x1886E2BA0")]
		public void MMKGKZTPXIJ([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x86E2C80", Offset = "0x86E1280", VA = "0x1886E2C80")]
		public void MMKGKZTPXIJ([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x86E2690", Offset = "0x86E0C90", VA = "0x1886E2690")]
		public UniformTRS KEVPRUPJBBV()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x86E26C0", Offset = "0x86E0CC0", VA = "0x1886E26C0")]
		public void KEVPRUPJBBV([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x86E3C90", Offset = "0x86E2290", VA = "0x1886E3C90")]
		public UniformTRS WIDIFYPIWFU()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x86E3BD0", Offset = "0x86E21D0", VA = "0x1886E3BD0")]
		public void WIDIFYPIWFU([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x86E2090", Offset = "0x86E0690", VA = "0x1886E2090")]
		public Vector3 BINTKSSPPPC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x86E3620", Offset = "0x86E1C20", VA = "0x1886E3620")]
		public void SetLocalPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x86E2380", Offset = "0x86E0980", VA = "0x1886E2380")]
		public Vector3 CUGKMWFUQTV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x86E37C0", Offset = "0x86E1DC0", VA = "0x1886E37C0")]
		public void SetWorldPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x86E2D30", Offset = "0x86E1330", VA = "0x1886E2D30")]
		public Quaternion MQHSIQNSUKN()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x86E36F0", Offset = "0x86E1CF0", VA = "0x1886E36F0")]
		public void SetLocalRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x86E3280", Offset = "0x86E1880", VA = "0x1886E3280")]
		public Quaternion QIXTNLICNEK()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x86E3890", Offset = "0x86E1E90", VA = "0x1886E3890")]
		public void SetWorldRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x86E2560", Offset = "0x86E0B60", VA = "0x1886E2560")]
		public float EKYDJBLQZNX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x86E3A10", Offset = "0x86E2010", VA = "0x1886E3A10")]
		public void UZADZAQRMIB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x86E2870", Offset = "0x86E0E70", VA = "0x1886E2870")]
		public float LNWZAHFGOWW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E70", Offset = "0x86E1470", VA = "0x1886E2E70")]
		public void MRVJAAHRYVU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x86E24D0", Offset = "0x86E0AD0", VA = "0x1886E24D0")]
		public Vector3 EDGJNWBYEUJ([In] Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectTransform(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x86E2600", Offset = "0x86E0C00", VA = "0x1886E2600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		private CXNQWDQLUPV KPWBMMSKTRS
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x86E3E30", Offset = "0x86E2430", VA = "0x1886E3E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public RRObject CVGRUMWZIVV
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x86D40A0", Offset = "0x86D26A0", VA = "0x1886D40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x86E3F20", Offset = "0x86E2520", VA = "0x1886E3F20")]
		public void JZBHIFQEXNV(string a, NativeObjectLocalIdList b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRObjectUserTags(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x86E3E90", Offset = "0x86E2490", VA = "0x1886E3E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRObjectUserTags other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x86D40B0", Offset = "0x86D26B0", VA = "0x1886D40B0", Slot = "3")]
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
		public NetworkCreatorId SDVTADBVHAB
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x86E6120", Offset = "0x86E4720", VA = "0x1886E6120")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRScene(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x86E6210", Offset = "0x86E4810", VA = "0x1886E6210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E6600", Offset = "0x86E4C00", VA = "0x1886E6600")]
			public RetainScope(ObjectLocalId localId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x86E6570", Offset = "0x86E4B70", VA = "0x1886E6570", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x86E5700", Offset = "0x86E3D00", VA = "0x1886E5700")]
		public RetainScope OQXQGPRVOUN()
		{
			return default(RetainScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x86E58E0", Offset = "0x86E3EE0", VA = "0x1886E58E0")]
		public EntityRemapArray ZEMSOPHXEEK(Allocator a = Allocator.Temp)
		{
			return default(EntityRemapArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x86E51B0", Offset = "0x86E37B0", VA = "0x1886E51B0")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CBNMIYVHKQS(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x86E5790", Offset = "0x86E3D90", VA = "0x1886E5790")]
		public NativeArray<ObjectNetworkId> OVMOOSNBTJH(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x86E55D0", Offset = "0x86E3BD0", VA = "0x1886E55D0")]
		public NativeArray<ObjectNetworkId> NFWBZPQZPME(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x86E54A0", Offset = "0x86E3AA0", VA = "0x1886E54A0")]
		public NativeObjectLocalIdArray MZJTNWSUWTI(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x86E5370", Offset = "0x86E3970", VA = "0x1886E5370")]
		public NativeObjectLocalIdArray MCIKJDXANBJ(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x86E5960", Offset = "0x86E3F60", VA = "0x1886E5960")]
		public NativeObjectLocalIdArray ZLODGFCDLWL(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRSceneEntityRemap(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x86E52E0", Offset = "0x86E38E0", VA = "0x1886E52E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRSceneEntityRemap other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x86E58C0", Offset = "0x86E3EC0", VA = "0x1886E58C0", Slot = "3")]
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
		public RRSceneEntityRemap MDNDTQIGCZK
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public RRSceneLoadResult JXQUNSAPXOR
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRSceneLoadResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public RRScene GXYXDGIAFRC
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRScene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x86E5D60", Offset = "0x86E4360", VA = "0x1886E5D60")]
		public bool AXXTNRKVLTT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x86E5E90", Offset = "0x86E4490", VA = "0x1886E5E90")]
		public bool HXSKKNUKGKH([Out] Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRSceneLoadOperation(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static implicit operator ObjectLocalId(RRSceneLoadOperation value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x86E5E00", Offset = "0x86E4400", VA = "0x1886E5E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRSceneLoadOperation other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x86E58C0", Offset = "0x86E3EC0", VA = "0x1886E58C0", Slot = "3")]
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
		public RRSceneLoadOperation GUFWKIXWKMR
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRSceneLoadOperation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public RRSceneEntityRemap MDNDTQIGCZK
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x86E5C50", Offset = "0x86E4250", VA = "0x1886E5C50")]
		public void ZNNZMPJJGEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x86E5A90", Offset = "0x86E4090", VA = "0x1886E5A90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRSceneLoadOperationSubgraph(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x86E5B60", Offset = "0x86E4160", VA = "0x1886E5B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "5")]
		public bool Equals(RRSceneLoadOperationSubgraph other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x86E5BF0", Offset = "0x86E41F0", VA = "0x1886E5BF0", Slot = "3")]
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
		public bool SJVUXVKOXJU
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x86E6090", Offset = "0x86E4690", VA = "0x1886E6090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ObjectLocalId JTDQUATOHKS
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		public RRSceneLoadResult(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x86D2000", Offset = "0x86D0600", VA = "0x1886D2000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x86E6000", Offset = "0x86E4600", VA = "0x1886E6000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x86D1E50", Offset = "0x86D0450", VA = "0x1886D1E50", Slot = "4")]
		public bool Equals(RRSceneLoadResult other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x86E58C0", Offset = "0x86E3EC0", VA = "0x1886E58C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class YVQFEVQIOJY
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
			[Cpp2IlInjected.Address(RVA = "0x86D16C0", Offset = "0x86CFCC0", VA = "0x1886D16C0")]
			public bool BRQQIJAFYMR([Out] ObjectNetworkId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x86D1760", Offset = "0x86CFD60", VA = "0x1886D1760")]
			public ObjectGuid(ObjectNetworkId networkId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x86E7220", Offset = "0x86E5820", VA = "0x1886E7220")]
		public static Guid NBZKUTNSSOM(this ObjectNetworkId a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x86E7200", Offset = "0x86E5800", VA = "0x1886E7200")]
		public static bool ENKXQGOUSBI(this Guid a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class PQMUROECHNS
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x86D3500", Offset = "0x86D1B00", VA = "0x1886D3500")]
		public static NHQJTNSTIUN ALUHJBZXLUS(this ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x86D37E0", Offset = "0x86D1DE0", VA = "0x1886D37E0")]
		public static EKUIPXDCQIY World(this ObjectLocalId id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x86D36D0", Offset = "0x86D1CD0", VA = "0x1886D36D0")]
		public static EntityManager NHNVKRVBEPU(this ObjectLocalId a)
		{
			return default(EntityManager);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BD20", Offset = "0x3B2A320", VA = "0x183B2BD20")]
		internal static bool YGSKQRIIELK<a>(this ObjectLocalId a, bool b) where a : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x86D3590", Offset = "0x86D1B90", VA = "0x1886D3590")]
		public static bool BQAEOPTWDKZ(this ObjectLocalId a, NetworkProperty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AE10", Offset = "0x3B29410", VA = "0x183B2AE10")]
		public static bool KPPSUXHWGGU<b>(this ObjectLocalId a) where b : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B030", Offset = "0x3B29630", VA = "0x183B2B030")]
		public static bool NPCZKCDQQNY<c>(this ObjectLocalId a) where c : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AA00", Offset = "0x3B29000", VA = "0x183B2AA00")]
		[MustUseRefValueWithoutStoring]
		internal static NativeArray<T> FTBIFGIHVKT<T>(this ObjectLocalId a, Allocator b) where T : struct, IBufferElementData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B4B0", Offset = "0x3B29AB0", VA = "0x183B2B4B0")]
		[MustUseRefValueWithoutStoring]
		public static T PTVBYLDNWBV<T>(this ObjectLocalId a) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B790", Offset = "0x3B29D90", VA = "0x183B2B790")]
		[MustUseRefValueWithoutStoring]
		public static d PYRLKRNCOOD<d>(this ObjectLocalId a) where d : struct, IComponentData
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3B2AC00", Offset = "0x3B29200", VA = "0x183B2AC00")]
		public static bool HPMIAWVLHNV<e>(this ObjectLocalId a, [Out] e b) where e : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3B2B320", Offset = "0x3B29920", VA = "0x183B2B320")]
		public static f PRMNCUSFCIS<f>(this ObjectLocalId a) where f : struct, IComponentData
		{
			return (f)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3B2BBA0", Offset = "0x3B2A1A0", VA = "0x183B2BBA0")]
		public static g SBAFJEEMPKP<g>(this ObjectLocalId a) where g : class, IComponentData
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class XJVORSWXAPX
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
		[Cpp2IlInjected.Address(RVA = "0x65CD880", Offset = "0x65CBE80", VA = "0x1865CD880")]
		public EntityRemapArray(NativeObjectLocalIdArray src, NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x86CE400", Offset = "0x86CCA00", VA = "0x1886CE400")]
		public LocalId FNOZEFBECYF(LocalId a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x86CE440", Offset = "0x86CCA40", VA = "0x1886CE440")]
		public LocalId FNOZEFBECYF(int a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x86CE390", Offset = "0x86CC990", VA = "0x1886CE390", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EICJLSRXAJZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UYJHZIOMGYG(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ERLFEZAXBMA(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BDNPQFQZNZP(ObjectLocalId a, uint b);

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KDPGGDHTTBC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string VPCSFLUIVOU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TTGPXWMHJCY(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool WORRTWCSBOT(ObjectLocalId a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XHVOFZLBRLO(ObjectLocalId a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KOGIUQPMNTM
	{
		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		Guid YLKNFQNVNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		Guid KQDZWXKQESF
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IHIGHRRFMEF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task MQSJTAXHVCD(RRObject a);

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Guid KGOQICBZBKW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SBZBNMAQOLD(ObjectLocalId a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AREQYFZJFON(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task NQEUGCXUOAI(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WHMBGZMPPQD(ObjectLocalId a, ObjectNetworkId b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YEOKHNAWCAK
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		Guid YLKNFQNVNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SBMDYJZYMAU(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XHOFCQVELXK
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeObjectLocalIdArray FHSAHJWGFLJ(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeObjectLocalIdArray EABIRMLLARA(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VSENVKARYYN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ILQGDIDTPET(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool NEFCTMINRTF(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool TUJOQVZVQJU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZPZIHZNCVYA(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId RFJVKKQCXIP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QCNWNCIFKNV(NativeObjectLocalIdArray a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KSYPNEUZESI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OENYAXKHSTO(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int FDIQQEZGGUJ();

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MOWRXNBRKGY(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JKRXTVWXZLM
	{
		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ObjectLocalId, ObjectLocalId> MMZGUMYNXSK;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ObjectLocalId, ObjectLocalId> RKYIODIFUXW;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<ObjectLocalId, ObjectLocalId, ObjectLocalId> SRSLCQYBLTM;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ObjectLocalId> RNTJKADLJNT;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool MCVPSETFJDY(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ObjectLocalId CSNKUEJHXPU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray KOGQBYGRSXT(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ObjectLocalId ENFOJSCUZDI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PFHQYSSMFSY(ObjectLocalId a, Vector3 b, Quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DKTVQURPEHR(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool BSHQYIGUHSV(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool WXKVQYUOPXL(ObjectLocalId a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 IFVACKJXFKJ(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "17")]
		quaternion VWGYBGICSWA(RRObjectConnectable a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class UQDTGBEYDUA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZPIAUVNCNBQ
	{
		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		object JTLROBRFNZC
		{
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GSNDGRFYNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GLVKSQBVMVI(ObjectLocalId a, QQYPBZHNRPK b);

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DIZGEDIWCDN(QQYPBZHNRPK a);

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MSAFLCVAOUZ(ObjectLocalId a, [Out] QQYPBZHNRPK b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FEJMQOCLGZK
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WUKIWNVHXQX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeArray<ObjectLocalId> YPGIVWRVUFF();
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
	public interface ZGZDWFKXWGS
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
		bool UUSDPUIVVYX(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RAWKZLGXSOX(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TFTHDNPLUVL(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AHMFATSGIHM(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool XDDTRIHQBQK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QNWBWNIDTQW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId KTPFDEIZHCA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ReadOnlySpan<ObjectLocalId> CWOJFXBACSK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ReadOnlySpan<ObjectLocalId> QMEQQFBATFZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SnapPointPreviewInformation IGNEYJLURLD(ObjectLocalId a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LAUUOLDKFRH(ObjectLocalId a, [Out] ElementGroupStatusData b);

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void STABHTNTBHR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void YXNVIWJDMBE(ObjectLocalId a);
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
		[Cpp2IlInjected.Address(RVA = "0x50762D0", Offset = "0x50748D0", VA = "0x1850762D0")]
		public GameConfig(T defaultValue, [Optional][CallerMemberName] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Obfuscation(ApplyToMembers = false)]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GameConfig<int> RANNULMCVXI;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GameConfig<int> FVTMFOYOTBA;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GameConfig<int> VAURESKMEWQ;
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
	public static class ZVWQUGEOKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1596740", Offset = "0x1594D40", VA = "0x181596740")]
		public static bool IsEnabled(this GameConfigState state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x199D950", Offset = "0x199BF50", VA = "0x18199D950")]
		public static bool FWAIDAEJNZC(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x31FCA00", Offset = "0x31FB000", VA = "0x1831FCA00")]
		public static bool RDKKHEPPGXV(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1596730", Offset = "0x1594D30", VA = "0x181596730")]
		public static bool EWMHEVXALUE(this GameConfigState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface KPXFTPKFCPC
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
		State ATWYIAKNCVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		bool YSRRIISRPBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool IXIBFOPBEYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		EditReadyPreference JRLFUKXMSXM
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
	public interface NSSZUZNBGHA
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		GameConfigState XFDUBJOMICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		GameConfigState GPVCANEYZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		GameConfigState UPROSIPTRGC
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		GameConfigState DITCTIZYPER
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		GameConfigState ZCFBWFQMCTS
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		GameConfigState CDSQQWDJRRK
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		GameConfigState JQELQYMWAYK
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		GameConfigState LQWJKUMRZCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		GameConfigState KSSQMBWOHSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		GameConfigState XDZXJNOLBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		GameConfigState BAOHKIWAHGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		GameConfigState FHPCTRAKVOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		GameConfigState NFYFJWJHRSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		GameConfigState CBOLLMKNJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		GameConfigState OMDHVCGEIUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		GameConfigState AKXXRBSALMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		GameConfigState LFUQRAPVJTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		GameConfigState VYNDSHNHIYX
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		GameConfigState XQLRANLLCDO
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		GameConfigState DKVRDYMBKOW
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
	public interface MMTRKLJTBTD
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event SBMKBOGGRAH.ParentsChangedCallback TSTPLGAHHOP;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId QXJHGFWBTLS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NativeObjectLocalIdArray FJAUGWMUSUF(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FractionalIndex QFQWQGKECJY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EEAVKTCJHIN(IEnumerable<ObjectLocalId> a);

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FractionalIndex Move(ObjectLocalId parent, ObjectLocalId src, bool isBefore, ObjectLocalId target);

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId TXGKFWFDMWI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SetParent(ObjectLocalId localId, ObjectLocalId parent, bool worldPositionStays = false);

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PNYMSQQXFJM(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool YGQNWIFRFMF(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[Obsolete("Use IHierarchyService.GetChildren() instead")]
		NativeObjectLocalIdArray LHEYCQQJTOU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool OERTVWZPNAT(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NativeObjectLocalIdArray OTGQMEMGLRS(NativeObjectLocalIdArray a, DescendantFlags b, Allocator c);

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool LDEIRIBNIUJ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ObjectLocalId AXQFAXRNZYC(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool CRVSGOHTTBP(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ObjectLocalId CBWBVPIRYPS(ObjectLocalId[] a);

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId WSNCUOAOVMR(ObjectLocalId a, uint b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class AJEHQDXDGUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x86CD340", Offset = "0x86CB940", VA = "0x1886CD340")]
		public static bool NXIOQPKZSPK(this MMTRKLJTBTD a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x86CD3B0", Offset = "0x86CB9B0", VA = "0x1886CD3B0")]
		public static NativeObjectLocalIdArray OTGQMEMGLRS(this MMTRKLJTBTD a, ObjectLocalId b, DescendantFlags c, Allocator d)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x86CD2C0", Offset = "0x86CB8C0", VA = "0x1886CD2C0")]
		public static NativeObjectLocalIdArray JISBDBPHOUQ(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x86CD640", Offset = "0x86CBC40", VA = "0x1886CD640")]
		public static NativeObjectLocalIdArray SEUJYBTPWJP(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x86CD7D0", Offset = "0x86CBDD0", VA = "0x1886CD7D0")]
		public static NativeObjectLocalIdArray TYUHTCCOQRK(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x86CD280", Offset = "0x86CB880", VA = "0x1886CD280")]
		public static NativeObjectLocalIdArray CZIWIJMFRAR(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x86CD300", Offset = "0x86CB900", VA = "0x1886CD300")]
		public static NativeObjectLocalIdArray MVDSFXQXJQX(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x86CD680", Offset = "0x86CBC80", VA = "0x1886CD680")]
		public static NativeObjectLocalIdArray SMPUNLRPACN(this MMTRKLJTBTD a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x86CD6C0", Offset = "0x86CBCC0", VA = "0x1886CD6C0")]
		public static NativeObjectLocalIdArray SMPUNLRPACN(this MMTRKLJTBTD a, NativeObjectLocalIdArray b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QKSJPMFGORP
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x86D3C60", Offset = "0x86D2260", VA = "0x1886D3C60", Slot = "0")]
		Task<RRSceneLoadOperation> LoadMain(SerializedDataWrapper serializedDataWrapper, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "1")]
		void MBDNPFXSZKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface PKCVCCBDLWS
	{
		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event SBMKBOGGRAH.ParentsChangedCallback TSTPLGAHHOP;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId TXGKFWFDMWI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ReadOnlySpan<ObjectLocalId> DBLUUHMWZUC();

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ReadOnlySpan<ObjectLocalId> SAZLEJMUSCD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OKRLNJEXTTO(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BSPHQSQLWCL(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool VKMMNPLGWBN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PNYMSQQXFJM(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FractionalIndex QWZRTRWBPDQ(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SXPWRHSNWRV
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		bool DSNRWXQYLGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		bool SYOBSRHTGLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool PIAIOYYEGCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface TDUVTVPZQAF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface AIFQMZZYTYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JCJEHRLEQPM(ObjectLocalId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WGGURFUGLCJ(ObjectLocalId a, NetworkProperty b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface EWYECPRGJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RentedArray<string> FYIYJSQMYJS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RentedArray<string> FVFBFUROXUN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VVFIQYSVEAN(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WSOEACFUDBC(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EOPZZQTLZVX(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HZYGZOVMKQX
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		InteractionFilterMode ANPURUAAOBL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IHAYHFEZJUN(ObjectLocalId a, InteractionFilterMode b);

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZAMICCJPLWT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ARKARKJRJOP(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RentedArray<string> IJGYIOPMMPR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JTPNMPJMZCT(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RentedArray<string> PNHCERBTSMR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VSPCFCDUCPX(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RentedArray<string> EPMCFWITVAT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PBWBCNHRIYL(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RentedArray<string> PLPBVLUWNSV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void IYNJXFVWIHT(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool VZJOKGLIRPX(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OSCHYGYXUZY
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast([In] float3 origin, [In] float3 direction, float maxDistance, [Out] RayIntersection intersection, [Out] ObjectLocalId spline);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OverlapSphere([In] float3 origin, float radius, List<ObjectLocalId> localIds);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int XPSHTSWMCQL(Plane[] a, float3 b, float3 c, quaternion d, List<ObjectLocalId> e);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MMQFDPTIPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Raycast([In] NativeArray<Entity> entities, [In] float3 origin, [In] float3 direction, [In] NativeArray<RayIntersection> outRayIntersections);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeList<Entity> OverlapSphere([In] NativeArray<Entity> entities, [In] float3 origin, float radius);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NativeList<Entity> XPSHTSWMCQL([In] NativeArray<Entity> entities, [In] NativeArray<float4> frustumPlanes);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public struct PhysicsSceneColliderHandle : FKATZDKRTHL, IEquatable<PhysicsSceneColliderHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x303B5B0", Offset = "0x3039BB0", VA = "0x18303B5B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x303B5C0", Offset = "0x3039BC0", VA = "0x18303B5C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x86D3BC0", Offset = "0x86D21C0", VA = "0x1886D3BC0", Slot = "8")]
		public bool Equals(PhysicsSceneColliderHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x86D3C10", Offset = "0x86D2210", VA = "0x1886D3C10", Slot = "3")]
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
	public interface YMBCRDCUMDF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SAOUEARSLXZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		NHQJTNSTIUN ALUHJBZXLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		ObjectServiceHandle UJMIGLONFGG
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		int WZIEAHKLBNE
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		int LDXUSPSQHRB
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		int IUVASGSMVAH
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		int WOUZNKBFIUG
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		int DPADCPFWKSD
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<NativeObjectLocalIdArray, NativeArray<RRObjectPrefabData>> LIIYINSNHCE;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<NativeObjectLocalIdArray> VVICRFHAZRC;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray AZGQYUCCJUV();

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ObjectType UJJCYZALUJJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RRObjectPrefabData FHSYXRVAOBE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void QWJQWZRWLLU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "15")]
		RRObject Embody(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool TYZWNSNRPFV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool ZVSYIVWSQVD(ObjectLocalId a, [Out] Transform b);

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId DJKRIPJPWDE(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool DKMDVWSKUCL(ObjectNetworkId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "20")]
		ObjectNetworkId PQWRQADVFBB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		NativeObjectLocalIdArray DJKRIPJPWDE(NativeArray<ObjectNetworkId> a, Allocator b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool DJTFBRZERTF(NativeArray<ObjectCreationData> a, NativeArray<ObjectNetworkId> b, NativeArray<Entity> c, RentedArray<SBZBMFPSOBU> d);

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "23")]
		RRObject TSAVXWLCHOO();

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RRObject CreateObject(RRObjectPrefabData prefabType, [Optional] CreationInstantiationParameters instantiationParameters);

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RRObjectContainer CBGJHJMSPSD();

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RRObjectShapeSpline ZNQLAXKABBX();

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RRObjectShapePrimitive RGCOWBKXKCB(PrimitiveShapeType a);

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void TJNAAQGPHMD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void XRWANGDZRCW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool GZBTXPRNIUQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		NativeObjectLocalIdArray GHUIZNXTYWE(NativeObjectLocalIdArray a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool Exists(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool HMFXSGHYEQU(ObjectLocalId a, ComponentTypeSet b);

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ObjectLocalId CHACRJSJXZT(Transform a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class CGGEFYHLIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x86CE110", Offset = "0x86CC710", VA = "0x1886CE110")]
		internal static ObjectLocalId WVFEXIHDQKN(this Entity a, SAOUEARSLXZ b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x86CE090", Offset = "0x86CC690", VA = "0x1886CE090")]
		public static RRObject NTOUZWZJGYD(this SAOUEARSLXZ a, LocalId b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x86CDC60", Offset = "0x86CC260", VA = "0x1886CDC60")]
		public static ObjectLocalId DJKRIPJPWDE(this SAOUEARSLXZ a, LocalId b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x86CE0A0", Offset = "0x86CC6A0", VA = "0x1886CE0A0")]
		public static ObjectNetworkId PQWRQADVFBB(this SAOUEARSLXZ a, LocalId b)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x86CDEF0", Offset = "0x86CC4F0", VA = "0x1886CDEF0")]
		public static RRObjectContainer MKWNRJKNAHB(this SAOUEARSLXZ a, RigidTransform b)
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x86CDD40", Offset = "0x86CC340", VA = "0x1886CDD40")]
		public static RRObjectShapePrimitive JROGNGDLOER(this SAOUEARSLXZ a, PrimitiveShapeType b, RigidTransform c)
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x86CDAC0", Offset = "0x86CC0C0", VA = "0x1886CDAC0")]
		public static RRObjectShapeSpline AYMOCGBRQEJ(this SAOUEARSLXZ a, RigidTransform b)
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x86CDD10", Offset = "0x86CC310", VA = "0x1886CDD10")]
		private static void IZKOFTZLBXV(RRObject a, RigidTransform b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal interface NGUVAXEPVPY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CRUWWEPXMPT
	{
		[Cpp2IlInjected.Token(Token = "0x17000210")]
		bool AVTTPQWPJWM
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		ObjectLocalId YEFYVFTRJDM
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		RRObject XWYIQHONOET
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event ScopeChangedEventHandler YIAWPLAVQTS;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId AXQFAXRNZYC(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CRVSGOHTTBP(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WFTSTOGIXFS();

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IBZOKUTANMM();

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ZFYJFHADDSN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool DVPNRFIVTWA(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate void ScopeChangedEventHandler(RRObject oldScope, RRObject newScope);
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class VKCNOYTTHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x86E6F50", Offset = "0x86E5550", VA = "0x1886E6F50")]
		public static bool MEFWKKSUUOX(this CRUWWEPXMPT a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x86E6DF0", Offset = "0x86E53F0", VA = "0x1886E6DF0")]
		public static bool CEMKHBFNJIM(this CRUWWEPXMPT a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x86E6ED0", Offset = "0x86E54D0", VA = "0x1886E6ED0")]
		public static bool IPLGCTHFDDH(this CRUWWEPXMPT a, ObjectLocalId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QZRXMKBROTY
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DCRYSVFDBBG(NativeList<RRObjectPrefabData> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BGQZNSSZVHM
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VXUDHGXSZDV(RRObject a, ReferenceGroupKind b, List<RRObject> c);

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int SNVJXTAUTVQ(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FWDRIKPVQDI(RRObject a, List<RRObject> b);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DAWBYAWITUB(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRObject LVJBAXBYKJI(RRObject a, int b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JAIIZJKTRBT(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool RDJPIPKTLGD(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ZBVCHSTUMUY(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JNOBDFIPIVE(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EIOOSEKVFCF(Entity a, Entity b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PSXOTJNVWFT(Entity a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool VIKKHYQDNDQ(RRObject a, ReferenceGroupKind b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WFPLTSWUEQQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000213")]
		RRScene DDBYOUMEZOC
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
		NetworkCreatorId OGMVDBVBYGV(RRScene a);

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRScene XGJNUWPASBM();

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRScene EUXHRNHWXBI();
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CTTCFIGDGAR
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FPRAMRYLPRT(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PFBVKPLATCK
	{
		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<ObjectLocalId> EFHZKEWGLVP;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XOWSYPBXXOR(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XZTWNUENWHF(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void APNAENJALMD(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LWIGPBJZGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ObjectLocalId> EJBHVTGHWCB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ObjectLocalId FISETQIBIKT(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int VCLCMOTVOKN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SplineParameters HQPSZFNPWTK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XKKZDTTEZEQ(ObjectLocalId a, SplineParameters b);

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId MEFZIVFZQOC(ObjectLocalId a, [Optional] float3? b, [Optional] quaternion? c, [Optional] float3? d);

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId XBYTHYNJNPH(ObjectLocalId a, int b, [Optional] float3? c, [Optional] quaternion? d, [Optional] float3? e);

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DTHIUBDRMTN(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AYDOJXUAIMQ(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface INGGFEVHWYE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface ZMWNPDHDBTV
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RJCHUEZCQRW(ObjectLocalId a, ReadOnlySpan<TerrainGenerationLayer> b);

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MVUXYXFDWVZ(ObjectLocalId a, ReadOnlySpan<TerrainCustomMaterialLayer> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MIMNXURAIYR
	{
		[Cpp2IlInjected.Token(Token = "0x17000214")]
		bool AQKFHYJSFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NKBENTUFUIJ();

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HGRIQLAPSHA();

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZIYWTHWTUBY();

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QODCVWAOUNV();

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZSGHNYYGZAF();

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FGWIGNFLUEU();

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TDBLVKMUCFA();

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YUIKOEIXVJU();

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OWEBOOCCUJE();

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void EHXWFLPRNZW();

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void AQWIHYODHCV();

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XJDXCHRKUWK();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZXYDVJEPOUG
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FUNUVBFJPOW(ObjectLocalId a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LVLAQZIZZGX(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ForceCleanup(ObjectLocalId target, bool forceImmediate);

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TLVRGZSONRI(ObjectLocalId a, float b, float c, float d);

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BZXHDVHQANM(ObjectLocalId a, [Out] float b, [Out] float c);

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YZIUPADAZKZ(ObjectLocalId a, float3 b, quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FMQRPLVIOYE(ObjectLocalId a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YGNEACSGNJT(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YCOHKLSVTYA
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetLocalPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float3 BINTKSSPPPC(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLocalRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "3")]
		quaternion MQHSIQNSUKN(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MJGNXYQVBAW(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KUGZQSKHYYG(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RTGKSMNXMTT(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MMKGKZTPXIJ(Entity a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MMKGKZTPXIJ(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UZADZAQRMIB(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float EKYDJBLQZNX(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SetWorldPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "12")]
		float3 CUGKMWFUQTV(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void SetWorldRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		quaternion QIXTNLICNEK(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void MRVJAAHRYVU(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float LNWZAHFGOWW(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void PHQERWWQZDU(Entity a, [Out] float4x4 b);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void VZWXFXBMPDI(Entity a, [In] float4x4 localToWorld);

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void NotifyTransformParentChanged(Entity entity);

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void XUQZAPXAULX(Entity a, Entity b, Entity c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class MSFPYKNBXSG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WCKDNWDWHWY
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EYNBBHZCRHG(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CXNQWDQLUPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZETIDHQHMJG(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMLWDRRLBFQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AINPCSUWGVQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WGXZDFNJTNS(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EAXZUOKPEZB(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NOVBFOBUSXD(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int ELPXNZQOMAN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int CFVTUHSZGRC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int HRJHZKHXUOK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IMEKMSZAYDL<string> XXSKRCJQWQE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NZDNNZGVJWO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IMEKMSZAYDL<string> CIPRJMDYEKG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool QZSKIOUUDAV(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void AIHPBZYIMBP(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectLocalId QTTCVGJZRSE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OJHOTMBHVPQ(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void JZBHIFQEXNV(ObjectLocalId a, string b, NativeObjectLocalIdList c);

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		IMEKMSZAYDL<string> QITUGMNCIRL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public static class FZXPOCWUOCG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PXUIZTVXKSH
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "0")]
		World VCVPAHXUNZR(string a = "Main");

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "1")]
		World VUQCLYGGEZS(string a = "Shadow");

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "2")]
		World KDRYUTXQOPJ(string a = "Deserialization");

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "3")]
		World VUEYQGJXKGQ(string a = "Serialization");
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EKUIPXDCQIY
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		World RTMQTFNCZGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		World KWUDTUHCYTK
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		EntityManager NHNVKRVBEPU
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		bool UPIAPPMCHTM
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ComponentSystemBase RYFWURHSZAJ(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public static class CWNHNHPZGRH
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x86CE1C0", Offset = "0x86CC7C0", VA = "0x1886CE1C0")]
		public static ComponentSystemBase QTRWBRHSEPH(this World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x370ECE0", Offset = "0x370D2E0", VA = "0x18370ECE0")]
		public static a RYFWURHSZAJ<a>(this EKUIPXDCQIY a) where a : ComponentSystemBase
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YIVHEABNWPZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YWSBZLXUJLU(NativeListAsync<Entity> a);

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TWCDBFUOCHD(CollisionIslandGeneratorState a);

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AVNANDGLQLA(NativeListAsync<Entity> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ETVPUQSUMAE();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UHWTHBAMSFD(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface UTDJJZEXMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JKELYVSQXHY(Collider a, [Out] ObjectLocomotionSettings b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VHASDORTCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Collider LFBKPMEZWGE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject JLOCYEQSYHX(ObjectLocalId a, GameObject b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RLQPXGFPDXN(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "3")]
		a NOCYKTFHXSL<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RXMTZYZSWUH(Collider a);

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject VQCOHXOPQGL<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GTKNBOMGRVX ZHAIXHBESTG(ObjectLocalId a, ObjectLocalId b, PrimitiveShapeType c, float3 d, quaternion e, float3 f);

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IHXCMVXMQLK(ObjectLocalId a, [Out] GTKNBOMGRVX b);

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LGAGLYKJCAM(ObjectLocalId a, [Out] ObjectLocalId b);
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
	public interface JQSXGTNWQAV
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
		void IVLHUEOFPPN(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d);

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KOBICAWPUJJ(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PWBAULLSOXO HSAQBTDJKHT(ObjectLocalId a, List<ObjectLocalId> b);

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GTKNBOMGRVX PEASQRMVZPU(GameObject a, GameObject b);

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PXXTMELAIPE(GameObject a, List<GameObject> b);

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZLCMOMIDBUM(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "6")]
		a NOCYKTFHXSL<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RXMTZYZSWUH(Collider a);

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GameObject FLLHZJKXQGN<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool XGWGNFKIUFC(Collider a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CIAIAHIGRSI(ObjectLocalId a, [Out] ObjectLocomotionSettings b);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<ColliderType> ZYAJXVFKVPM(Allocator a = Allocator.TempJob);

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Mesh[] QRROJTWFWQU();
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DOWDGXIAQIF
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void REAOVRDITKT(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MPFOCSTHCIG(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int UWRIQUHHFSZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ObjectLocalId WGPJQHWBOJY(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NativeObjectLocalIdArray ZLGMGUUVHUE(ObjectLocalId a, Allocator b = Allocator.Temp);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PRAGVCDYNJK(ObjectLocalId a, object b, ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZMELRUNKTLL(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IMIDVXQKTON(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VECUERQRHIP(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KHEXQLIPSFJ(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PREHKDAUAME(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool KIOTGIAQTAI(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void JUUBFKTYLET(ObjectLocalId a, (Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool JYVCCQLALUI(ObjectLocalId a, [Out] quaternion b, [Out] float3 c);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void EMHBDTXPGWP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
		float3 MAEAMDMXIDZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 VJSBCOTNSIE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void REFOBQHYOUY(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OFVXPMXRJGJ(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		float WCGZLOXIJYY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "20")]
		float QHMYRWYVWUX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void UMMVYOUZIVZ(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void KTFGYGNZKKI(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CollisionDetectionMode XBYSWYPIRAS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void CARGUTSHDGC(ObjectLocalId a, CollisionDetectionMode b);

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "25")]
		TransformTrackRate PPEDXHKAZYD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void KKVGMRGDCPF(ObjectLocalId a, TransformTrackRate b);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool GVEVZUBLXNB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void NSPSSWJIFRF(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "29")]
		ObjectLocalId QXJHGFWBTLS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void DPFDOAQEDQU(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ObjectLocalId TXGKFWFDMWI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetParent(ObjectLocalId localId, ObjectLocalId value);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		RbexInterpolationMode PJHEEGFMAGG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void IHGQGHVQITI(ObjectLocalId a, RbexInterpolationMode b);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool NRJUYYWNLLB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void ZHOADJIBVTN(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool ROBOZASIZXY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void BTSFLUKBFPM(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		RigidbodyConstraints RZALGQTQKKR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void HSMFFWMRBRD(ObjectLocalId a, RigidbodyConstraints b);

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		float RLHPSOAHMYO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void TVGJOIJIBCS(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		float JFFCNYICBWE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void BCTVWPSPTJS(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool IMXCUUTGNCL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void YBKHNDMPATZ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool VNDXOXRBAJQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void WGZOKYHVFHE(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void YASPZLEAWYK(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		GWZOVDSJQAJ QDQTKQTHWRE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void HYOBQVJKLGC(ObjectLocalId a, GWZOVDSJQAJ b);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		XTLAQFBHGWM UVAYZDZYHMF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void PYHEVWPNNLD(ObjectLocalId a, XTLAQFBHGWM b);

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		float UVHNEUTETPZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void CSZQJSOKLDF(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void XBISBLLMBHK(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void EKNWDLACUXH(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		bool JZRNMOMCDMG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void XKOIMVIQKYU(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void XHPBJDRNPYD(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		bool JXJUIEXMELO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		bool BKTVDWXTOEO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		Rigidbody YIYNZRLGRLV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void TABXSAHYIDF(ObjectLocalId a, Rigidbody b);

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void XLEVRRHIHKP(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void IWTOHCEWFXU(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "67")]
		bool UWFANKPWEGL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void OWJUVUOQTAQ(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void DZDSFCDPNKS(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool VASSRVHQWMX(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool VMZJDXFJHLH(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "72")]
		bool XMOTNJSXNOF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void NGOHTAHYMBQ(ObjectLocalId a, object b, bool c);

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void ZEPFHZYISBE(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void PCHRAIXEUQY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "76")]
		bool LCMPWUVOXHB(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GNPBJNRNKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TVLWEGAACER(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CHZEESSHOAH(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WATBRTIDYDD(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IZKJXUTETSZ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DNRTICBTPJC(ObjectLocalId a, bool b);
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
		public NativeObjectLocalIdArray SBSGUCCTUZB
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x4304490", Offset = "0x4302A90", VA = "0x184304490")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public int VQADIKBXVTK
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x86CDA60", Offset = "0x86CC060", VA = "0x1886CDA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public NetworkProperty YWXLDIBZMSV
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD6210", Offset = "0xAD4810", VA = "0x180AD6210")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x86CDA80", Offset = "0x86CC080", VA = "0x1886CDA80")]
		public BulkPropertyChangeData(NativeObjectLocalIdArray objectIds, NativeArray<byte> prev, NativeArray<byte> curr, NetworkProperty property, int propertySize, Type propertyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x36BEA90", Offset = "0x36BD090", VA = "0x1836BEA90")]
		public NativeArray<a> JMNJWDMODSZ<a>() where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x36BE790", Offset = "0x36BCD90", VA = "0x1836BE790")]
		public NativeArray<b> DVRZYUWRMON<b>() where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x36BE870", Offset = "0x36BCE70", VA = "0x1836BE870")]
		public (NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>) Get<T>() where T : struct
		{
			return default((NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x49CE090", Offset = "0x49CC690", VA = "0x1849CE090")]
		public ObjectIdBulkPropertyChangeData ZTCBXPTQRQD()
		{
			return default(ObjectIdBulkPropertyChangeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface IXUTGBQAJSK
	{
		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		string YJXUHJLSYIA
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		IXUTGBQAJSK LSCVKFNPOFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		IEnumerable<IXUTGBQAJSK> FFQNPEJUIFU
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface BKRGAXGZFKP
	{
		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		IXUTGBQAJSK ONXJZFRBHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		NativeArray<NetworkProperty> FVOLWXRHUGU
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KKBHXXJPMHM(NetworkProperty a, [Out] IXUTGBQAJSK b);

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KQPXXDZDTRT(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VJDYMFSHNXM(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IIJDQCNASRO
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQPXXDZDTRT(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VJDYMFSHNXM(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class XSWNKAUNPXA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QLLYPNNPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		bool YXMNWSOBVFD
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		ReplicationData MGUQVKTZJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void USQZQMCTDDD(NetworkCreatorId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ACVBNZCXJNU(ObjectNetworkId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AHPRZEGXYGF(NativeArray<ObjectNetworkId> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class PAKGRNQCVLX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public readonly ref struct ObjectIdBulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly BulkPropertyChangeData data;

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public NativeObjectLocalIdArray SBSGUCCTUZB
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x4304490", Offset = "0x4302A90", VA = "0x184304490")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x86D1CF0", Offset = "0x86D02F0", VA = "0x1886D1CF0")]
		public ObjectIdBulkPropertyChangeData(BulkPropertyChangeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x86D1BC0", Offset = "0x86D01C0", VA = "0x1886D1BC0")]
		public NativeObjectLocalIdArray JMNJWDMODSZ()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x86D17A0", Offset = "0x86CFDA0", VA = "0x1886D17A0")]
		public NativeObjectLocalIdArray DVRZYUWRMON()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x86D18D0", Offset = "0x86CFED0", VA = "0x1886D18D0")]
		public (NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray) Get()
		{
			return default((NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class XBMVSTEVEED
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
		public bool OYWUXAUYOWE
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x86E6500", Offset = "0x86E4B00", VA = "0x1886E6500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public bool YXMNWSOBVFD
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x86E6520", Offset = "0x86E4B20", VA = "0x1886E6520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x86E6550", Offset = "0x86E4B50", VA = "0x1886E6550")]
		public ReplicationData(NativeBitArray bitArray, NativeParallelHashMap<ObjectNetworkId, int> bitOffsets, NativeParallelHashSet<NetworkCreatorId> denyCreatorIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x86E6330", Offset = "0x86E4930", VA = "0x1886E6330")]
		public bool ACVBNZCXJNU(ObjectNetworkId a, NetworkProperty b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZROVQIQEUAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		OutlineEffectType IMYXQNJYEUN
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
	public interface YRUOBARJWXG
	{
		[Cpp2IlInjected.Token(Token = "0x17000227")]
		int LLMWVAOHWEE
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		int BCCCXLDJALZ
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FDAZSGVUWTH(ObjectLocalId a, MutableRef b);

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle SASIXKMYZRX();

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RootHandle FUHVCDGPEBC();
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QMGOJBHKJUB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AKXJNRSXEHZ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XWIKAKQYJMF(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ComponentSystemBase OSMTEGDFZMM(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SXQYBEVTRWQ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VABTTXQAPHZ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SDYIVCLJRPA(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JWSFBUTLQHJ(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeParallelHashSet<ComponentTypeIndex> CORWWEPJJXM();
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EFJKQEFKKXE
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GRTYMUHZFOC(ObjectLocalId a, bool b);
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
		[Cpp2IlInjected.Address(RVA = "0x86CEFC0", Offset = "0x86CD5C0", VA = "0x1886CEFC0")]
		public InventionParameters(long id, Guid instanceId, bool overwriteIdData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YDHGDYYXAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RRSceneLoadOperation JWVFBUBNFDG(SerializedDataWrapper a, int b = 0, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRSceneLoadOperationSubgraph VEQGZCMIFCK(SerializedDataWrapper a, ObjectLocalId b, [In] UniformTRS parentFromWorldTransform, TUERVWEIBLJ c, [Optional] InventionParameters d, bool e = true, bool f = false, bool g = false, bool h = false);

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IQLXDYJJPSW LLVUJQPPRYT();

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IQLXDYJJPSW HHFIMIMVVZV(NativeObjectLocalIdArray a, [In] UniformTRS serializedSceneFromCommonParentOfSerializedRoots, [Optional] TUERVWEIBLJ b);

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool AXXTNRKVLTT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HXSKKNUKGKH(ObjectLocalId a, [Out] Exception b);

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NativeArray<ObjectNetworkId> OVMOOSNBTJH(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeArray<ObjectNetworkId> NFWBZPQZPME(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(Slot = "8")]
		NativeObjectLocalIdArray MZJTNWSUWTI(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NativeObjectLocalIdArray MCIKJDXANBJ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray JESKEABHUVF(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<EntityRemapUtility.EntityRemapInfo> CBNMIYVHKQS(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool FACUJBJIVZS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int GSNZKWUKRKW(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DUFTUQMSXRH
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xFEBC00", Offset = "0xFEA200", VA = "0x180FEBC00", Slot = "0")]
		bool IXSFUJNOUNW(object a, VMBFRJHVPND b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class YLQCWSDUKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x86E7120", Offset = "0x86E5720", VA = "0x1886E7120")]
		public static bool IXSFUJNOUNW(this DUFTUQMSXRH a, object b, [Out] VMBFRJHVPND c)
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
	public interface VMBFRJHVPND
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		NetworkEventType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		PlayerId MELQJXGPJAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		bool KYNRFQZNGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		bool POBCUWPVLMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object PMVHQMANAWA();

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IZQYXDCRLXU([Out] PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "6")]
		(PlayerId, object) BITMZCUNVWS()
		{
			return default((PlayerId, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "7")]
		(ObjectNetworkId, PlayerId) DLOFBXMESFA()
		{
			return default((ObjectNetworkId, PlayerId));
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "8")]
		KLNVRLWGEBL<(ObjectNetworkId, PlayerId)> ONSJSUJNRHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "9")]
		(OutOfBandMessageType, byte[]) WCCGTLOKMCN()
		{
			return default((OutOfBandMessageType, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "10")]
		(PacketSource, byte[]) ZKGSKRSEJMG()
		{
			return default((PacketSource, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740", Slot = "11")]
		a JGQIWVNGIKT<a>()
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public static class CXOSMYOJSAP
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x86CE250", Offset = "0x86CC850", VA = "0x1886CE250")]
		public static bool QKSUUYIDXUG(this VMBFRJHVPND a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public interface JSMAOFYDWXB : KLNVRLWGEBL<NetworkTransformSyncData>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface KLNVRLWGEBL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		int VQADIKBXVTK
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
	public static class NPLUDZDNTWI
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x86CF440", Offset = "0x86CDA40", VA = "0x1886CF440")]
		public static ObjectNetworkId DCGGJYBVPUX(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x86CF960", Offset = "0x86CDF60", VA = "0x1886CF960")]
		public static ObjectNetworkId YCHNOMWSBHP([In] this ObjectNetworkIdComponentData data)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x850B690", Offset = "0x8509C90", VA = "0x18850B690")]
		public static ObjectNetworkId CZCTOLHBBNG(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x850B690", Offset = "0x8509C90", VA = "0x18850B690")]
		public static ViewId GEAUVKHQEWV(this ObjectNetworkIdComponentData a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x86CF700", Offset = "0x86CDD00", VA = "0x1886CF700")]
		public static FixedString64Bytes EJCXLSEKEJD(this NetworkCreatorId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x86CF470", Offset = "0x86CDA70", VA = "0x1886CF470")]
		public static FixedString64Bytes DFDYFJDKMWM(this ObjectNetworkId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x86CF8D0", Offset = "0x86CDED0", VA = "0x1886CF8D0")]
		public static FixedString32Bytes EJCXLSEKEJD(this Entity a)
		{
			return default(FixedString32Bytes);
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CCXBIYQXOIH : QKPLUTIPQBC
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
	public interface NPBFDPXSNNT
	{
		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<object> HRCAEKXDTUH;

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "2")]
		void ZYLOSNDIAUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "3")]
		void CMUCWSWSYRH(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		void CSSOXQKZGYV(OutOfBandMessageType a, ReadOnlySpan<byte> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface KXDLYNFJRZB
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PacketSource DZKDSRZRUMS(ReadOnlySpan<byte> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface USRAYLNVKPG
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YAYZNGADQSL(PacketSource a, ReadOnlySpan<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UHRRQXVKUAR(ReadOnlySpan<PacketSource> a);
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
		public static NetworkCreatorId ZNKGNDGSFNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x86D3A40", Offset = "0x86D2040", VA = "0x1886D3A40")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x5457580", Offset = "0x5455B80", VA = "0x185457580")]
		public PacketSource(NetworkCreatorId creatorId, int packetId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x86D39B0", Offset = "0x86D1FB0", VA = "0x1886D39B0")]
		public static bool HCJGUXGANNO([In] PacketSource lhs, [In] PacketSource rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x86D3840", Offset = "0x86D1E40", VA = "0x1886D3840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x86D3950", Offset = "0x86D1F50", VA = "0x1886D3950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x86D3AA0", Offset = "0x86D20A0", VA = "0x1886D3AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x86D3A90", Offset = "0x86D2090", VA = "0x1886D3A90")]
		public void PKKFLCUPRJW([Out] NetworkCreatorId a, [Out] int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class ZXRPEZOEJIS
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
		[Cpp2IlInjected.Address(RVA = "0x86CEEA0", Offset = "0x86CD4A0", VA = "0x1886CEEA0", Slot = "3")]
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
	public static class JYNAWMEOJNW
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x86CF0A0", Offset = "0x86CD6A0", VA = "0x1886CF0A0")]
		public static bool FQJTDFBILOS(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x86CF0C0", Offset = "0x86CD6C0", VA = "0x1886CF0C0")]
		public static bool KABRQGKQZYM(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x86CF0D0", Offset = "0x86CD6D0", VA = "0x1886CF0D0")]
		public static bool MLWIEMUQFLO(this DeserializationOperationType a)
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
	public interface TUERVWEIBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FWCRLXXRHPA([In] Guid src, [Out] Guid a);
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
	public interface IQLXDYJJPSW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000230")]
		APCWCRYRQHU CTPRNPSTUYE
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ByteString XPIGHXADBRI();
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
		[Cpp2IlInjected.Address(RVA = "0x86CF230", Offset = "0x86CD830", VA = "0x1886CF230", Slot = "4")]
		public bool Equals(LocalBoundsData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GEEMCYTPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ReadOnlySpan<ObjectLocalId> ZIIEVEOGTCR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SQLZZZOMCSR(ObjectLocalId a, [Out] ObjectLocalId b);
	}
}
namespace RecRoom.ObjectModel.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PXUFBCLGXXL
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TAIAJNBVEWQ(long a);

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CYVMUOXDUMU(NativeParallelHashSet<long> a);

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LAXXVGZLBAO(World a, NativeParallelHashMap<Guid, long> b);

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ANKJZYYIKAJ(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WXNSVGXEOMW(ObjectNetworkId a, [Out] Guid b, [Out] long c);

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NUODGMTWWUJ(ObjectNetworkId a, Guid b, long c);

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DJSEERNIZJO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EIOVQZWLGWV(Guid a, [Out] int b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BISJILMNEAW(Guid a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TVQZCJNGCWR(Guid a);
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
