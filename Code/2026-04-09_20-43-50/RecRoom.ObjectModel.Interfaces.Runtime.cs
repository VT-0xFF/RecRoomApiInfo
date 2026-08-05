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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGOSYYBXCW
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
	[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
	public SVGOSYYBXCW()
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
		[Cpp2IlInjected.Address(RVA = "0x9BC0F40", Offset = "0x9BBFF40", VA = "0x189BC0F40", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class JTHJKDGINSF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9BC09F0", Offset = "0x9BBF9F0", VA = "0x189BC09F0")]
		public static void OTQMZVCMOHO(this Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0B80", Offset = "0x9BBFB80", VA = "0x189BC0B80")]
		public static void OTQMZVCMOHO(this Rigidbody a, Vector3 b, Quaternion c, Vector3 d)
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
			private readonly SOGEWMVZOFB objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x9BBF860", Offset = "0x9BBE860", VA = "0x189BBF860", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x9BBF550", Offset = "0x9BBE550", VA = "0x189BBF550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66B8D90", Offset = "0x66B7D90", VA = "0x1866B8D90")]
			public Enumerator(SOGEWMVZOFB objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF4D0", Offset = "0x9BBE4D0", VA = "0x189BBF4D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF680", Offset = "0x9BBE680", VA = "0x189BBF680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF750", Offset = "0x9BBE750", VA = "0x189BBF750", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9BC2460", Offset = "0x9BC1460", VA = "0x189BC2460", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9BC24E0", Offset = "0x9BC14E0", VA = "0x189BC24E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int ROOVUOBEKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9BC1F70", Offset = "0x9BC0F70", VA = "0x189BC1F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PSZZBSHCGGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9BC1E00", Offset = "0x9BC0E00", VA = "0x189BC1E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<LocalId> KKMGDAKPBLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CEC0", Offset = "0x2D9BEC0", VA = "0x182D9CEC0")]
			get
			{
				return default(NativeArray<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal NativeArray<Entity> XHZXOHQEVWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9BC1DA0", Offset = "0x9BC0DA0", VA = "0x189BC1DA0")]
			get
			{
				return default(NativeArray<Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BC22B0", Offset = "0x9BC12B0", VA = "0x189BC22B0")]
		public NativeObjectLocalIdArray(int capacity, SOGEWMVZOFB objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BC22A0", Offset = "0x9BC12A0", VA = "0x189BC22A0")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2230", Offset = "0x9BC1230", VA = "0x189BC2230")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<Entity> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC23D0", Offset = "0x9BC13D0", VA = "0x189BC23D0")]
		internal NativeObjectLocalIdArray(SOGEWMVZOFB objects, NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2360", Offset = "0x9BC1360", VA = "0x189BC2360")]
		internal NativeObjectLocalIdArray(SOGEWMVZOFB objects, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2180", Offset = "0x9BC1180", VA = "0x189BC2180")]
		public NativeObjectLocalIdArray(SOGEWMVZOFB objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC20D0", Offset = "0x9BC10D0", VA = "0x189BC20D0")]
		public NativeObjectLocalIdArray(NativeObjectLocalIdArray existing, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1950", Offset = "0x9BC0950", VA = "0x189BC1950")]
		public void CopyTo(List<ObjectLocalId> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1BE0", Offset = "0x9BC0BE0", VA = "0x189BC1BE0")]
		public void DGCFFBTPQMO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BC18B0", Offset = "0x9BC08B0", VA = "0x189BC18B0")]
		public NativeObjectLocalIdArray Clone(Allocator allocator)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1E40", Offset = "0x9BC0E40", VA = "0x189BC1E40")]
		public Span<ObjectLocalId> KINPYRRBFOI()
		{
			return default(Span<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2030", Offset = "0x9BC1030", VA = "0x189BC2030")]
		public NativeObjectLocalIdArray TZEWATJFNKH(int a, int b)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1C30", Offset = "0x9BC0C30", VA = "0x189BC1C30", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1C70", Offset = "0x9BC0C70", VA = "0x189BC1C70")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1FC0", Offset = "0x9BC0FC0", VA = "0x189BC1FC0", Slot = "6")]
		private IEnumerator<ObjectLocalId> SRPSAGZFVWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1D30", Offset = "0x9BC0D30", VA = "0x189BC1D30", Slot = "7")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class FEJGVAERUDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4FE0", Offset = "0x3AD3FE0", VA = "0x183AD4FE0")]
		public static RentedArray<a> LGKUNXPMRTW<a>(this NativeObjectLocalIdArray a) where a : UnityEngine.Component
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
			private readonly SOGEWMVZOFB objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x9BBF790", Offset = "0x9BBE790", VA = "0x189BBF790", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x9BBF5A0", Offset = "0x9BBE5A0", VA = "0x189BBF5A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x66B8D90", Offset = "0x66B7D90", VA = "0x1866B8D90")]
			public Enumerator(SOGEWMVZOFB objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF510", Offset = "0x9BBE510", VA = "0x189BBF510", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF5F0", Offset = "0x9BBE5F0", VA = "0x189BBF5F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF710", Offset = "0x9BBE710", VA = "0x189BBF710", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SOGEWMVZOFB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NativeList<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9BC2FB0", Offset = "0x9BC1FB0", VA = "0x189BC2FB0", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9BC30C0", Offset = "0x9BC20C0", VA = "0x189BC30C0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9BC2E50", Offset = "0x9BC1E50", VA = "0x189BC2E50", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9BC2E50", Offset = "0x9BC1E50", VA = "0x189BC2E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NativeList<LocalId> KKMGDAKPBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
			get
			{
				return default(NativeList<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2EA0", Offset = "0x9BC1EA0", VA = "0x189BC2EA0")]
		public NativeObjectLocalIdList(SOGEWMVZOFB objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2F20", Offset = "0x9BC1F20", VA = "0x189BC2F20")]
		public NativeObjectLocalIdList(SOGEWMVZOFB objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2B60", Offset = "0x9BC1B60", VA = "0x189BC2B60")]
		public NativeObjectLocalIdArray QSFRYGVNZZX()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9BC25C0", Offset = "0x9BC15C0", VA = "0x189BC25C0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2600", Offset = "0x9BC1600", VA = "0x189BC2600", Slot = "13")]
		public bool Contains(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2680", Offset = "0x9BC1680", VA = "0x189BC2680", Slot = "14")]
		public void CopyTo(ObjectLocalId[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2540", Offset = "0x9BC1540", VA = "0x189BC2540", Slot = "11")]
		public void Add(ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2A90", Offset = "0x9BC1A90", VA = "0x189BC2A90", Slot = "7")]
		public void Insert(int index, ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2CB0", Offset = "0x9BC1CB0", VA = "0x189BC2CB0", Slot = "15")]
		public bool Remove(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2A10", Offset = "0x9BC1A10", VA = "0x189BC2A10", Slot = "6")]
		public int IndexOf(ObjectLocalId item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2C60", Offset = "0x9BC1C60", VA = "0x189BC2C60", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2860", Offset = "0x9BC1860", VA = "0x189BC2860", Slot = "18")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9BC28A0", Offset = "0x9BC18A0", VA = "0x189BC28A0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2D70", Offset = "0x9BC1D70", VA = "0x189BC2D70", Slot = "16")]
		private IEnumerator<ObjectLocalId> SRPSAGZFVWS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC2930", Offset = "0x9BC1930", VA = "0x189BC2930", Slot = "17")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface YUZDAQJGJCS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ObjectLocalId WAWREKIWZDD(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface CMOSGNXFOTT : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IVNBTBVWVCF : LWNBRSIKBKT, PLVWZTFMBVA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		LZCFIZACNTF FKQIBKCAROQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		ObjectServiceHandle NIFAJYPOFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PLVWZTFMBVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VOOSCAUWYNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TMAPLLTILWZ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface EUKSWEOJHQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool SQGPDUJKWEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool AHTSEWJAPTM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool VGGUFNIRBPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool IKWMTPWAWZT
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool XHCBTYBMETM
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
		bool HZOEVXJLKMZ(ByteString a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OHIEYVUWXVI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VSIADALGQZL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PPCVAYWFABF FKQIBKCAROQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		WRBYQXNUTKF CPZTXHJFAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		BHEXHNXOSNE ZELZJDJVUGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		IVNBTBVWVCF SGRSRWHFIWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		ICTQXJFIFEY LCFWUQWVSSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		EUKSWEOJHQO TZKGDINOJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		EVTOWQLXIRU YPIEBPSMRDO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		FGSEFYNLQSE IBPKKWOHKIH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		VHNQEOVNDKG NCFPKEHXQZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		OHXWWKOOZRX SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		ZWCAHRSJCLZ MBDJJIXMWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		IPTYNRDFBYF TFGJVTACDEE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		HPNYXRKSYRJ WDNILCBEMDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		WPEENMVPQPL KOPZCPMGRRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		ODGNUZRWIZX FSWJVRDSGTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		ENZWUCLSKWE RSYAXVBJSZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		CNLXTDCWTGF HYWWWKRTAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		BFWVMJIJWJM IEUIRTYRZPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		FIYRUKDLVYY DSPZRVXXBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		GATSKXUMODS BAASZHZKXCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		XBTBGXVRMEZ WKQTAYVLYFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		DCMBYNPQINA TJXCIFTWTIS
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		WPQERZXHFFE HTBCNWIICRK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		BTZNJGALHRL CRHZMEQHHZI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		ZSOTDVTSKUZ VGKPYZBLZYB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		RAGQQAVCFVA OSHTOSAFAWF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		BDZTIYBTDBO EAPESTKTPER
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		PCIGIKYKGIA NCAHYGSQSPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		BUNPURTHBHJ LPSLFMTTLJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		NSPSZHUPQDE CCKENIWSWJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		OOCKLMKAALS BKBSEMZHNSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		WGZOUQSHTFY YSNGCJTSHPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		DCHYTMGFCDF PGVYKNTUZPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		VNXQNHKAVHQ FJOIBPHSFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		OFBPVVLEQCL BOAHHILDDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		PQSFFCXSVQS SMEBLUCYTBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		FYUXRLHIKCV SMZQCLOOVYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		ERDOEXZOEOA RQIMLGHUVBB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		ZOHMBYWXOFF JTRDCYDGXSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DebuggerTypeProxy(typeof(QWQDMCZIHNN))]
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
		public SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D60", Offset = "0x9BC2D60", VA = "0x189BC3D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IVNBTBVWVCF SGRSRWHFIWA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3CA0", Offset = "0x9BC2CA0", VA = "0x189BC3CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public LocalId NHQBQFLOUGK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3F10", Offset = "0x9BC2F10", VA = "0x189BC3F10")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal ObjectServiceHandle NIFAJYPOFJI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D00", Offset = "0x9BC2D00", VA = "0x189BC3D00")]
			get
			{
				return default(ObjectServiceHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool SJXJLVVMDOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3F50", Offset = "0x9BC2F50", VA = "0x189BC3F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool HJHGFIYJVYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D10", Offset = "0x9BC2D10", VA = "0x189BC3D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4070", Offset = "0x9BC3070", VA = "0x189BC4070")]
		public ObjectLocalId(SOGEWMVZOFB objectSystem, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4130", Offset = "0x9BC3130", VA = "0x189BC4130")]
		public ObjectLocalId(ObjectServiceHandle handle, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
		public RRObject QXFPHVOFHJJ()
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9BC41C0", Offset = "0x9BC31C0", VA = "0x189BC41C0")]
		public static implicit operator LocalId(ObjectLocalId objId)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4200", Offset = "0x9BC3200", VA = "0x189BC4200")]
		public static implicit operator Entity(ObjectLocalId objId)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B80", Offset = "0x9BC2B80", VA = "0x189BC3B80")]
		public static bool IQJYWSDTJLC(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DC0", Offset = "0x9BC2DC0", VA = "0x189BC3DC0")]
		public static bool OOOEUMVNSLV(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DE0", Offset = "0x9BC2DE0", VA = "0x189BC3DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39B0", Offset = "0x9BC29B0", VA = "0x189BC39B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC38B0", Offset = "0x9BC28B0", VA = "0x189BC38B0", Slot = "4")]
		public int CompareTo(ObjectLocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "5")]
		public bool Equals(ObjectLocalId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class IHNBIVSLPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0770", Offset = "0x9BBF770", VA = "0x189BC0770")]
		public static ObjectNetworkId GVJBBKGTVZJ(this ObjectLocalId a)
		{
			return default(ObjectNetworkId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class QWQDMCZIHNN
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
		private static SOGEWMVZOFB defaultObjectService;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static IVNBTBVWVCF defaultObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static SOGEWMVZOFB[] objectServices;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static IVNBTBVWVCF[] objectModels;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static Stack<byte> freeHandles;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IVNBTBVWVCF SGRSRWHFIWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9BC4510", Offset = "0x9BC3510", VA = "0x189BC4510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public SOGEWMVZOFB NABGNGDBURY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9BC43A0", Offset = "0x9BC33A0", VA = "0x189BC43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5110", Offset = "0x9BC4110", VA = "0x189BC5110")]
		static ObjectServiceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2737DF0", Offset = "0x2736DF0", VA = "0x182737DF0")]
		internal ObjectServiceHandle(byte value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A49C50", Offset = "0x8A48C50", VA = "0x188A49C50", Slot = "4")]
		public bool Equals(ObjectServiceHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4300", Offset = "0x9BC3300", VA = "0x189BC4300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10C8400", Offset = "0x10C7400", VA = "0x1810C8400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4970", Offset = "0x9BC3970", VA = "0x189BC4970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9BC45F0", Offset = "0x9BC35F0", VA = "0x189BC45F0")]
		private static SOGEWMVZOFB OLPNQXRMDBY(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4250", Offset = "0x9BC3250", VA = "0x189BC4250")]
		private static IVNBTBVWVCF ETYLNJHJKIY(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4FB0", Offset = "0x9BC3FB0", VA = "0x189BC4FB0")]
		private static object YXZLNHQJSKG(byte a, object[] b, object c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC46A0", Offset = "0x9BC36A0", VA = "0x189BC46A0")]
		private static int QMSQUHHBFHO(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4240", Offset = "0x9BC3240", VA = "0x189BC4240")]
		private static int AQODNMLKEKE(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4490", Offset = "0x9BC3490", VA = "0x189BC4490")]
		private static (int, int) HSEZLZMFKWK(byte a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4480", Offset = "0x9BC3480", VA = "0x189BC4480")]
		private static byte GLXWBLDHRCH(int a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC46B0", Offset = "0x9BC36B0", VA = "0x189BC46B0")]
		internal static ObjectServiceHandle SIFQFAPRLAF(IVNBTBVWVCF a, SOGEWMVZOFB b)
		{
			return default(ObjectServiceHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4A20", Offset = "0x9BC3A20", VA = "0x189BC4A20")]
		internal static void WKECLZBLVZA(ObjectServiceHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC4C30", Offset = "0x9BC3C30", VA = "0x189BC4C30")]
		private static void WQYJWUYKSTE(int a)
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
	public interface JOVEUEDNTZV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool MOJDNGOELYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool KARNVRMCFBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool CBGLFNBPORI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool HPALIOMEFSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool PPUYNNNVJSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CTAQTRIFRJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HJLEXYXGGRJ(CYZULSGWQRY a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SIMYFCYLNCW(CYZULSGWQRY a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JJBSVDYSVLV(AEIULYWIKIO a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface DULCQNADRTP : CYZULSGWQRY, JOVEUEDNTZV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		int CGYOIQMFZMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FXGSPCSBVEN(DCVUFXSAJRM a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface CYZULSGWQRY : JOVEUEDNTZV
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
		bool DHLZHQUUWOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool CJIWUJXWQKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool ZAHUXJLEESI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface DCVUFXSAJRM
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool OIDRLIWCRUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		PrimitiveShapeType GJVLUAKAYMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		YWVYKLRCINC RKVFIIVBRWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		float3 LWKWIDIZVNV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		quaternion KGAYDLOYNUK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		float3 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		RenderableMaterial KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RenderableColor LPXTJPZIKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		float SVFPOYRRLZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		float3 UKUIDNUTOUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		float SDPVMFANIXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ShapeConfigFlags VGGDXNOJJIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface WMGCXZRRUPM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		float3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		float3 KUNLLKTXIHV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		quaternion KMWKJYSUNTH(float3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface YWVYKLRCINC
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool SBAJEMJWSNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool VLURESVZGVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool IPQBAZDNXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		float UVQLYSMCQLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		int YSCZYCLUVZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		int TASCUYNVLSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RMLWOYRTXEG(WMGCXZRRUPM a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public class WFCZETZQHVC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public WFCZETZQHVC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YCXAWPXRFTT
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Guid OMIIPKCTMRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task BLHOLQAYEIB(Guid a, Guid b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task PKQQCLBJPBI(Guid a, Guid[] b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid CJFCVULIKJT(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task OQRVZAJUNQF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IJDGNSNDDNW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EZWXWJQNQNG(HOOYDJHYZLE a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SGFDMXKOSNL(Guid a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void FICVERMUYOE(Guid a, ObjectNetworkId b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VRATEJMGVSK(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void GNNSKXQFLEI(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QCNGOEJVGHA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EAEQOBINGNQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "0")]
		void SAKBSQEIZTZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WRBYQXNUTKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		EAEQOBINGNQ FLXBQWOEKOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		SOJYREOXQXL MLZEAJXCYKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		ZDYWEUKZHIU QEMFXQMHBOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		YZPJLVEVJBA OCZHVGLDNUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		SVVKGAIGFCG IYBCATJYQSC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		FVEXUFQWHDH TVUIIURUYZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		NGJNZGENJRV MEAUOGPNNAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		YFEVIRQYIWY DNXPYOWONOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SOJYREOXQXL
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		string IJKEELTXUQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ULAYRELCYPQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CVFYTFHYZVM(Action a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RQNHRCGFGNZ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int XFGLJJICOSJ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZYDTQAGIVOH([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IYQZAAJLZQW([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YUZKHQEGLQC([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EGANQYKZXDH([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZDYWEUKZHIU
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "0")]
		void ULFGHPEMVDD(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YZPJLVEVJBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		protected static readonly Guid AEIRRUMGYTL;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		static readonly Guid OYRKJVPZPXO;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		static readonly Guid UPPTRVMEJMQ;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		static readonly Guid NZBGRHSMDRS;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		bool VGTGIXDYJJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool BYJFJYYTFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		bool BWMWUQLDAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool PKCGTYAUATQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9040", Offset = "0x9BD8040", VA = "0x189BD9040", Slot = "4")]
		string[] OLRTGMSXBZQ(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PXHRKQXDMSA();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2600", Offset = "0x8DE1600", VA = "0x188DE2600", Slot = "6")]
		Guid OWBGJJEGSJX(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int VUJLSZUFNFP(SerializedDataWrapper a);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MEUMEVBAHSJ(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int JGVKFRFARDV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool WBWPSJGNGCY(string a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		string UPTHJRRFBAB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool SSYFGMEOSIG(RRObjectPrefabData a, [Out] LocalId b);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RentedArray<byte[]> ZSUQYOJHDYH(NativeArray<ViewDescriptor> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void OQZWVLIOWAY(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GameObject BYUDUVPGCNE(string a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LAVGIVGWHKX(Transform a, RRObjectPrefabData b, NSNTXJAOJGZ c);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool DELGGOZEXPC(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void DPLMGMMNGPE(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "19")]
		void VBOCRKMEYDL(SerializedDataWrapper a, NativeArray<int> b, WRLHKUPPYHT<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void SDGQITDLXHB();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
		void TDSLTLVHSQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "22")]
		void MRDBQJCGYPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "23")]
		bool APIOCIFXDOW(SerializedDataWrapper a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "24")]
		CTAQTRIFRJM TVIDNALZQBA(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "25")]
		void AXWHJCTZMOU(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "26")]
		bool YGVPPHIIOBO(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9BD90E0", Offset = "0x9BD80E0", VA = "0x189BD90E0")]
		static YZPJLVEVJBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YCVVYZQWGCU
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		long IVEIRHDFTDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		long KAHAVEFCDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "1")]
			get
			{
				return default(long);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface SVVKGAIGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool WBHADULSMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		int KFQOBGMSJEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		int VYQNGKBKFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		int SZTBRXXLFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		bool HOJHDHAHSLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		int BZLWRELHDXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		void XUWHRXRAQKR(FJAIXDTJXYY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		void PBRPEHJWYRL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "8")]
		bool WJLVPHYTEYV(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		void LBDVXHTLWXZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "10")]
		void XPRJIQXLOVO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void IHIDDQVUBSP(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ESVVXNSSDEI(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		void IOJOTYXDNJE(NativeArray<ViewId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
		void MDTORHPGFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
		void HLWTOEPYOFS(OutOfBandMessageType a, ReadOnlySpan<byte> b, PlayerId c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "16")]
		void HLWTOEPYOFS(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "17")]
		void HLWTOEPYOFS(OutOfBandMessageType a, ReadOnlySpan<byte> b, ReadOnlySpan<byte> c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "18")]
		void RNQOECKLKTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "19")]
		void EOUKNVOSFNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "20")]
		void QDEGAUQWRSV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
		void LJOEEOBURHS(Dictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "22")]
		void KLWZZWUCJAT(NativeList<ObjectNetworkId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "24")]
		void APSFOVCXDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "25")]
		void VPTHMRFDCWY(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "26")]
		void DFLVUUDRUVS(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "27")]
		void QATRDSAAFVD(PlayerId a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "28")]
		void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "29")]
		void LOAYEBRBMQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class TGJVGPDFNUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8660", Offset = "0x9BD7660", VA = "0x189BD8660")]
		public static NetworkPauseScope ZVKOHAHYITW(this SVVKGAIGFCG a, object b)
		{
			return default(NetworkPauseScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct NetworkPauseScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private SVVKGAIGFCG dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object token;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9BC31C0", Offset = "0x9BC21C0", VA = "0x189BC31C0")]
		public NetworkPauseScope(SVVKGAIGFCG dependencies, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3170", Offset = "0x9BC2170", VA = "0x189BC3170", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NVKJNZVENLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate void ApplyNetworkTransform(ViewId viewId, NetworkTransformSyncData syncData, int sender);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "0")]
		void Pause(ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "1")]
		void BCLHNHIBLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "2")]
		void RDGUPVIGSJQ(JHVMANSCQQR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GVOBCMRDLAM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface PJZRKIAGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PLVZGBAGWIA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FVEXUFQWHDH
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct LoadScreenScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private FVEXUFQWHDH notifications;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x9BC0E30", Offset = "0x9BBFE30", VA = "0x189BC0E30")]
			public LoadScreenScope(FVEXUFQWHDH notifications, string title, string subtitle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC0D70", Offset = "0x9BBFD70", VA = "0x189BC0D70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct FadeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private FVEXUFQWHDH notifications;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Task task;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9BBF9F0", Offset = "0x9BBE9F0", VA = "0x189BBF9F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "0")]
		void BFUFXYGLESF(string a, float b = 5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "1")]
		void ZCZAGXYALWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VWTUNNFUUHU(bool a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "3")]
		void OITBVJZTCBT(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TJUNTTGFTOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9BD86F0", Offset = "0x9BD76F0", VA = "0x189BD86F0")]
		public static FVEXUFQWHDH.LoadScreenScope WYYQWJUQDRW(this FVEXUFQWHDH a, string b, string c)
		{
			return default(FVEXUFQWHDH.LoadScreenScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GJYCODXNIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int QSJKGVRFNOT(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void THOPXVXOXCM(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TransferOwnership(GameObject gameObject, int playerId);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DFYTURDNJYZ(int a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object LLZXSRFIWJR(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c);

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KHAXVWLXOMS(GameObject a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HJUTNMDKODO
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		YYGOMMBAADJ FZKTHDKINDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IAWSSEFWJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PDXBLUWZQQH(NetworkCreatorId a, RolePermission b);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AMQRYZCQZRT(PlayerId a, AccountRoleTypeNetworked b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface EQAGBLRJVMC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GHRXOLGFAHI(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object Deserialize(NativeArray<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WHPVXJXTXMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool EMOCWMLUNDY
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Delegate BVSSXQXNXNU(CVWDRVYPYSK a, Action<CVWDRVYPYSK> b);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LFIRCTMAJIH(CVWDRVYPYSK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Delegate QIOXGIKUSNJ(CVWDRVYPYSK a, Action<CVWDRVYPYSK> b);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RNGQYANEDVJ(CVWDRVYPYSK a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool XKPOTKSKOSY(CVWDRVYPYSK a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CVWDRVYPYSK XUAJPYEMLXY(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZCUTXEYWEKT
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		int RXEAPXYFSFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		int JZCLYMDOOEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool XFQWYCMCUFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool HKWEJUYCFRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId ESDDJZRGYPR(int a);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VKWNSVTBGDR(GameObject a, JobHandle b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface YYGOMMBAADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SFSWCOQRXBZ(AccountRoleTypeNetworked a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NGJNZGENJRV
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool SQGPDUJKWEE
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ACKGHZQMQUZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		ZINHPKXEDYG TOMVFGMHDYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		CGMZJKGSGAM UCQALHFKJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool NVJYVLFLHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZKNBMZQZXWL(Transform a);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RJJRBVGVEQT(Transform a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QACYMINENBN(Transform a, OutlineEffectType b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YFEVIRQYIWY
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DJAJWOTXOZK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MLZVBKWWDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MJQGDXVAIXE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ServiceLifetime(Lifetime.Application)]
	public interface OUICVHSTPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVKKTBSCUCX(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XJYLJUJGTES(ObjectLocalId a, bool b, float3 c, quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RXFCZHBOJRR(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MYBNJJURGDH(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RYDJYDEIKOR(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AJQILYLFYCK(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IPLOFGCQLFV(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GOESHKDAYGJ(HZTYXVTZUZS a);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TPREANIAUZM(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ROFUJHZLTLZ(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BNUPIXXOHVR(ObjectLocalId a);
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

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1800", Offset = "0x9BC0800", VA = "0x189BC1800")]
		public NativeArrayPinnedMemory(ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9BC17D0", Offset = "0x9BC07D0", VA = "0x189BC17D0", Slot = "4")]
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
		public ZXQZGDZOMJG.EditReadyPreference? loadEditReadyPreference;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9BD85E0", Offset = "0x9BD75E0", VA = "0x189BD85E0")]
		public SerializedDataWrapper(ByteString serializedOMData, [Optional] object persistenceViewData, [Optional] object connectableGraphData, [Optional] IEnumerable<string> legacyTags, bool isLatestDeprecatedVersion = true, [Optional] ZXQZGDZOMJG.EditReadyPreference? loadEditReadyPreference)
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
		public Guid NPTAAVGKNLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6939A30", Offset = "0x6938A30", VA = "0x186939A30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool TAOFIUAYRKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8FD0", Offset = "0x9BD7FD0", VA = "0x189BD8FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool ALVQMNAZUCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8FF0", Offset = "0x9BD7FF0", VA = "0x189BD8FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool VKHFUDYPCVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8FC0", Offset = "0x9BD7FC0", VA = "0x189BD8FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool UZMULXKIBFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8FE0", Offset = "0x9BD7FE0", VA = "0x189BD8FE0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9BC04B0", Offset = "0x9BBF4B0", VA = "0x189BC04B0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9BD81D0", Offset = "0x9BD71D0", VA = "0x189BD81D0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD81D0", Offset = "0x9BD71D0", VA = "0x189BD81D0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFB90", Offset = "0x9BBEB90", VA = "0x189BBFB90", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0710", Offset = "0x9BBF710", VA = "0x189BC0710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GGOGHMXGSEC
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		TWXUSQEJIPV MPVCMIXWMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface HOOYDJHYZLE
	{
		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface URYWMLUHLEE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class PNDPGEGEOUE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3DA8CD0", Offset = "0x3DA7CD0", VA = "0x183DA8CD0")]
		public static RRObject QXFPHVOFHJJ<a>(this a a) where a : HOOYDJHYZLE
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5120", Offset = "0x9BC4120", VA = "0x189BC5120")]
		public static MonoBehaviour GBRRJMGOFLA(this HOOYDJHYZLE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9BC51A0", Offset = "0x9BC41A0", VA = "0x189BC51A0")]
		public static GameObject GameObject(this HOOYDJHYZLE localId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface XTDSPIQRHPB : HOOYDJHYZLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectLocalId objectId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface PIQUXHALYZB : HOOYDJHYZLE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FLGDJBVOVLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ParentsChangedCallback(ObjectIdBulkPropertyChangeData changeData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event ParentsChangedCallback MPARVLSGNTF;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface BMKQGCLVVHV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface ILLCEKFPVYO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface EJFBPJOFWSR
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Transform GetTransform();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Collider GetCollider();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MoveToObject(ObjectLocalId newObject);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NotifyIsUniform(bool isUniform);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DestroyCollider();

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OBYQVEOZSLQ(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface BTIVVBQURQW
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRootRBEXChanged(OGYYXGOOHSH newRootWithUnityRigidbody);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface OGYYXGOOHSH
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		GameObject FFDFHWZHUDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		Transform VVUQJWBKDSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		LXUPYHZBZJT KAMWXBFNNPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool KJMEBHGONHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetImplementation(LXUPYHZBZJT impl);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RigidbodyExData GetData();
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class CVPKZAKRBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF030", Offset = "0x9BBE030", VA = "0x189BBF030")]
		public static void WFFVUHRUAQQ(this OGYYXGOOHSH a, NSNTXJAOJGZ b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface LXUPYHZBZJT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		Rigidbody EUMMWSSQGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		OGYYXGOOHSH PCQWDGQGDIK
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		GameObject DCEMLZFKLGR
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		Transform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		LXUPYHZBZJT LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		LXUPYHZBZJT OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		int OVJQGIMCWJT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		bool DOFZZALFMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		DBBKETFETMV KOLYPESMRMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		HAIRCSDLSLS HEFJROZQYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		float KJTVCDHLYHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "36")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		Vector3 MDEBPHEQMEU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "38")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Vector3 TLYLWZDIHEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		Vector3 ICEPCSIMYGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "42")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		Vector3 LDDNNQAATIV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "44")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		bool JCPEEYMQIDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool KZCJJPMQQYY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "46")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool NJUAISBZIJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool LIMCAIRXPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		Vector3 XKMDQDDFWQV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		Vector3 SZXZTHRYZSL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Vector3 IZFYQQIUYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Vector3 JROGDJXDQKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		float WRDRETNSTCQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		float WURUEBFLLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "56")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		Vector3 LSZXGKRJVRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		Quaternion GOCCYCVSGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		float TEAHUUGNNOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "61")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		float STVEYJONKSE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "63")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool OSWXTAUUJQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "65")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		TransformTrackRate QAIPJDPLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "67")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		bool CBIJVKAZZYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		Vector3 CUJKMYEUBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "71")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		float EFHRNQBDZAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "73")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		float TLPBRAXDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "74")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "75")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		Quaternion MNNDKHLHEHU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "77")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		Vector3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "79")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "81")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		RigidbodyConstraints BRFYXOLZCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(Slot = "83")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		bool NKNFNYBZXXV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "85")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		CollisionDetectionMode NZWQSZICZJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "87")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool MRCGPFUHMWC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RbexAction YLNBUCLIBKU;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RbexAction OUJVHEBRGPM;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RbexAction ITXXROJJITF;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RbexAction JKNPYNIICDY;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RbexAction UEXVUWFUIRR;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RbexAction EHAGBLPBDNE;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event RbexAction IFPNYWKNMIB;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexParentChangeAction KPKZLGALJHC;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UpdateLOD, UpdateLOD> CSGCRCJQBEM;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		LXUPYHZBZJT NJFBOEXBSEC(int a);

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void NPMABWUKGBF((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "89")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "90")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "91")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void OnDestroy();

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void SetParent(LXUPYHZBZJT value, bool isPhysicallyDetachedOnly = false);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void WRQDVZSAQUJ(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void ALHGLJSLWJW(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "97")]
		Vector3 YPKMPNFBOFR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "98")]
		Vector3 QAIXHGLGTND(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void ZDKPEVDVEEK();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void LVVLWBMRZLB();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void MCQBNWMCNZI();

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void IHXJKMBIMTE(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "103")]
		void BLHUQEBCBOP(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "104")]
		void MANMXVCYIEK(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "105")]
		void QZFKXASVYKM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "106")]
		void QKWMHBMXTOR(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "107")]
		void YCGZAVPWGQO(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "108")]
		Vector3 QSJCZUUDSVN(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "109")]
		Vector3 AOXLURTOEVP(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "110")]
		void GNUDOOUXQAG();

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "111")]
		void TAWPVMUYQXO(LXUPYHZBZJT a, object b);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "112")]
		void IDTUFHGJOZT(object a);

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "113")]
		void OYEMNLQPEHP();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "114")]
		void LAPJFJGAHUC();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "115")]
		void OXLQGXAIGFJ();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "116")]
		bool JGCPBCSKBCV();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "117")]
		void RKYXLQNOLOF();

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "118")]
		void ZVQCSLWDZWM(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "119")]
		void OLXCXOCOVEZ(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "120")]
		void DFZMGVMLCVL(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "121")]
		void IANYDHQMCBV(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "122")]
		void DNWLVXMFKVJ(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "123")]
		bool AETYWSNIILY(float a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "124")]
		void BGYCNWQZPOH(object a);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "125")]
		void CUDKGZWQNNK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "126")]
		void TFXFJGHHFHF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "127")]
		void DTJULSXSPPU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "128")]
		void USYWIONWZMS(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "129")]
		void YAPLWXIDAZG(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "130")]
		void SZAHRAMMZXH(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "131")]
		void GHUSPGJLABX(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "132")]
		bool HXXFZGWJNGE(Vector3 a, [Out] RaycastHit b, float c);

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "133")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface HAIRCSDLSLS
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class CJSBCKIWMLR : HAIRCSDLSLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public CJSBCKIWMLR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "0")]
		void HYXDXFCKJQR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "1")]
		void QJPGBJXYEZG(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "2")]
		void GBTRDCPODIE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "3")]
		void REGRDDPTKDZ(Vector3 a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface DBBKETFETMV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 CXYMNJQTGHL();

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 YSJAWMVYBKU();

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZEEGGALKPBN(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void RbexAction(OGYYXGOOHSH thisRigidbodyEx);
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
	public delegate void RbexParentChangeAction(OGYYXGOOHSH thisRigidbodyEx, bool isPhysicallyDetachedOnly = false);
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
		public GameObject FFDFHWZHUDT
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6590", Offset = "0x9BD5590", VA = "0x189BD6590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ObjectNetworkId YVFGQNGUAIL
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD61C0", Offset = "0x9BD51C0", VA = "0x189BD61C0")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public ObjectType PXKGTKDNITJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5EF0", Offset = "0x9BD4EF0", VA = "0x189BD5EF0")]
			get
			{
				return default(ObjectType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public RRObjectPrefabData XPIYFOQEWMC
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6950", Offset = "0x9BD5950", VA = "0x189BD6950")]
			get
			{
				return default(RRObjectPrefabData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool CSNUTABYSGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD67B0", Offset = "0x9BD57B0", VA = "0x189BD67B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool JZRFHSTNQFF
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5FB0", Offset = "0x9BD4FB0", VA = "0x189BD5FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool OIDRLIWCRUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6370", Offset = "0x9BD5370", VA = "0x189BD6370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool UDDEOYDXFZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5F90", Offset = "0x9BD4F90", VA = "0x189BD5F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool QRBMMDACEYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6800", Offset = "0x9BD5800", VA = "0x189BD6800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool IEVKADQJRTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6060", Offset = "0x9BD5060", VA = "0x189BD6060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool XFOKXAVZDHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6330", Offset = "0x9BD5330", VA = "0x189BD6330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool OONEMSITTQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6020", Offset = "0x9BD5020", VA = "0x189BD6020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool LCFLGMXHOSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6770", Offset = "0x9BD5770", VA = "0x189BD6770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool SZYICWUERUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6910", Offset = "0x9BD5910", VA = "0x189BD6910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool DKIALIRXGEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6450", Offset = "0x9BD5450", VA = "0x189BD6450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool OYGNCHDWRJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6CB0", Offset = "0x9BD5CB0", VA = "0x189BD6CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool DDUSIIAVFUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6C70", Offset = "0x9BD5C70", VA = "0x189BD6C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool OSRQFOXVPGS
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD64E0", Offset = "0x9BD54E0", VA = "0x189BD64E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool GKGKWKABSYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6090", Offset = "0x9BD5090", VA = "0x189BD6090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool OBPVEWKLDXP
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6FD0", Offset = "0x9BD5FD0", VA = "0x189BD6FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool LERSLQYOYWM
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6390", Offset = "0x9BD5390", VA = "0x189BD6390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public RRObjectCircuitBoard XHMXZVMHNYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectCircuitBoard);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public RRObjectIdentity PENTZHYXMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectIdentity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RRObjectPhysics WDNILCBEMDT
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectPhysics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public RRObjectPlayerInteraction BWLUBIQRGJR
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectPlayerInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RRObjectPolicy UMIGAUMIEES
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectPolicy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public RRObjectReferenceGroup OGJLEMWJJOM
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectReferenceGroup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public RRObjectRenderEffects DYVLYFRNJTM
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectRenderEffects);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public RRObjectReplicatedObject JDXTBPMZTFA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectReplicatedObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public RRObjectReplicator OLYJLFYEPYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectReplicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public RRObjectScope KOPZCPMGRRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectScope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public RRObjectToolCleanup LWFTKVRKLCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectToolCleanup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public RRObjectUserTags JAHEZXJYVLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectUserTags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public RRObjectAIMetadata GIZDCPZALOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectAIMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RRObjectDeformable KBCZLBVKIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectDeformable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public RRObjectObjectInteractionFilter RQYIRIKHFET
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectObjectInteractionFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool SJOZJJLZQSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6DF0", Offset = "0x9BD5DF0", VA = "0x189BD6DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool IPIPEZDSOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6A70", Offset = "0x9BD5A70", VA = "0x189BD6A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool LROUSFNJANU
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6F90", Offset = "0x9BD5F90", VA = "0x189BD6F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool SJXJLVVMDOY
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6F80", Offset = "0x9BD5F80", VA = "0x189BD6F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool GCEGZECJUDW
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD62F0", Offset = "0x9BD52F0", VA = "0x189BD62F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool FTGAARJNIMB
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD7010", Offset = "0x9BD6010", VA = "0x189BD7010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool VNOTECCJADG
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD6550", Offset = "0x9BD5550", VA = "0x189BD6550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public RRObjectTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RRObjectHierarchy SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D60", Offset = "0x9BC2D60", VA = "0x189BC3D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator RRObject(ObjectLocalId objectId)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD63D0", Offset = "0x9BD53D0", VA = "0x189BD63D0")]
		public RRObjectContainer KLLSNAXLMJF()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6520", Offset = "0x9BD5520", VA = "0x189BD6520")]
		public RRObjectShape NDGYJVYVCKB()
		{
			return default(RRObjectShape);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6170", Offset = "0x9BD5170", VA = "0x189BD6170")]
		public RRObjectConnectable EEJUMXPREDE()
		{
			return default(RRObjectConnectable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9BD67D0", Offset = "0x9BD57D0", VA = "0x189BD67D0")]
		public RRObjectPlayer PUXIXSVEBOV()
		{
			return default(RRObjectPlayer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5FD0", Offset = "0x9BD4FD0", VA = "0x189BD5FD0")]
		public RRObjectPlayerInteractionFilter BHZTRBYKLRE()
		{
			return default(RRObjectPlayerInteractionFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9BD68C0", Offset = "0x9BD58C0", VA = "0x189BD68C0")]
		public RRObjectStudioObject RBOJKHTIXSF()
		{
			return default(RRObjectStudioObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6720", Offset = "0x9BD5720", VA = "0x189BD6720")]
		public RRObjectElementSnapPoint NZNFCAJJIFQ()
		{
			return default(RRObjectElementSnapPoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6490", Offset = "0x9BD5490", VA = "0x189BD6490")]
		public RRObjectElement MDYUPGAUMXC()
		{
			return default(RRObjectElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6AB0", Offset = "0x9BD5AB0", VA = "0x189BD6AB0")]
		public RRObjectTerrain TCNAUUXAGNX()
		{
			return default(RRObjectTerrain);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6CF0", Offset = "0x9BD5CF0", VA = "0x189BD6CF0")]
		public void VJHHRUOBKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD60D0", Offset = "0x9BD50D0", VA = "0x189BD60D0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6820", Offset = "0x9BD5820", VA = "0x189BD6820")]
		public void QQNUVJSFQCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6EE0", Offset = "0x9BD5EE0", VA = "0x189BD6EE0")]
		public bool WNAADBVYJYU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6B00", Offset = "0x9BD5B00", VA = "0x189BD6B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObject value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator ObjectLocalId(RRObject value)
		{
			return default(ObjectLocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8AD0", Offset = "0x9BC7AD0", VA = "0x189BC8AD0")]
		public static bool IQJYWSDTJLC(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DC0", Offset = "0x9BC2DC0", VA = "0x189BC3DC0")]
		public static bool OOOEUMVNSLV(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD6260", Offset = "0x9BD5260", VA = "0x189BD6260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
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
		private DCHYTMGFCDF YEKQGVHLOHP
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9BC5F00", Offset = "0x9BC4F00", VA = "0x189BC5F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5CF0", Offset = "0x9BC4CF0", VA = "0x189BC5CF0")]
		public void MWAGCNYZOHX(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5A70", Offset = "0x9BC4A70", VA = "0x189BC5A70")]
		public bool JYUTKIQFVEY([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5F60", Offset = "0x9BC4F60", VA = "0x189BC5F60")]
		public bool XDKZRXILIUG([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5DF0", Offset = "0x9BC4DF0", VA = "0x189BC5DF0")]
		public void RVHCJWNYIGE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5960", Offset = "0x9BC4960", VA = "0x189BC5960")]
		[CanBeNull]
		public string GXIKZCFYXUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5B70", Offset = "0x9BC4B70", VA = "0x189BC5B70")]
		public bool KSKAOYZUFSD([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6070", Offset = "0x9BC5070", VA = "0x189BC6070")]
		public void YNVOBIYOEBW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectAIMetadata(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9BC58D0", Offset = "0x9BC48D0", VA = "0x189BC58D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectAIMetadata other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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
		private EVTOWQLXIRU XQBVJELAJYP
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6960", Offset = "0x9BC5960", VA = "0x189BC6960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		private DCHYTMGFCDF PGVYKNTUZPE
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x9BC61A0", Offset = "0x9BC51A0", VA = "0x189BC61A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool KWNAOKTFREJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6110", Offset = "0x9BC5110", VA = "0x189BC6110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool ITDNLOVJTYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6280", Offset = "0x9BC5280", VA = "0x189BC6280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public bool URIHQSSNSPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6560", Offset = "0x9BC5560", VA = "0x189BC6560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Guid ADZMCGTTPLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6740", Offset = "0x9BC5740", VA = "0x189BC6740")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Guid POILAGDGQRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6200", Offset = "0x9BC5200", VA = "0x189BC6200")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Guid OBNSMBEJBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6350", Offset = "0x9BC5350", VA = "0x189BC6350")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public RRObjectHierarchy SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9BC67C0", Offset = "0x9BC57C0", VA = "0x189BC67C0")]
		public bool PIXYRAQFHKS([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6AE0", Offset = "0x9BC5AE0", VA = "0x189BC6AE0")]
		public bool ZUPGBKOOIPA([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9BC69C0", Offset = "0x9BC59C0", VA = "0x189BC69C0")]
		public void XWEEYJPZNSR(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6860", Offset = "0x9BC5860", VA = "0x189BC6860")]
		public void UJMZZZEJKCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6620", Offset = "0x9BC5620", VA = "0x189BC6620")]
		public Guid MSNQBQQSENM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectCircuitBoard(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC62C0", Offset = "0x9BC52C0", VA = "0x189BC62C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectCircuitBoard other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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
		private VHNQEOVNDKG FIWTVKRWTOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7330", Offset = "0x9BC6330", VA = "0x189BC7330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public RigidTransform DPQIMWDPJTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7170", Offset = "0x9BC6170", VA = "0x189BC7170")]
			get
			{
				return default(RigidTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public Vector3 RPLSWDYNJBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7020", Offset = "0x9BC6020", VA = "0x189BC7020")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public Quaternion PJEUHTSSRXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9BC76B0", Offset = "0x9BC66B0", VA = "0x189BC76B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public float ZSUXMAUJNBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x9BC74E0", Offset = "0x9BC64E0", VA = "0x189BC74E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RRObject AOOQTXPWAQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x9BC72A0", Offset = "0x9BC62A0", VA = "0x189BC72A0")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6B80", Offset = "0x9BC5B80", VA = "0x189BC6B80")]
		public NativeObjectLocalIdArray AEXONULEHLX(Allocator a)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC7610", Offset = "0x9BC6610", VA = "0x189BC7610")]
		public bool RLDNZWBKURQ(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC7390", Offset = "0x9BC6390", VA = "0x189BC7390")]
		public void MRFEIQWEHKY(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6E80", Offset = "0x9BC5E80", VA = "0x189BC6E80")]
		public void EMALDLCGAQH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6CC0", Offset = "0x9BC5CC0", VA = "0x189BC6CC0")]
		public void DNLSQVIBMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectConnectable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectConnectable value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator ObjectLocalId(RRObjectConnectable value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F90", Offset = "0x9BC5F90", VA = "0x189BC6F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectConnectable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		private OHXWWKOOZRX CNNUVDWIJHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7EC0", Offset = "0x9BC6EC0", VA = "0x189BC7EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
		public Span<RRObject> HVTKKGTTFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7810", Offset = "0x9BC6810", VA = "0x189BC7810")]
			get
			{
				return default(Span<RRObject>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x9BC7F20", Offset = "0x9BC6F20", VA = "0x189BC7F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9BC79A0", Offset = "0x9BC69A0", VA = "0x189BC79A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public RRObjectTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public RRObjectHierarchy SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC7A20", Offset = "0x9BC6A20", VA = "0x189BC7A20")]
		public void FSCVKUTGYEM(RRObjectContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectContainer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectContainer value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC7910", Offset = "0x9BC6910", VA = "0x189BC7910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectContainer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
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
		private GRVBYUYUBSW wrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool isReadOnly;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public RRObject Object
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			[CompilerGenerated]
			readonly get
			{
				return default(RRObject);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public CreationInstantiationKey this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x9BC82C0", Offset = "0x9BC72C0", VA = "0x189BC82C0")]
			readonly set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC81F0", Offset = "0x9BC71F0", VA = "0x189BC81F0")]
		internal RRObjectCreationParameters(RRObject obj, bool isReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9BC7FA0", Offset = "0x9BC6FA0", VA = "0x189BC7FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EED460", Offset = "0x3EEC460", VA = "0x183EED460")]
		public void XTVSHKXLHAB<a>(CreationInstantiationKey a, a b, [Optional] a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8140", Offset = "0x9BC7140", VA = "0x189BC8140")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
		public Dictionary<int, object> PEVYLTYKTEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC80D0", Offset = "0x9BC70D0", VA = "0x189BC80D0")]
		private readonly void EGDOAAIJBDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class LWZNSXGXGQT
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0CB0", Offset = "0x9BBFCB0", VA = "0x189BC0CB0")]
		public static RRObjectCreationParameters XGFYNZVCAVA(this RRObject a)
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

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		private bool DKIALIRXGEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8510", Offset = "0x9BC7510", VA = "0x189BC8510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public Vector3 CCVDKPDFHOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8740", Offset = "0x9BC7740", VA = "0x189BC8740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x9BC86E0", Offset = "0x9BC76E0", VA = "0x189BC86E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8400", Offset = "0x9BC7400", VA = "0x189BC8400")]
		public Vector3 AJADOVLNXHY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8380", Offset = "0x9BC7380", VA = "0x189BC8380")]
		public void AIANJSLROWK([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8600", Offset = "0x9BC7600", VA = "0x189BC8600")]
		public void TUMYRUDRKAU([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8550", Offset = "0x9BC7550", VA = "0x189BC8550")]
		public bool RXAKZOZIYRX([In] Vector3 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectDeformable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8480", Offset = "0x9BC7480", VA = "0x189BC8480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectDeformable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8680", Offset = "0x9BC7680", VA = "0x189BC8680", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8870", Offset = "0x9BC7870", VA = "0x189BC8870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectDesync other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		private PQSFFCXSVQS SMEBLUCYTBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9310", Offset = "0x9BC8310", VA = "0x189BC9310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public bool YJYTQSDMYSE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8E20", Offset = "0x9BC7E20", VA = "0x189BC8E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public bool QCURIWDYTZY
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8CF0", Offset = "0x9BC7CF0", VA = "0x189BC8CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public ElementGroupStatusData DMZEYRDKUNV
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9400", Offset = "0x9BC8400", VA = "0x189BC9400")]
			get
			{
				return default(ElementGroupStatusData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public bool GWOYWUXPGNR
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9240", Offset = "0x9BC8240", VA = "0x189BC9240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public bool HIVKNJPLAIK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9280", Offset = "0x9BC8280", VA = "0x189BC9280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public bool UNQYMCIJWVU
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9370", Offset = "0x9BC8370", VA = "0x189BC9370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8F50", Offset = "0x9BC7F50", VA = "0x189BC8F50")]
		public bool DYWAKRZMAEF(RRObjectElement a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9BC91A0", Offset = "0x9BC81A0", VA = "0x189BC91A0")]
		public bool KQUMXNCKHOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9530", Offset = "0x9BC8530", VA = "0x189BC9530")]
		public bool YORLANFWXIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9080", Offset = "0x9BC8080", VA = "0x189BC9080")]
		public ReadOnlySpan<ObjectLocalId> HFCPZIWCFUG()
		{
			return default(ReadOnlySpan<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectElement(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8AD0", Offset = "0x9BC7AD0", VA = "0x189BC8AD0")]
		public static bool IQJYWSDTJLC(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DC0", Offset = "0x9BC2DC0", VA = "0x189BC3DC0")]
		public static bool OOOEUMVNSLV(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8FF0", Offset = "0x9BC7FF0", VA = "0x189BC8FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectElement other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		private PQSFFCXSVQS BKIUVUECGWP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8BC0", Offset = "0x9BC7BC0", VA = "0x189BC8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public bool KYNEQUMVEXM
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x9BC8C20", Offset = "0x9BC7C20", VA = "0x189BC8C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public RRObjectTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8900", Offset = "0x9BC7900", VA = "0x189BC8900")]
		public bool DYWAKRZMAEF(RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8A30", Offset = "0x9BC7A30", VA = "0x189BC8A30")]
		public bool GVINKFMWRXJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8AE0", Offset = "0x9BC7AE0", VA = "0x189BC8AE0")]
		public bool JXXIYXHMTOF([Out] RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8C80", Offset = "0x9BC7C80", VA = "0x189BC8C80")]
		public void ZLMHSDXCQHM(ElementSnapPointRuntimeFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectElementSnapPoint(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8AD0", Offset = "0x9BC7AD0", VA = "0x189BC8AD0")]
		public static bool IQJYWSDTJLC(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DC0", Offset = "0x9BC2DC0", VA = "0x189BC3DC0")]
		public static bool OOOEUMVNSLV(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC89A0", Offset = "0x9BC79A0", VA = "0x189BC89A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectElementSnapPoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		private OHXWWKOOZRX CNNUVDWIJHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9910", Offset = "0x9BC8910", VA = "0x189BC9910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public ObjectLocalId JMIDBODQUDP
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9BC95D0", Offset = "0x9BC85D0", VA = "0x189BC95D0")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public RRObject LXEGSVYJGSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9880", Offset = "0x9BC8880", VA = "0x189BC9880")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public RRObject OFIFJQDFJXG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9660", Offset = "0x9BC8660", VA = "0x189BC9660")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9C10", Offset = "0x9BC8C10", VA = "0x189BC9C10")]
		public Span<RRObject> NOPLRBBZORR()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9B10", Offset = "0x9BC8B10", VA = "0x189BC9B10")]
		public Span<RRObject> NBCVONCYDHO()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9EE0", Offset = "0x9BC8EE0", VA = "0x189BC9EE0")]
		public Span<RRObject> XJQIQPNKPCF()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9780", Offset = "0x9BC8780", VA = "0x189BC9780")]
		public Span<RRObject> HGWFDLFJGIB()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9D10", Offset = "0x9BC8D10", VA = "0x189BC9D10")]
		public bool SetParent(RRObject parent, bool worldPositionStays = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9E40", Offset = "0x9BC8E40", VA = "0x189BC9E40")]
		public bool VVKCICVJOYB(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9A00", Offset = "0x9BC8A00", VA = "0x189BC9A00")]
		public RRObject MBIKJQBDGVT(uint a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC9970", Offset = "0x9BC8970", VA = "0x189BC9970")]
		public RRObjectContainer KLTMHZLHQAT()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectHierarchy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectHierarchy value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9BC96F0", Offset = "0x9BC86F0", VA = "0x189BC96F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectHierarchy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string XPLVRGXLMTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA410", Offset = "0x9BC9410", VA = "0x189BCA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string TNXGIGDPDVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA3D0", Offset = "0x9BC93D0", VA = "0x189BCA3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public string POJGGLCWMGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA4A0", Offset = "0x9BC94A0", VA = "0x189BCA4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public string TWSVURHXCXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x9BC9FE0", Offset = "0x9BC8FE0", VA = "0x189BC9FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA310", Offset = "0x9BC9310", VA = "0x189BCA310")]
		public bool KSKAOYZUFSD([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectIdentity(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA280", Offset = "0x9BC9280", VA = "0x189BCA280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectIdentity other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA550", Offset = "0x9BC9550", VA = "0x189BCA550", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectInternal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		private SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D60", Offset = "0x9BC2D60", VA = "0x189BC3D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		private EntityManager HVJITUBUWTE
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA8E0", Offset = "0x9BC98E0", VA = "0x189BCA8E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB730", Offset = "0x9BCA730", VA = "0x189BCB730")]
		public float WOIOHQXRQTK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9BCACD0", Offset = "0x9BC9CD0", VA = "0x189BCACD0")]
		public void NBAMSAMKLNO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB4B0", Offset = "0x9BCA4B0", VA = "0x189BCB4B0")]
		public static ConnectResult UMWOEKLJHRV(RRObjectMagneticAnchor a, RRObjectMagneticAnchor b)
		{
			return default(ConnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9BCAE90", Offset = "0x9BC9E90", VA = "0x189BCAE90")]
		public bool POWDDYZZLFC([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g, [Out] RRObject h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA5E0", Offset = "0x9BC95E0", VA = "0x189BCA5E0")]
		public bool BCXNWEHUBMU([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA910", Offset = "0x9BC9910", VA = "0x189BCA910")]
		private void KHVVGLLVUEP(Entity a, EntityManager b, MagneticAnchorData c, [Out] GameObject d, [Out] GameObject e, [Out] RRObject f, [Out] RRObject g, [Out] Vector3 h, [Out] Vector3 i, [Out] Vector3 j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectMagneticAnchor(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCA850", Offset = "0x9BC9850", VA = "0x189BCA850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectMagneticAnchor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB450", Offset = "0x9BCA450", VA = "0x189BCB450", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB820", Offset = "0x9BCA820", VA = "0x189BCB820", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectNetworkComponents other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		private FYUXRLHIKCV BKIUVUECGWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBD20", Offset = "0x9BCAD20", VA = "0x189BCBD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public InteractionFilterMode VCPJRYGHJXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBCE0", Offset = "0x9BCACE0", VA = "0x189BCBCE0")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBA60", Offset = "0x9BCAA60", VA = "0x189BCBA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public RentedArray<string> ZLUFNTFWAJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBBD0", Offset = "0x9BCABD0", VA = "0x189BCBBD0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9BCB8B0", Offset = "0x9BCA8B0", VA = "0x189BCB8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public RentedArray<string> WQDAOJIZGZT
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBD80", Offset = "0x9BCAD80", VA = "0x189BCBD80")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x9BCBAB0", Offset = "0x9BCAAB0", VA = "0x189BCBAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectObjectInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x9BCB9D0", Offset = "0x9BCA9D0", VA = "0x189BCB9D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectObjectInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public Collider IPTGXPDRCOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC100", Offset = "0x9BCB100", VA = "0x189BCC100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public CollisionLayerEnum SYADIDSXHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC480", Offset = "0x9BCB480", VA = "0x189BCC480")]
			get
			{
				return default(CollisionLayerEnum);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC430", Offset = "0x9BCB430", VA = "0x189BCC430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public CollisionMode RWDVGIEPEIT
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC370", Offset = "0x9BCB370", VA = "0x189BCC370")]
			get
			{
				return default(CollisionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC4C0", Offset = "0x9BCB4C0", VA = "0x189BCC4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public GrabbableMode EVTNFHVPWBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCCC0", Offset = "0x9BCBCC0", VA = "0x189BCCCC0")]
			get
			{
				return default(GrabbableMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC2E0", Offset = "0x9BCB2E0", VA = "0x189BCC2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public float PHTNUTZMNYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC330", Offset = "0x9BCB330", VA = "0x189BCC330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCC70", Offset = "0x9BCBC70", VA = "0x189BCCC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public bool DHLZHQUUWOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCD80", Offset = "0x9BCBD80", VA = "0x189BCCD80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCBD0", Offset = "0x9BCBBD0", VA = "0x189BCCBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public bool ONLIAWLFVKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCD00", Offset = "0x9BCBD00", VA = "0x189BCCD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC710", Offset = "0x9BCB710", VA = "0x189BCC710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public bool LIIIIAXZIZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9BCC7B0", Offset = "0x9BCB7B0", VA = "0x189BCC7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC510", Offset = "0x9BCB510", VA = "0x189BCC510")]
		public static bool KUOUGDQCKBF(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC830", Offset = "0x9BCB830", VA = "0x189BCC830")]
		public static bool PXXJOAVVPYH(RRObject a, [Out] RRObjectPhysics b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9BCBEA0", Offset = "0x9BCAEA0", VA = "0x189BCBEA0")]
		public bool ACHHKPTAOEQ([Out] EJFBPJOFWSR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9BCCA80", Offset = "0x9BCBA80", VA = "0x189BCCA80")]
		public bool SRZFYROGHDT([Out] ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC0A0", Offset = "0x9BCB0A0", VA = "0x189BCC0A0")]
		public bool CNMAQIVTWOU(PhysicsModelEnumFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC3B0", Offset = "0x9BCB3B0", VA = "0x189BCC3B0")]
		public void KBLNYAOGTPG(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC000", Offset = "0x9BCB000", VA = "0x189BCC000")]
		public void CBKVOZIFCAD(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectPhysics(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCC250", Offset = "0x9BCB250", VA = "0x189BCC250", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectPhysics other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9BCCB70", Offset = "0x9BCBB70", VA = "0x189BCCB70", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public bool HSAPZMUJKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE010", Offset = "0x9BCD010", VA = "0x189BCE010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectPlayer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9BCDF80", Offset = "0x9BCCF80", VA = "0x189BCDF80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectPlayer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		private ODGNUZRWIZX FSWJVRDSGTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9BCDF20", Offset = "0x9BCCF20", VA = "0x189BCDF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x9BCDE30", Offset = "0x9BCCE30", VA = "0x189BCDE30")]
		public void MTHPXJVMTSP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectPlayerInteraction(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9BCDDA0", Offset = "0x9BCCDA0", VA = "0x189BCDDA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteraction other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		private ZWCAHRSJCLZ MBDJJIXMWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x9BCDC20", Offset = "0x9BCCC20", VA = "0x189BCDC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public InteractionFilterMode AXVINKKBOER
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9BCCFD0", Offset = "0x9BCBFD0", VA = "0x189BCCFD0")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD310", Offset = "0x9BCC310", VA = "0x189BCD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public bool CLCUTZEOTZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD830", Offset = "0x9BCC830", VA = "0x189BCD830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD5D0", Offset = "0x9BCC5D0", VA = "0x189BCD5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public RentedArray<string> MGDITHJYTPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD8C0", Offset = "0x9BCC8C0", VA = "0x189BCD8C0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9BCDC80", Offset = "0x9BCCC80", VA = "0x189BCDC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public RentedArray<string> ZBBTKNLNEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD0D0", Offset = "0x9BCC0D0", VA = "0x189BCD0D0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD9E0", Offset = "0x9BCC9E0", VA = "0x189BCD9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public RentedArray<string> AXBYHWNRTTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD710", Offset = "0x9BCC710", VA = "0x189BCD710")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD4B0", Offset = "0x9BCC4B0", VA = "0x189BCD4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public RentedArray<string> PHYZUUPLFGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x9BCD1F0", Offset = "0x9BCC1F0", VA = "0x189BCD1F0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x9BCDB00", Offset = "0x9BCCB00", VA = "0x189BCDB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9BCD670", Offset = "0x9BCC670", VA = "0x189BCD670")]
		public bool MIWWTZUODJD(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectPlayerInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator ObjectLocalId(RRObjectPlayerInteractionFilter value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9BCD420", Offset = "0x9BCC420", VA = "0x189BCD420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool OHIEAHSTJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE140", Offset = "0x9BCD140", VA = "0x189BCE140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool GNZYSNBCOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE6D0", Offset = "0x9BCD6D0", VA = "0x189BCE6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public bool UULPYXKVUHK
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE720", Offset = "0x9BCD720", VA = "0x189BCE720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE1D0", Offset = "0x9BCD1D0", VA = "0x189BCE1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool IVYCYALHHLY
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE550", Offset = "0x9BCD550", VA = "0x189BCE550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool DTQEGMRECWF
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE5E0", Offset = "0x9BCD5E0", VA = "0x189BCE5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool MLLAEZXKSSG
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEBC0", Offset = "0x9BCDBC0", VA = "0x189BCEBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool WESXLCTSVKE
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEF00", Offset = "0x9BCDF00", VA = "0x189BCEF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool KEQHIVTBBFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE630", Offset = "0x9BCD630", VA = "0x189BCE630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool ECDAXBEFMCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEF50", Offset = "0x9BCDF50", VA = "0x189BCEF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool CYPOSACJUJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE4B0", Offset = "0x9BCD4B0", VA = "0x189BCE4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public bool BNZVUZGBZXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE8A0", Offset = "0x9BCD8A0", VA = "0x189BCE8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public bool PZJYTCQQFWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE500", Offset = "0x9BCD500", VA = "0x189BCE500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool KARNVRMCFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE460", Offset = "0x9BCD460", VA = "0x189BCE460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public bool CBGLFNBPORI
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE100", Offset = "0x9BCD100", VA = "0x189BCE100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE770", Offset = "0x9BCD770", VA = "0x189BCE770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public bool UBEZTJOVEQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE1F0", Offset = "0x9BCD1F0", VA = "0x189BCE1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public NavMeshGenerationMode GJQEHTANFDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEC10", Offset = "0x9BCDC10", VA = "0x189BCEC10")]
			get
			{
				return default(NavMeshGenerationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE240", Offset = "0x9BCD240", VA = "0x189BCE240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public bool TNYOWRHZNQA
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEC50", Offset = "0x9BCDC50", VA = "0x189BCEC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public CircuitsTransformBehavior CCVSQISXLFY
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE5A0", Offset = "0x9BCD5A0", VA = "0x189BCE5A0")]
			get
			{
				return default(CircuitsTransformBehavior);
			}
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE180", Offset = "0x9BCD180", VA = "0x189BCE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public bool KWKQANCCKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE320", Offset = "0x9BCD320", VA = "0x189BCE320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public Vector3 QWSKOJBPXTH
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE820", Offset = "0x9BCD820", VA = "0x189BCE820")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public Vector3 VPCIEWFELQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEDF0", Offset = "0x9BCDDF0", VA = "0x189BCEDF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public bool LHJOCSANFVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE8F0", Offset = "0x9BCD8F0", VA = "0x189BCE8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public bool ICFZHNQNEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x9BCE360", Offset = "0x9BCD360", VA = "0x189BCE360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		private EntityManager HVJITUBUWTE
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x9BCA8E0", Offset = "0x9BC98E0", VA = "0x189BCA8E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE060", Offset = "0x9BCD060", VA = "0x189BCE060")]
		public bool BHFHNHODWNW(ObjectPolicyEnum a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9BCEE70", Offset = "0x9BCDE70", VA = "0x189BCEE70")]
		public void WMZFSDIELEQ(ObjectPolicyEnum a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE7D0", Offset = "0x9BCD7D0", VA = "0x189BCE7D0")]
		public bool QWMZCLQYNWO(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9BCED70", Offset = "0x9BCDD70", VA = "0x189BCED70")]
		public void UMTLGPSKJYO(ObjectPolicyUserConfigurableFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE0C0", Offset = "0x9BCD0C0", VA = "0x189BCE0C0")]
		public ObjectPolicyUserConfigurableFlags BKNCXAKZDVB()
		{
			return default(ObjectPolicyUserConfigurableFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE680", Offset = "0x9BCD680", VA = "0x189BCE680")]
		public bool OQSCHTOJDRF(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectPolicy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE290", Offset = "0x9BCD290", VA = "0x189BCE290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectPolicy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		private BFWVMJIJWJM IEUIRTYRZPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x9BCEFA0", Offset = "0x9BCDFA0", VA = "0x189BCEFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF4F0", Offset = "0x9BCE4F0", VA = "0x189BCF4F0")]
		public bool LYMKBQGSPFB(ReferenceGroupKind a, List<RRObject> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF9E0", Offset = "0x9BCE9E0", VA = "0x189BCF9E0")]
		public int YCEQGNLFRKW(ReferenceGroupKind a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF2B0", Offset = "0x9BCE2B0", VA = "0x189BCF2B0")]
		public void IMCXGDHTKVE(List<RRObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF8B0", Offset = "0x9BCE8B0", VA = "0x189BCF8B0")]
		public int UZIXKKPPECR(RRObject a, ReferenceGroupKind b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF3C0", Offset = "0x9BCE3C0", VA = "0x189BCF3C0")]
		public RRObject LIWVCUKLYWO(int a, ReferenceGroupKind b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF620", Offset = "0x9BCE620", VA = "0x189BCF620")]
		public void TKGTYWBEQZH(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF750", Offset = "0x9BCE750", VA = "0x189BCF750")]
		public bool TKTYUBMFFGD(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF000", Offset = "0x9BCE000", VA = "0x189BCF000")]
		public void AJTGZUBOACE(ReferenceGroupKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF800", Offset = "0x9BCE800", VA = "0x189BCF800")]
		public bool TLZMTJAUDHU(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF1A0", Offset = "0x9BCE1A0", VA = "0x189BCF1A0")]
		public bool GSUWYMBOYQS(ReferenceGroupKind a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectReferenceGroup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF110", Offset = "0x9BCE110", VA = "0x189BCF110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectReferenceGroup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BCFAF0", Offset = "0x9BCEAF0", VA = "0x189BCFAF0")]
		public void CBJGESRWLQN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BCFC10", Offset = "0x9BCEC10", VA = "0x189BCFC10")]
		public void FFNROREQCXV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDC90", Offset = "0x3EECC90", VA = "0x183EEDC90")]
		public a TLRIWQLZAUB<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectRenderEffects(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x9BCFB80", Offset = "0x9BCEB80", VA = "0x189BCFB80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectRenderEffects other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public bool CZQALZCLPRA
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFDC0", Offset = "0x9BCEDC0", VA = "0x189BCFDC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFEC0", Offset = "0x9BCEEC0", VA = "0x189BCFEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public bool JKRGJVXBSYH
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFE00", Offset = "0x9BCEE00", VA = "0x189BCFE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public int PRRNGEPMOOY
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFE80", Offset = "0x9BCEE80", VA = "0x189BCFE80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFCA0", Offset = "0x9BCECA0", VA = "0x189BCFCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectReplicatedObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9BCFD30", Offset = "0x9BCED30", VA = "0x189BCFD30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectReplicatedObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public int WNCRGWTKPHR
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0110", Offset = "0x9BCF110", VA = "0x189BD0110")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0030", Offset = "0x9BCF030", VA = "0x189BD0030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public int ZJXEGITGZSL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFF10", Offset = "0x9BCEF10", VA = "0x189BCFF10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0080", Offset = "0x9BCF080", VA = "0x189BD0080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public uint GSDOHHEMEFD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x9BD00D0", Offset = "0x9BCF0D0", VA = "0x189BD00D0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x9BCFFE0", Offset = "0x9BCEFE0", VA = "0x189BCFFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectReplicator(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9BCFF50", Offset = "0x9BCEF50", VA = "0x189BCFF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectReplicator other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private WPEENMVPQPL TDBZHMPZRPV
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x9BD09F0", Offset = "0x9BCF9F0", VA = "0x189BD09F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		private XBTBGXVRMEZ WKQTAYVLYFN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0150", Offset = "0x9BCF150", VA = "0x189BD0150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public bool DRJHFQLLYQV
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0960", Offset = "0x9BCF960", VA = "0x189BD0960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public bool KNJGAPUJNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0710", Offset = "0x9BCF710", VA = "0x189BD0710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool CLEAFLOYTQF
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0510", Offset = "0x9BCF510", VA = "0x189BD0510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public bool JUXAMFCDKUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0540", Offset = "0x9BCF540", VA = "0x189BD0540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public bool UHDJKGUFYSH
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0320", Offset = "0x9BCF320", VA = "0x189BD0320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public bool VYWGHTJCMSU
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0610", Offset = "0x9BCF610", VA = "0x189BD0610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public bool RSQCRDBWAQK
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0B00", Offset = "0x9BCFB00", VA = "0x189BD0B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public bool EBLBMGTCHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x9BD01B0", Offset = "0x9BCF1B0", VA = "0x189BD01B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public bool LDNHSGBZBQG
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0350", Offset = "0x9BCF350", VA = "0x189BD0350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9BD06A0", Offset = "0x9BCF6A0", VA = "0x189BD06A0")]
		public bool NZZWFSVZDBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD07B0", Offset = "0x9BCF7B0", VA = "0x189BD07B0")]
		public RRObject QVFNSBSVXWP(RRObject a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0850", Offset = "0x9BCF850", VA = "0x189BD0850")]
		public ObjectLocalId QXNWWICLUGN()
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0A50", Offset = "0x9BCFA50", VA = "0x189BD0A50")]
		public bool VWRVYPFHUYR(ObjectLocalId a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectScope(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectScope value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0480", Offset = "0x9BCF480", VA = "0x189BD0480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectScope other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public EShapeType GJVLUAKAYMF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1BC0", Offset = "0x9BD0BC0", VA = "0x189BD1BC0")]
			get
			{
				return default(EShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public RenderableColor LPXTJPZIKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1A10", Offset = "0x9BD0A10", VA = "0x189BD1A10")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1B70", Offset = "0x9BD0B70", VA = "0x189BD1B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public RenderableMaterial KSFJLDIUTJD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1C00", Offset = "0x9BD0C00", VA = "0x189BD1C00")]
			get
			{
				return default(RenderableMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1C40", Offset = "0x9BD0C40", VA = "0x189BD1C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public float EOPHSKSLVST
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1EC0", Offset = "0x9BD0EC0", VA = "0x189BD1EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1B20", Offset = "0x9BD0B20", VA = "0x189BD1B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public Vector3 LLAYOCSJPSA
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1D60", Offset = "0x9BD0D60", VA = "0x189BD1D60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1C90", Offset = "0x9BD0C90", VA = "0x189BD1C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public float SDPVMFANIXC
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1F00", Offset = "0x9BD0F00", VA = "0x189BD1F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public ShapeConfigFlags VGGDXNOJJIN
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1DE0", Offset = "0x9BD0DE0", VA = "0x189BD1DE0")]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1E70", Offset = "0x9BD0E70", VA = "0x189BD1E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public bool XVNIIQJRSSH
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1A50", Offset = "0x9BD0A50", VA = "0x189BD1A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x9BD19B0", Offset = "0x9BD09B0", VA = "0x189BD19B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public RRObjectTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public RRObjectHierarchy SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1E20", Offset = "0x9BD0E20", VA = "0x189BD1E20")]
		public RRObjectShapePrimitive OZKZNMXDHUV()
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1D10", Offset = "0x9BD0D10", VA = "0x189BD1D10")]
		public RRObjectShapeSpline MJAUDYKRLIN()
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1FD0", Offset = "0x9BD0FD0", VA = "0x189BD1FD0")]
		private bool ZNAKSGPBAPD(ShapeConfigFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1F50", Offset = "0x9BD0F50", VA = "0x189BD1F50")]
		public void YOVESJUCOJA(ShapeConfigFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectShape(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectShape value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3DC0", Offset = "0x9BC2DC0", VA = "0x189BC3DC0")]
		public static bool OOOEUMVNSLV(RRObjectShape a, RRObjectShape b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1A90", Offset = "0x9BD0A90", VA = "0x189BD1A90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectShape other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public RRObjectShape PWKGDJMDBER
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public PrimitiveShapeType ZSCESOZTSPT
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0D30", Offset = "0x9BCFD30", VA = "0x189BD0D30")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectShapePrimitive(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectShapePrimitive value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0CA0", Offset = "0x9BCFCA0", VA = "0x189BD0CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectShapePrimitive other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		private BTZNJGALHRL CRHZMEQHHZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x9BD1140", Offset = "0x9BD0140", VA = "0x189BD1140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public RRObjectShape PWKGDJMDBER
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public SplineParameters LOBROSPYODP
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD14F0", Offset = "0x9BD04F0", VA = "0x189BD14F0")]
			get
			{
				return default(SplineParameters);
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD11A0", Offset = "0x9BD01A0", VA = "0x189BD11A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public IEnumerable<RRObjectSplinePoint> USHMEGBZNAT
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD16B0", Offset = "0x9BD06B0", VA = "0x189BD16B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public RRObjectSplinePoint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD18A0", Offset = "0x9BD08A0", VA = "0x189BD18A0")]
			get
			{
				return default(RRObjectSplinePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD0D70", Offset = "0x9BCFD70", VA = "0x189BD0D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public RRObjectTransform IBGMOBEIUDO
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0F20", Offset = "0x9BCFF20", VA = "0x189BD0F20")]
		public RRObjectSplinePoint FLYXUGEVGZO(float3? a, [Optional] quaternion? b, [Optional] Vector3? c)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x9BD12C0", Offset = "0x9BD02C0", VA = "0x189BD12C0")]
		public RRObjectSplinePoint Insert(int index, float3? position, [Optional] quaternion? rotation, [Optional] Vector3? scale)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x9BD1610", Offset = "0x9BD0610", VA = "0x189BD1610")]
		public void PWQUCYFMOWJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0E00", Offset = "0x9BCFE00", VA = "0x189BD0E00")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectShapeSpline(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x9BC77F0", Offset = "0x9BC67F0", VA = "0x189BC77F0")]
		public static implicit operator bool(RRObjectShapeSpline value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x9BC8AD0", Offset = "0x9BC7AD0", VA = "0x189BC8AD0")]
		public static bool IQJYWSDTJLC(RRObjectShapeSpline a, RRObjectShapeSpline b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9BD0E90", Offset = "0x9BCFE90", VA = "0x189BD0E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectShapeSpline other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public RRObjectShapeSpline RKVFIIVBRWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2020", Offset = "0x9BD1020", VA = "0x189BD2020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public float3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2190", Offset = "0x9BD1190", VA = "0x189BD2190")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2240", Offset = "0x9BD1240", VA = "0x189BD2240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x9BD21F0", Offset = "0x9BD11F0", VA = "0x189BD21F0")]
			get
			{
				return default(quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x9BD22A0", Offset = "0x9BD12A0", VA = "0x189BD22A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public float3 KUNLLKTXIHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2130", Offset = "0x9BD1130", VA = "0x189BD2130")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2300", Offset = "0x9BD1300", VA = "0x189BD2300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public FractionalIndex BDAHNGRSJUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2360", Offset = "0x9BD1360", VA = "0x189BD2360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x9BD22F0", Offset = "0x9BD12F0", VA = "0x189BD22F0")]
		public void WLPLEESEFFL(RRObjectShapeSpline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectSplinePoint(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD20A0", Offset = "0x9BD10A0", VA = "0x189BD20A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectSplinePoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool QVZVHIPXTKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2440", Offset = "0x9BD1440", VA = "0x189BD2440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectStudioObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x9BD23B0", Offset = "0x9BD13B0", VA = "0x189BD23B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectStudioObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		private ZOHMBYWXOFF JTRDCYDGXSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2F60", Offset = "0x9BD1F60", VA = "0x189BD2F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public uint MDQMYODBSLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2C90", Offset = "0x9BD1C90", VA = "0x189BD2C90")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2C00", Offset = "0x9BD1C00", VA = "0x189BD2C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public TerrainLayerRoughness BENMGAPMYZC
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2E40", Offset = "0x9BD1E40", VA = "0x189BD2E40")]
			get
			{
				return default(TerrainLayerRoughness);
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2620", Offset = "0x9BD1620", VA = "0x189BD2620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public float DLFXGVNBOSO
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2590", Offset = "0x9BD1590", VA = "0x189BD2590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2700", Offset = "0x9BD1700", VA = "0x189BD2700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public float PHLDSJJCHVH
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD24B0", Offset = "0x9BD14B0", VA = "0x189BD24B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2AF0", Offset = "0x9BD1AF0", VA = "0x189BD2AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public TerrainPlayAreaShape XVNNSQASVOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x9BD29A0", Offset = "0x9BD19A0", VA = "0x189BD29A0")]
			get
			{
				return default(TerrainPlayAreaShape);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x9BD24F0", Offset = "0x9BD14F0", VA = "0x189BD24F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public float NQSQRBIFGJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2CD0", Offset = "0x9BD1CD0", VA = "0x189BD2CD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2540", Offset = "0x9BD1540", VA = "0x189BD2540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public float PAVWHGDHUEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2F10", Offset = "0x9BD1F10", VA = "0x189BD2F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public float LOVMCHNGJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2ED0", Offset = "0x9BD1ED0", VA = "0x189BD2ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public float LSKLMSALJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2D60", Offset = "0x9BD1D60", VA = "0x189BD2D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2DF0", Offset = "0x9BD1DF0", VA = "0x189BD2DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public RenderableColor GJNUBTLDROG
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2920", Offset = "0x9BD1920", VA = "0x189BD2920")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD25D0", Offset = "0x9BD15D0", VA = "0x189BD25D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public RenderableColor LDZWOYABVOM
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2C50", Offset = "0x9BD1C50", VA = "0x189BD2C50")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2D10", Offset = "0x9BD1D10", VA = "0x189BD2D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public float BHTQRKXBYAV
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2960", Offset = "0x9BD1960", VA = "0x189BD2960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2E80", Offset = "0x9BD1E80", VA = "0x189BD2E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public TerrainWaterMaterial MLHIAOSRQEG
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3050", Offset = "0x9BD2050", VA = "0x189BD3050")]
			get
			{
				return default(TerrainWaterMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2DA0", Offset = "0x9BD1DA0", VA = "0x189BD2DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public WaterOverrides INGXHLOWJTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3010", Offset = "0x9BD2010", VA = "0x189BD3010")]
			get
			{
				return default(WaterOverrides);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2FC0", Offset = "0x9BD1FC0", VA = "0x189BD2FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public ReadOnlySpan<TerrainGenerationLayer> OQWAYWUPIVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2B40", Offset = "0x9BD1B40", VA = "0x189BD2B40")]
			get
			{
				return default(ReadOnlySpan<TerrainGenerationLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2750", Offset = "0x9BD1750", VA = "0x189BD2750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public ReadOnlySpan<TerrainCustomMaterialLayer> QSDFIQKPWNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x9BD2860", Offset = "0x9BD1860", VA = "0x189BD2860")]
			get
			{
				return default(ReadOnlySpan<TerrainCustomMaterialLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x9BD29E0", Offset = "0x9BD19E0", VA = "0x189BD29E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectTerrain(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator ObjectLocalId(RRObjectTerrain value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD2670", Offset = "0x9BD1670", VA = "0x189BD2670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectTerrain other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		private RAGQQAVCFVA CZIVUEJJUQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3470", Offset = "0x9BD2470", VA = "0x189BD3470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public bool CIHHACAIORW
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3550", Offset = "0x9BD2550", VA = "0x189BD3550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x9BD30F0", Offset = "0x9BD20F0", VA = "0x189BD30F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public bool VYTFOKBOGUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3640", Offset = "0x9BD2640", VA = "0x189BD3640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3090", Offset = "0x9BD2090", VA = "0x189BD3090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public float PCXDFIPOZUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x9BD39B0", Offset = "0x9BD29B0", VA = "0x189BD39B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x9BD31E0", Offset = "0x9BD21E0", VA = "0x189BD31E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public bool QGPMCHJRHUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3850", Offset = "0x9BD2850", VA = "0x189BD3850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x9BD35A0", Offset = "0x9BD25A0", VA = "0x189BD35A0")]
		public void QJAIRCXAIHR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x9BD38A0", Offset = "0x9BD28A0", VA = "0x189BD38A0")]
		public bool XRXREWHPAFE([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3230", Offset = "0x9BD2230", VA = "0x189BD3230")]
		public void ForceCleanup(bool forceImmediate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3420", Offset = "0x9BD2420", VA = "0x189BD3420")]
		public bool JHJKFSMSBQQ(ToolCleanupFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD34D0", Offset = "0x9BD24D0", VA = "0x189BD34D0")]
		public void MSIGRTVUWIZ(ToolCleanupFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD39F0", Offset = "0x9BD29F0", VA = "0x189BD39F0")]
		public void ZTTNZMYDWJE(float a, float b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD32D0", Offset = "0x9BD22D0", VA = "0x189BD32D0")]
		public void IMAPLFZWBZL(float3 a, quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3690", Offset = "0x9BD2690", VA = "0x189BD3690")]
		public bool RGBQLXWCPUQ([Out] float3 a, [Out] quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3B30", Offset = "0x9BD2B30", VA = "0x189BD3B30")]
		public bool ZWHRNIOTWUO([Out] float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x9BD37C0", Offset = "0x9BD27C0", VA = "0x189BD37C0")]
		public void RLLBOMOSCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectToolCleanup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3150", Offset = "0x9BD2150", VA = "0x189BD3150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectToolCleanup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		private BDZTIYBTDBO SDJYSRMAQYP
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5430", Offset = "0x9BD4430", VA = "0x189BD5430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Vector3 JOGSRQJMWZG
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x9BD42B0", Offset = "0x9BD32B0", VA = "0x189BD42B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5750", Offset = "0x9BD4750", VA = "0x189BD5750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Quaternion LFODOXUWQHP
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5200", Offset = "0x9BD4200", VA = "0x189BD5200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5860", Offset = "0x9BD4860", VA = "0x189BD5860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public Vector3 CUJKMYEUBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x9BD4160", Offset = "0x9BD3160", VA = "0x189BD4160")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5C00", Offset = "0x9BD4C00", VA = "0x189BD5C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public Quaternion MNNDKHLHEHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9BD4A70", Offset = "0x9BD3A70", VA = "0x189BD4A70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3C60", Offset = "0x9BD2C60", VA = "0x189BD3C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public float EFHRNQBDZAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x9BD3E90", Offset = "0x9BD2E90", VA = "0x189BD3E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x9BD4860", Offset = "0x9BD3860", VA = "0x189BD4860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public float TLPBRAXDDKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5B60", Offset = "0x9BD4B60", VA = "0x189BD5B60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public Matrix4x4 FXFBDCJHSCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5820", Offset = "0x9BD4820", VA = "0x189BD5820")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public RRObjectHierarchy SSIKHXUTKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		private SOGEWMVZOFB NRQKIBFOWNC
		{
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3D60", Offset = "0x9BC2D60", VA = "0x189BC3D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3E40", Offset = "0x9BD2E40", VA = "0x189BD3E40")]
		public RRTransform CWSZBLSCIFG()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3D30", Offset = "0x9BD2D30", VA = "0x189BD3D30")]
		public void CQYMPNZQGWS([Out] Matrix4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9BD55B0", Offset = "0x9BD45B0", VA = "0x189BD55B0")]
		public void UIGOVSNUEKW([In] Vector3 localPosition, [In] Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD54F0", Offset = "0x9BD44F0", VA = "0x189BD54F0")]
		public void UIGOVSNUEKW([In] RigidTransform parentFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD40B0", Offset = "0x9BD30B0", VA = "0x189BD40B0")]
		public void FHGNUGFKNOG([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4D00", Offset = "0x9BD3D00", VA = "0x189BD4D00")]
		public void SSALYBRCCUR([In] Vector3 worldPosition, [In] Quaternion worldRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4E00", Offset = "0x9BD3E00", VA = "0x189BD4E00")]
		public void SSALYBRCCUR([In] RigidTransform worldFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5930", Offset = "0x9BD4930", VA = "0x189BD5930")]
		public void XKWPGDJSKKZ([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5A10", Offset = "0x9BD4A10", VA = "0x189BD5A10")]
		public void XKWPGDJSKKZ([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5400", Offset = "0x9BD4400", VA = "0x189BD5400")]
		public UniformTRS TPBLZFCRXQP()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5340", Offset = "0x9BD4340", VA = "0x189BD5340")]
		public void TPBLZFCRXQP([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3FF0", Offset = "0x9BD2FF0", VA = "0x189BD3FF0")]
		public UniformTRS EXYMXVGBZHU()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9BD3F30", Offset = "0x9BD2F30", VA = "0x189BD3F30")]
		public void EXYMXVGBZHU([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9BD45D0", Offset = "0x9BD35D0", VA = "0x189BD45D0")]
		public Vector3 KUIGAPIWNJG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4EC0", Offset = "0x9BD3EC0", VA = "0x189BD4EC0")]
		public void SetLocalPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4BB0", Offset = "0x9BD3BB0", VA = "0x189BD4BB0")]
		public Vector3 RLMKNRYWBCT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5060", Offset = "0x9BD4060", VA = "0x189BD5060")]
		public void SetWorldPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4400", Offset = "0x9BD3400", VA = "0x189BD4400")]
		public Quaternion KMWKJYSUNTH()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4F90", Offset = "0x9BD3F90", VA = "0x189BD4F90")]
		public void SetLocalRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4720", Offset = "0x9BD3720", VA = "0x189BD4720")]
		public Quaternion LRXFEFTCMYO()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5130", Offset = "0x9BD4130", VA = "0x189BD5130")]
		public void SetWorldRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5AC0", Offset = "0x9BD4AC0", VA = "0x189BD5AC0")]
		public float YZKGIRCVDAB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x9BD49C0", Offset = "0x9BD39C0", VA = "0x189BD49C0")]
		public void ONLZAHLVUJP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x9BD56B0", Offset = "0x9BD46B0", VA = "0x189BD56B0")]
		public float UPMJURWGDEO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4910", Offset = "0x9BD3910", VA = "0x189BD4910")]
		public void NRXYRIKOQDY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4540", Offset = "0x9BD3540", VA = "0x189BD4540")]
		public Vector3 KRYKZIQTZFL([In] Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectTransform(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x9BD4020", Offset = "0x9BD3020", VA = "0x189BD4020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private BUNPURTHBHJ LPSLFMTTLJS
		{
			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x9BD5E90", Offset = "0x9BD4E90", VA = "0x189BD5E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public RRObject JECROGUQHMD
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		private VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x9BC6060", Offset = "0x9BC5060", VA = "0x189BC6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5D60", Offset = "0x9BD4D60", VA = "0x189BD5D60")]
		public void FASQFJGUMRB(string a, NativeObjectLocalIdList b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRObjectUserTags(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9BD5CD0", Offset = "0x9BD4CD0", VA = "0x189BD5CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRObjectUserTags other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5EE0", Offset = "0x9BC4EE0", VA = "0x189BC5EE0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public NetworkCreatorId MXPODCNCTIB
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x9BD80E0", Offset = "0x9BD70E0", VA = "0x189BD80E0")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRScene(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8050", Offset = "0x9BD7050", VA = "0x189BD8050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8540", Offset = "0x9BD7540", VA = "0x189BD8540")]
			public RetainScope(ObjectLocalId localId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x9BD84B0", Offset = "0x9BD74B0", VA = "0x189BD84B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7050", Offset = "0x9BD6050", VA = "0x189BD7050")]
		public RetainScope AZHLKHCROZT()
		{
			return default(RetainScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7760", Offset = "0x9BD6760", VA = "0x189BD7760")]
		public EntityRemapArray QTTEASLKZPI(Allocator a = Allocator.Temp)
		{
			return default(EntityRemapArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7500", Offset = "0x9BD6500", VA = "0x189BD7500")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> LKVPMMQJRYO(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7630", Offset = "0x9BD6630", VA = "0x189BD7630")]
		public NativeArray<ObjectNetworkId> LZZOIBSRDAZ(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD72A0", Offset = "0x9BD62A0", VA = "0x189BD72A0")]
		public NativeArray<ObjectNetworkId> FPSNFFLBIKM(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x9BD70E0", Offset = "0x9BD60E0", VA = "0x189BD70E0")]
		public NativeObjectLocalIdArray DHHNPSDKHZA(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x9BD73D0", Offset = "0x9BD63D0", VA = "0x189BD73D0")]
		public NativeObjectLocalIdArray IQAQGBPOTJZ(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7800", Offset = "0x9BD6800", VA = "0x189BD7800")]
		public NativeObjectLocalIdArray URXTJBAWREH(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRSceneEntityRemap(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7210", Offset = "0x9BD6210", VA = "0x189BD7210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRSceneEntityRemap other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x9BD77E0", Offset = "0x9BD67E0", VA = "0x189BD77E0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public RRSceneEntityRemap UCSUCFCGFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public RRSceneLoadResult HGFNJPDQARP
		{
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRSceneLoadResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public RRScene NZKDOTCPVYM
		{
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRScene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7C10", Offset = "0x9BD6C10", VA = "0x189BD7C10")]
		public bool EAPDAKUVTYZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7DC0", Offset = "0x9BD6DC0", VA = "0x189BD7DC0")]
		public bool WHZWSRPAHHZ([Out] Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7D40", Offset = "0x9BD6D40", VA = "0x189BD7D40")]
		public void QWJXCJWXAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRSceneLoadOperation(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator ObjectLocalId(RRSceneLoadOperation value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7CB0", Offset = "0x9BD6CB0", VA = "0x189BD7CB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRSceneLoadOperation other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x9BD77E0", Offset = "0x9BD67E0", VA = "0x189BD77E0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public RRSceneLoadOperation OMWKYAKWVZL
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRSceneLoadOperation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public RRSceneEntityRemap UCSUCFCGFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7A90", Offset = "0x9BD6A90", VA = "0x189BD7A90")]
		public void GCXKIXVKSSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7930", Offset = "0x9BD6930", VA = "0x189BD7930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRSceneLoadOperationSubgraph(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7A00", Offset = "0x9BD6A00", VA = "0x189BD7A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "5")]
		public bool Equals(RRSceneLoadOperationSubgraph other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7B10", Offset = "0x9BD6B10", VA = "0x189BD7B10", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public bool DOAXQABPIVY
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x9BD7FC0", Offset = "0x9BD6FC0", VA = "0x189BD7FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public ObjectLocalId NLCFJQSWBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public RRSceneLoadResult(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3B50", Offset = "0x9BC2B50", VA = "0x189BC3B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x9BD7F30", Offset = "0x9BD6F30", VA = "0x189BD7F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC39A0", Offset = "0x9BC29A0", VA = "0x189BC39A0", Slot = "4")]
		public bool Equals(RRSceneLoadResult other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9BD77E0", Offset = "0x9BD67E0", VA = "0x189BD77E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class FXDZDMWHGQC
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

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x9BC3250", Offset = "0x9BC2250", VA = "0x189BC3250")]
			public bool NNQPHMUWMAZ([Out] ObjectNetworkId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x9BC32F0", Offset = "0x9BC22F0", VA = "0x189BC32F0")]
			public ObjectGuid(ObjectNetworkId networkId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF950", Offset = "0x9BBE950", VA = "0x189BBF950")]
		public static Guid RCCXKBMDBOQ(this ObjectNetworkId a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF930", Offset = "0x9BBE930", VA = "0x189BBF930")]
		public static bool QRGFCUBCZDQ(this Guid a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class HEQINVJXAUY
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFC10", Offset = "0x9BBEC10", VA = "0x189BBFC10")]
		public static VSIADALGQZL FLDPVMRBDIC(this ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFEF0", Offset = "0x9BBEEF0", VA = "0x189BBFEF0")]
		public static OOCKLMKAALS World(this ObjectLocalId id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFCA0", Offset = "0x9BBECA0", VA = "0x189BBFCA0")]
		public static EntityManager HVJITUBUWTE(this ObjectLocalId a)
		{
			return default(EntityManager);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B09100", Offset = "0x3B08100", VA = "0x183B09100")]
		internal static bool IEOOEGDSXDG<a>(this ObjectLocalId a, bool b) where a : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFDB0", Offset = "0x9BBEDB0", VA = "0x189BBFDB0")]
		public static bool VARDBIMEXKB(this ObjectLocalId a, NetworkProperty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3B09520", Offset = "0x3B08520", VA = "0x183B09520")]
		public static bool XZOAVXEZVBK<b>(this ObjectLocalId a) where b : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3B093A0", Offset = "0x3B083A0", VA = "0x183B093A0")]
		public static bool KDLCKSOQBTA<c>(this ObjectLocalId a) where c : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3B08E20", Offset = "0x3B07E20", VA = "0x183B08E20")]
		[MustUseRefValueWithoutStoring]
		internal static NativeArray<T> GCOEUMNAAZR<T>(this ObjectLocalId a, Allocator b) where T : struct, IBufferElementData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3B08620", Offset = "0x3B07620", VA = "0x183B08620")]
		[MustUseRefValueWithoutStoring]
		public static T EWTUSTPQFQT<T>(this ObjectLocalId a) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x3B08900", Offset = "0x3B07900", VA = "0x183B08900")]
		[MustUseRefValueWithoutStoring]
		public static d EYJXWVSVDDN<d>(this ObjectLocalId a) where d : struct, IComponentData
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x3B08410", Offset = "0x3B07410", VA = "0x183B08410")]
		public static bool DZGRKOFLUOP<e>(this ObjectLocalId a, [Out] e b) where e : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x3B08280", Offset = "0x3B07280", VA = "0x183B08280")]
		public static f CDNYVJHEZAW<f>(this ObjectLocalId a) where f : struct, IComponentData
		{
			return (f)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x3B09300", Offset = "0x3B08300", VA = "0x183B09300")]
		public static g IOTDQAIJYCL<g>(this ObjectLocalId a) where g : class, IComponentData
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class XAMDJGQRVYR
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

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x81E7470", Offset = "0x81E6470", VA = "0x1881E7470")]
		public EntityRemapArray(NativeObjectLocalIdArray src, NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF490", Offset = "0x9BBE490", VA = "0x189BBF490")]
		public LocalId WAWREKIWZDD(LocalId a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF420", Offset = "0x9BBE420", VA = "0x189BBF420")]
		public LocalId WAWREKIWZDD(int a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9BBF3B0", Offset = "0x9BBE3B0", VA = "0x189BBF3B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DCHYTMGFCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XDKZRXILIUG(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JYUTKIQFVEY(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MWAGCNYZOHX(ObjectLocalId a, uint b);

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NXHOJFPZSXS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string GXIKZCFYXUI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RVHCJWNYIGE(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KSKAOYZUFSD(ObjectLocalId a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void YNVOBIYOEBW(ObjectLocalId a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EVTOWQLXIRU
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		Guid OMIIPKCTMRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		Guid HFBFWZXLDWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KWNAOKTFREJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task GFGMNZZRSYL(RRObject a);

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Guid MSNQBQQSENM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XWEEYJPZNSR(ObjectLocalId a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UJMZZZEJKCZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task DPWMSUXLTBK(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EJPKYQEKMGD(ObjectLocalId a, ObjectNetworkId b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XLCJKMKESDE
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		Guid OMIIPKCTMRB
		{
			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EIDJVZSSRPS(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FIYRUKDLVYY
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeObjectLocalIdArray JYNVCRQRPZV(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeObjectLocalIdArray RKIPXWKHUQS(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SROFLUXCRCF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JKRGJVXBSYH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZXEIAWVUDDN(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CZQALZCLPRA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JVJRPDLHTHS(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId KOIJZDVFNKT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MIVZCXSYHBJ(NativeObjectLocalIdArray a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool UGVBBEMYUQM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JWHMKJJIUCQ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int FCOBNJBDSZX();

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ISUGNTYXFSM(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VHNQEOVNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ObjectLocalId, ObjectLocalId> PHSEMMXEWWG;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ObjectLocalId, ObjectLocalId> ESPFHNIVNIA;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<ObjectLocalId, ObjectLocalId, ObjectLocalId> FQYVNLBJHRY;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ObjectLocalId> VRGDKMASITL;

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool RLDNZWBKURQ(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ObjectLocalId KDXMTVKGHGO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray AEXONULEHLX(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ObjectLocalId HYMQWHGGTAG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MRFEIQWEHKY(ObjectLocalId a, Vector3 b, Quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void EMALDLCGAQH(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool KBSEHXRLSGR(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool WRHXYMAIZZX(ObjectLocalId a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool EDZYHMNCHSC(ObjectLocalId a, [Out] float b);

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float3 NYAOYMBMJWR(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		quaternion EUYRFINCMWQ(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		RigidTransform PWCALPRGQKI(RRObjectConnectable a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class XXULYCKFVUI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HLYXDPFKQHQ
	{
		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		object WZYXCWGWADS
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FGSEFYNLQSE
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UKNEXBHTFUG(ObjectLocalId a, HZTYXVTZUZS b);

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LKEIGKQYUBB(HZTYXVTZUZS a);

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool HNLAYSEFHRT(ObjectLocalId a, [Out] HZTYXVTZUZS b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ERDOEXZOEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FALLFBAZVTZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeArray<ObjectLocalId> YDSVOGROCHZ();
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
	public interface PQSFFCXSVQS
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

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EIELZLPMHFN(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KDBFFRFQVLZ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PVQTKYUXRIR(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DWSJRFCFSKW(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UNQYMCIJWVU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HIVKNJPLAIK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId CNEBARCSGSU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ReadOnlySpan<ObjectLocalId> SUJFNHFORUC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ReadOnlySpan<ObjectLocalId> YVGHABKRDZR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SnapPointPreviewInformation QJAZDCDFQTX(ObjectLocalId a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ZXAQQKOYCCB(ObjectLocalId a, [Out] ElementGroupStatusData b);

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void PJGSIXBMLUH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void EMCXPWECTRI(ObjectLocalId a);
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

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x64B15B0", Offset = "0x64B05B0", VA = "0x1864B15B0")]
		public GameConfig(T defaultValue, [Optional][CallerMemberName] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Obfuscation(ApplyToMembers = false)]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GameConfig<int> NFVQBDVBUGW;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GameConfig<int> UIEVMSEGOUO;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GameConfig<int> QDFUUGWALMQ;
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
	public static class DHNCNRIEPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x1561E50", Offset = "0x1560E50", VA = "0x181561E50")]
		public static bool IsEnabled(this GameConfigState state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x196C1F0", Offset = "0x196B1F0", VA = "0x18196C1F0")]
		public static bool TKMJWNEAQGU(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x329E950", Offset = "0x329D950", VA = "0x18329E950")]
		public static bool OPZELNVBQFZ(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1561E60", Offset = "0x1560E60", VA = "0x181561E60")]
		public static bool NOOMCGTDRFS(this GameConfigState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface ZXQZGDZOMJG
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

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		State CPHVQGWNERP
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		bool QCTNIDBILOH
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		bool SRHPKSLOBOF
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		EditReadyPreference URXFPCCGFMW
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BHEXHNXOSNE
	{
		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		GameConfigState FTHVEUZKEXT
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		GameConfigState ESHGMUZZKUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		GameConfigState YCGIGPDUTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		GameConfigState PVBKFTQKRWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		GameConfigState CDCZLCOIISM
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		GameConfigState WNABPDGMXTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		GameConfigState IFWXEKNOSCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		GameConfigState ZSIIGVHOTAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		GameConfigState MPEFHCQQYYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		GameConfigState WDNILCBEMDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		GameConfigState FQNDKBFYDBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		GameConfigState LTVXRENUPDE
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		GameConfigState NPAHTGYSWSN
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		GameConfigState GIICXKKFLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		GameConfigState TXKSACLNBIC
		{
			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		GameConfigState TIZFPYNVYLY
		{
			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		GameConfigState YQQJKXGLXWP
		{
			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		GameConfigState BTCGYMQZNXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		GameConfigState GETTMYHZQBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		GameConfigState BNBZPXBUJAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Get(GameConfig<int> config);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OHXWWKOOZRX
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event FLGDJBVOVLB.ParentsChangedCallback MPARVLSGNTF;

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId THHDBOMNHMQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NativeObjectLocalIdArray GRHFJQQYBBP(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FractionalIndex DOICUKLSUYC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QRACNQTDHGZ(IEnumerable<ObjectLocalId> a);

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FractionalIndex Move(ObjectLocalId parent, ObjectLocalId src, bool isBefore, ObjectLocalId target);

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId TFEJQQDIUAU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SetParent(ObjectLocalId localId, ObjectLocalId parent, bool worldPositionStays = false);

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HWSDSRUFYWW(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CMYFMDATNDH(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[Obsolete("Use IHierarchyService.GetChildren() instead")]
		NativeObjectLocalIdArray VVXLXRGFBSM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool CZKREKDYGZV(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NativeObjectLocalIdArray QEEKELLVWLS(NativeObjectLocalIdArray a, DescendantFlags b, Allocator c);

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool VVKCICVJOYB(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ObjectLocalId NDYDTAPZRVI(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool SJMLJSZJHYR(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ObjectLocalId EBGXASHGJVS(ObjectLocalId[] a);

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId MBIKJQBDGVT(ObjectLocalId a, uint b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class UUAUYVAIBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8860", Offset = "0x9BD7860", VA = "0x189BD8860")]
		public static bool DOFZZALFMLC(this OHXWWKOOZRX a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8B20", Offset = "0x9BD7B20", VA = "0x189BD8B20")]
		public static NativeObjectLocalIdArray QEEKELLVWLS(this OHXWWKOOZRX a, ObjectLocalId b, DescendantFlags c, Allocator d)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8950", Offset = "0x9BD7950", VA = "0x189BD8950")]
		public static NativeObjectLocalIdArray NBCVONCYDHO(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x9BD88D0", Offset = "0x9BD78D0", VA = "0x189BD88D0")]
		public static NativeObjectLocalIdArray HGWFDLFJGIB(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8910", Offset = "0x9BD7910", VA = "0x189BD8910")]
		public static NativeObjectLocalIdArray KCXXSAMBMSA(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8DB0", Offset = "0x9BD7DB0", VA = "0x189BD8DB0")]
		public static NativeObjectLocalIdArray XJQIQPNKPCF(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8990", Offset = "0x9BD7990", VA = "0x189BD8990")]
		public static NativeObjectLocalIdArray NOPLRBBZORR(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8AE0", Offset = "0x9BD7AE0", VA = "0x189BD8AE0")]
		public static NativeObjectLocalIdArray PDQDFREFSBH(this OHXWWKOOZRX a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x9BD89D0", Offset = "0x9BD79D0", VA = "0x189BD89D0")]
		public static NativeObjectLocalIdArray PDQDFREFSBH(this OHXWWKOOZRX a, NativeObjectLocalIdArray b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IZCTLAONCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0820", Offset = "0x9BBF820", VA = "0x189BC0820", Slot = "0")]
		Task<RRSceneLoadOperation> LoadMain(SerializedDataWrapper serializedDataWrapper, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "1")]
		void NYZAJISQPTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface VNXQNHKAVHQ
	{
		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event FLGDJBVOVLB.ParentsChangedCallback MPARVLSGNTF;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId TFEJQQDIUAU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ReadOnlySpan<ObjectLocalId> DVIYYZFCLZQ();

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ReadOnlySpan<ObjectLocalId> LDFCQUUGTWP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DURLHNXRQDC(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IIFLLLEFFMD(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LLEGGUYHIHZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HWSDSRUFYWW(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FractionalIndex TVGLXSONWIK(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MXQMWQVVOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ONPOFPZJCLU
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		bool OXVWODRHZNS
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		bool CDGZINCZIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PXKSKAKGPHT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CKYRMUOHWOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SURLTGPNSVI(ObjectLocalId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TBOXGJPCOXD(ObjectLocalId a, NetworkProperty b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FYUXRLHIKCV
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RentedArray<string> RZKTGXYMLHC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RentedArray<string> MBLTLJYJTNT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DVKHJDTPFYB(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YPQDFMIKAWU(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BVIACZNRYPP(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZWCAHRSJCLZ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		InteractionFilterMode FBKSDNPALEB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OTTKFDEAPWR(ObjectLocalId a, InteractionFilterMode b);

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LFWIUPYQYTN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MGDKUZTCQQP(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RentedArray<string> PXRTVZTRTBR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FCQEWUAJLHJ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RentedArray<string> WGDZWYGWBGB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TMWLCKMEHIB(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RentedArray<string> JAWQXGQZLRJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void BQEPQGQFHLJ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RentedArray<string> HCDKJVXNDQB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void PEJKPKAHAXT(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool MIWWTZUODJD(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WPQERZXHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast([In] float3 origin, [In] float3 direction, float maxDistance, [Out] RayIntersection intersection, [Out] ObjectLocalId spline);

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OverlapSphere([In] float3 origin, float radius, List<ObjectLocalId> localIds);

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KUOWIDBUFJN(Plane[] a, float3 b, float3 c, quaternion d, List<ObjectLocalId> e);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EDWJFXFXNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Raycast([In] NativeArray<Entity> entities, [In] float3 origin, [In] float3 direction, [In] NativeArray<RayIntersection> outRayIntersections);

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeList<Entity> OverlapSphere([In] NativeArray<Entity> entities, [In] float3 origin, float radius);

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NativeList<Entity> KUOWIDBUFJN([In] NativeArray<Entity> entities, [In] NativeArray<float4> frustumPlanes);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public struct PhysicsSceneColliderHandle : QLTKPKJZZYR, IEquatable<PhysicsSceneColliderHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A70", Offset = "0x30D3A70", VA = "0x1830D4A70", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A80", Offset = "0x30D3A80", VA = "0x1830D4A80", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x9BC55F0", Offset = "0x9BC45F0", VA = "0x189BC55F0", Slot = "8")]
		public bool Equals(PhysicsSceneColliderHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5640", Offset = "0x9BC4640", VA = "0x189BC5640", Slot = "3")]
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
	public interface MCADMDXANPR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SOGEWMVZOFB
	{
		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		VSIADALGQZL FLDPVMRBDIC
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		ObjectServiceHandle NIFAJYPOFJI
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		int HQTETCBFYUK
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		int NLRDBAMJKDR
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		int DGTGMYCZIZB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		int WMDCBRLFGRU
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		int PKCNIVHZOHB
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<NativeObjectLocalIdArray, NativeArray<RRObjectPrefabData>> BBXFGGZHOZK;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<NativeObjectLocalIdArray> QKUIDCAOBDW;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray VEMCNSNVUQN();

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NativeObjectLocalIdArray WXGTIVDVERH();

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ObjectType KOCWERFPBDZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		RRObjectPrefabData RCRYHRFSOFE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void DIVZEUMRIRE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "16")]
		RRObject Embody(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool SJOZJJLZQSX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool VHTAKDXHGYN(ObjectLocalId a, [Out] Transform b);

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "19")]
		ObjectLocalId IETVAKWNWLM(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool VRYLNXWYCAP(ObjectNetworkId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "21")]
		ObjectNetworkId GVJBBKGTVZJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		NativeObjectLocalIdArray IETVAKWNWLM(NativeArray<ObjectNetworkId> a, Allocator b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool UUDWPPCILXN(NativeArray<ObjectCreationData> a, NativeArray<ObjectNetworkId> b, NativeArray<Entity> c, RentedArray<GRVBYUYUBSW> d);

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RRObject KWENGWYWMOC();

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RRObject CreateObject(RRObjectPrefabData prefabType, [Optional] CreationInstantiationParameters instantiationParameters);

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RRObjectContainer WFGMCMMQCLF();

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RRObjectShapeSpline SKQUTFIMKYF();

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "28")]
		RRObjectShapePrimitive ILUIUASOTXL(PrimitiveShapeType a);

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void JHOJKZHIFCP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void QQNUVJSFQCC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool WNAADBVYJYU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "32")]
		NativeObjectLocalIdArray KMIMLKLIAQA(NativeObjectLocalIdArray a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool Exists(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool IUMHYGIUIIM(ObjectLocalId a, ComponentTypeSet b);

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(Slot = "35")]
		ObjectLocalId GNTFHMTZGSV(Transform a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class MUXYMRAFSSE
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC10D0", Offset = "0x9BC00D0", VA = "0x189BC10D0")]
		internal static ObjectLocalId EVIAQTBOUWF(this Entity a, SOGEWMVZOFB b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x9BC12A0", Offset = "0x9BC02A0", VA = "0x189BC12A0")]
		public static RRObject QSNGWVBZUJZ(this SOGEWMVZOFB a, LocalId b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x9BC11F0", Offset = "0x9BC01F0", VA = "0x189BC11F0")]
		public static ObjectLocalId IETVAKWNWLM(this SOGEWMVZOFB a, LocalId b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1180", Offset = "0x9BC0180", VA = "0x189BC1180")]
		public static ObjectNetworkId GVJBBKGTVZJ(this SOGEWMVZOFB a, LocalId b)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x9BC12B0", Offset = "0x9BC02B0", VA = "0x189BC12B0")]
		public static RRObjectContainer QXXADGBSCMX(this SOGEWMVZOFB a, RigidTransform b)
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1620", Offset = "0x9BC0620", VA = "0x189BC1620")]
		public static RRObjectShapePrimitive XWTWABEEZOB(this SOGEWMVZOFB a, PrimitiveShapeType b, RigidTransform c)
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x9BC1450", Offset = "0x9BC0450", VA = "0x189BC1450")]
		public static RRObjectShapeSpline QYZQPJEXHFL(this SOGEWMVZOFB a, RigidTransform b)
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC15F0", Offset = "0x9BC05F0", VA = "0x189BC15F0")]
		private static void WMWGSIVJCXJ(RRObject a, RigidTransform b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal interface TQHCVVJORRE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WPEENMVPQPL
	{
		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool XRCYDHYIKNC
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		ObjectLocalId CAVUICCMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		RRObject WVEATUZQXQH
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event ScopeChangedEventHandler BONGWVKMBRS;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId NDYDTAPZRVI(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SJMLJSZJHYR(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LUBNLAVBIKM();

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BZNRUEGFXJC();

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool DRJHFQLLYQV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool VYWGHTJCMSU(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate void ScopeChangedEventHandler(RRObject oldScope, RRObject newScope);
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class RHOMVWSBWAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC57A0", Offset = "0x9BC47A0", VA = "0x189BC57A0")]
		public static bool MLBZFQMGQJR(this WPEENMVPQPL a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x9BC57F0", Offset = "0x9BC47F0", VA = "0x189BC57F0")]
		public static bool NAFEMEOCJHG(this WPEENMVPQPL a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5720", Offset = "0x9BC4720", VA = "0x189BC5720")]
		public static bool JUXAMFCDKUZ(this WPEENMVPQPL a, ObjectLocalId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WGZOUQSHTFY
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KYKVCXJWSAM(NativeList<RRObjectPrefabData> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BFWVMJIJWJM
	{
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LYMKBQGSPFB(RRObject a, ReferenceGroupKind b, List<RRObject> c);

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int YCEQGNLFRKW(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IMCXGDHTKVE(RRObject a, List<RRObject> b);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int UZIXKKPPECR(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRObject LIWVCUKLYWO(RRObject a, int b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TKGTYWBEQZH(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool TKTYUBMFFGD(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void AJTGZUBOACE(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool TLZMTJAUDHU(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GCDGISOWPUZ(Entity a, Entity b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PIOPVKARXGN(Entity a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool GSUWYMBOYQS(RRObject a, ReferenceGroupKind b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GATSKXUMODS
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		RRScene BZJJTJHYWTE
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NetworkCreatorId SXHENOBMPOJ(RRScene a);

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRScene DIUGGOTJQPI();

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRScene MJXPHNOZMBE();
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XBTBGXVRMEZ
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VWRVYPFHUYR(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DCMBYNPQINA
	{
		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<ObjectLocalId> HTUHJDDOJLD;

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CBJGESRWLQN(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FFNROREQCXV(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SBVWRWKEOKD(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BTZNJGALHRL
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ObjectLocalId> DTKCUCOMFFH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ObjectLocalId IBPWMIBGYST(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int TGFZHIVKPZT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SplineParameters SCVOVAJOKUA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ENDOROYCQKQ(ObjectLocalId a, SplineParameters b);

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId GTCELGPUIWC(ObjectLocalId a, [Optional] float3? b, [Optional] quaternion? c, [Optional] float3? d);

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId LIADVTGULVD(ObjectLocalId a, int b, [Optional] float3? c, [Optional] quaternion? d, [Optional] float3? e);

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void POOJWRLQBXR(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NQGBKCMVNYU(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HDOOPRAKFKU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface ZOHMBYWXOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KSBDPMHTAOE(ObjectLocalId a, ReadOnlySpan<TerrainGenerationLayer> b);

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YBORSCQUEQD(ObjectLocalId a, ReadOnlySpan<TerrainCustomMaterialLayer> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZSOTDVTSKUZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000216")]
		bool WGMNILVCLQF
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RHCBYMESQFH();

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OFHHXXUTCPI();

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AZODKKQWUJI();

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YRIEFRCIRCH();

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GYABJEUQMFP();

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void UYUKBCVDWKY();

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XSLDKVGBTZE();

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void EUEFBONSCUS();

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RDZSNKTREMG();

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void VFPYFTQHEPW();

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void MWHEDXURKTH();

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IZFBPLQUPOW();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface RAGQQAVCFVA
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XRXREWHPAFE(ObjectLocalId a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QJAIRCXAIHR(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ForceCleanup(ObjectLocalId target, bool forceImmediate);

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZTTNZMYDWJE(ObjectLocalId a, float b, float c, float d);

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZWHRNIOTWUO(ObjectLocalId a, [Out] float b, [Out] float c);

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IMAPLFZWBZL(ObjectLocalId a, float3 b, quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool RGBQLXWCPUQ(ObjectLocalId a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RLLBOMOSCNP(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BDZTIYBTDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetLocalPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float3 KUIGAPIWNJG(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLocalRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "3")]
		quaternion KMWKJYSUNTH(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UIGOVSNUEKW(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FHGNUGFKNOG(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SSALYBRCCUR(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XKWPGDJSKKZ(Entity a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XKWPGDJSKKZ(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ONLZAHLVUJP(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float YZKGIRCVDAB(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SetWorldPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "12")]
		float3 RLMKNRYWBCT(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void SetWorldRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "14")]
		quaternion LRXFEFTCMYO(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void NRXYRIKOQDY(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float UPMJURWGDEO(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VNBIXVHDDRA(Entity a, [Out] float4x4 b);

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void CJGTUOUQSFA(Entity a, [In] float4x4 localToWorld);

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void NotifyTransformParentChanged(Entity entity);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void JEOIYMOEPLD(Entity a, Entity b, Entity c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class BLXRYWHAHBQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PCIGIKYKGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GNEYASQVKDK(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BUNPURTHBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QFQXODIJERO(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HKETQXTUQXA(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IDSFEPWTLQO(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZVJKEKOAHDW(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OYDAGBOESDF(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YAKBSRWHYUZ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int DXMPXKDVONT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int LILLQRDBHKM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int DFQQTIUUSQO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "9")]
		WRLHKUPPYHT<string> UBMNRCGBWCA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CKGGTVYPNDE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "11")]
		WRLHKUPPYHT<string> LCZSAMJTBKC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool ZNKFEPRSUSF(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void YYFNCCKWTOJ(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectLocalId GLYWWJMWQUE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void DCNFTMECPDA(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void FASQFJGUMRB(ObjectLocalId a, string b, NativeObjectLocalIdList c);

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		WRLHKUPPYHT<string> VLBMWGOGDEZ();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public static class TGWIOOQIYLM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XPMETFCVUXV
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		World NZMXMNLXDYT(string a = "Main");

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		World CLCRPJSJPYQ(string a = "Shadow");

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		World TXOCXMKYTID(string a = "Deserialization");

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		World QJUEMUQSBAQ(string a = "Serialization");
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OOCKLMKAALS
	{
		[Cpp2IlInjected.Token(Token = "0x17000217")]
		World DDTNZIVNXAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		World TBLOWNYQVPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		EntityManager HVJITUBUWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ComponentSystemBase JVNBFAHTYCZ(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public static class QMOKGFWYMZP
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5690", Offset = "0x9BC4690", VA = "0x189BC5690")]
		public static ComponentSystemBase OPEAOWGDXMZ(this World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CE00", Offset = "0x3E4BE00", VA = "0x183E4CE00")]
		public static a JVNBFAHTYCZ<a>(this OOCKLMKAALS a) where a : ComponentSystemBase
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NGKFRZQBJHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NTNGXVJDWTQ(NativeListAsync<Entity> a);

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YOZFTLXVPKB(CollisionIslandGeneratorState a);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DMDRUXKBHAK(NativeListAsync<Entity> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QBXWWWPCUCI();

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UIGIQKODSYV(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface IPTYNRDFBYF
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JDMEWEIFORY(Collider a, [Out] ObjectLocomotionSettings b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HPNYXRKSYRJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Collider FZRLROQTUAA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject UYGTQWMRZKF(ObjectLocalId a, GameObject b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HJUKITSUPLF(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "3")]
		a VCXOOIRRTNV<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NDTYOOFPETJ(Collider a);

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject QOQEOPWTHYD<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "6")]
		EJFBPJOFWSR RILHLQOASME(ObjectLocalId a, ObjectLocalId b, PrimitiveShapeType c, float3 d, quaternion e, float3 f);

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ACHHKPTAOEQ(ObjectLocalId a, [Out] EJFBPJOFWSR b);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool VSPVDUJWCWQ(ObjectLocalId a, [Out] ObjectLocalId b);
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
	public interface XJVWBOPIDBX
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

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RYVDLUOQDOX(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d);

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MDFGLYXVDWT(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KKEEMLCGECQ XNDVPMXOZRD(ObjectLocalId a, List<ObjectLocalId> b);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EJFBPJOFWSR CEKXLXYMNSW(GameObject a, GameObject b);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GYMQUAZGOGO(GameObject a, List<GameObject> b);

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CFGHJQNIHEU(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		a VCXOOIRRTNV<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NDTYOOFPETJ(Collider a);

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GameObject SNEIRTSIGLD<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool WEQFMUZROCY(Collider a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KMDWOXJBJCI(ObjectLocalId a, [Out] ObjectLocomotionSettings b);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<ColliderType> XIUBMUIWVXU(Allocator a = Allocator.TempJob);

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Mesh[] LZCRMWEOSAE();
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CNLXTDCWTGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AZYZTCUIDGT(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ODGWVXJIHZI(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int OMOWKQMVVQF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ObjectLocalId NJFBOEXBSEC(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NativeObjectLocalIdArray LTOWNAADUDC(ObjectLocalId a, Allocator b = Allocator.Temp);

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QDODNFSARJC(ObjectLocalId a, object b, ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RBYTNLERKJD(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TNOPEGWHUFT(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BCEDUVXQLTB(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FVZKHQWYTXR(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AHWXTAIJXUI(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool RIZOABHFZZG(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GUTJLRWISFV(ObjectLocalId a, (Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool WTYEGQMCREY(ObjectLocalId a, [Out] quaternion b, [Out] float3 c);

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void NHJDRLDLPZV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "15")]
		[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
		float3 IFYPMQAJSXR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 REQVATJHIHO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void WDVPGJHLRFS(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void RDTTAHGZBVL(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "19")]
		float YMDCUNBGMQE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "20")]
		float VIWRRWXDBED(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KTPWFQPLKMT(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void VDKCYUBXJCE(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CollisionDetectionMode SAOWSZRUSKS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void TEGFWYWVMUK(ObjectLocalId a, CollisionDetectionMode b);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		TransformTrackRate ZWIEZMRSKXB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void DOXLPIFKECP(ObjectLocalId a, TransformTrackRate b);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool URFACSWJQDJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void OOZTIBQHXVV(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "29")]
		ObjectLocalId THHDBOMNHMQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void MQPOOIDHNPG(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ObjectLocalId TFEJQQDIUAU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetParent(ObjectLocalId localId, ObjectLocalId value);

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "33")]
		RbexInterpolationMode ILUYSXJOJOK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void RKFSJNTZDBQ(ObjectLocalId a, RbexInterpolationMode b);

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool QDZACIDMRDJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DGXTSLKRPPF(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool ESCMMOWAVTY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void OASMUNNNJVY(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "39")]
		RigidbodyConstraints GEJFVURBMOB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void EYEPDMVRTMV(ObjectLocalId a, RigidbodyConstraints b);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "41")]
		float BSXIWDLXCEW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void QOUTBYYYEFQ(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		float IRILZHIOIRC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void WKEKRWVWEHS(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool YCWQQPFMWTF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void KODCQCHFIBV(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool AHYSAXEFBTA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void DQMOLJOPEXQ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void ADKAAJLLZLQ(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "50")]
		DBBKETFETMV PMTBCDQOSKK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void VRFDKBBJGZY(ObjectLocalId a, DBBKETFETMV b);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "52")]
		HAIRCSDLSLS VVFXKBGZQYZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void TDZDKYCBFYJ(ObjectLocalId a, HAIRCSDLSLS b);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "54")]
		float QNJQHWQDQFJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void DQHRVUGNXDF(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void QVNFLMJBDGM(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void DXXNTDVEZYB(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "58")]
		bool DQLUSPQBYVI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void YMRBJZYZUFK(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void ZZFOOZQNZAD(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "61")]
		bool OQZRCAVOGGQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "62")]
		bool GEKWZUYGJPE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "63")]
		Rigidbody LOIZGGKJFPN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void PPWFNGGVKGP(ObjectLocalId a, Rigidbody b);

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void TFXFJGHHFHF(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void DTJULSXSPPU(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "67")]
		bool OILWSOUQWSD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void FTXJUDJKTCU(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void VLPZFQBLUGG(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool ODGSUAFCZVZ(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool SOXGJOQYGER(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "72")]
		bool CBIJVKAZZYJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void PVXHMQWNESW(ObjectLocalId a, object b, bool c);

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void OROOHGEVGWS(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void YRAOYUOIPAE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(Slot = "76")]
		bool PWHMLDHCLOT(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EZKCAVHAVDZ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BTBCUVFYXSJ(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UAFTADPWBXF(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EDKCZMPYRMF(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ODGNUZRWIZX
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZBMHJUMXFEE(ObjectLocalId a, bool b);
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

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public NativeObjectLocalIdArray ARVZEXBXIWH
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x3067910", Offset = "0x3066910", VA = "0x183067910")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x9BBEFD0", Offset = "0x9BBDFD0", VA = "0x189BBEFD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public NetworkProperty IFWWVKYBDVT
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xD3A1E0", Offset = "0xD391E0", VA = "0x180D3A1E0")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x9BBEFF0", Offset = "0x9BBDFF0", VA = "0x189BBEFF0")]
		public BulkPropertyChangeData(NativeObjectLocalIdArray objectIds, NativeArray<byte> prev, NativeArray<byte> curr, NetworkProperty property, int propertySize, Type propertyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x37F6650", Offset = "0x37F5650", VA = "0x1837F6650")]
		public NativeArray<a> CEMAJHIIBJD<a>() where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x37F6950", Offset = "0x37F5950", VA = "0x1837F6950")]
		public NativeArray<b> UJVDGBFUCEZ<b>() where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x37F6730", Offset = "0x37F5730", VA = "0x1837F6730")]
		public (NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>) Get<T>() where T : struct
		{
			return default((NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C78C60", Offset = "0x5C77C60", VA = "0x185C78C60")]
		public ObjectIdBulkPropertyChangeData SHAERASMVZB()
		{
			return default(ObjectIdBulkPropertyChangeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface ZCIBIFKBEZY
	{
		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		string XJITUBNMCVO
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		ZCIBIFKBEZY DVUIYGGUEYD
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		IEnumerable<ZCIBIFKBEZY> PVSYGPXIXBI
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface LISNGJFWSIP
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		ZCIBIFKBEZY KCIGFEYUWIT
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		NativeArray<NetworkProperty> XTYTASVBKAA
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool QKOZTMGSFJU(NetworkProperty a, [Out] ZCIBIFKBEZY b);

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SIFQFAPRLAF(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WKECLZBLVZA(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ENZWUCLSKWE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SIFQFAPRLAF(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WKECLZBLVZA(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class BJSUEPLEJWC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CKSQIGMXKJV
	{
		[Cpp2IlInjected.Token(Token = "0x17000223")]
		bool DFPVKMZCDUV
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		ReplicationData ADIFCBJBFDE
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TSOVHDQVUHP(NetworkCreatorId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IEWQTVOVRYO(ObjectNetworkId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QBEACXYNAKF(NativeArray<ObjectNetworkId> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class QLIGKUHWGUB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public readonly ref struct ObjectIdBulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly BulkPropertyChangeData data;

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public NativeObjectLocalIdArray ARVZEXBXIWH
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x3067910", Offset = "0x3066910", VA = "0x183067910")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3880", Offset = "0x9BC2880", VA = "0x189BC3880")]
		public ObjectIdBulkPropertyChangeData(BulkPropertyChangeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3330", Offset = "0x9BC2330", VA = "0x189BC3330")]
		public NativeObjectLocalIdArray CEMAJHIIBJD()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3750", Offset = "0x9BC2750", VA = "0x189BC3750")]
		public NativeObjectLocalIdArray UJVDGBFUCEZ()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x9BC3460", Offset = "0x9BC2460", VA = "0x189BC3460")]
		public (NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray) Get()
		{
			return default((NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class HQVFSLIASWH
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

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public bool UKQWKEKOVME
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8470", Offset = "0x9BD7470", VA = "0x189BD8470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public bool DFPVKMZCDUV
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x9BD8270", Offset = "0x9BD7270", VA = "0x189BD8270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8490", Offset = "0x9BD7490", VA = "0x189BD8490")]
		public ReplicationData(NativeBitArray bitArray, NativeParallelHashMap<ObjectNetworkId, int> bitOffsets, NativeParallelHashSet<NetworkCreatorId> denyCreatorIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9BD82A0", Offset = "0x9BD72A0", VA = "0x189BD82A0")]
		public bool IEWQTVOVRYO(ObjectNetworkId a, NetworkProperty b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DFZKVWGSBRA
	{
		[Cpp2IlInjected.Token(Token = "0x17000228")]
		OutlineEffectType YUBGOPRQFZP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface DAKGUQNXONS
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		int CGYOIQMFZMA
		{
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		int AMWUFMUSDQL
		{
			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TUHWOXRONKN(ObjectLocalId a, MutableRef b);

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle WGTUCEPAKIF();

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RootHandle PNOIFWMCQMU();
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PYRLVRDYMGZ
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UHLMBOERYQX(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XFCTFKOUJVD(World a);

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ComponentSystemBase XFYIWFMHOOM(World a);

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QMBAXKLGVLO(World a);

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZFSEJGXQENB(World a);

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PHVLOQWEJXQ(World a);

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TJTFQKWPDBR(World a);

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeParallelHashSet<ComponentTypeIndex> AFXFVTYNKYW();
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NSPSZHUPQDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AFUXNVFSYPM(ObjectLocalId a, bool b);
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

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x9BC09A0", Offset = "0x9BBF9A0", VA = "0x189BC09A0")]
		public InventionParameters(long id, Guid instanceId, bool overwriteIdData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ICTQXJFIFEY
	{
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RRSceneLoadOperation FQANDRDLEUI(SerializedDataWrapper a, int b = 0, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRSceneLoadOperationSubgraph IQLVSUGADDQ(SerializedDataWrapper a, ObjectLocalId b, [In] UniformTRS parentFromWorldTransform, DEMYGUIRPEH c, [Optional] InventionParameters d, bool e = true, bool f = false, bool g = false, bool h = false);

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JKOGGPGPVBA WOTNVMUFCCT();

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JKOGGPGPVBA LPGMDOVEBFN(NativeObjectLocalIdArray a, [In] UniformTRS serializedSceneFromCommonParentOfSerializedRoots, [Optional] DEMYGUIRPEH b);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EAPDAKUVTYZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WHZWSRPAHHZ(ObjectLocalId a, [Out] Exception b);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QWJXCJWXAGP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeArray<ObjectNetworkId> LZZOIBSRDAZ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "8")]
		NativeArray<ObjectNetworkId> FPSNFFLBIKM(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NativeObjectLocalIdArray DHHNPSDKHZA(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray IQAQGBPOTJZ(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray WOWWLDJBRCX(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NativeArray<EntityRemapUtility.EntityRemapInfo> LKVPMMQJRYO(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool TAOUIVEETJC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int KDUJYWHXQEW(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GVWRNBYTFSF
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xFA20B0", Offset = "0xFA10B0", VA = "0x180FA20B0", Slot = "0")]
		bool VPWDAIBPJGY(object a, JHVMANSCQQR b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class APLGZZEGPVP
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x9BBEDE0", Offset = "0x9BBDDE0", VA = "0x189BBEDE0")]
		public static bool VPWDAIBPJGY(this GVWRNBYTFSF a, object b, [Out] JHVMANSCQQR c)
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
	public interface JHVMANSCQQR
	{
		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		NetworkEventType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		PlayerId JXNAEWQJFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		bool EPIWWBMRZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		bool VTAYJJLOXJF
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object OTXTCZBQXPK();

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool XTJZGYYVHYS([Out] PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210", Slot = "6")]
		(PlayerId, object) MXYICIUJUVI()
		{
			return default((PlayerId, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "7")]
		(ObjectNetworkId, PlayerId) KXBCIYHBNLI()
		{
			return default((ObjectNetworkId, PlayerId));
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "8")]
		CAJIYQQGHAR<(ObjectNetworkId, PlayerId)> PSDFMJZWXPH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210", Slot = "9")]
		(OutOfBandMessageType, byte[]) ULFMISLHHDX()
		{
			return default((OutOfBandMessageType, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210", Slot = "10")]
		(PacketSource, byte[]) TKHXGMSZXIW()
		{
			return default((PacketSource, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210", Slot = "11")]
		a CVNGPMTOKUP<a>()
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public static class VJWAPXJMKWT
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x9BD8E80", Offset = "0x9BD7E80", VA = "0x189BD8E80")]
		public static bool JGTBFHLXOUC(this JHVMANSCQQR a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public interface SOCMGEDNYMP : CAJIYQQGHAR<NetworkTransformSyncData>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface CAJIYQQGHAR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		int HSBKFDGFQWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
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
	public static class HFSXBYNRWKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFF90", Offset = "0x9BBEF90", VA = "0x189BBFF90")]
		public static ObjectNetworkId GRZUGCSKMBB(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFF50", Offset = "0x9BBEF50", VA = "0x189BBFF50")]
		public static ObjectNetworkId DQDTVACWWDL([In] this ObjectNetworkIdComponentData data)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x9A013D0", Offset = "0x9A003D0", VA = "0x189A013D0")]
		public static ObjectNetworkId NALURPEKITO(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x9A013D0", Offset = "0x9A003D0", VA = "0x189A013D0")]
		public static ViewId NGGKTVQASJH(this ObjectNetworkIdComponentData a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC02E0", Offset = "0x9BBF2E0", VA = "0x189BC02E0")]
		public static FixedString64Bytes RMLZNJZLKMN(this NetworkCreatorId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x9BBFFC0", Offset = "0x9BBEFC0", VA = "0x189BBFFC0")]
		public static FixedString64Bytes PRUHKVVUJME(this ObjectNetworkId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0250", Offset = "0x9BBF250", VA = "0x189BC0250")]
		public static FixedString32Bytes RMLZNJZLKMN(this Entity a)
		{
			return default(FixedString32Bytes);
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XMCEBHMXKLR : FJAIXDTJXYY
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
	public interface URCPEIKCZIN
	{
		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<object> YGUMDRBDUOH;

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "2")]
		void MPVUJSSEYBF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "3")]
		void PBYGCMWQGAB(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		void DHBNURQEJNX(OutOfBandMessageType a, ReadOnlySpan<byte> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface DKRSPNYYJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PacketSource EATAEQNMCBI(ReadOnlySpan<byte> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OFIEPGEIVKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LBDVXHTLWXZ(PacketSource a, ReadOnlySpan<byte> b);

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ODYYFDWSNSB(ReadOnlySpan<PacketSource> a);
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

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public static NetworkCreatorId JRBZDYBXKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x9BC5470", Offset = "0x9BC4470", VA = "0x189BC5470")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x6938C80", Offset = "0x6937C80", VA = "0x186938C80")]
		public PacketSource(NetworkCreatorId creatorId, int packetId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x9BC53E0", Offset = "0x9BC43E0", VA = "0x189BC53E0")]
		public static bool IQJYWSDTJLC([In] PacketSource lhs, [In] PacketSource rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5270", Offset = "0x9BC4270", VA = "0x189BC5270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5380", Offset = "0x9BC4380", VA = "0x189BC5380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x9BC54C0", Offset = "0x9BC44C0", VA = "0x189BC54C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x9BC5260", Offset = "0x9BC4260", VA = "0x189BC5260")]
		public void BXVWZDHELXS([Out] NetworkCreatorId a, [Out] int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class JMMXAAHAIZU
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

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0880", Offset = "0x9BBF880", VA = "0x189BC0880", Slot = "3")]
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
	public static class YPSEYTAYUWY
	{
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9020", Offset = "0x9BD8020", VA = "0x189BD9020")]
		public static bool TBTHOJIYLFE(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9010", Offset = "0x9BD8010", VA = "0x189BD9010")]
		public static bool LNOZFWRLOAY(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x9BD9000", Offset = "0x9BD8000", VA = "0x189BD9000")]
		public static bool EVDLBYWHABG(this DeserializationOperationType a)
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
	public interface DEMYGUIRPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KRYRIWQBJWK([In] Guid src, [Out] Guid a);
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
	public interface JKOGGPGPVBA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000232")]
		YUZDAQJGJCS PAYZFZNYCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ByteString VZHZKJZHGFU();
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

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x9BC0EC0", Offset = "0x9BBFEC0", VA = "0x189BC0EC0", Slot = "4")]
		public bool Equals(LocalBoundsData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OFBPVVLEQCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ReadOnlySpan<ObjectLocalId> VROCXXDHWER(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DBFMYZPVUUV(ObjectLocalId a, [Out] ObjectLocalId b);
	}
}
namespace RecRoom.ObjectModel.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JBECKBTBEVL
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LZPHUKWUAFK(long a);

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UAMORETHNWU(NativeParallelHashSet<long> a);

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IQGCOULLPSK(World a, NativeParallelHashMap<Guid, long> b);

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DHXLCAGDNJD(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool EBJPNRLBMYG(ObjectNetworkId a, [Out] Guid b, [Out] long c);

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YLIUEECBWJH(ObjectNetworkId a, Guid b, long c);

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FEKFEDBSSPW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TQFWXYBYJMN(Guid a, [Out] int b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DEEHLNGRINM(Guid a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HTMPPAMSVHD(Guid a);
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
