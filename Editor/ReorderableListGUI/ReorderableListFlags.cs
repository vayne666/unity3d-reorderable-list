// Copyright (c) 2012-2013 Rotorz Limited. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;

/// <summary>
/// Additional flags which can be passed into reorderable list field.
/// </summary>
[Flags]
public enum ReorderableListFlags {
	/// <summary>
	/// Hide grab handles and disable reordering of list items.
	/// </summary>
	DisableReordering		= 0x01,
	/// <summary>
	/// Hide add button at base of control.
	/// </summary>
	HideAddButton			= 0x02,
	/// <summary>
	/// Hide remove buttons from list items.
	/// </summary>
	HideRemoveButtons		= 0x04,
	/// <summary>
	/// Do not display context menu upon right-clicking grab handle.
	/// </summary>
	DisableContextMenu		= 0x08,
	/// <summary>
	/// Hide "Duplicate" option from context menu.
	/// </summary>
	DisableDuplicateCommand	= 0x10,
}